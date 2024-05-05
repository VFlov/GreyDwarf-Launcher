using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace GreyDwarfLauncher
{
    public static class GlobalWorker
    {
        public static string version = null;
        public static string pathBepInEx = @"BepInEx\"; 
        public static string currPath = null;  // текущая директория
        public static string exename = "valheim.exe";
        public static string versionFile = "http://85.209.9.15:8080/api/public/dl/xOiZMtSQ/fileserver/version.txt";
        public static string newsFile = "http://85.209.9.15:8080/api/public/dl/xS00q43M/fileserver/news.txt";
        public static string updateFile = "http://85.209.9.15:8080/api/public/dl/Ggz5EpC9/fileserver/update_v2.zip";
        ////public static string updateFile = "http://5.128.188.197:2020/api/public/dl/5wJ1z_r1/update_v2.zip";
        public static string[] backgroundImage = {"http://85.209.9.15:8080/api/public/dl/dchbO8A_/fileserver/background_image.jpg",
            "http://85.209.9.15:8080/api/public/dl/AxTzFIWr/fileserver/background_image2.jpg",
            "http://85.209.9.15:8080/api/public/dl/4489xQtR/fileserver/background_image3.jpg"
        };
        public static string jsonPath = Path.GetTempPath(); //%temp%
        public static string url = "http://85.209.9.15:8080/api/public/dl/xOiZMtSQ";
        public static bool downloading = false;
        public static bool chooseUpdate;
        public static ConfigurationData Configuration = new ConfigurationData();
        public static string serverVersion = GlobalWorker.Configuration.Version;
        public static string GameArchiveFileName = "build.zip";

        public static void LoadConfiguration()
        {
            if (jsonPath == null)
                return; 
            if (!File.Exists(jsonPath + @"\" + "config.json"))
            {
                GlobalWorker.Configuration = new ConfigurationData();
                return;
            }
            try
            {
                var strData = File.ReadAllText(jsonPath + @"\" + "config.json");
                var obj = JsonConvert.DeserializeObject<ConfigurationData>(strData);
                if (obj != null)
                    GlobalWorker.Configuration = obj;
            }
            catch (Exception ex)
            {
                GlobalWorker.Configuration = new ConfigurationData();
            }
            currPath = GlobalWorker.Configuration.Path;
            version = GlobalWorker.Configuration.Version;
        }

        public static void SaveConfiguration()
        {
            if (File.Exists(jsonPath + @"\" + "config.json"))
            {
                try
                {
                    File.SetAttributes(jsonPath + @"\" + "config.json", FileAttributes.Normal);
                    File.Delete(jsonPath + @"\" + "config.json");
                }
                catch (Exception ex)
                {
                    // cant delete config.json
                    return;
                }
            }
            try
            {
                var strData = JsonConvert.SerializeObject(GlobalWorker.Configuration);
                File.WriteAllText(jsonPath + @"\" + "config.json", strData);
            }
            catch (Exception ex)
            {
                // cant write config.json
                return;
            }
        }

        public static void InstallMods()
        {
            /*if (!FileExist() || Configuration.ModPackDisable)
            {
                MessageBox.Show("Изменения не сохранены. Ванильная версия игры");
                return;
            }*/
            var check1 = currPath + @"/" + GlobalWorker.Configuration.GetCheck1();
            var check2 = currPath + @"/" + GlobalWorker.Configuration.GetCheck2();
            var adminToolsPath = currPath + @"/" + GlobalWorker.Configuration.GetAdminToolsPath();
            var check3 = currPath + @"/" + GlobalWorker.Configuration.GetCheck3();

            // delete old mods
            GlobalWorker.SafeDeleteFile(check1);
            GlobalWorker.SafeDeleteFile(check2);
            GlobalWorker.SafeDeleteFile(Path.GetDirectoryName(adminToolsPath));
            GlobalWorker.SafeDeleteFile(check3);

            // install new mods
            if (GlobalWorker.Configuration.check1)
            {
                DownloadSave(GlobalWorker.Configuration.GetCheckURL1(), check1);
            }

            if (GlobalWorker.Configuration.check2)
            {
                DownloadSave(GlobalWorker.Configuration.GetCheckURL2(), check2);
            }
            if (GlobalWorker.Configuration.AdminTools)
            {
                DownloadSaveAdm(GlobalWorker.Configuration.GetAdminToolsUrl(), adminToolsPath);
                ZipFile.ExtractToDirectory(adminToolsPath, Path.GetDirectoryName(adminToolsPath));
                File.Delete(adminToolsPath);
            }
            if (GlobalWorker.Configuration.check3)
            {
                DownloadSave(GlobalWorker.Configuration.GetCheckURL3(), check3);
            }
            Configuration.Version = serverVersion;
        }

        private static void DownloadSave(string url, string savePath)
        {
            try
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile(new Uri(url), savePath);
                }
            }
            catch (Exception ex)
            {
                // unable to download file
            }
        }
        private static void DownloadSaveAdm(string url, string savePath)
        {
            try
            {
                var dirName = Path.GetDirectoryName(savePath);
                if (!Directory.Exists(dirName))
                {
                    Directory.CreateDirectory(dirName);
                }
                using (var client = new WebClient())
                {
                    client.DownloadFile(new Uri(url), savePath);
                }
            }
            catch (Exception ex)
            {
                // unable to download file
            }
        }

        public static void Reinstall()
        {
            GlobalWorker.Configuration.Version = null;
            version = "None";
            if (Directory.Exists(currPath + @"\" + "BepInEx_disable"))
            {
                Directory.Move(GlobalWorker.currPath + @"\" + "BepInEx" + "_disable", GlobalWorker.currPath + @"\" + "BepInEx");
            }
            if (Directory.Exists(currPath + @"\" + pathBepInEx))
            {
                DirectoryInfo dir = new DirectoryInfo(Path.GetFullPath(currPath + @"\" + pathBepInEx));
                foreach (FileInfo item in dir.GetFiles())
                {
                    item.Delete();
                }
                foreach (DirectoryInfo item in dir.GetDirectories())
                {
                    item.Delete(true);
                }
            }
            if (File.Exists(jsonPath + @"\" + "config.json"))
                File.Delete(jsonPath + @"\" + "config.json");
            SafeDeleteFile(jsonPath + @"\" + "config.json");
            Application.Restart();
        }

        public static void SafeDeleteFile(string path)
        {
            if (File.Exists(path) || Directory.Exists(path))
            {
                try
                {
                    File.SetAttributes(path, FileAttributes.Normal);
                    File.Delete(path);
                }
                catch 
                {
                    Directory.Delete(path,true);
                    // unable to delete
                }
            }
        }
        public static bool FileExist()
        {
            if (File.Exists(currPath + @"\" + exename))
                return true;
            else
                return false;
        }
        public static List<string> GetRequest()
        {
            var url = "http://5.128.188.197:2020/api/public/dl/rx9-HcW8/Api1";

            var textFromFile = (new WebClient()).DownloadString(url);
            using (var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
            {
                client.BaseAddress = new Uri(textFromFile);
                HttpResponseMessage response = client.GetAsync(textFromFile).Result;
                response.EnsureSuccessStatusCode();
                string result = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine("Result: " + result);
                JObject jsonResponse = JObject.Parse(result);

                // Обращение к значению ключа "players" и его вывод
                int playersCount = jsonResponse["responce"]["data"]["players"].Value<int>();
                string status = jsonResponse["responce"]["status"].Value<string>();
                List<string> res = new List<string>(2);
                res.Add(playersCount.ToString());
                res.Add(status);
                return res;
            }
        }
        public static List<string> GetRequest2()
        {
            var url = "http://5.128.188.197:2020/api/public/dl/e8Btl4WI/Api2";

            var textFromFile = (new WebClient()).DownloadString(url);
            if (textFromFile == "")
                return new List<string>() { "0", "Off" };
            using (var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
            {
                client.BaseAddress = new Uri(textFromFile);
                HttpResponseMessage response = client.GetAsync(textFromFile).Result;
                response.EnsureSuccessStatusCode();
                string result = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine("Result: " + result);
                JObject jsonResponse = JObject.Parse(result);

                // Обращение к значению ключа "players" и его вывод
                int playersCount = jsonResponse["responce"]["data"]["players"].Value<int>();
                string status = jsonResponse["responce"]["status"].Value<string>();
                List<string> res = new List<string>(2);
                res.Add(playersCount.ToString());
                res.Add(status);
                return res;
            }
        }

    }
}
