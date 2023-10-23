using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.WordOfTanks
{
    public class Tank
    {
        public string Name { get; private set; }
        public int AmmunitionLevel { get; private set; }
        public int ArmorLevel { get; private set; }
        public int ManeuverabilityLevel { get; private set; }

        public Tank(string name)
        {
            Name = name;
            Random random = new Random();
            AmmunitionLevel = random.Next(0, 101);
            ArmorLevel = random.Next(0, 101);
            ManeuverabilityLevel = random.Next(0, 101);
        }

        public override string ToString()
        {
            return $"{Name}: Ammo={AmmunitionLevel}, Armor={ArmorLevel}, Maneuverability={ManeuverabilityLevel}";
        }

        public static bool operator ^(Tank tank1, Tank tank2)
        {
            int advantageCount = 0;

            if (tank1.AmmunitionLevel > tank2.AmmunitionLevel)
                advantageCount++;
            if (tank1.ArmorLevel > tank2.ArmorLevel)
                advantageCount++;
            if (tank1.ManeuverabilityLevel > tank2.ManeuverabilityLevel)
                advantageCount++;

            return advantageCount >= 2;
        }
    }
}
