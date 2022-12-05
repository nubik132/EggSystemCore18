using System;
using System.Reflection.Metadata.Ecma335;

namespace egg34
{
    class Program
    {
        static void Main(string[] args)
        {
            AdultCow adultCow = new();
            Console.WriteLine("Может ли взрослая корова дать молока?");
            Console.WriteLine(ValidateMilk(adultCow) ? "Может" : "Не может");
        }
        static bool ValidateMilk(AdultCow cow)
        {
            Type type = typeof(AdultCow);
            object[] attributes = type.GetCustomAttributes(false);
            foreach (Attribute attr in attributes)
            {
                if (attr is CanCowGiveMilkAttribute cowAttribute)
                    return cow.canCowGiveMilk && cowAttribute.canCowGiveMilk;
            }
            return false;
        }
    }
    class CanCowGiveMilkAttribute : Attribute
    {
        public bool canCowGiveMilk;
        public CanCowGiveMilkAttribute(bool canCowGiveMilk) { this.canCowGiveMilk = canCowGiveMilk; }
    }
    [CanCowGiveMilk(true)]
    class AdultCow
    {
        public bool canCowGiveMilk;
        public AdultCow() { canCowGiveMilk = true; }
        bool isHaveMilk = false;
        public void GiveMilk()
        {
            if (isHaveMilk)
                Console.WriteLine("Корова дала 5 литров молока");
            isHaveMilk = false;
        }
        public void Eat()
        {
            Console.WriteLine("Корова поела");
            isHaveMilk = true;
        }
    }
}