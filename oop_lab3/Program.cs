using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab3
{
    class Airline
    {
        public string Destination;
        public string Number;
        public string Type;
        public string Time;
        public string Days;
        static int amount;

        static Airline()
        {
            amount = 0;
        }
        public Airline()
        {
            amount++;
            this.Destination = "Москва";
            this.Number = "SU 1234";
            this.Type = "Boeing-777";
            this.Time = "06.30";
            this.Days = "Среда";
        }

        public Airline(string Destination, string Number, string Type, string Time, string Days)
        {
            amount++;
            this.Destination = Destination;
            this.Number = Number;
            this.Type = Type;
            this.Time = Time;
            this.Days = Days;
        }

        public Airline(string Destination, string Number)
        {
            amount++;
            this.Destination = Destination;
            this.Number = Number;
            this.Type = "Boeing-777";
            this.Time = "08.00";
            this.Days = "Вторник";
        }
        public void Info()
        {
            Console.WriteLine($"{Number}, {Time}, {Days}, {Destination}, {Type}");
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main()
        {
            Airline Airline1 = new Airline();
            Airline1.Info();

            Airline Airline2 = new Airline("Мозырь", "SU 5678", "Boeing-737", "22.30", "Пятница");
            Airline2.Info();

            Airline Airline3 = new Airline("Брест", "SU 9214");
            Airline3.Info();

            Airline Airline4 = new Airline("Париж", "SU 4564");
            Airline4.Info();

            Airline Airline5 = new Airline("Марс", "SU 5823", "Boeing-757", "00.00", "Понедельник");
            Airline5.Info();

        }
    }
}
