using System.Collections.Generic;
using Newtonsoft.Json;

namespace SysVentory
{
    class File
    {
        public List<Scan> Scans { get; set; }
        const string filePath = "Scans.txt";

        public File()
        {
            Scans = new List<Scan>();

            if (System.IO.File.Exists(filePath))
            {
                string scanJson = System.IO.File.ReadAllText(filePath);
                Scans = JsonConvert.DeserializeObject<List<Scan>>(scanJson);
            }
        }

        public void WriteScan(Scan scan)
        {
            Scans.Add(scan);

            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }

            string scanJson = JsonConvert.SerializeObject(Scans);
            System.IO.File.WriteAllText(filePath, scanJson);
        }
    }
}
