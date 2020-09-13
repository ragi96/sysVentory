using DiffMatchPatch;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq;

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
            LoadGui();
        }
        private void LoadGui()
        {
            object cmbScan1 = CmbScans1.SelectedItem;
            object cmbScan2 = CmbScans2.SelectedItem;
            object cmbDelta = CmbDeltas.SelectedItem;
            CmbScans1.Items.Clear();
            CmbScans2.Items.Clear();
            CmbDeltas.Items.Clear();

            // load scans
            List<Scan> scans = Controller.GetScans();
            if(scans != null) { 
                foreach (Scan scan in scans) {
                    CmbScans1.Items.Add(scan.GetSelect());
                    CmbScans2.Items.Add(scan.GetSelect());
                }
            }
            // load deltas
            List<Delta> deltas = Controller.GetDeltas();
            if (deltas != null)
            {
                foreach (Delta delta in deltas)
                    CmbDeltas.Items.Add(delta.Title);
            }
           
            if (cmbScan1 != null)
                CmbScans1.SelectedItem = cmbScan1;

            if (cmbScan2 != null)
                CmbScans2.SelectedItem = cmbScan2;

            if (cmbDelta != null)
                CmbDeltas.SelectedItem = cmbDelta;
            //load all scanned Computers
            string[] Computers = Controller.getComputers();
            foreach (string s in Computers)
            {
                cmbDeleteComputer.Items.Add(s);
            }
        }

        private void CmdScan_Click(object sender, EventArgs e)
        {
            Controller.ScanNow();
            LoadGui();
        }

        private void CmdShow1_Click(object sender, EventArgs e)
        {
            if (CmbScans1.SelectedItem != null) {
                Scan selectedScan = Controller.FindScanBySelected(CmbScans1.SelectedItem.ToString());
                TxtOut1.Text = selectedScan.ToString();
            }
            else
                MessageBox.Show(errorMessages[0]);
        }

        private void CmdShow2_Click(object sender, EventArgs e)
        {
            if (CmbScans2.SelectedItem != null) {
                Scan selectedScan = Controller.FindScanBySelected(CmbScans2.SelectedItem.ToString());
                TxtOut2.Text = selectedScan.ToString();
            }
            else
                MessageBox.Show(errorMessages[1]);

        }
        private void CmdDiff_Click(object sender, EventArgs e)
        {
            if (CmbScans1.SelectedItem != null && CmbScans2.SelectedItem != null) {
                Delta delta = Controller.GetListDiffByTwoSelected(CmbScans1.SelectedItem.ToString(), CmbScans2.SelectedItem.ToString());
                WriteDiffs(delta.DiffsSoftware, RtbDiffSoftware);
                WriteDiffs(delta.DiffsHardware, RtbDiffHardware);
                LoadGui();
                CmbDeltas.ResetText();
                CmbDeltas.SelectedText = CmbScans1.SelectedItem.ToString() + " " + CmbScans2.SelectedItem.ToString();
            } else
                MessageBox.Show(errorMessages[2]);
        }
        private void CmdDelete1_Click(object sender, EventArgs e)
        {
            if (CmbScans1.SelectedItem != null)
            {
                Controller.DeleteByScan(CmbScans1.SelectedItem.ToString());
                CmbScans1.SelectedItem = null;
                CmbScans1.SelectedText = "Scan 1 auswählen";
                LoadGui();
            }
            else
                MessageBox.Show(errorMessages[0]);
        }

        private void CmdDelete2_Click(object sender, EventArgs e)
        {
            if (CmbScans2.SelectedItem != null)
            {
                Controller.DeleteByScan(CmbScans2.SelectedItem.ToString());
                CmbScans2.SelectedItem = null;
                CmbScans2.SelectedText = "Scan 2 auswählen";
                LoadGui();
            }
            else
                MessageBox.Show(errorMessages[1]);
        }

        private void WriteDiffs(List<Diff> diffs, RichTextBox rtb)
        {
            rtb.Text = "";
            List<Highlights> highlightList = new List<Highlights>();
            foreach (Diff aDiff in diffs)
            {
                Highlights high = new Highlights();
                high.startpos = rtb.TextLength;
                rtb.Text += aDiff.text;
                high.length = aDiff.text.Length;
                switch (aDiff.operation)
                {
                    case Operation.INSERT:
                        high.color = Color.GreenYellow;
                        break;
                    case Operation.DELETE:
                        high.color = Color.Tomato;
                        break;
                    case Operation.EQUAL:
                        high.color = Color.White;
                        break;
                }
                highlightList.Add(high);
            }
            HighlightDiff(highlightList, rtb);
        }

        private void HighlightDiff(List<Highlights> highlights, RichTextBox rtb)
        {
            foreach (Highlights high in highlights)
            {
                rtb.Select(high.startpos, high.length);
                rtb.SelectionBackColor = high.color;
            }
        }

        private void CmdShowDiff_Click(object sender, EventArgs e)
        {
            if (CmbDeltas.SelectedItem != null)
            {
                Delta selectedDelta = Controller.FindDeltaBySelected(CmbDeltas.SelectedItem.ToString());
                WriteDiffs(selectedDelta.DiffsSoftware, RtbDiffSoftware);
                WriteDiffs(selectedDelta.DiffsHardware, RtbDiffHardware);
                LoadGui();
            }
            else
                MessageBox.Show(errorMessages[3]);
        }

        private void cmdDeleteComputer_Click(object sender, EventArgs e)
        {
            if (cmbDeleteComputer.SelectedItem != null)
            {
                Controller.DeleteComputerScan(cmbDeleteComputer.SelectedItem.ToString());
            }
            else
                MessageBox.Show(errorMessages[0]);
        }
    }
}
