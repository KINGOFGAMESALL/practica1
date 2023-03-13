using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practica1
{
    public class Check
    {
        public string Name { get; set; }
        public int Account_number { get; set; }
        public double Sum { get; set; }
        public Check(string name, int account_number, double sum)
        {
            Name = name;
            Account_number = account_number;
            Sum = sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр класса Check с помощью конструктора с параметрами
            Check check = new Check("John Doe", 12345, 100.50);

            // Выводим информацию о чеке
            Console.WriteLine("Name: " + check.Name);
            Console.WriteLine("Account number: " + check.Account_number);
            Console.WriteLine("Sum: " + check.Sum);

            // Ожидаем нажатия любой клавиши
            Console.ReadKey();
        }
    }
}

