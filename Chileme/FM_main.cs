using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Chileme
{
    public partial class FM_main : Form
    {
        string path;
        List<string> arr = new List<string>();
        public FM_main()
        {
            path = "list.txt";
            if (!File.Exists(path))
                File.Create(path);
            StreamReader sr = new StreamReader(path, Encoding.Default);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                arr.Add(line.ToString());
            }
            sr.Close();
            InitializeComponent();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
                MessageBox.Show("未找到list.txt文件！");
            if (arr.Count() == 0)
                return;
            Random ran = new Random();
            int bingo = ran.Next(0, arr.Count());
            textBox1.Text = arr[bingo];
        }

        private void link_about_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FM_about son = new FM_about();
            son.Owner = this;
            son.Show();
        }

        private void link_openList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string cmd = Application.StartupPath+"\\"+path;
            System.Diagnostics.Process.Start(cmd);
        }
    }
}
