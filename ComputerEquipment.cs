using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class ComputerEquipment
    {
        protected string Brand {  get; set; }       // производитель
        protected string CpuBrand { get; set; }     // производитель процессора
        protected int Ram { get; set; }             // объем оперативной памяти
        protected int Price { get; set; }           // цена


        public ComputerEquipment(string brand = "Неизвестный", string cpu_brand = "Неизвестный", int ram = 0, int price = 0)
        {
            Brand = brand;
            CpuBrand = cpu_brand;
            Ram = ram;
            Price = price;
        }


        public virtual void Print() 
        {
            Console.WriteLine($"Производитель: {Brand}");
            Console.WriteLine($"Процессор: {CpuBrand}");
            Console.WriteLine($"Объем памяти: {Ram}");
            Console.WriteLine($"Цена: {Price}");
        }
    }
}
