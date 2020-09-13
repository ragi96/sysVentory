using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System;

namespace SysVentory
{
    class File
    {
        public List<Scan> Scans { get; set; }
        public List<Delta> Deltas { get; set; }
        const string folder = "data";

        const string deltaFilePath = folder + "/delta.json";
        readonly string Machinename = "undefinded";
        readonly string filePath = folder + "/scans.json";

        public File()
        {
            Scans = new List<Scan>();
            Deltas = new List<Delta>();
            Machinename = Environment.MachineName;
            filePath = folder + "/" + Machinename + ".json";
            // Create Folder
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            // Scan init
            if (System.IO.File.Exists(filePath))
            {
                string scanJson = System.IO.File.ReadAllText(filePath);
                if (JsonConvert.DeserializeObject<List<Scan>>(scanJson) != null) {
                    Scans = JsonConvert.DeserializeObject<List<Scan>>(scanJson);
                };
            }
            // Delta init
            if (System.IO.File.Exists(deltaFilePath))
            {
                string scanJson = System.IO.File.ReadAllText(deltaFilePath);
                if (JsonConvert.DeserializeObject<List<Delta>>(scanJson) != null)
                {
                    Deltas = JsonConvert.DeserializeObject<List<Delta>>(scanJson);
                }
            }
        }

        public void WriteScan(Scan scan)
        {
            Scans.Add(scan);

            if (System.IO.File.Exists(filePath))
                System.IO.File.Delete(filePath);

            string scanJson = JsonConvert.SerializeObject(Scans);
            System.IO.File.WriteAllText(filePath, scanJson);
        }

        public void DeleteScan(string selectedScan) {
            string scanJson = System.IO.File.ReadAllText(filePath);
            Scans = JsonConvert.DeserializeObject<List<Scan>>(scanJson);
            Scan toDelete = new Scan();
            foreach (Scan singleScan in Scans) {
                if (singleScan.GetSelect() == selectedScan)
                    toDelete = singleScan;
                    
            }
            Scans.Remove(toDelete);
            string newScanJson = JsonConvert.SerializeObject(Scans);
            System.IO.File.WriteAllText(filePath, newScanJson);
        }

        public void WriteDelta(Delta delta)
        {
            Deltas.Add(delta);

            if (System.IO.File.Exists(deltaFilePath))
                System.IO.File.Delete(deltaFilePath);

            string scanJson = JsonConvert.SerializeObject(Deltas);
            System.IO.File.WriteAllText(deltaFilePath, scanJson);
        }
    }
}
