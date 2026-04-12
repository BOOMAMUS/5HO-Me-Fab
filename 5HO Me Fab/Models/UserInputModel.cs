using System;
using System.Collections.Generic;

namespace _5HO_Me_Fab.Models
{
    public class UserInputModel
    {
        public string? TankCust1 { get; set; }
        public string? TankCust2 { get; set; }
        public string? TankCust3 { get; set; }
        public string? TankCust4 { get; set; }
        public string? TankCust5 { get; set; }
        public string? TankCust6 { get; set; }
        public string? TankCust1Notes { get; set; }
        public string? TankCust2Notes { get; set; }
        public string? TankCust3Notes { get; set; }
        public string? TankCust4Notes { get; set; }
        public string? TankCust5Notes { get; set; }
        public string? TankCust6Notes { get; set; }
        public decimal? Tax { get; set; }
        public decimal? Total { get; set; }
        public decimal? LaborHours { get; set; }
        public decimal? IndividualPrice { get; set; }
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
        public Dictionary<string, string> TankLookup { get; set; } = new()
        {
            { "FTOA-450X350-3.0-304-P-E-H", "FTOA-A-490X390-170-N- 1 304SS, EPDM Gskt" },
            { "FTOA-550X450-3.0-304-P-E-H", "FTOA-A-550x450-80-N- 1 304SS (Entry is 450x350) 18\"x14\", EPDM Gskt" },
            { "FTOA-550X450-3.0-316-P-E-H", "FTOA-A-550x450-80-N- 1 316SS (Entry is 450x350) 18\"x14\", EPDM Gskt" },
            { "FTOA-565X465-3.0-304-P-E-H", "FTOA-A-565x465-100-N- 1 304SS, EPDM Gskt" },
            { "FTOA-565X465-3.0-316-P-E-H", "FTOA-A-565x465-100-N- 1 316SS, EPDM Gskt" },
            { "FTOA-565X465-3.0-316-P-E-HF", "FTOA-A-565x465-100-N- 1 316SS, EPDM Gskt" },
            { "FTOA-580-GSKT-E", "FTOA-A-580x480 Manway Gasket EPDM (Entry is 450x350) 18\"x14\"" },
            { "FTOA-580-GSKT-V", "FTOA-A-580x480 Manway Gasket FPM (Entry is 450x350) 18\"x14\"" },
            { "FTOA-580X480-3.0-304-P-E-HF", "FTOA-A-580X480-133-N-3A 1 304SS, EPDM GSKT" },
            { "FTOA-580X480-3.0-316-P-E-HF", "FTOA-A-580x480-133-N- 1 316SS 18\"x14\", EPDM Gskt" },
            { "FTOA-HUB-3", "Black Plastic Hub for Oval Manway" },
            { "FTOA-03", "Manway Cross Bar SS (Key #3)" },
            { "FTOA-05-Y ; FTOC-05-Y", "Manway Handle, Y-Style (SS - \"Wing\" or \"Y\" style), Key #5" },
            { "FTOA-07 ; FTOC-07", "Manway Connex Pin FTOC, FTOA" },
            { "FTOA-08 ; FTOC-08", "Manway Cap Nut FTOC" },
            { "FTOA-04", "Manway Arm FTOA" }
        };
        public Dictionary<string, decimal> TankPrices { get; set; } = new()
        {
            { "FTOA-450X350-3.0-304-P-E-H", 35.30m },
            { "FTOA-550X450-3.0-304-P-E-H", 22.82m },
            { "FTOA-550X450-3.0-316-P-E-H", 17.87m },
            { "FTOA-565X465-3.0-304-P-E-H", 0m },
            { "FTOA-565X465-3.0-316-P-E-H", 0m },
            { "FTOA-565X465-3.0-316-P-E-HF", 61.15m },
            { "FTOA-580-GSKT-E", 51.32m },
            { "FTOA-580-GSKT-V", 0m },
            { "FTOA-580X480-3.0-304-P-E-HF", 51.05m },
            { "FTOA-580X480-3.0-316-P-E-HF", 68.24m },
            { "FTOA-HUB-3", 103.09m },
            { "FTOA-03", 37.72m },
            { "FTOA-05-Y ; FTOC-05-Y", 0m },
            { "FTOA-07 ; FTOC-07", 0.07m },
            { "FTOA-08 ; FTOC-08", 1.24m },
            { "FTOA-04", 1.25m }
        };
    }
}