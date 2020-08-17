using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datasource;

namespace SysVentory.Model
{
    class Scan
    {
        public long Timestamp {get; set;}
        public Data Data { get; set; }

        public Scan(Data data)
        {
            Timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            Data = data;
        }
    }
}
