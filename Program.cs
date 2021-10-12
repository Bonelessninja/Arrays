using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
      static string[] weaponname = new string[3];
      static int[] ammo = new int[3];
      static int[] maxAmmo = new int[3];
        static void Main(string[] args)
        {

            weaponname[0] = "pistol";
            weaponname[1] = "shotgun";
            weaponname[2] = "bfg";

            ammo[0] = 6;
            ammo[1] = 2;
            ammo[2] = 20;

            maxAmmo[0] = 6;
            maxAmmo[1] = 2;
            maxAmmo[2] = 20;

            for (int x = 0; x < 6; x++)
            {
                fire(0);
                fire(1);
                fire(2);
                Console.WriteLine(weaponname[0] + " ammo: "+ ammo[0]);
                Console.WriteLine(weaponname[1] + " ammo: " + ammo[1]);
                Console.WriteLine(weaponname[2] + " ammo: " + ammo[2]);


                Console.ReadKey(true);
            }
            reload(0);
            reload(1);
            reload(2);
            Console.WriteLine("pistol Ammo: " + ammo[0]);
            Console.WriteLine("shot gun Ammo: " + ammo[1]);
            Console.WriteLine("BFG Ammo: " + ammo[2]);


            Console.ReadKey(true);


        }
        static void fire(int index)
        {
            if (ammo[index] > 0)
            {
                Console.WriteLine(weaponname[index] + " firing");
                ammo[index] -= 1;
            }
            
            Console.ReadKey(true);
        }
        static void reload(int index)
        {
            if (ammo[index] < maxAmmo[index])
            {
                Console.WriteLine(weaponname[index] + " reloading");
                ammo[index] = maxAmmo[index];
            }
           

        }
    }
}
