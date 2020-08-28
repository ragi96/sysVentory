using System;
using System.Windows.Forms;
using SysVentory.ThirdParty;

namespace SysVentory
{
    class Scan
    {
        public string MachineName { get; set; }
        public long Timestamp {get; set;}
        public Data Data { get; set; }

        public Scan(Data data)
        {
            MachineName = Environment.MachineName;
            Timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            Data = data;
        }

        public Scan() {
            MachineName = Environment.MachineName;
            Timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }

        public String GetSelect()
        {
            string selectTxt = MachineName + " " + GetPrintDate();
            return selectTxt;
        }

        private String GetPrintDate()
        {
            // First make a System.DateTime equivalent to the UNIX Epoch.
            System.DateTime dateTime = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);

            // Add the number of seconds in UNIX timestamp to be converted.
            dateTime = dateTime.AddMilliseconds(Timestamp);

            // The dateTime now contains the right date/time so to format the string,
            // use the standard formatting methods of the DateTime object.
            return dateTime.ToShortDateString() + " " + dateTime.ToShortTimeString();
        }
    }
}
