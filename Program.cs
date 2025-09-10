using System;
using System.Text;

namespace laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;


            List<ComputerEquipment> equipment = new List<ComputerEquipment>();
            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Добавить устройство");
                Console.WriteLine("2. Печать списка");
                Console.WriteLine("3. Выход");
                Console.Write("Выберите действие: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Неверный ввод!");
                    continue;
                }

                if (choice == 1)
                {
                    Console.WriteLine("\nВыберите тип устройства:");
                    Console.WriteLine("1. Компьютерная техника");
                    Console.WriteLine("2. Персональный компьютер");
                    Console.WriteLine("3. Ноутбук");
                    Console.Write("Введите номер типа: ");

                    if (!int.TryParse(Console.ReadLine(), out int type))
                    {
                        Console.WriteLine("Неверный ввод!");
                        continue;
                    }

                    ComputerEquipment newDevice = null;

                    if (type == 1)
                    {
                        Console.Write("\nВведите бренд компьютерной техники: ");
                        string brand = Console.ReadLine();
                        Console.Write("Введите бренд процессора: ");
                        string cpuBrand = Console.ReadLine();
                        Console.Write("Введите объём оперативной памяти (Гб): ");
                        int ram = int.Parse(Console.ReadLine());
                        Console.Write("Введите цену (Руб.): ");
                        int price = int.Parse(Console.ReadLine());

                        newDevice = new ComputerEquipment(brand, cpuBrand, ram, price);
                    }
                    else if (type == 2)
                    {
                        Console.Write("\nВведите бренд компьютерной техники: ");
                        string brand = Console.ReadLine();
                        Console.Write("Введите бренд процессора: ");
                        string cpuBrand = Console.ReadLine();
                        Console.Write("Введите объём оперативной памяти (Гб): ");
                        int ram = int.Parse(Console.ReadLine());
                        Console.Write("Введите цену (Руб.): ");
                        int price = int.Parse(Console.ReadLine());

                        newDevice = new PC(brand, cpuBrand, ram, price);
                    }
                    else if (type == 3)
                    {
                        Console.Write("\nВведите бренд компьютерной техники: ");
                        string brand = Console.ReadLine();
                        Console.Write("Введите бренд процессора: ");
                        string cpuBrand = Console.ReadLine();
                        Console.Write("Введите объём оперативной памяти (Гб): ");
                        int ram = int.Parse(Console.ReadLine());
                        Console.Write("Введите цену (Руб.): ");
                        int price = int.Parse(Console.ReadLine());

                        newDevice = new Laptop(brand, cpuBrand, ram, price);
                    }

                    if (newDevice != null)
                    {
                        equipment.Add(newDevice);
                        Console.WriteLine("Устройство добавлено в список.");
                    }
                    else
                    {
                        Console.WriteLine("Неверный тип устройства.");
                    }
                }
                else if (choice == 2)
                {
                    if (equipment.Count == 0)
                    {
                        Console.WriteLine("\nСписок устройств пуст.");
                    }
                    else
                    {
                        Console.WriteLine("\nСписок устройств:");
                        Console.WriteLine();
                        foreach (var device in equipment)
                        {
                            device.Print();
                            Console.WriteLine("--------------------");
                        }
                    }
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Выход из программы.");
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный выбор.");
                }
            }
        }
    }
}
