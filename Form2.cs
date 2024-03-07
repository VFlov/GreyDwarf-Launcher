using GreyDwarfLauncher.Resources;
using System;
using System.Windows.Forms;

namespace GreyDwarfLauncher
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Opacity = 0;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.05d) >= 0.75) timer.Stop();
            });
            timer.Interval = 30;
            timer.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            if (GlobalWorker.chooseUpdate)
            {
                Options2 form = new Options2();
                form.ShowDialog();
            }
            else
            { 
                Options form = new Options();
                form.ShowDialog();
            }
            this.Close();
        }
    }
}
