using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class Laptop : ComputerEquipment, IPrintable
    {
        private bool HasBacklight { get; set; }         // наличие подсветки клавиатуры


        public Laptop(string brand = "Неизвестный", string cpu_brand = "Неизвестный",
                      int ram = 0, int price = 0, int hasBacklight = 0)
                      : base(brand, cpu_brand, ram, price)
        {
            if(hasBacklight == 1)
            {
                HasBacklight = true;
            }
            else if(hasBacklight == 0)
            {
                HasBacklight = false;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Установлено значение по умолчанию (НЕТ)");
                HasBacklight = false;
            }

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
