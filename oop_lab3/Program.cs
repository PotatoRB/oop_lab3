using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab3
{
    partial class Airline
    {
        private string Destination;
        private string Number;
        private string Type;
        private double Time;
        private string Days;
        private static int amount;
        private readonly double ID; 
        private const int Consta = 7;

        //get set
        public string Dstntn
        {
            get
            {
                return this.Destination;
            }

            set
            {
                this.Destination = value;
            }
        }

        public string Nmbr
        {
            get
            {
                return this.Number;
            }

            set
            {
                this.Number = value;
            }
        }

        public string Tp
        {
            get
            {
                return this.Type;
            }

            set
            {
                this.Type = value;
            }
        }

        public double Tm
        {
            get
            {
                return this.Time;
            }

            set
            {
                this.Time = value;
            }
        }

        public string Ds
        {
            get
            {
                return this.Days;
            }

            set
            {
                this.Days = value;
            }
        }

        public double id
        {
            get
            {
                return this.ID;
            }

            set
            {
                this.id = value;
            }
        }

        //

        // конструкторы
        static Airline()
        {
            amount = 0;
        }

        public Airline()
        {
            amount++;
            this.Destination = "Москва";
            this.Number = "SU1234";
            this.Type = "Boeing-777";
            this.Time = 06.30;
            this.Days = "Среда";
            this.ID = GetID(Destination, Number, Type, Time, Days, amount, Consta);
        }

        public Airline(string Destination, string Number, string Type, double Time, string Days)
        {
            amount++;
            this.Destination = Destination;
            this.Number = Number;
            this.Type = Type;
            this.Time = Time;
            this.Days = Days;
            this.ID = GetID(Destination, Number, Type, Time, Days, amount, Consta);
        }

        public Airline(string Destination, string Number)
        {
            amount++;
            this.Destination = Destination;
            this.Number = Number;
            this.Type = "Boeing-777";
            this.Time = 8.00;
            this.Days = "Среда";
            this.ID = GetID(Destination, Number, Type, Time, Days, amount, Consta);
        }
        //

        //функции
        public double GetID(string a1, string a2, string a3, double a4, string a5, int a6 , int a7)
        {
            double ID = 0;
            ID += (a1.Length + a2.Length + a3.Length + a4 + a5.Length) * (a6 + a7);
            return ID;
        }

        public void Info()
        {
            Console.WriteLine($"{Number}, {Time}, {Days}, {Destination}, {Type}, {ID}");
            Console.ReadKey();
        }
        //
    }
    class Program
    {
        static void Main()
        {
            Airline Airline1 = new Airline();
            Airline1.Info();

            Airline Airline2 = new Airline("Мозырь", "SU5678", "Boeing-737", 22.30, "Пятница");
            Airline2.Info();

            Airline Airline3 = new Airline("Брест", "SU9214");
            Airline3.Info();

            Airline Airline4 = new Airline("Париж", "SU4564");
            Airline4.Info();

            Airline Airline5 = new Airline("Москва", "SU5823", "Boeing-757", 00.00, "Понедельник");
            Airline5.Info();

            object[] arrAirline = new object[5];
            arrAirline[0] = Airline1;
            arrAirline[1] = Airline2;
            arrAirline[2] = Airline3;
            arrAirline[3] = Airline4;
            arrAirline[4] = Airline5;

            //сравнение и прочее
            Console.WriteLine(Airline1.Equals(Airline3));
            Console.WriteLine(Airline2.Equals(Airline4));
            Console.WriteLine(Airline2.Equals(Airline2));
            Console.WriteLine(Airline1.Dstntn.Equals(Airline5.Dstntn));
            Console.WriteLine(Airline1.Ds.GetHashCode());
            Console.WriteLine(Airline3.Ds.GetHashCode());
            Console.WriteLine(Airline5.Ds.GetHashCode());
            Console.WriteLine(Airline5.ToString());
            Console.WriteLine(Airline2.Nmbr.ToString());
            Console.WriteLine(Airline4.Nmbr);
            Console.WriteLine(Airline2.id);
            Console.ReadKey();
            //

            //методы\задачки
            Console.WriteLine("Пункт назначения Москва");
            foreach (Airline Airline in arrAirline)
            {
                if (Airline.Dstntn == "Москва")
                {
                    Console.WriteLine($"Номер рейса {Airline.Nmbr}, id {Airline.id}, пункт назначения {Airline.Dstntn}");
                }
            }
            Console.ReadKey();

            Console.WriteLine("День недели среда");
            foreach (Airline Airline in arrAirline)
            {
                if (Airline.Ds == "Среда")
                {
                    Console.WriteLine($"Номер рейса {Airline.Nmbr}, id {Airline.id}, день недели {Airline.Ds}");
                }
            }
            Console.ReadKey();
            //

            // ref out
            RefOut();
            void RefOut()
            {
                int a = 1;
                Console.WriteLine($"Базовое значение {a}");
                aaa(a);
                Console.WriteLine($"после функции без ref {a}");
                bbb(ref a);
                Console.WriteLine($"после функции с ref {a}");
                ccc(a, out int s);
                Console.WriteLine($"{s}");

                void aaa(int q)
                {
                    q++;
                    Console.WriteLine($"значение функции {q}");
                }
                void bbb(ref int q)
                {
                    q++;
                    Console.WriteLine($"значение функции {q}");
                }
                void ccc(int q, out int w)
                {
                    w = q * 100;
                }
            }
            Console.ReadKey();
            //

            //аноним
            var airline = new { Num = "US1600" };
            Console.WriteLine(airline.Num);
            Console.ReadKey();
            //
        }
    }
}
