using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24PointGame
{
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Record_Load(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream(Program.filePath, FileMode.Open);
            StreamReader sr = new StreamReader(fileStream);
            string line;
            int cnt = 0;
            //while ((line = sr.ReadLine()) != null)
            //{
            //    cnt++;
            //    //txtRecord.Text = txtRecord.Text + cnt + ".    " + line + "\r\n";
            //}

            string str = sr.ReadToEnd();
            sr.Close();
            string[] arrayStr = Regex.Split(str, "\r\n");
            cnt = arrayStr.Length-1;
            if (cnt == 0)
            {
                txtRecord.Text = "无";
                return;
            }
            for (int i = 1; i <= ((cnt >= 3) ? 3 : cnt); i++) 
            {
                txtRecord.Text = txtRecord.Text + i + ".    " + arrayStr[arrayStr.Length - i - 1] + "\r\n";
            }
            
        }
    }
}
