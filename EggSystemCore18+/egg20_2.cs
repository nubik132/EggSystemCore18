using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggSystemCore18_
{
    internal class egg20_2
    {
        static public void Prog()
        {
            Console.WriteLine("Введите состояние машины");
            Car car = new Car();
            car.Read();
            car.Print();
        }
    }
    class CarVirtual
    {
       protected string state;
        public virtual void Read()
        {
            state = Console.ReadLine();
        }
    }
    class Car: CarVirtual
    {
        public void Print()
        {
            Console.WriteLine(state);
        }
        public override void Read()
        {
            state = "Не " + Console.ReadLine();
        }
    }
}
