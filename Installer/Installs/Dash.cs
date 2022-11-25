using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installer
{
    public class Dash
    {
        public static async Task Install()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(1000f));

            Form1.installInfoStatus = "Downloading 3Dash";

            await Task.Run(() => {
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://drive.google.com/uc?export=download&id=1ndvXI4P6D0yt_G3fwpCDgiKWEXOiE6YX&confirm=t&uuid=3f0da927-6d5a-41fb-aebf-95e08a7b9ab3", Path.Combine(Form1.path, "3Dash.zip"));

                    Form1.installInfoStatus = "Downloaded 3Dash, Extracting";

                    if (Directory.Exists(Path.Combine(Form1.path, "3Dash Windows v1.2")))
                    {
                        Utils.clearFolder(Path.Combine(Form1.path, "3Dash Windows v1.2"));

                        Directory.Delete(Path.Combine(Form1.path, "3Dash Windows v1.2"));
                    }

                    ZipFile.ExtractToDirectory(Path.Combine(Form1.path, "3Dash.zip"), Form1.path);

                    Form1.installInfoStatus = "Success Installing 3Dash, Downloading Melonloader";

                    File.Delete(Path.Combine(Form1.path, "3Dash.zip"));
                }
            });

            Form1.path = Path.Combine(Form1.path, "3Dash Windows v1.2");
            await Task.Run(() => InstallMelonloader());
        }


        public static async Task InstallMelonloader()
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://github.com/LavaGang/MelonLoader/releases/download/v0.5.4/MelonLoader.x64.zip", Path.Combine(Form1.path, "Melonx64.zip"));

                Form1.installInfoStatus = "Melonloader Download Complete, Installing Menu";

                ExtractMelonLoader();
            }
        }

        public static async Task ExtractMelonLoader()
        {
            ZipFile.ExtractToDirectory(Path.Combine(Form1.path, "Melonx64.zip"), Form1.path);

            Form1.installInfoStatus = "Success Installing MelonLoader, Downloading Menu";

            File.Delete(Path.Combine(Form1.path, "Melonx64.zip"));

            InstallMenu();
        }

        public static async Task InstallMenu()
        {
            string url = "https://github.com/Underkirby/3Hack/releases/download/build/Hacks.dll";
            string modsPath = Path.Combine(Form1.path, "Mods");
            string libsPath = Path.Combine(Form1.path, "UserLibs");

            using (var client = new WebClient())
            {
                if (!Directory.Exists(modsPath))
                {
                    Directory.CreateDirectory(modsPath);
                }
                else
                {
                    if (File.Exists(Path.Combine(modsPath, "Hacks.dll")))
                    {
                        File.Delete(Path.Combine(modsPath, "Hacks.dll"));
                    }
                }

                client.DownloadFile(url, Path.Combine(modsPath, "Hacks.dll"));

                Form1.installInfoStatus = "Menu Download Complete, Installing Dependencies";
            }

            string url2 = "https://github.com/Underkirby/3Hack/releases/download/build/DiscordRPC.dll";

            using (var client2 = new WebClient())
            {
                if (!Directory.Exists(libsPath))
                {
                    Directory.CreateDirectory(libsPath);
                }
                else
                {
                    if (File.Exists(Path.Combine(libsPath, "DiscordRPC.dll")))
                    {
                        File.Delete(Path.Combine(libsPath, "DiscordRPC.dll"));
                    }
                }

                client2.DownloadFile(url2, Path.Combine(libsPath, "DiscordRPC.dll"));

                Form1.installInfoStatus = "Successfully Downloaded Mod Menu";

                Form1.installing = false;
                MessageBox.Show("Installation Complete", "3Hack");
            }
        }
    }
}
