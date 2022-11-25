using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installer
{
    public class UninstallClass
    {
        public static void DoUninstall()
        {
            if (Directory.Exists(Path.Combine(Form1.path, "Mods")))
            {
                if (File.Exists(Path.Combine(Path.Combine(Form1.path, "Mods"), "Hacks.dll")))
                {
                    File.Delete(Path.Combine(Path.Combine(Form1.path, "Mods"), "Hacks.dll"));
                }
            }

            if (Directory.Exists(Path.Combine(Form1.path, "UserLibs")))
            {
                if (File.Exists(Path.Combine(Path.Combine(Form1.path, "UserLibs"), "DiscordRPC.dll")))
                {
                    File.Delete(Path.Combine(Path.Combine(Form1.path, "UserLibs"), "DiscordRPC.dll"));
                }
            }

            MessageBox.Show("Success Uninstalling 3Hack", "3Hack");
        }
    }
}
