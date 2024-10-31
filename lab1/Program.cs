using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CompEquipment> equipment = new List<CompEquipment>();
            while (true) {

                Console.WriteLine("1. Добавить устройство\n");
                Console.WriteLine("2. Печать списка\n");
                Console.WriteLine("3. Выход:\n");
                Console.WriteLine("Выберите действие: \n");
                int choice;
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("\nВыберите тип устройства:\n");
                    Console.WriteLine("1. Компьютерная техника\n");
                    Console.WriteLine("2. Персональный компьютер\n");
                    Console.WriteLine("3. Ноутбук\n");
                    Console.WriteLine("Введите номер типа: \n");
                    int type;
                    type = Convert.ToInt32(Console.ReadLine());
                    CompEquipment NewDevice = null;

                    if (type == 1)
                    {
                        string brand, cpu_brand;
                        int ram, price;
                        Console.WriteLine("\nВведите бренд компьютерной техники: ");
                        brand = Console.ReadLine();
                        Console.WriteLine("Введите бренд процессора: ");
                        cpu_brand = Console.ReadLine();
                        Console.WriteLine("Введите объём оперативной памяти (Гб): ");
                        ram = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите цену (Руб.): ");
                        price = Convert.ToInt32(Console.ReadLine());
                        NewDevice = new CompEquipment(brand, cpu_brand, ram, price);
                    }
                    else if (type == 2)
                    {
                        string brand, cpu_brand;
                        int ram, price;
                        double weight;
                        Console.WriteLine("\nВведите бренд персонального компьютера: ");
                        brand = Console.ReadLine();
                        Console.WriteLine("Введите бренд процессора: ");
                        cpu_brand = Console.ReadLine();
                        Console.WriteLine("Введите объём оперативной памяти (Гб): ");
                        ram = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите цену (Руб.): ");
                        price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите вес компьютера (кг): ");
                        weight = Convert.ToDouble(Console.ReadLine());
                        NewDevice = new PersonalComputer(brand, cpu_brand, ram, price, weight);
                    }
                    else if (type == 3)
                    {
                        string brand, cpu_brand;
                        int ram, price, battery;
                        Console.WriteLine("\nВведите бренд ноутбука: ");
                        brand = Console.ReadLine();
                        Console.WriteLine("Введите бренд процессора: ");
                        cpu_brand = Console.ReadLine();
                        Console.WriteLine("Введите объём оперативной памяти (Гб): ");
                        ram = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите цену (Руб.): ");
                        price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите объем аккумулятора (mAh.): ");
                        battery = Convert.ToInt32(Console.ReadLine());
                        NewDevice = new Laptop(brand, cpu_brand, ram, price, battery);
                    }

                    if (NewDevice != null)
                    {
                        equipment.Add(NewDevice);
                        Console.WriteLine("Устройство добавлено в список.\n");
                    }
                    else
                    {
                        Console.WriteLine("Неверный тип устройства.\n");
                    }
                }
                else if (choice == 2)
                {
                    if (equipment.Count == 0)
                    {
                        Console.WriteLine("\nСписок устройств пуст.\n");
                    }
                    else
                    {
                        Console.WriteLine("\nСписок устройств:\n");
                        foreach (CompEquipment equp in equipment)
                        {
                            equp.PrintInfo();
                            Console.WriteLine("--------------------");
                        }
                    }
                }
                else if (choice == 3)
                {
                    equipment.Clear();
                    break;
                }
                else {
                    Console.WriteLine("Неверный выбор.");
                }
            }
        }
    }
}
