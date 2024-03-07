using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyDwarfLauncher
{
    public class ConfigurationData
    {
        public bool check1 { get; set; }

        public string GetCheck1() { return @"BepInEx\plugins\Mod1.dll"; }
        public string GetCheckURL1() { return @"http://5.128.188.197:2020/api/public/dl/OEymm0sa/Additions/mod1.dll"; }

        public bool check2 { get; set; }

        public string GetCheck2() { return @"BepInEx\plugins\Mod2.dll"; }
        public string GetCheckURL2() { return @"http://5.128.188.197:2020/api/public/dl/KnUzwgpt/Additions/mod2.dll"; }

        public bool AdminTools { get; set; }

        public string GetAdminToolsPath() { return @"BepInEx\plugins\DevMods\AdminsMods.zip"; }
        public string GetAdminToolsUrl() { return @"http://5.128.188.197:2020/api/public/dl/CG_KOPPg/AdminsMods.zip"; }

        public bool check3 { get; set; }

        public string GetCheck3() { return @"BepInEx\plugins\Mod3.dll"; }
        public string GetCheckURL3() { return @"http://5.128.188.197:2020/api/public/dl/T7Ccje8A/Additions/mod3.dll"; }


        public bool ModPackDisable { get; set; }
        public string StartParams { get; set; }
        public string Path { get; set; } 
        public string Version { get; set; } 

    }
}
