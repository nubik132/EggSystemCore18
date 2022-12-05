using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggSystemCore18_
{
    internal class egg20_3
    {
        static public void Prog()
        {
            int[] mass;
            mass = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
                mass[i] = random.Next(10);
            int chees1 = 0, chees2 = 0;

            try
            {
                chees1 = Int32.Parse(Console.ReadLine());
                chees2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine(mass[chees1] + mass[chees2]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Введена не цифра");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Одно число или более больше размера массива");
            }
        }
    }
}
