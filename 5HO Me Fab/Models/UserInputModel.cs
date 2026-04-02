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
            "Extra Bracing",
            "Reinforced Welds",
            "Heavy-Duty Mounting Tabs",
            "Internal Baffles",
            "Double-Wall Construction",
            "Stainless Steel Upgrade",
            "Aluminum Construction",
            "Corrosion-Resistant Coating",
            "High-Temperature Alloy",
            "High-Pressure Fittings",
            "Additional Inlet Port",
            "Additional Outlet Port",
            "Drain Valve Upgrade",
            "Sight Glass Installation",
            "Custom Paint",
            "Powder Coat Finish",
            "Polished Exterior",
            "Industrial Primer Only",
            "Pressure Relief Valve",
            "Temperature Sensor Port",
            "Level Sensor Port",
            "Insulation Wrap",
            "Mounting Brackets"
        };
    }
}
