using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class Laptop : ComputerEquipment
    {
        private bool HasBacklight { get; set; }

        public Laptop(string brand = "Неизвестный", string cpu_brand = "Неизвестный",
                      int ram = 0, int price = 0, bool hasBacklight = false)
                      : base(brand, cpu_brand, ram, price)
        {
            HasBacklight = hasBacklight;
        }


        public override void Print()
        {
            base.Print();
            Console.Write($"Подсветка клавиатуры: ");
            if (HasBacklight) { Console.WriteLine("ДА"); }
            else { Console.WriteLine("НЕТ"); }
            Console.WriteLine();
        }
    }  
}
