using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ammo system:");
            // pistol = 6/6
            //shotgun = 2/2
            //...
            //bfg = 20/20

            int weapon = 0; // 0 = pistol, 1 = shotgun, ... 4 = bfg

            Console.WriteLine("BEFORE Arrays:");
            int pistolAmmo = 6;
            int shotgunAmmo = 2;
            // ...
            int bfgAmmo = 20;

            if (weapon == 0)
            {
                Console.WriteLine("pistol Ammo: " + pistolAmmo);
            }
            else if (weapon == 1)
            {
                Console.WriteLine("shot gun Ammo: " + shotgunAmmo);
            }
            else if (weapon == 2)
            {
                Console.WriteLine("BFG Ammo: " + bfgAmmo);
            }

            Console.WriteLine("Ammo: " + ammo[weapon]);

            Console.ReadKey(true);

            Console.WriteLine();

            Console.WriteLine("Arrays:");

            int[] ammo;



            ammo = new int[3];
            ammo[0] = 6;
            ammo[1] = 2;
            ammo[2] = 20;

            string[] weaponname = new string[3];
            weaponname[0] = "pistol";
            weaponname[1] = "shotgun";
            weaponname[2] = "bfg";

            Console.WriteLine("pistol Ammo: " + ammo[0]);
            Console.WriteLine("shot gun Ammo: " + ammo[1]);
            Console.WriteLine("BFG Ammo: " + ammo[2]);

            Console.ReadKey();
        }
    }
}
