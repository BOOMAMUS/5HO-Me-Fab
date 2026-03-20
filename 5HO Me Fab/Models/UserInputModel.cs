using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5HO_Me_Fab.Models
{
    public class UserInputModel
    {
        public string? Name { get; set; }
        public string? TankCust1 { get; set; }
        public string? TankCust2 { get; set; }
        public string? TankCust3 { get; set; }

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