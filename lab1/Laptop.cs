using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Laptop: CompEquipment
    {
        private int battery;
        public Laptop(string brand = "Неизвестный",
           string cpu_brand = "Неизвестный",
           int ram = 0,
           int price = 0,
           int battery = 0)
           : base(brand, cpu_brand, ram, price)
        {
            this.battery = battery;
        }
        public int GetBattery()
        {
            return this.battery;
        }

        public void SetBattery(int battery)
        {
            this.battery = battery;
        }

        public override void PrintInfo() {
            base.PrintInfo();
            Console.WriteLine($"Обьем аккумулятора: {battery} mAh");
        }
    }
}
