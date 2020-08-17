using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datasource;
using SysVentory.Model;

namespace SysVentory.Controller
{
    class Controller
    {
        public static Scan ScanNow()
        {
            Data newData = Data.Read();
            return new Scan(newData);
        }
    }
}
