using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vienna_Client
{
    public partial class flashFastbootMenu : Form
    {
        public flashFastbootMenu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flashRecovery_TextChanged(object sender, EventArgs e)
        {
        }

        private void flashRecoveryButton_Click(object sender, EventArgs e)
        {
            string text = flashRecovery.Text;
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = "/c fastboot.exe flash recovery " + text + " & pause";
            psi.WorkingDirectory = "C:\\Program Files (x86)\\Vienna Client\\Assets";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = false;
            Process.Start(psi);
        }

        private void bootImageButton_Click(object sender, EventArgs e)
        {
            string text = BootImages.Text;
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = "/c fastboot.exe boot " + text + " & pause";
            psi.WorkingDirectory = "C:\\Program Files (x86)\\Vienna Client\\Assets";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = false;
            Process.Start(psi);
        }

        private void flashSystemButton_Click(object sender, EventArgs e)
        {
            string text = flashSystem.Text;
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = "/c fastboot.exe flash system " + text + " & pause";
            psi.WorkingDirectory = "C:\\Program Files (x86)\\Vienna Client\\Assets";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = false;
            Process.Start(psi);
        }

        private void flashUserdataButton_Click(object sender, EventArgs e)
        {
            string text = flashUserdata.Text;
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = "/c fastboot.exe flash userdata " + text + " & pause";
            psi.WorkingDirectory = "C:\\Program Files (x86)\\Vienna Client\\Assets";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = false;
            Process.Start(psi);
        }

        private void flashCachebutton_Click(object sender, EventArgs e)
        {
            string text = flashCache.Text;
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = "/c fastboot.exe flash cache " + text + " & pause";
            psi.WorkingDirectory = "C:\\Program Files (x86)\\Vienna Client\\Assets";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = false;
            Process.Start(psi);
        }

        private void flashBootButton_Click(object sender, EventArgs e)
        {
            string text = flashBoot.Text;
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = "/c fastboot.exe flash boot " + text + " & pause";
            psi.WorkingDirectory = "C:\\Program Files (x86)\\Vienna Client\\Assets";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = false;
            Process.Start(psi);
        }

        private void flashStockRecoverbutton_Click(object sender, EventArgs e)
        {
            string text = flashStockRecovery.Text;
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = "/c fastboot.exe flash recovery " + text + " & pause";
            psi.WorkingDirectory = "C:\\Program Files (x86)\\Vienna Client\\Assets";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = false;
            Process.Start(psi);
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
