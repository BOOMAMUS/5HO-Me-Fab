using System;
using System.Collections.Generic;

namespace _5HO_Me_Fab.Models
{
    public class UserInputModel
    {
        public string? TankCust1 { get; set; }
        public string? TankCust2 { get; set; }
        public string? TankCust3 { get; set; }

        public string? TankCust1Notes { get; set; }
        public string? TankCust2Notes { get; set; }
        public string? TankCust3Notes { get; set; }

        public string? NozzleCust1 { get; set; }
        public string? NozzleCust2 { get; set; }
        public string? NozzleCust3 { get; set; }

        public string? NozzleCust1Notes { get; set; }
        public string? NozzleCust2Notes { get; set; }
        public string? NozzleCust3Notes { get; set; }
        public int? Tax { get; set; }
        public int? Total { get; set; }
        public int? LaborHours { get; set; }
        public int? IndividualPrice { get; set; }
        public List<string> TankOptions { get; set; } = new()
        {
            "FTOA-450X350-3.0-304-P-E-H",
            "FTOA-550X450-3.0-304-P-E-H",
            "FTOA-550X450-3.0-316-P-E-H",
            "FTOA-565X465-3.0-304-P-E-H",
            "FTOA-565X465-3.0-316-P-E-H",
            "FTOA-565X465-3.0-316-P-E-HF",
            "FTOA-580-GSKT-E",
            "FTOA-580-GSKT-V",
            "FTOA-580X480-3.0-304-P-E-HF",
            "FTOA-580X480-3.0-316-P-E-HF",
            "FTOA-HUB-3",
            "FTOA-03",
            "FTOA-05-Y ; FTOC-05-Y",
            "FTOA-07 ; FTOC-07",
            "FTOA-08 ; FTOC-08",
            "FTOA-04"
        };
        public List<string> TankDesc { get; set; } = new()
        {
            "FTOA-A-490X390-170-N- 1 304SS, EPDM Gskt",
            "FTOA-A-550x450-80-N- 1 304SS (Entry is 450x350) 18\"x14\", EPDM Gskt",
            "FTOA-A-550x450-80-N- 1 316SS (Entry is 450x350) 18\"x14\", EPDM Gskt",
            "FTOA-A-565x465-100-N- 1 304SS, EPDM Gskt",
            "FTOA-A-565x465-100-N- 1 316SS, EPDM Gskt",
            "FTOA-A-565x465-100-N- 1 316SS, EPDM Gskt",
            "FTOA-A-580x480 Manway Gasket EPDM (Entry is 450x350) 18\"x14\"",
            "FTOA-A-580x480 Manway Gasket FPM (Entry is 450x350) 18\"x14\"",
            "FTOA-A-580X480-133-N-3A 1 304SS, EPDM GSKT",
            "FTOA-A-580x480-133-N- 1 316SS 18\"x14\", EPDM Gskt",
            "Black Plastic Hub for Oval Manway",
            "Manway Cross Bar SS (Key #3)",
            "Manway Handle, Y-Style (SS - \"Wing\" or \"Y\" style), Key #5",
            "Manway Connex Pin FTOC, FTOA",
            "Manway Cap Nut FTOC",
            "Manway Arm FTOA",
        };
    }
}