using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installer
{
    public partial class Form1 : Form
    {
        public static string installInfoStatus = "", path;
        public static Form1 instance;
        public float animationTimer;

        public string dashPath;

        public Stopwatch sw;

        public AnimationPart state = AnimationPart.None;

        public SelectedMode mode = SelectedMode.DashPlus;

        public float xOffset;

        public static bool installing, uninstallingMode;

        public Form1()
        {
            InitializeComponent();

            /*Bitmap b = (Bitmap)pictureBox1.Image;
            IntPtr pIcon = b.GetHicon();
            Icon i = Icon.FromHandle(pIcon);
            Icon = i;*/
            //i.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            instance = this;
            sw = new Stopwatch();

            sw.Start();

            installationStatus.SendToBack();
            CloseButtor.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            client.DownloadDataCompleted += new DownloadDataCompletedEventHandler(client_DownloadDataCompleted);

            string execPath = AppDomain.CurrentDomain.BaseDirectory;

            client.DownloadDataAsync(new Uri("https://github.com/LavaGang/MelonLoader/releases/download/v0.5.4/MelonLoader.x64.zip"), execPath + "\\newfile.zip");

            /*(using (var client = new WebClient())
            {
                client.DownloadFile("https://github.com/LavaGang/MelonLoader/releases/download/v0.5.4/MelonLoader.x64.zip", @"C:\Users\talgo\Downloads\E.zi");
            }*/
        }

        void client_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            MessageBox.Show("File downloaded");

            string execPath = AppDomain.CurrentDomain.BaseDirectory;

            if (!File.Exists(execPath + "\\newfile.zip"))
            {
                File.Create(execPath + "\\newfile.zip");
            }

            File.WriteAllBytes(execPath + "\\newfile.zip", e.Result);//
        }



        //DRAGABLE
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void DoMelonLoader(string path)
        {
            dashPath = path;
            installInfo.Text = path;

            string melonPath = path + "\\MelonLoader";

            installInfo.Text = melonPath;

            if (Directory.Exists(melonPath))
            {
                installInfo.Text = "Found MelonLoader";
                InstallMenu();
            }
            else
            {
                if (File.Exists(dashPath + "Melonx64.zip"))
                {
                    ExtractMelonLoader();
                }
                else
                {
                    installInfo.Text = "Couldn't Find MelonLoader, Installing";

                    using (var client = new WebClient())
                    {
                        client.DownloadFile("https://github.com/LavaGang/MelonLoader/releases/download/v0.5.4/MelonLoader.x64.zip", dashPath + "Melonx64.zip");

                        installInfo.Text = "Download Complete, Installing";

                        ExtractMelonLoader();
                    }
                }
            }
        }

        public void ExtractMelonLoader()
        {
            installInfo.Text = "Extracting MelonLoader";
            ZipFile.ExtractToDirectory(dashPath + "Melonx64.zip", dashPath);
            installInfo.Text = "Success Installing MelonLoader, Downloading Menu";

            File.Delete(dashPath + "Melonx64.zip");

            InstallMenu();
        }

        public void InstallMenu()
        {
            string url = "https://github.com/Underkirby/3Hack/releases/download/build/Hacks.dll";

            using (var client = new WebClient())
            {
                if (!Directory.Exists(dashPath + "/Mods/"))
                {
                    Directory.CreateDirectory(dashPath + "/Mods/");
                }
                else
                {
                    if (File.Exists(dashPath + "/Mods/Hacks.dll"))
                    {
                        File.Delete(dashPath + "/Mods/Hacks.dll");
                    }
                }

                client.DownloadFile(url, dashPath + "/Mods/Hacks.dll");

                installInfo.Text = "Menu Download Part 1 Complete";
            }

            string url2 = "https://github.com/Underkirby/3Hack/releases/download/build/DiscordRPC.dll";

            using (var client2 = new WebClient())
            {
                if (!Directory.Exists(dashPath + "/UserLibs/"))
                {
                    Directory.CreateDirectory(dashPath + "/UserLibs/");
                }
                else
                {
                    if (File.Exists(dashPath + "/UserLibs/DiscordRPC.dll"))
                    {
                        File.Delete(dashPath + "/UserLibs/DiscordRPC.dll");
                    }
                }

                client2.DownloadFile(url2, dashPath + "/UserLibs/DiscordRPC.dll");

                installInfo.Text = "Successfully Downloaded Mod Menu";

                Application.Run(new Form1());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sw.Stop();

            if (state != AnimationPart.None)
            {
                animationTimer += (sw.ElapsedMilliseconds / 1000f) * 1.25f;

                animationTimer = Utils.Clamp(animationTimer, 0, 1);

                if (animationTimer == 1)
                {
                    state = AnimationPart.None;
                }
            }

            Animate();
            UpdateModeButtons();

            sw = new Stopwatch();

            sw.Start();
        }

        private void Unselect(object sender, EventArgs e)
        {
            ActiveControl = installInfo;
        }

        private void installInfo_TextChanged(object sender, EventArgs e)
        {

        }


        public void Animate()
        {
            startupMainText.Location = new Point((int)(Math.Round(12 - (Width * Utils.easeInCubic(animationTimer))) + xOffset), 12);
            TypeTitle.Location = new Point((int)((Math.Round(12 - (Width * Utils.easeInCubic(animationTimer)))) + xOffset) + Width, 12);

            installButton.Location = new Point((int)(Math.Round(Width - installButton.Width - 24 - (Width * Utils.easeInCubic(animationTimer))) + xOffset), 320 - 105);

            uninstallButton.Location = new Point((int)(Math.Round(Width - installButton.Width - 24 - (Width * Utils.easeInCubic(animationTimer))) + xOffset), 320 - 55);

            nextType.Location = new Point((int)(Math.Round(Width - installButton.Width - 24 - (Width * Utils.easeInCubic(animationTimer))) + xOffset) + Width, 320 - 55);

            //28, 107
            new3dashType.Location = new Point((int)(Math.Round(Width - (Width * Utils.easeInCubic(animationTimer))) + xOffset) + 28, 107);
            new3dashplusType.Location = new Point((int)(Math.Round(Width - (Width * Utils.easeInCubic(animationTimer))) + xOffset) + 28, 144);
            existingType.Location = new Point((int)(Math.Round(Width - (Width * Utils.easeInCubic(animationTimer))) + xOffset) + 28, 181);

            pathTitle.Location = new Point((int)((Math.Round(12 - (Width * Utils.easeInCubic(animationTimer)))) + xOffset) + Width + Width, 12);


            pathSelectBox.Location = new Point((int)((Math.Round(28 - (Width * Utils.easeInCubic(animationTimer)))) + xOffset) + Width + Width, 127);
            pathSelectButton.Location = new Point((int)((Math.Round(398 - (Width * Utils.easeInCubic(animationTimer)))) + xOffset) + Width + Width, 122);

            pathInstallButton.Location = new Point((int)(Math.Round(Width - installButton.Width - 24 - (Width * Utils.easeInCubic(animationTimer))) + xOffset) + Width + Width, 320 - 55);

            installationStatus.Location = new Point((int)(Math.Round(Width - (Width * Utils.easeInCubic(animationTimer)))), installationStatus.Location.Y);
            //loadingCircle.Location = new Point((int)(Math.Round(Width - (Width * Utils.easeInCubic(animationTimer))) + 191) + Width, 67);

            if (Directory.Exists(pathSelectBox.Text))
            {
                pathInstallButton.BackColor = Color.MediumSpringGreen;
            }
            else
            {
                pathInstallButton.BackColor = Color.FromArgb(51, 51, 51);
            }

            installationStatus.Text = installInfoStatus;

            new3dashType.Visible = !uninstallingMode;
            new3dashplusType.Visible = !uninstallingMode;
            existingType.Visible = !uninstallingMode;

            uninstallTitle.Visible = uninstallingMode;
            TypeTitle.Visible = !uninstallingMode;
            uninstallPath.Visible = uninstallingMode;
            nextType.Visible = !uninstallingMode;
            uninstallBrowse.Visible = uninstallingMode;
            uninstallButtonPage.Visible = uninstallingMode;

            uninstallBrowse.Location = new Point((int)((Math.Round(398 - (Width * Utils.easeInCubic(animationTimer)))) + xOffset) + Width, 122);

            uninstallPath.Location = new Point((int)((Math.Round(28 - (Width * Utils.easeInCubic(animationTimer)))) + xOffset) + Width, 127);


            uninstallTitle.Location = new Point((int)((Math.Round(12 - (Width * Utils.easeInCubic(animationTimer)))) + xOffset) + Width, 12);

            uninstallButtonPage.Location = new Point((int)(Math.Round(Width - installButton.Width - 24 - (Width * Utils.easeInCubic(animationTimer))) + xOffset) + Width, 320 - 55);
        }

        public void UpdateModeButtons()
        {
            if (mode == SelectedMode.DashPlus)
            {
                new3dashplusType.ForeColor = Color.Black;
                new3dashplusType.BackColor = Color.MediumSpringGreen;
            }
            else
            {
                new3dashplusType.ForeColor = Color.White;
                new3dashplusType.BackColor = Color.FromArgb(51, 51, 51);
            }

            if (mode == SelectedMode.Dash)
            {
                new3dashType.ForeColor = Color.Black;
                new3dashType.BackColor = Color.MediumSpringGreen;
            }
            else
            {
                new3dashType.ForeColor = Color.White;
                new3dashType.BackColor = Color.FromArgb(51, 51, 51);
            }

            if (mode == SelectedMode.Existing)
            {
                existingType.ForeColor = Color.Black;
                existingType.BackColor = Color.MediumSpringGreen;
            }
            else
            {
                existingType.ForeColor = Color.White;
                existingType.BackColor = Color.FromArgb(51, 51, 51);
            }
        }



        public enum AnimationPart
        {
            None,
            MovingMain,
            MovingMode,
            InstallScale
        }

        public enum SelectedMode
        {
            DashPlus,
            Dash,
            Existing
        }


        private void Close(object sender, EventArgs e)
        {
            if (installing)
            {
                if (MessageBox.Show("Are you sure you want to quit, Installation is not finished", "3Hack", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void new3dashplusType_Click(object sender, EventArgs e)
        {
            mode = SelectedMode.DashPlus;
        }

        private void new3dashType_Click(object sender, EventArgs e)
        {
            mode = SelectedMode.Dash;
        }

        private void existingType_Click(object sender, EventArgs e)
        {
            mode = SelectedMode.Existing;
        }

        private void InstallClicked(object sender, EventArgs e)
        {
            state = AnimationPart.MovingMain;
        }

        private void TypeNext(object sender, EventArgs e)
        {
            xOffset = -Width;
            animationTimer = 0;
            state = AnimationPart.MovingMode;
        }

        private void Uninstall(object sender, EventArgs e)
        {
            if (state != AnimationPart.MovingMain)
            {
                if (uninstallingMode)
                {
                    /*xOffset = -Width;
                    animationTimer = 0;
                    state = AnimationPart.MovingMain;*/

                    path = pathSelectBox.Text;

                    UninstallClass.DoUninstall();
                }
                else
                {
                    uninstallingMode = true;
                    state = AnimationPart.MovingMain;
                }
            }
        }

        private void SelectPath(object sender, EventArgs e)
        {
            using (FolderBrowserDialog openFileDialog = new FolderBrowserDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pathSelectBox.Text = openFileDialog.SelectedPath;
                    uninstallPath.Text = openFileDialog.SelectedPath;
                }
            }
        }

        private void BeginInstall(object sender, EventArgs e)
        {
            if (Directory.Exists(pathSelectBox.Text))
            {
                path = pathSelectBox.Text;

                xOffset -= Width;
                animationTimer = 0;
                state = AnimationPart.InstallScale;

                installing = true;

                if (mode == SelectedMode.Existing)
                {
                    Existing.Install();
                }

                if (mode == SelectedMode.DashPlus)
                {
                    DashPlus.Install();
                }

                if (mode == SelectedMode.Dash)
                {
                    Dash.Install();
                }
            }
        }
    }
}
