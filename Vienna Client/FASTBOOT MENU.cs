using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Security;
using System.Diagnostics.Eventing.Reader;
using System.IO;


namespace Vienna_Client
{
    public partial class FASTBOOT_MENU : Form
    {
        public FASTBOOT_MENU()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            InitializeComponent();
            Process.Start("cmd");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flashFastbootMenu newForm = new flashFastbootMenu();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = "/c fastboot.exe devices & pause";
            psi.WorkingDirectory = "C:\\Program Files (x86)\\Vienna Client\\Assets";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = false;
            Process.Start(psi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = "/c fastboot.exe reboot recovery & pause";
            psi.WorkingDirectory = "C:\\Program Files (x86)\\Vienna Client\\Assets";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = false;
            Process.Start(psi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = "/c fastboot.exe reboot bootloader & pause";
            psi.WorkingDirectory = "C:\\Program Files (x86)\\Vienna Client\\Assets";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = false;
            Process.Start(psi);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = "/c fastboot.exe reboot & pause";
            psi.WorkingDirectory = "C:\\Program Files (x86)\\Vienna Client\\Assets";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = false;
            Process.Start(psi);
        }
    }
}
