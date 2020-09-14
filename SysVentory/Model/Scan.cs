using System;
using SysVentory.ThirdParty;

namespace SysVentory
{
    class Scan
    {
        public string MachineName { get; set; }
        public long Timestamp {get; set; }
        public Data Data { get; set; }

        public Scan(Data data)
        {
            var currentTime = DateTimeOffset.Now;
            TimeZoneInfo cetInfo = TimeZoneInfo.FindSystemTimeZoneById("Central Europe Standard Time");

            MachineName = Environment.MachineName;
            Timestamp = TimeZoneInfo.ConvertTime(currentTime, cetInfo).ToUnixTimeMilliseconds();
            Data = data;
        }

        public Scan(string machineName, long timestamp, Data data)
        {
            MachineName = machineName;
            Timestamp = timestamp;
            Data = data;
        }

        public Scan()
        {
            var currentTime = DateTimeOffset.Now;
            TimeZoneInfo cetInfo = TimeZoneInfo.FindSystemTimeZoneById("Central Europe Standard Time");

            MachineName = Environment.MachineName;
            Timestamp = TimeZoneInfo.ConvertTime(currentTime, cetInfo).ToUnixTimeMilliseconds();
        }

        public string GetSelect() => MachineName + " " + this.GetPrintDate();


        private string GetPrintDate()
        {
            // First make a System.DateTime equivalent to the UNIX Epoch.
            DateTime dateTime = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);

            // Add the number of seconds in UNIX timestamp to be converted.
            dateTime = dateTime.AddMilliseconds(Timestamp).ToLocalTime();


            // The dateTime now contains the right date/time so to format the string,
            // use the standard formatting methods of the DateTime object.
            return dateTime.ToShortDateString() + " " + dateTime.ToShortTimeString();
        }

        public override string ToString() => this.GetSelect() + ":\r\n" + Data.ToString();
    }
}
