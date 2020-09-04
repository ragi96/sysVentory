using System;
using System.Collections.Generic;
using DiffMatchPatch;

namespace SysVentory
{
    class Delta
    {
        public string Title { get; set; }
        public Scan Scan1 { get; set; }

        public Scan Scan2 { get; set; }

        public List<Diff> Diffs { get; set; }

        public Delta() {
            Title = "";
        }

        public Delta(Scan scan1, Scan scan2)
        {
            Title = scan1.GetSelect() + " " + scan2.GetSelect();
            Scan1 = scan1;
            Scan2 = scan2;
            // Googles Diff Match Patch for Diff
            diff_match_patch DIFF = new diff_match_patch();
            Diffs = DIFF.diff_main(scan1.ToString(), scan2.ToString());
            //cleans up diffs to human readable
            DIFF.diff_cleanupSemantic(Diffs);
        }
    }
}
