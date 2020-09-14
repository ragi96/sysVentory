using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DiffMatchPatch;
using SysVentory.ThirdParty;

namespace SysVentory
{
    // Das Delta stellt den speicherbaren Unterschied zwischen zwei Scans, unterteilt in Hard- und Software, dar
    class Delta
    {
        // Titel, der in der View angezeigt werden kann
        public string Title { get; set; }

        // Generiertes Diff der Hardware-Elemente
        public List<Diff> DiffsHardware { get; set; }

        // Generiertes Diff der Software-Elemente
        public List<Diff> DiffsSoftware { get; set; }

        // Konstruktur, der ein leeres Delta zurückliefert
        public Delta() {
            Title = "";
        }

        // Konstruktor, der ein Delta mit Diffs generiert
        public Delta(Scan scan1, Scan scan2)
        {
            Title = scan1.GetSelect() + " " + scan2.GetSelect();

            // Split der Hard- und Software-Elemente
            Scan scan1Software = new Scan(scan1.MachineName, scan1.Timestamp, FilterSoftwareData(scan1.Data));
            Scan scan2Software = new Scan(scan2.MachineName, scan2.Timestamp, FilterSoftwareData(scan2.Data));

            Scan scan1Hardware = new Scan(scan1.MachineName, scan1.Timestamp, FilterHardwareData(scan1.Data));
            Scan scan2Hardware = new Scan(scan2.MachineName, scan2.Timestamp, FilterHardwareData(scan2.Data));
            // Googles Diff Match Patch for Diff
            diff_match_patch DIFF = new diff_match_patch();
            DiffsSoftware = DIFF.diff_main(scan1Software.ToString(), scan2Software.ToString());
            DiffsHardware = DIFF.diff_main(scan1Hardware.ToString(), scan2Hardware.ToString());
            // Bereinigt die DIffs zur vereinfachten Darstellung in der View
            DIFF.diff_cleanupSemantic(DiffsSoftware);
            DIFF.diff_cleanupSemantic(DiffsHardware);
        }

        // Filtert die Element Liste auf Software Elemente
        private Data FilterSoftwareData(Data data)
        {
            return new Data(data.Where(d => d.ItemType == "Software"));
        }

        // Filtert die Element Liste auf Hardware Elemente
        private Data FilterHardwareData(Data data)
        {
            return new Data(data.Where(d => d.ItemType != "Software"));
        }
    }
}
