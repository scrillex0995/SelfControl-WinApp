using System;
using System.IO;
using System.Windows.Forms;

namespace SelfControl
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }

        bool noCloseDialog = false;

        private void everyTick(object sender, EventArgs e)
        {
            int Minutes = Properties.Settings.Default.SecondsLeft / 60;
            int Seconds = Properties.Settings.Default.SecondsLeft - Minutes * 60;
            int Hours = Minutes / 60;

            timeLeftLabel.Text = String.Format("{0:00}:{1:00}:{2:00}", Hours, Minutes, Seconds);

            Properties.Settings.Default.SecondsLeft -= 1;

            if (Properties.Settings.Default.SecondsLeft <= 0)
            {
                Properties.Settings.Default.SelfControl = false;
                noCloseDialog = true;

                if (File.Exists("C:\\hosts.backup"))
                {
                    File.Copy("C:\\hosts.backup", @Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\" + "drivers\\etc\\hosts", true);
                    File.Delete("C:\\hosts.backup");
                }
                else
                {
                    MessageBox.Show("Hosts backup file was not found, edit the hosts file by yourself", "Backup file was not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }         
                Application.Exit();
            }
        }

        private void TimerClosing(object sender, FormClosingEventArgs e)
        {
            if (!noCloseDialog)
            {
                DialogResult dr = MessageBox.Show("Are you sure to cancel? Closing this window will freeze the timer until you open the programm next time", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                    e.Cancel = true;
            }

            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void Timer_Load(object sender, EventArgs e)
        {
            noCloseDialog = false;
            ResetButton.Enabled = Properties.Settings.Default.AllowReset;
        }

        private void Timer_MouseUp(object sender, MouseEventArgs e)
        {
            this.Opacity += 1;
        }

        private void Timer_MouseDown(object sender, MouseEventArgs e)
        {
            this.Opacity -= 1;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon.Visible = false;
        }

        private void Timer_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon.Visible = false;
            }
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AllowToDelete = false;
            Properties.Settings.Default.Save();

            blockListEditor blockListEditor = new blockListEditor();
            blockListEditor.ShowDialog();
        }

        private void ResetClicked(object sender, EventArgs e)
        {
            Properties.Settings.Default.SecondsLeft = 5;
        }
    }
}
