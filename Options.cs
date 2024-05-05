using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace GreyDwarfLauncher.Resources
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            Opacity = 0;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.05d) == 1) timer.Stop();
            });
            timer.Interval = 30;
            timer.Start();
        }
        
        private void OptionsForm_Load(object sender, EventArgs e)
        {
            var url = "http://85.209.9.15:8080/api/public/dl/FbxR7sAG/fileserver/options.txt";
            var textFromFile = (new WebClient()).DownloadString(url);
            var text = textFromFile.Split(new char[] { '\n', });
            check1.Text = text[0];
            check2.Text = text[1];
            check3.Text  = text[2];
            check1.Checked = GlobalWorker.Configuration.check1;
            check2.Checked = GlobalWorker.Configuration.check2;
            adminToolsCheckBox.Checked = GlobalWorker.Configuration.AdminTools;
            check3.Checked = GlobalWorker.Configuration.check3;
            StartParamsComboBox.SelectedItem = GlobalWorker.Configuration.StartParams;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (GlobalWorker.currPath == null || !GlobalWorker.FileExist() || !Directory.Exists(GlobalWorker.Configuration.Path + @"\" + "BepInEx"))
            {
                MessageBox.Show("Установите игру. Изменения не сохранены");
                this.Close(); 
                return;
            }
            if (GlobalWorker.downloading)
            {
                MessageBox.Show("Идет установка. Изменения не сохранены");
                this.Close();
                return;
            }
            if (GlobalWorker.Configuration.ModPackDisable)
            {
                MessageBox.Show("Ванильная версия игры. Изменения не сохранены");
                this.Close();
                return;
            }
            GlobalWorker.Configuration.check1 = check1.Checked;
            GlobalWorker.Configuration.check2 = check2.Checked;
            GlobalWorker.Configuration.AdminTools = adminToolsCheckBox.Checked;
            GlobalWorker.Configuration.check3 = check3.Checked;
            GlobalWorker.Configuration.StartParams = StartParamsComboBox.Text;

            GlobalWorker.SaveConfiguration();

            GlobalWorker.InstallMods();

            this.Close();
        }

        private void ReinstallButton_Click(object sender, EventArgs e)
        {
            GlobalWorker.Reinstall();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
