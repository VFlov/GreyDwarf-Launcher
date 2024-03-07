using System;
using System.Drawing;
using System.Windows.Forms;

namespace GreyDwarfLauncher
{
    public partial class Options2 : Form
    {
        public Options2()
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
            label3.Text = "Выберите путь к папке Valheim";
            label3.ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GlobalWorker.Configuration.Path = GlobalWorker.currPath;
            GlobalWorker.SaveConfiguration();
            this.Close();
        }
        private void Explorer_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                GlobalWorker.currPath = folderBrowserDialog1.SelectedPath;
                GamePath.Text = GlobalWorker.currPath;
                if (GlobalWorker.FileExist())
                {
                    label3.ForeColor = Color.DarkOliveGreen;
                    label3.Text = "Файл valheim.exe найден.";
                }
                else
                {
                    label3.ForeColor = Color.Salmon;
                    label3.Text = "Файл valheim.exe не найден. Пожалуйста убедитесь что вы выбрали папку с Valheim игрой.";
                }
            }
        }
    }
}
