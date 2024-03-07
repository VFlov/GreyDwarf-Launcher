using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GreyDwarfLauncher
{
    delegate void Download();
    public partial class Form1 : Form
    {
       
        
        public Form1()
        {
            
            InitializeComponent();
            Opacity = 0;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.05d) == 1) timer.Stop();
            });
            timer.Interval = 60;
            timer.Start();
            GlobalWorker.LoadConfiguration();
        }
        PrivateFontCollection pfc = new PrivateFontCollection();
        public void InitFont()
        {
            ///pfc.AddFontFile("Yarin-Bold.ttf");
            string FileName = Path.GetTempFileName();
            File.WriteAllBytes(FileName, Properties.Resources.Yarin_Regular);
            pfc.AddFontFile(FileName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //System.IO.Directory.CreateDirectory(@"BepInEx\"); //Создаем папку для бепайнекса
            System.Net.WebClient wc = new System.Net.WebClient();
            try
            {
                label2.Text = wc.DownloadString(GlobalWorker.newsFile);
            }
            catch
            {
                MessageBox.Show("Невозможно соединиться с сервером обновлений GreyDwarf. Проверьте свое подключение к сети интернет или обновление лаунчера на сайте GreyDwarf.ru. Если вам не удалось выявить источник данной ошибки - свяжитесь с нами!");
                //Close();
            }
            if (GlobalWorker.Configuration.ModPackDisable)
            {
                ModOn.Image = GreyDwarfLauncher.Properties.Resources.orange_control;
                ModOff.Image = GreyDwarfLauncher.Properties.Resources.green_control;
            }
            else
            {
                ModOn.Image = GreyDwarfLauncher.Properties.Resources.green_control_22;
                ModOff.Image = GreyDwarfLauncher.Properties.Resources.orange_control_28;
            
            }
            
            var online1 = GlobalWorker.GetRequest();
            if (online1[1] == "ok")
            { 
                pictureBox4.BackgroundImage = Properties.Resources.greendot;
                label4.Text = "Онлайн: " + online1[0];
            }
            
            var online2 = GlobalWorker.GetRequest2();
            if (online2[1] == "ok")
            {
                pictureBox3.BackgroundImage = Properties.Resources.greendot;
                label6.Text = "Онлайн: " + online2[0];
            }
            
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            InitFont();
            //label4.Font = new Font(pfc.Families[0], 13, FontStyle.Bold);
            label3.Font = new Font(pfc.Families[0], 18, FontStyle.Regular);
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            label5.Font = new Font(pfc.Families[0], 14, FontStyle.Regular);
            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.GrayDwarf_v2;
            try
            {
                pictureBox1.ImageLocation = GlobalWorker.backgroundImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; //Подгон размера
            }
            catch 
            {
                //MessageBox.Show("Невозможно установить фоновое изображение");
            }
            pictureBox2.BackgroundImage = Properties.Resources.loadbar1;
            label1.Font = new Font(pfc.Families[0], 14, FontStyle.Regular);
            transparentLabel1.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
            label1.BringToFront();
            button1.Font = new Font(pfc.Families[0], 30, FontStyle.Regular);

            if (GlobalWorker.version == null)
            {
                GlobalWorker.version = "Не установлен";
            }
            else
            {
                GlobalWorker.version = GlobalWorker.Configuration.Version;
            }
            

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(GlobalWorker.versionFile);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream recivestream = response.GetResponseStream();
                StreamReader readstream = null;
                if (response.CharacterSet == null)
                {
                    readstream = new StreamReader(recivestream);
                }
                else
                {
                    readstream = new StreamReader(recivestream, Encoding.GetEncoding(response.CharacterSet));
                }
                //В файле(v.txt) версия сервера
                string data = readstream.ReadToEnd();
                GlobalWorker.serverVersion = data;
                response.Close();
                readstream.Close();
            }
            else
            {
                MessageBox.Show("Ошибка соединения с сервером");
            }


            label1.Text = "Версия клиента: v" + GlobalWorker.version + "    /     Актуальная версия: v" + GlobalWorker.serverVersion;
            if (GlobalWorker.version == "Не установлен")
                label1.Text = "Версия клиента: v" + "0.0" + "    /     Актуальная версия: v" + GlobalWorker.serverVersion;
            label3.Text = "Что нового v" + GlobalWorker.serverVersion;


            if (!GlobalWorker.downloading)
            {
                if (GlobalWorker.version != GlobalWorker.serverVersion)
                {
                    if (!GlobalWorker.FileExist())
                    {
                        button1.Text = "Установить";
                        button1.Click += UpdateGame;
                    }
                    else
                    {
                        button1.Text = "Обновить v" + GlobalWorker.serverVersion;
                        button1.Click += UpdateGame;
                    }
                }
                else
                {
                    button1.Text = "Играть";
                    button1.Click += Play;
                }
            }
        }

        private const int megabyte = 1048576;

        private void UpdateGame(object sender, EventArgs e)
        {
            if (GlobalWorker.Configuration.ModPackDisable)
            {
                MessageBox.Show("Включите ModPack");
                return;
            }
            if (GlobalWorker.Configuration.Path == null || !GlobalWorker.FileExist())
            {
                GlobalWorker.chooseUpdate = true;
                Form2 form = new Form2();
                form.ShowDialog();
                return;
            }

            GlobalWorker.downloading = true;
            button1.ForeColor = Color.Gray;
            button1.Enabled = false;


            Directory.CreateDirectory(GlobalWorker.currPath + @"\" + GlobalWorker.pathBepInEx);
            DirectoryInfo dir = new DirectoryInfo(Path.GetFullPath(GlobalWorker.currPath + @"\" + GlobalWorker.pathBepInEx));
            foreach (FileInfo item in dir.GetFiles())
            {
                item.Delete();
            }
            foreach (DirectoryInfo item in dir.GetDirectories())
            {
                item.Delete(true);
            }


            if (File.Exists(GlobalWorker.currPath + @"\" + "changelog.txt"))
            {
                DirectoryInfo dir2 = new DirectoryInfo(Path.GetFullPath(GlobalWorker.currPath + @"\" + "doorstop_libs"));
                foreach (FileInfo item in dir2.GetFiles())
                {
                    item.Delete();
                }
                foreach (DirectoryInfo item in dir.GetDirectories())
                {
                    item.Delete(true);
                }
                DirectoryInfo dir3 = new DirectoryInfo(Path.GetFullPath(GlobalWorker.currPath + @"\" + "unstripped_corlib"));
                foreach (FileInfo item in dir3.GetFiles())
                {
                    item.Delete();
                }
                foreach (DirectoryInfo item in dir.GetDirectories())
                {
                    item.Delete(true);
                }
                //Еб*чий костыль. Не бейте
                File.Delete(GlobalWorker.currPath + @"\" + "changelog.txt");
                File.Delete(GlobalWorker.currPath + @"\" + "doorstop_config.ini");
                File.Delete(GlobalWorker.currPath + @"\" + "start_game_bepinex.sh");
                File.Delete(GlobalWorker.currPath + @"\" + "start_server_bepinex.sh");
                File.Delete(GlobalWorker.currPath + @"\" + "winhttp.dll");
                Directory.Delete(GlobalWorker.currPath + @"\" + "doorstop_libs");
                Directory.Delete(GlobalWorker.currPath + @"\" + "unstripped_corlib");
            }

            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += (s, g) =>
                {
                    var text = $@"{g.BytesReceived / megabyte}/{g.TotalBytesToReceive / megabyte}";
                    if (transparentLabel1.Text != text)
                        transparentLabel1.Text = text;

                    pictureBox2.Width = (int)(591f * (g.ProgressPercentage / 100f));
                };

                wc.DownloadFileCompleted += (s, g) =>
                {
                    if (g.Cancelled)
                    {
                        MessageBox.Show("Загрузка была отменена.");
                        return;
                    }

                    if (g.Error != null)
                    {
                        MessageBox.Show("Ошибка. Возможно сервер загрузок недоступен или лаунчер обновился. Подробнее в нашем Discord.");
                        return;
                    }
                    
                    ZipFile.ExtractToDirectory(GlobalWorker.currPath + @"\" + GlobalWorker.GameArchiveFileName, GlobalWorker.currPath);
                    GlobalWorker.version = GlobalWorker.serverVersion;
                    label1.Text = "Версия клиента: v" + GlobalWorker.version + "    /     Актуальная версия: v" + GlobalWorker.serverVersion;

                    button1.Text = "Играть";
                    button1.Click -= UpdateGame;
                    button1.Click += Play; ;

                    button1.ForeColor = Color.White;
                    button1.Enabled = true;
                    GlobalWorker.downloading = false;
                    GlobalWorker.InstallMods();
                };
                wc.DownloadFileAsync(new Uri(GlobalWorker.updateFile), GlobalWorker.currPath + @"\" + GlobalWorker.GameArchiveFileName);
                GlobalWorker.Configuration.ModPackDisable = false;
            }
        }

        private void Play(object sender, EventArgs e)
        {
            if (File.Exists(GlobalWorker.currPath + @"\" + GlobalWorker.GameArchiveFileName)) 
                File.Delete(GlobalWorker.currPath + @"\" + GlobalWorker.GameArchiveFileName);
            if (GlobalWorker.FileExist() && GlobalWorker.Configuration.Version == GlobalWorker.serverVersion)
            {
                string startparm1 = "gfx-enable-gfx-jobs=1\r\ngfx-enable-native-gfx-jobs=1\r\nwait-for-native-debugger=0\r\nhdr-display-enabled=0\r\ngc-max-time-slice=10\r\nvr-enabled=0";
                string startparm2 = "gfx-enable-gfx-jobs=1\r\ngfx-enable-native-gfx-jobs=1\r\nwait-for-native-debugger=0\r\nhdr-display-enabled=0\r\ngc-max-time-slice=10\r\nvr-enabled=0\r\njob-worker-count=";
                try
                {
                    if (String.IsNullOrEmpty(GlobalWorker.Configuration.StartParams))
                    {
                        using (StreamWriter sw = File.CreateText(GlobalWorker.currPath + @"\" + "valheim_Data" + @"\" + "boot.config"))
                        {
                            sw.WriteLine(startparm1);
                        }
                        Process.Start(GlobalWorker.currPath + @"\" + GlobalWorker.exename);
                    }
                    else
                    {
                        using (StreamWriter sw = File.CreateText(GlobalWorker.currPath + @"\" + "valheim_Data" + @"\" + "boot.config"))
                        {
                            sw.WriteLine(startparm2 + GlobalWorker.Configuration.StartParams);
                        }
                        Process.Start(GlobalWorker.currPath + @"\" + GlobalWorker.exename);
                    }

                    GlobalWorker.SaveConfiguration();
                    Close();
                }
                catch (Exception ex)
                {
                    GlobalWorker.chooseUpdate = true;
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.com/invite/yStAQ2fgax");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/SZqaBYvDxz");
        }

        /*private void ReinstallButton_Click(object sender, EventArgs e)
        {
            GlobalWorker.Reinstall();
        }*/

        private void label5_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/5DP2JxrJUq");
        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            GlobalWorker.chooseUpdate = false;
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void ModOff_Click(object sender, EventArgs e)
        {
            //if (File.Exists(GlobalWorker.currPath + @"\" + GlobalWorker.pathBepInEx))

            if (GlobalWorker.downloading)
                return;
            try
            {
                if (!GlobalWorker.Configuration.ModPackDisable)
                {
                    Directory.Move(GlobalWorker.currPath + @"\" + "BepInEx", GlobalWorker.currPath + @"\" + "BepInEx" + "_disable");
                    GlobalWorker.Configuration.ModPackDisable = true;
                    label1.Text = "Модпак выключен. Ванильная версия игры";
                    ModOn.Image = GreyDwarfLauncher.Properties.Resources.orange_control;
                    ModOff.Image = GreyDwarfLauncher.Properties.Resources.green_control;
                }
                else
                    return;
                GlobalWorker.SaveConfiguration();
            }
            catch
            {
                MessageBox.Show("Модпак не установлен. Изменения не сохранены");
            }
        }
        private void ModOn_Click(object sender, EventArgs e)
        {
            if (GlobalWorker.downloading)
                return;
            if (Directory.Exists(GlobalWorker.currPath + @"\" + GlobalWorker.pathBepInEx))
            {
                MessageBox.Show("Пожалуйста удалите папку BepInEx из папки с игрой");
                return;
            }
            try
            {
                if (GlobalWorker.Configuration.ModPackDisable)
                {
                    Directory.Move(GlobalWorker.currPath + @"\" + "BepInEx" + "_disable", GlobalWorker.currPath + @"\" + "BepInEx");
                    GlobalWorker.Configuration.ModPackDisable = false;
                    label1.Text = "Версия клиента: v" + GlobalWorker.version + "    /     Актуальная версия: v" + GlobalWorker.serverVersion;
                    ModOn.Image = GreyDwarfLauncher.Properties.Resources.green_control_22;
                    ModOff.Image = GreyDwarfLauncher.Properties.Resources.orange_control_28;
                }
                else
                    return;
                GlobalWorker.SaveConfiguration();
            }
            catch
            {
                MessageBox.Show("Пожалуйста перезапустите лаунчер с правами администратора. Изменения не сохранены");
            }
        }
        
    

        //============================================================================================================================
        //                                                      НЕ ТРОГАТЬ
        //============================================================================================================================
        
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void transparentLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_2(object sender, EventArgs e)
        {

        }
    }
}
