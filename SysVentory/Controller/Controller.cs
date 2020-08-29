using System.Collections.Generic;
using SysVentory.ThirdParty;
using System.Linq;

/*
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JsonDiffPatchDotNet;
*/

namespace SysVentory
{
    class Controller
    {
        private File Storage { get; set; }

        public Controller()
        {
            Storage = new File();
        }

        public Scan ScanNow()
        {
            Scan newScan = new Scan(Data.Read());
            Storage.WriteScan(newScan);

            return newScan;
        }

        public string GetAllScans()
        {
            string scans = "";
            Storage.Scans.ForEach(scan => scans += scan.MachineName + ":\r\n" + scan.Timestamp + "\r\n\r\n");
            return scans;
        }

        public List<Scan> GetScans()
        {
            return Storage.Scans;
        }

        public File GetStorage()
        {
            return Storage;
        }

        public Scan FindScanBySelected(string selected)
        {
            foreach (Scan scan in Storage.Scans)
            {
                if (scan.GetSelect() == selected)
                    return scan;
            }
            return new Scan();
        }

        public string GetDiffByTwoSelected(string selected1, string selected2)
        {
            Scan scan1 = FindScanBySelected(selected1);
            Scan scan2 = FindScanBySelected(selected2);


            IEnumerable<string> set1 = scan1.ToString().Split(' ').Distinct();
            IEnumerable<string> set2 = scan2.ToString().Split(' ').Distinct();
            if (set2.Count() > set1.Count())
            {
                List<string> diffList = set2.Except(set1).ToList();
                return string.Join(" ", diffList);
            }
            else
            {
                List<string> diffList = set1.Except(set2).ToList();
                return string.Join(" ", diffList);
            }
        }
    }
}
