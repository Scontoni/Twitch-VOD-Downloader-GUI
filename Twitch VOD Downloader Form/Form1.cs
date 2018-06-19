using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twitch_VOD_Downloader_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var process = new System.Diagnostics.Process();
            var startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            process.StartInfo = startInfo;
            process.Start();
            process.StandardInput.WriteLine("concat_win.exe" + " -vod=" + vodIdInput.Text + " -quality=" + quality.Text + "30" + " -start=" + '\u0022' + startTime.Text + '\u0022' + " -end=" + endTime.Text);

            process.OutputDataReceived += new DataReceivedEventHandler(ProcessDataReceived);
            process.BeginOutputReadLine();

           process.WaitForExit();
           process.Close();
        }

        private void ProcessDataReceived(object sender, DataReceivedEventArgs e)
        {
            string output = e.Data;
            outputBox.Text = output;
        }

        private void outputBox_TextChanged(object sender, EventArgs e)
        {
                        
        }
    }
}
