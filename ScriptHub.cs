using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KrnlAPI;

namespace JerryExecutor
{
    public partial class ScriptHub : Form
    {
        public ScriptHub()
        {
            InitializeComponent();
            MainAPI.Load();
        }

        Point lastPoint;

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source");
            MainAPI.Execute(Script);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/1201for/V.G-Hub/main/V.Ghub");
            MainAPI.Execute(Script);
        }

        

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://gist.githubusercontent.com/DinosaurXxX/b757fe011e7e600c0873f967fe427dc2/raw/ee5324771f017073fc30e640323ac2a9b3bfc550/dark%2520dex%2520v4");
            MainAPI.Execute(Script);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/ChaosityYT/GameScripts/master/T0PK3K%204.0.txt");
            MainAPI.Execute(Script);
        }
    }
}
