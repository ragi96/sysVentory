using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace SysVentory.View
{
    public partial class View : Form
    {
        private readonly Controller Controller;
        public View()
        {
            InitializeComponent();
            Controller = new Controller();
            TxtSelection.Text = Controller.GetAllScans();
        }

        private void CmdScan_Click(object sender, EventArgs e)
        {
            Scan latestScan = Controller.ScanNow();
            TxtOut.Text += JsonConvert.SerializeObject(latestScan);
        }
    }
}
