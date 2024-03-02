using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SelfControl
{
    public partial class blockListEditor : Form
    {
        private string filePath = "C:\\domainBlackList.txt";
        private int Minutes = 0;
        private int Hours = 0;
        private TimeSpan timeSpan = DateTime.Now.TimeOfDay;
        public blockListEditor()
        {
            InitializeComponent();
        }

        private void addDomain(object sender, EventArgs e)
        {
            domainBlackList.Items.Add(domainName.Text);
        }

        private void deleteSelectedItems(object sender, EventArgs e)
        {
            if (domainBlackList.Items.Count > 0)
            {
                for (int i = 0; i < domainBlackList.Items.Count; i++)
                {
                    if (domainBlackList.GetItemCheckState(i) == CheckState.Checked)
                    {
                        domainBlackList.Items.RemoveAt(i);
                    }
                }
            }
        }

        private bool IsInHosts(string[] host, string domainName, string DNS)
        {
            foreach (string hostDomain in host)
            {
                if (DNS + " " + domainName == hostDomain) { return true; }
            }

            return false;
        }

        private void onClosing(object sender, FormClosingEventArgs e)
        {
            if (!File.Exists(filePath)) { File.Create(filePath); }

            File.GetAccessControl("C:\\domainBlackList.txt");

            File.WriteAllText(filePath, string.Empty);

            foreach (string domain in domainBlackList.Items)
            {
                using (StreamWriter streamWriter = File.AppendText(filePath)) { streamWriter.WriteLine(domain); }
            }

            Properties.Settings.Default.AllowToStart = true;

            if (Properties.Settings.Default.SelfControl)
            {
                string[] blackListedDomains = File.ReadAllLines(filePath);
                string[] host = File.ReadAllLines(@Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\" + "\\drivers\\etc\\hosts");
                string DNS = "0.0.0.0";

                foreach (string domain in blackListedDomains)
                {
                    if (!IsInHosts(host, domain, DNS))
                    {
                        using (StreamWriter streamWriter = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts")))
                        {
                            streamWriter.WriteLine(DNS + " " + domain);
                        }
                    }
                }
            }

            if (barTofAt.Value * 5 < timeSpan.TotalMinutes && ToffCheckbox.Checked)
            {
                MessageBox.Show("Setted time is not possible to reach", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }

            Properties.Settings.Default.ToffBarValue = barTofAt.Value;
            Properties.Settings.Default.TurnOffPC = ToffCheckbox.Checked;
            Properties.Settings.Default.AllowReset = AllResetCheckbox.Checked;
            Properties.Settings.Default.Save();
        }

        private void blockListEditor_Load(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                foreach (string domain in File.ReadLines(filePath))
                {
                    domainBlackList.Items.Add(domain);
                }
            }

            deleteButton.Enabled = Properties.Settings.Default.AllowToDelete;
            ToffCheckbox.Checked = Properties.Settings.Default.TurnOffPC;
            barTofAt.Value = Properties.Settings.Default.ToffBarValue;
            AllResetCheckbox.Checked = Properties.Settings.Default.AllowReset;

            if (ToffCheckbox.Checked) 
            {
                barTofAt.Enabled = true;
                labelPCTime.Enabled = true;

                Hours = barTofAt.Value * 5 / 60;
                Minutes = barTofAt.Value * 5 - Hours * 60;

                labelPCTime.Text = String.Format("{0:00}:{1:00}", Hours, Minutes);
            }
        }

        private void blackList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ToffPCAt_Checkbox(object sender, EventArgs e)
        {
            if (ToffCheckbox.Checked) 
            {
                barTofAt.Enabled = true;
                labelPCTime.Enabled = true;
            }
            else 
            {
                barTofAt.Enabled = false;
                labelPCTime.Enabled = false;
            }
        }

        private void trackbarTurnOffAt_Scroll(object sender, EventArgs e)
        {
            Hours = barTofAt.Value * 5 / 60;
            Minutes = barTofAt.Value * 5 - Hours * 60;

            labelPCTime.Text = String.Format("{0:00}:{1:00}", Hours, Minutes);

            if (barTofAt.Value * 5 < timeSpan.TotalMinutes)
            {
                labelPCTime.ForeColor = Color.Red;
            }
            else
            {
                labelPCTime.ForeColor = Color.Black;
            }
        }
    }
}
