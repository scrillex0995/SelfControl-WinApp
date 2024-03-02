using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SelfControl
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void openBlackList(object sender, EventArgs e) 
        {
            blockListEditor blockList = new blockListEditor();
            blockList.ShowDialog();
            StartButton.Enabled = Properties.Settings.Default.AllowToStart;
        }

        private float Hours = 0;
        private float Minutes = 1;

        private void barScroll(object sender, EventArgs e)
        {
            Hours = ((timeBar.Value - 1) * 5) / 60;
            Minutes = (timeBar.Value - 1) * 5 - Hours * 60;

            if (timeBar.Value == 1) 
            {
                Hours = 0;
                Minutes = 1;
            }

            if (Minutes == 0) 
            {
                estimitedTimeLabel.Text = String.Format("{0} hours", Hours);
            }
            else if (Hours == 0) 
            {
                estimitedTimeLabel.Text = String.Format("{0} minutes", Minutes);
            }
            else 
            {
                estimitedTimeLabel.Text = String.Format("{0} hours {1} minutes", Hours, Minutes);
            }
        }

        public void StartButtonPressed(object sender, EventArgs e)
        {
            if (!File.Exists("C:\\domainBlackList.txt"))
            {
                MessageBox.Show("Fill out the blacklist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] blackListDomains = File.ReadAllLines("C:\\domainBlackList.txt");

            if (blackListDomains.Length > 0)
            {
                if (!File.Exists("C:\\hosts.backup"))
                {
                    File.Copy(@Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\" + "\\drivers\\etc\\hosts", "C:\\hosts.backup");
                }

                for (int i = 0; i < blackListDomains.Length; i++)
                {
                    using (StreamWriter w = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts")))
                    {
                        w.WriteLine("#Selfcontrol");
                        
                        if (!blackListDomains[i].ToString().Contains("www."))
                        {
                            w.WriteLine("0.0.0.0 " + "www." + blackListDomains[i].ToString());
                        }
                        else
                        {
                            w.WriteLine("0.0.0.0 " + blackListDomains[i].ToString());
                        }

                        if (blackListDomains[i].ToString().Contains("https://"))
                        {
                            w.WriteLine("0.0.0.0 " + blackListDomains[i].Replace("https://", "").ToString());
                        }
                    }
                }

                Properties.Settings.Default.SecondsLeft = (int)Minutes * 60 + (int)Hours * 60 * 60;
                //Properties.Settings.Default.SecondsLeft = 15; 
                Properties.Settings.Default.SelfControl = true;

                Timer timer = new Timer();
                timer.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Domain blacklist is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Properties.Settings.Default.TurnOffPC)
            {
                TimeSpan timeSpan = DateTime.Now.TimeOfDay;
                int amountMinutes = Properties.Settings.Default.ToffBarValue * 5;
                int leftNeededTime = amountMinutes - (int)timeSpan.TotalMinutes;

                Console.WriteLine(amountMinutes + " | " + timeSpan.TotalMinutes);

                var psi = new ProcessStartInfo("shutdown", "/s /t " + leftNeededTime * 60);
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                Process.Start(psi);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SelfControl)
            {
                MessageBox.Show("You have to finish your previos session");
                Timer timer = new Timer();
                timer.Show();
            }

            StartButton.Enabled = Properties.Settings.Default.AllowToStart;

            if (!Properties.Settings.Default.AllowToDelete) { Properties.Settings.Default.AllowToDelete = true; }
        }

        private void Main_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        private void Showed(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.SelfControl) { this.Hide(); }
        }
    }
}
