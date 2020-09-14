using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System;

namespace SysVentory
{
    // Der Storage hält die Daten zur Laufzeit und ist für die Persistenz zuständig
    class Storage
    {
        // Liste von Scans, die Scanobjekte aller verfügbaren Computer beinhaltet
        public List<Scan> Scans { get; set; }
        // Liste von Deltas, die alle verfügbare Deltas beinhaltet
        public List<Delta> Deltas { get; set; }

        // Diverse Namen für die Schreib- und Lesezugriffe
        private const string DeltaFolder = "deltas";
        private const string DeltaFilePath = DeltaFolder + "/" + "delta.json";
        private const string Folder = "data";
        private string Machinename = "undefined";
        private readonly string Prefix = "SCAN_";

        // Baut einen neuen Storage beim Programmstart auf
        public Storage()
        {
            Scans = new List<Scan>();
            Deltas = new List<Delta>();
            Machinename = Environment.MachineName;
            
            string filePath = Folder + "/" + Prefix + Machinename + ".json";
            
            // Erstellt Ordner, falls sie noch nicht vorhanden sind
            if (!Directory.Exists(Folder))
                Directory.CreateDirectory(Folder);
            if (!Directory.Exists(DeltaFolder))
                Directory.CreateDirectory(DeltaFolder);

            // Lest alle Scans aus
            var scanFiles = Directory.GetFiles("data", "SCAN*.json");

            foreach (var scan in scanFiles)
            {
                if (scanFiles != null)
                {
                    string scanJson = File.ReadAllText(scan);
                    if(scanJson != "false") { 
                        if (JsonConvert.DeserializeObject<List<Scan>>(scanJson) != null)
                            Scans.AddRange(JsonConvert.DeserializeObject<List<Scan>>(scanJson));
                    }
                }
            }

            // Sortiert alle Scans
            Scans = Scans.OrderBy(s => s.GetSelect()).ToList();

            // Lest alle Deltas aus
            if (File.Exists(DeltaFilePath))
            {
                string scanJson = File.ReadAllText(DeltaFilePath);
                if (JsonConvert.DeserializeObject<List<Delta>>(scanJson) != null)
                    Deltas = JsonConvert.DeserializeObject<List<Delta>>(scanJson);
            }

        }

        // Fügt einen Scan hinzu und persistiert ihn
        public void WriteScan(Scan Scan)
        {
            Scans.Add(Scan);
            string filePath = Scan.GetFileName(Folder, Prefix);

            if (File.Exists(filePath))
                File.Delete(filePath);

            string scanJson = JsonConvert.SerializeObject(Scans);
            File.WriteAllText(filePath, scanJson);
        }

        // Löscht einen Scan
        public void DeleteScan(string selectedScan) {
            Scan toDelete = new Scan();
            foreach (Scan singleScan in Scans) {
                if (singleScan.GetSelect() == selectedScan)
                    toDelete = singleScan;     
            }
            // Löschen aus allen Scans
            Scans.Remove(toDelete);
            string machineFilePath = toDelete.GetFileName(Folder, Prefix);

            //Löschen aus dem Machine JSON
            List<Scan> machineScans = Scans.Where(s => s.MachineName == toDelete.MachineName).ToList();
            machineScans.Remove(toDelete);
            string newScanJson = JsonConvert.SerializeObject(machineScans);
            File.WriteAllText(machineFilePath, newScanJson);
        }

        // Fügt ein Delta hinzu und persistiert es
        public void WriteDelta(Delta delta)
        {
            Deltas.Add(delta);

            if (File.Exists(DeltaFilePath))
                File.Delete(DeltaFilePath);

            string scanJson = JsonConvert.SerializeObject(Deltas);
            File.WriteAllText(DeltaFilePath, scanJson);
        }

        // Löscht das Scanfile, für den angegebenen Computer
        public void DeleteComputerScan(string selectedComputer)
        {
            selectedComputer = Folder + "/"+ Prefix + selectedComputer + ".json";
            File.Delete(selectedComputer);
        }
    }
}
