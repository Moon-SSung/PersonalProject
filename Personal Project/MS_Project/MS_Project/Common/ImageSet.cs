using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Controls;
using System.Drawing;

namespace MS_Project.Common
{
    class ImageSet 
    {
        public static string SetNavImage(string imgName)
        {
            IniFile ini = new IniFile();
            ini.Load(IniData.SettingIniFile);
            IniSection resSection = ini["Resources"];

            string bgResPath = Directory.GetCurrentDirectory() + $@"{resSection["ResourceFolder"]}{resSection["NavigationFolder"]}" + $@"\{imgName}";
            //string bmp = new Bitmap(bgResPath + $@"\{imgName}.png");
            return bgResPath;
        }
    }
}
