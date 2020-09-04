using System;
using System.Windows.Forms;
using System.Collections.Generic;
using DiffMatchPatch;
using System.Drawing;

namespace SysVentory.View
{


    public partial class View : Form
    {


        private readonly Controller Controller;

        private readonly string[] errorMessages = {
            "Bitte wählen Sie Scan 1 aus!",
            "Bitte wählen Sie Scan 2 aus!",
            "Bitte wählen Sie Scan 1 und 2 aus!",
            "Bitte wählen Sie ein Delta aus!"
        };

        /*
        * Structure For Selection and Highlight the Delta Text
        */
        public struct Highlights
        {
            public int startpos;
            public int length;
            public Color color;
        }

        public View()
        {
            InitializeComponent();
            Controller = new Controller();
            loadGui();
        }
        private void loadGui()
        {
            object cmbScan1 = cmbScans1.SelectedItem;
            object cmbScan2 = cmbScans2.SelectedItem;
            object cmbDelta = cmbDeltas.SelectedItem;
            cmbScans1.Items.Clear();
            cmbScans2.Items.Clear();
            cmbDeltas.Items.Clear();

            // load scans
            List<Scan> scans = Controller.GetScans();
            foreach (Scan scan in scans) {
                cmbScans1.Items.Add(scan.GetSelect());
                cmbScans2.Items.Add(scan.GetSelect());
            }
            // load deltas
            List<Delta> deltas = Controller.GetDeltas();
            foreach (Delta delta in deltas)
                cmbDeltas.Items.Add(delta.Title);

           
            if (cmbScan1 != null)
                cmbScans1.SelectedItem = cmbScan1;

            if (cmbScan2 != null)
                cmbScans2.SelectedItem = cmbScan2;

            if (cmbDelta != null)
                cmbDeltas.SelectedItem = cmbDelta;
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
            if (cmbScans1.SelectedItem != null && cmbScans2.SelectedItem != null) {
                Delta delta = Controller.GetListDiffByTwoSelected(cmbScans1.SelectedItem.ToString(), cmbScans2.SelectedItem.ToString());
                writeDiffs(delta.Diffs);
                loadGui();
                cmbDeltas.ResetText();
                cmbDeltas.SelectedText = cmbScans1.SelectedItem.ToString() + " " + cmbScans2.SelectedItem.ToString();
            } else
                MessageBox.Show(errorMessages[2]);
        }
        private void cmdDelete1_Click(object sender, EventArgs e)
        {
            if (cmbScans1.SelectedItem != null)
            {
                Controller.DeleteByScan(cmbScans1.SelectedItem.ToString());
                cmbScans1.SelectedItem = null;
                cmbScans1.SelectedText = "Scan 1 auswählen";
                loadGui();
            }
            else
                MessageBox.Show(errorMessages[0]);
        }

        private void cmdDelete2_Click(object sender, EventArgs e)
        {
            if (cmbScans1.SelectedItem != null)
            {
                Controller.DeleteByScan(cmbScans2.SelectedItem.ToString());
                cmbScans2.SelectedItem = null;
                cmbScans2.SelectedText = "Scan 2 auswählen";
                loadGui();
            }
            else
                MessageBox.Show(errorMessages[1]);
        }

        private void writeDiffs(List<Diff> diffs)
        {
            rtbDiff1.Text = "";
            List<Highlights> highlightList = new List<Highlights>();
            foreach (Diff aDiff in diffs)
            {
                Highlights high = new Highlights();
                high.startpos = rtbDiff1.TextLength;
                rtbDiff1.Text += aDiff.text;
                high.length = aDiff.text.Length;
                switch (aDiff.operation)
                {
                    case Operation.INSERT:
                        high.color = Color.Green;
                        break;
                    case Operation.DELETE:
                        high.color = Color.Red;
                        break;
                    case Operation.EQUAL:
                        high.color = Color.White;
                        break;
                }
                highlightList.Add(high);
            }
            highlightDiff(highlightList);
        }

        private void highlightDiff(List<Highlights> highlights)
        {
            foreach (Highlights high in highlights)
            {
                rtbDiff1.Select(high.startpos, high.length);
                rtbDiff1.SelectionBackColor = high.color;
            }
        }

        private void cmdShowDiff_Click(object sender, EventArgs e)
        {
            if (cmbDeltas.SelectedItem != null)
            {
                Delta selectedDelta = Controller.FindDeltaBySelected(cmbDeltas.SelectedItem.ToString());
                writeDiffs(selectedDelta.Diffs);
                loadGui();
            }
            else
                MessageBox.Show(errorMessages[3]);
        }
    }
}
