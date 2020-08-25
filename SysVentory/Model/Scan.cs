using System;
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
    }
}
