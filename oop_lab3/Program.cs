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

        public Airline()
        {
            Destination = "Москва";
            Number = "SU 1234";
            Type = "Boeing-777";
            Time = "06.30";
            Days = "Среда";
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
            Airline q = new Airline();
            q.Info();
        }
    }
}
