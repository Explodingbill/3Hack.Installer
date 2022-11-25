using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Installer
{
    public class Utils
    {
        public static float Clamp(float value, float min, float max)
        {
            float x = value;

            if (x < min) x = min;
            if (x > max) x = max;

            return x;
        }

        public static float easeInCubic(float x) {
            return x * x * x;
        }

        public static void clearFolder(string FolderName)
        {
            DirectoryInfo dir = new DirectoryInfo(FolderName);

            foreach (FileInfo fi in dir.GetFiles())
            {
                fi.Delete();
            }

            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                clearFolder(di.FullName);
                di.Delete();
            }
        }
    }
}
