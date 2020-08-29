using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SysVentory.View
{
    public partial class View : Form
    {
        private readonly Controller Controller;

        private readonly string[] errorMessages = {
            "Bitte Wählen Sie Scan 1 aus!",
            "Bitte Wählen Sie Scan 2 aus!",
            "Bitte Wählen Sie Scan 1 und 2 aus!"
        };
        public View()
        {
            InitializeComponent();
            Controller = new Controller();
            loadGui();
        }
        private void loadGui()
        {
            cmbScans1.Items.Clear();
            cmbScans2.Items.Clear();
            List<Scan> scans = Controller.GetScans();
            foreach (Scan scan in scans) {
                cmbScans1.Items.Add(scan.GetSelect());
                cmbScans2.Items.Add(scan.GetSelect());
            }
        }

        private void CmdScan_Click(object sender, EventArgs e)
        {
            Controller.ScanNow();
            loadGui();
        }

        private void cmdShow1_Click(object sender, EventArgs e)
        {
            if (cmbScans1.SelectedItem != null) {
                Scan selectedScan = Controller.FindScanBySelected(cmbScans1.SelectedItem.ToString());
                TxtOut1.Text += selectedScan.ToString();
            }
            else
                MessageBox.Show(errorMessages[0]);
        }

        private void cmdShow2_Click(object sender, EventArgs e)
        {
            if (cmbScans2.SelectedItem != null) {
                Scan selectedScan = Controller.FindScanBySelected(cmbScans2.SelectedItem.ToString());
                TxtOut2.Text += selectedScan.ToString();
            }
            else
                MessageBox.Show(errorMessages[1]);

        }
        private void cmdDiff_Click(object sender, EventArgs e)
        {
            if (cmbScans1.SelectedItem != null && cmbScans2.SelectedItem != null)
                txtDiff.Text = Controller.GetDiffByTwoSelected(cmbScans1.SelectedItem.ToString(), cmbScans2.SelectedItem.ToString());
            else
                MessageBox.Show(errorMessages[2]);
            
        }
    }
}
