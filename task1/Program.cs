using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        // Моделирование счета в банке
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите тип номера счёта\nНажмите клавишу <Ввод> - если номер счета цифровой\nНажмите любую клавишу - если номер счета буквенно-цифровой");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("Введите данные банковского счёта\n");
                Console.WriteLine("Введите номер счета, до 15 знаков:");
                long number = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Введите баланс:");
                decimal balance = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Введите ФИО владельца:");
                string name = Convert.ToString(Console.ReadLine());
                Account<long> account = new Account<long>(number, balance, name);
                Print<long>(number, balance, name);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Введите данные банковского счёта\n");
                Console.WriteLine("Введите номер счета:");
                string number = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите баланс:");
                decimal balance = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Введите ФИО владельца:");
                string name = Convert.ToString(Console.ReadLine());
                Account<string> account = new Account<string>(number, balance, name);
                Print<string>(number, balance, name);
            }
            Console.ReadKey();
        }
        static void Print<T>(T number, decimal balance, string name)
        {
            Console.Clear();
            Console.WriteLine($"Добрый день {name}, на вашем счету {number}: {balance} денежкаф");
        }
    }
    class Account<T>
    {
        private T Number { get; set; }
        private decimal Balance { get; set; }
        private string Name { get; set; }
        public Account(T number, decimal balance, string name)
        {
            Number = number;
            Balance = balance;
            Name = name;
        }
    }

}
    

