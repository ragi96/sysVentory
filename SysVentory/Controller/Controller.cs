using SysVentory.ThirdParty;

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

        public File GetStorage()
        {
            return Storage;
        }
    }
}
