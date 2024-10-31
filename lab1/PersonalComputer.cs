using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class PersonalComputer: CompEquipment
    {
        private double weight;
        public PersonalComputer(string brand = "Неизвестный",
           string cpu_brand = "Неизвестный",
           int ram = 0,
           int price = 0,
           double weight = 0
           )
           : base(brand, cpu_brand, ram, price) 
        { 
            this.weight = weight;
        }

        public double GetWeight()
        {
            return this.weight;
        }

        public void SetWeight(double weight)
        {
            this.weight = weight;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Вес компьютера: {weight} кг");
        }
    }
}
