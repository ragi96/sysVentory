using DiffMatchPatch;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SysVentory.View
{
    // Die View stellt die Benutzeroberfläche und ihre Aktionen dar
    public partial class View : Form
    {
        // Controller, der den Datenzugriff steuert
        private Controller Controller;

        // Liste von möglichen Fehlermeldungen
        private readonly string[] errorMessages = {
            "Bitte wählen Sie Scan 1 aus!",
            "Bitte wählen Sie Scan 2 aus!",
            "Bitte wählen Sie Scan 1 und 2 aus!",
            "Bitte wählen Sie ein Delta aus!",
            "Bitte wählen Sie einen Computer aus!"
        };

        // Highlights, die Änderungen in Deltas darstellt
        public struct Highlights
        {
            public int startpos;
            public int length;
            public Color color;
        }

        // Erstellt eine neue View und lädt alle GUI Daten
        public View()
        {
            InitializeComponent();
            Controller = new Controller();
            LoadGui();
        }

        // Wird zum initialen Load und Reload des GUIs verwendet
        private void LoadGui(bool hardScanReset = false)
        {
            object cmbScan1 = CmbScans1.SelectedItem;
            object cmbScan2 = CmbScans2.SelectedItem;
            object cmbDelta = CmbDeltas.SelectedItem;
            CmbScans1.Items.Clear();
            CmbScans2.Items.Clear();
            CmbDeltas.Items.Clear();
            CmbDeleteComputer.Items.Clear();

            if (hardScanReset == true) {
                Controller = new Controller();
                CmbDeleteComputer.ResetText();
                CmbScans1.ResetText();
                CmbScans2.ResetText();
                TxtOut1.Text = "";
                TxtOut2.Text = "";
                CmbScans1.SelectedItem = null;
                CmbScans1.SelectedText = "Scan 1 auswählen";
                CmbScans2.SelectedItem = null;
                CmbScans2.SelectedText = "Scan 2 auswählen";
            }

            // Lädt Scans aus dem Storage
            List<Scan> scans = Controller.GetScans();
            if(scans != null) { 
                foreach (Scan scan in scans) {
                    CmbScans1.Items.Add(scan.GetSelect());
                    CmbScans2.Items.Add(scan.GetSelect());
                }
            }
            // Lädt Deltas aus dem Storage
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
            
            // Lädt alle verfügbaren Computer
            string[] Computers = Controller.GetComputers();
            foreach (string s in Computers)
            {
                CmbDeleteComputer.Items.Add(s);
            }
        }

        // Erstellt einen neuen Scan
        private void CmdScan_Click(object sender, EventArgs e)
        {
            Controller.ScanNow();
            LoadGui();
        }

        // Stellt den ausgewählten Scan aus Feld 1 dar
        private void CmdShow1_Click(object sender, EventArgs e)
        {
            if (CmbScans1.SelectedItem != null) {
                Scan selectedScan = Controller.FindScanBySelected(CmbScans1.SelectedItem.ToString());
                TxtOut1.Text = selectedScan.ToString();
            }
            else
                MessageBox.Show(errorMessages[0]);
        }

        // Stellt den ausgewählten Scan aus Feld 2 dar
        private void CmdShow2_Click(object sender, EventArgs e)
        {
            if (CmbScans2.SelectedItem != null) {
                Scan selectedScan = Controller.FindScanBySelected(CmbScans2.SelectedItem.ToString());
                TxtOut2.Text = selectedScan.ToString();
            }
            else
                MessageBox.Show(errorMessages[1]);

        }

        // Erstellt ein neues Delta der ausgewählten Scans
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

        // Löscht den ausgewählten Scan in Feld 1
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

        // Löscht den ausgewählten Scan in Feld 2
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

        // Lädt das ausgewählte Delta mit hervorhebungen
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

        // Setzt die korrekte Hervorhebung auf dem Delta
        private void HighlightDiff(List<Highlights> highlights, RichTextBox rtb)
        {
            foreach (Highlights high in highlights)
            {
                rtb.Select(high.startpos, high.length);
                rtb.SelectionBackColor = high.color;
            }
        }

        // Schreibt das ausgewählte Delta ins GUI
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

        // Löscht die Scans des ausgewählten Computers
        private void CmdDeleteComputer_Click(object sender, EventArgs e)
        {
            if (CmbDeleteComputer.SelectedItem != null)
            {
                Controller.DeleteComputerScan(CmbDeleteComputer.SelectedItem.ToString());
                LoadGui(true);
            }
            else
                MessageBox.Show(errorMessages[4]);
        }

        private void CmbDeleteComputer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
