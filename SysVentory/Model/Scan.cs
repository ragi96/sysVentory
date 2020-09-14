using System;
using SysVentory.ThirdParty;

namespace SysVentory
{
    // Der Scan stellt ein momentanes Abbild der Systeminformationen eines Computers dar
    class Scan
    {
        // MachineName, der den Namen des Computers darstellt
        public string MachineName { get; set; }
        // Timestamp, der den Zeitpunkt des Abbilds beinhaltet
        public long Timestamp {get; set; }
        // Data, in dem die Scandaten abgelegt sind
        public Data Data { get; set; }

        // Konstruktor, der ein neues Scanobjekt anhand eines Datas erstellt
        public Scan(Data data)
        {
            var currentTime = DateTimeOffset.Now;
            TimeZoneInfo cetInfo = TimeZoneInfo.FindSystemTimeZoneById("Central Europe Standard Time");

            MachineName = Environment.MachineName;
            Timestamp = TimeZoneInfo.ConvertTime(currentTime, cetInfo).ToUnixTimeMilliseconds();
            Data = data;
        }

        // Konstruktor, der ein neues Scanobjekt erstellt
        public Scan(string machineName, long timestamp, Data data)
        {
            MachineName = machineName;
            Timestamp = timestamp;
            Data = data;
        }

        // Konstruktor, der ein neues Scanobjekt ohne Data erstellt
        public Scan()
        {
            var currentTime = DateTimeOffset.Now;
            TimeZoneInfo cetInfo = TimeZoneInfo.FindSystemTimeZoneById("Central Europe Standard Time");

            MachineName = Environment.MachineName;
            Timestamp = TimeZoneInfo.ConvertTime(currentTime, cetInfo).ToUnixTimeMilliseconds();
        }

        // Gibt den Titel, des Scans aus
        public string GetSelect() => MachineName + " " + this.GetPrintDate();

        // Gibt den passenden Dateipfad zur Machine des Scans zurück
        public string GetFilePath(string folder, string prefix) => folder + "/" + prefix + MachineName + ".json";

        // Gibt die Scan-Zeit lesbar formatiert aus
        private string GetPrintDate()
        {
            DateTime dateTime = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateTime = dateTime.AddMilliseconds(Timestamp).ToLocalTime();
            return dateTime.ToShortDateString() + " " + dateTime.ToLongTimeString();
        }

        // Gibt den gesamten Scan lesbar aus
        public override string ToString() => this.GetSelect() + ":\r\n" + Data.ToString();
    }
}
