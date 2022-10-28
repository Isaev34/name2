
using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Выберите какую операцию вы хотите выполнить:");
            Console.WriteLine("1. Угадайте число");
            Console.WriteLine("2. Таблицы умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Закрыть программу\n");

            Console.Write("Введите номер операции: ");
            string input = Console.ReadLine();

            if (input.Length == 0) Menu();
            else if (Convert.ToInt32(input) == 1) Menu1("Добро пожаловать в - Угадайте число");
            else if (Convert.ToInt32(input) == 2) Menu2("Добро пожаловать в - Таблицу умножения");
            else if (Convert.ToInt32(input) == 3) Menu3("Добро пожаловать в - Вывод делителей числа");
            else if (Convert.ToInt32(input) == 4) Environment.Exit(0);
            else Menu();
        }
        static void Menu1(string name)
        {
            int min = 0, max = 3;
            bool active = true;
            Console.WriteLine("{0} от {1} до {2}", name, min, max);
            Console.WriteLine("Чтобы выйти нажмите - enter");

            Random rnd = new Random();
            int value = rnd.Next(min, max);
            while (active)
            {
                Console.Write("Ввод: ");
                string input = Console.ReadLine();
                if (input == "") active = false;
                else if (Convert.ToInt32(input) > value) Console.WriteLine("Надо меньше");
                else if (Convert.ToInt32(input) < value) Console.WriteLine("Надо больше");

                if (active && Convert.ToInt32(input) == value) active = false;
            }
            Menu();
        }
        static void Menu2(string name)
        {
            Console.WriteLine("{0}", name);
            for (int i = 2; i < 11; i++)
            {
                for (int j = 2; j < 11; j++)
                {
                    int result = i * j;
                    Console.Write($"{i}*{j}={result}\t");
                }
                Console.WriteLine();
            }
            Console.Write("Нажмите на любую кнопку чтобы выйти... ");
            Console.ReadLine();
            Menu();
        }
        static void Menu3(string name)
        {
            bool active = true;
            Console.WriteLine("{0}", name);
            Console.WriteLine("Чтобы выйти нажмите enter");
            while (active)
            {
                Console.Write("Ввод: ");
                string input = Console.ReadLine();
                int value = 0;
                if (input == "") active = false;
                else if (input.Length != 0)
                {
                    value = Convert.ToInt32(input);
                    Console.Write("Число {0}:\t", value);
                    for (int i = 1; i <= value; i++) if (value % i == 0) Console.Write($"{i}\t");
                    Console.WriteLine();
                }
            }
            Menu();
        }
    }
}