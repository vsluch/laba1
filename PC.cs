using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class PC : ComputerEquipment
    {
        private string CaseColor {  get; set; }

        public PC(string brand = "Неизвестный", string cpu_brand = "Неизвестный", 
                  int ram = 0, int price = 0, string _CaseColor = "Чёрный") 
                  : base(brand, cpu_brand, ram, price)
        {
            CaseColor = _CaseColor;
        }


        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Цвет корпуса: {CaseColor}");
            Console.WriteLine();
        }
    }
}
