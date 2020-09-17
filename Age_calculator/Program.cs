using System;

namespace Age_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int year, number_of_years = 0, year_now, month, month_now, day, day_now;
            DateTime date_now = DateTime.Now;
            
            // Обработка имени
            Console.WriteLine("Здравствуйте");
            Console.Write("Введите ваше имя:");
            name = Console.ReadLine();

            // Обработка года
            Console.Write("Укажите год своего рождения:");
            year = Convert.ToInt32(Console.ReadLine());
            if (year < 1000)
            {
                Console.WriteLine("Вы явно допустили ошибку");
                Console.ReadKey();
                Environment.Exit(0); 
            }
            

            // Обработка месяца
            Console.Write("Укажите месяц рождения:");
            month = Convert.ToInt32(Console.ReadLine());
            
            if (month < 1 ^ month > 12)
            {
                Console.WriteLine("Вы явно допустили ошибку");
                Console.ReadKey();
                Environment.Exit(0);
            }

            // Обработка дня
            Console.Write("Осталось указать день:");
            day = Convert.ToInt32(Console.ReadLine());
            if (month == 1 ^ month == 3 ^ month == 5 ^ month == 7 ^ month == 8 ^ month == 10 ^ month == 12)
                {
                    if (day > 31 ^ day < 1)
                    {
                    Console.WriteLine("Вы явно допустили ошибку");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                }
            else if ((month <= 12 && month > 1) && (month != 2))
                {
                    if (day > 30 ^ day < 1)
                        {
                            Console.WriteLine("Вы явно допустили ошибку");
                            Console.ReadKey();
                            Environment.Exit(0);
                }
                }
            else
                {
                    if ((year % 4 == 0) && (year % 100 != 0))
                        {
                            if (day < 1 ^ day > 29)
                                {
                                    Console.WriteLine("Вы явно допустили ошибку");
                                    Console.ReadKey();
                                    Environment.Exit(0);
                    }
                    }
                    else if ((year % 4 == 0) && (year % 100 == 0) && (year % 400 == 0))
                       {
                       if (day < 1 ^ day > 29)
                       {
                       Console.WriteLine("Вы явно допустили ошибку");
                       Console.ReadKey();
                       Environment.Exit(0);
                    }
                    }
                    else
                        {
                        if (year < 1 ^ year > 28)
                            {
                            Console.WriteLine("Вы явно допустили ошибку");
                            Console.ReadKey();
                            Environment.Exit(0);
                    }
                    }
                }

            // Подсчет лет
            year_now = date_now.Year;
            month_now = date_now.Month;
            day_now = date_now.Day;
            
            if (month < month_now)
                {
                number_of_years = year_now - year;
            }
            else if (month > month_now)
                {
                number_of_years = year_now - year - 1;
            }
            else if (day < day_now)
                {
                number_of_years = year_now - year - 1;
            }
            else if (day >= day_now)
                {
                number_of_years = year_now - year - 1;
            }

            Console.WriteLine($"Привет, {name}. Ваш возраст равен {number_of_years} лет. Приятно познакомиться!");
            
            Console.ReadKey();
        }
    }
}