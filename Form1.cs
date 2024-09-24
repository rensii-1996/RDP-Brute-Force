using FastRDP.Models;
using System.Windows.Forms;

namespace FastRDP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resultGridView.Rows.Add("", "", "", "", "", "");
        }

        private void usernamesBtn_Click(object sender, EventArgs e)
        {
            if (usernamesOFD.ShowDialog() == DialogResult.OK)
            {
                usernameTextBox.Text = usernamesOFD.FileName.ToString();
            }
        }

        private void passwordsBtn_Click(object sender, EventArgs e)
        {
            if (passwordsOFD.ShowDialog() == DialogResult.OK)
            {
                passwordsTextBox.Text = usernamesOFD.FileName.ToString();
            }
        }

        private void startStopScan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.hostsList.Text))
            {
                MessageBox.Show("Hosts list must be filled.");
                return;
            }
            startStopScan.Enabled = false;
            if (startStopScan.Text == "Start Scan")
            {
                int timeout = Convert.ToInt32(numericTimeout.Value);
                int threads = Convert.ToInt32(numericThreads.Value);
                RDPBruteForce.parseArguments(usernamesOFD.FileName, passwordsOFD.FileName, hostsList.Lines,
                    portsList.Lines, timeout, threads);
                new Thread(() =>
                {
                    if (RDPBruteForce.start())
                    {
                        
                    }
                }).Start();
                new Thread(() =>
                {
                    Thread.Sleep(3000);
                    this.Invoke(new MethodInvoker(delegate { startStopScan.Text = "Stop Scan"; }));
                    while (true)
                    {
                        RDPResult? rdpResult;
                        rdpResult = RDPBruteForce.getResult();
                        if (rdpResult == null && RDPBruteForce.allResultGetted()) break;
                        else if (rdpResult == null) continue;
                        if (rdpResult == null && RDPBruteForce.allResultGetted())
                        {
                            break;
                        }else if(rdpResult == null)
                        {
                            continue;
                        }
                        resultGridView.Invoke(new Action(() =>
                        {
                            if(rdpResult != null)
                            {
                                if(!rdpResult.Status)
                                {
                                    resultGridView.Rows[0].SetValues(rdpResult.Hostname, rdpResult.Port, rdpResult.Username,
                                rdpResult.Password, rdpResult.Status.ToString(), rdpResult.Error);
                                }
                                else
                                {
                                    resultGridView.Rows.Add(rdpResult.Hostname, rdpResult.Port, rdpResult.Username,
                                    rdpResult.Password, rdpResult.Status.ToString(), rdpResult.Error);
                                }
                            }
                        }));
                        
                    }
                    this.Invoke(new MethodInvoker(
                        delegate
                        {
                            startStopScan.Text = "Done";
                            startStopScan.Enabled = false;
                            MessageBox.Show("Scan finished.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }));
                }).Start();
            }
            else
            {
                if (RDPBruteForce.stop())
                {
                    RDPBruteForce.stop();
                    startStopScan.Text = "Start Scan";
                }
            }
            Thread.Sleep(3000);
            startStopScan.Enabled = true;
        }
    }
}
