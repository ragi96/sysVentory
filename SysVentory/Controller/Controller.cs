using System.Collections.Generic;
using SysVentory.ThirdParty;
using System.IO;
using System.Text.RegularExpressions;

namespace SysVentory
{
    // Der Controller steuert den Datenzugriff aus der View und liefert die Daten aus dem Model
    class Controller
    {
        // Storage, in dem die Daten zur Laufzeit gehalten werden
        private Storage Storage { get; set; }

        // Konstruktur, erstellt zum Programmstart einen neuen Storage
        public Controller()
        {
            Storage = new Storage();
        }

        // Fügt einen neuen Scan im Storage hinzu
        public Scan ScanNow()
        {
            Scan newScan = new Scan(Data.Read());
            Storage.WriteScan(newScan);

            return newScan;
        }

        // Liefert alle Scans im Storage zurück
        public List<Scan> GetScans()
        {
            return Storage.Scans;
        }

        // Liefert alle verfügbaren Computer mit Scans zurück
        public string[] GetComputers()
        {
            string[] Computers =  Directory.GetFiles(@"data");
            for (int i = 0; i < Computers.Length; i++)
            {               
                Computers[i] = Regex.Replace(Computers[i], @"data\\SCAN_", "");
                Computers[i] = Regex.Replace(Computers[i], @"\.json", "");
            }
            return Computers;
        }

        // Liefert alle Deltas im Storage zurück
        public List<Delta> GetDeltas()
        {
            return Storage.Deltas;
        }

        // Liefert einen bestimmten Scan aus dem Storage zurück
        public Scan FindScanBySelected(string selected)
        {
            foreach (Scan scan in Storage.Scans)
            {
                if (scan.GetSelect() == selected)
                    return scan;
            }
            return new Scan();
        }

        // Liefert ein bestimmtes Delta aus dem Storage zurück
        public Delta FindDeltaBySelected(string selected)
        {
            foreach (Delta delta in Storage.Deltas)
            {
                if (delta.Title == selected)
                    return delta;
            }
            return new Delta();
        }

        // Generiert ein neues Delta und fügt dieses dem Storage hinzu
        public Delta GetListDiffByTwoSelected(string selected1, string selected2)
        {
            if (FindDeltaBySelected(selected1 + " " + selected2).Title == "")
            {
                Scan scan1 = FindScanBySelected(selected1);
                Scan scan2 = FindScanBySelected(selected2);
                Delta newDelta = new Delta(scan1, scan2);
                Storage.WriteDelta(newDelta);
                return newDelta;
            }
            else {
                // Sollte das Delta bereits einmal generiert sein, wird das bestehende zurückgeliefert
                return FindDeltaBySelected(selected1 + " " + selected2);
            }
        }

        // Löscht einen bestimmten Scan aus dem Storage
        public void DeleteByScan(string selected) {
            Storage.DeleteScan(selected);
        }

        // Löscht alle Scans eines Computers
        public void DeleteComputerScan(string selectedComputer)
        {
            Storage.DeleteComputerScan(selectedComputer);
        }
    }
}
