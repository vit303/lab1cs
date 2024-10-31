using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class CompEquipment
    {
        protected string brand;
        protected string cpu_brand;
        protected int ram;
        protected int price;
        public CompEquipment(string brand = "Неизвестный",
            string cpu_brand = "Неизвестный", 
            int ram = 0, 
            int price = 0
            ) {
            this.brand = brand;
            this.cpu_brand = cpu_brand;
            this.ram = ram;
            this.price = price;
        }

        public virtual void PrintInfo() {
            Console.WriteLine($"Бренд: {this.brand}");
            Console.WriteLine($"Бренд процессора: {this.cpu_brand}");
            Console.WriteLine($"Объем оперативной памяти (Гб): {this.ram}");
            Console.WriteLine($"Цена (Руб.): {this.price}");
        }

        public  string GetBrand() 
        {
            return this.brand;
        }
        public string GetCpuBrand()
        {
            return this.cpu_brand;
        }
        public int GetRam()
        {
            return this.ram;
        }

        public int GetPrice()
        {
            return this.price;
        }

        public void SetBrand(string brand)
        {
            this.brand = brand;
        }

        public void SetCpuBrand(string cpu_brand) { 
            this.cpu_brand = cpu_brand;
        }

        public void SetRam(int ram)
        {
            this.ram = ram;
        }

        public void SetPrice(int price)
        {
            this.price = price;
        }

    }
}
