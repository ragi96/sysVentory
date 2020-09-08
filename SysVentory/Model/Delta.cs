using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DiffMatchPatch;
using SysVentory.ThirdParty;

namespace SysVentory
{
    class Delta
    {
        public string Title { get; set; }

        public List<Diff> DiffsHardware { get; set; }

        public List<Diff> DiffsSoftware { get; set; }

        public Delta() {
            Title = "";
        }

        public Delta(Scan scan1, Scan scan2)
        {
            Title = scan1.GetSelect() + " " + scan2.GetSelect();

            Scan scan1Software = new Scan(scan1.MachineName, scan1.Timestamp, FilterSoftwareData(scan1.Data));
            Scan scan2Software = new Scan(scan2.MachineName, scan2.Timestamp, FilterSoftwareData(scan2.Data));

            Scan scan1Hardware = new Scan(scan1.MachineName, scan1.Timestamp, FilterHardwareData(scan1.Data));
            Scan scan2Hardware = new Scan(scan2.MachineName, scan2.Timestamp, FilterHardwareData(scan2.Data));
            // Googles Diff Match Patch for Diff
            diff_match_patch DIFF = new diff_match_patch();
            DiffsSoftware = DIFF.diff_main(scan1Software.ToString(), scan2Software.ToString());
            DiffsHardware = DIFF.diff_main(scan1Hardware.ToString(), scan2Hardware.ToString());
            //cleans up diffs to human readable
            DIFF.diff_cleanupSemantic(DiffsSoftware);
            DIFF.diff_cleanupSemantic(DiffsHardware);
        }

        private Data FilterSoftwareData(Data data)
        {
            return new Data(data.Where(d => d.ItemType == "Software"));
        }

        private Data FilterHardwareData(Data data)
        {
            return new Data(data.Where(d => d.ItemType != "Software"));
        }
    }
}
