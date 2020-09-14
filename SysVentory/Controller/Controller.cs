using System.Collections.Generic;
using SysVentory.ThirdParty;
using System.IO;

namespace SysVentory
{

    class Controller
    {
        private Storage Storage { get; set; }

        public Controller()
        {
            Storage = new Storage();
        }

        public Scan ScanNow()
        {
            Scan newScan = new Scan(Data.Read());
            Storage.WriteScan(newScan);

            return newScan;
        }

        public List<Scan> GetScans()
        {
            return Storage.Scans;
        }

        //load all Json files in data folder
        public string[] GetComputers()
        {
            return Directory.GetFiles(@"data");
        }

        public List<Delta> GetDeltas()
        {
            return Storage.Deltas;
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

        public Delta FindDeltaBySelected(string selected)
        {
            foreach (Delta delta in Storage.Deltas)
            {
                if (delta.Title == selected)
                    return delta;
            }
            return new Delta();
        }

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
                return FindDeltaBySelected(selected1 + " " + selected2);
            }
        }

        public void DeleteByScan(string selected) {
            Storage.DeleteScan(selected);
        }

        public void DeleteComputerScan(string selectedComputer)
        {
            File.Delete(selectedComputer);
        }
    }
}
