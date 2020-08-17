using System;
using Datasource;
using System.Windows.Forms;

namespace SysVentory {
    static class Program {
        static void Main(string[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new View.View());
        }
    }
}
