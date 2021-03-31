#region Автор
//Анна Буланова
#endregion


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задача №1

            #region Описание задачи

            //Написать метод, возвращающий минимальное из трёх чисел.

            #endregion

            Console.WriteLine("Введите три целых числа.");
            Console.Write("Введите первое число:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число:");
            int c = int.Parse(Console.ReadLine());
            int min;

            if (a < b && a < c)
            {
                min = a;
            }

            else if(b < c)
            {
                min = b;
            }

            else
            {
                min = c;
            }

            Console.WriteLine($"Минимальное число: {min}");
            Console.ReadKey();
            #endregion

            #region Задача №2

            #region Описание задачи

            //Написать метод подсчета количества цифр числа.

            #endregion

            Console.WriteLine("Здравствуйте, вас приветствует программа подсчета количества цифр числа.");
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            int count = 0;

            while (num > 0)
            {
                count++;
                num /= 10;
            }

            Console.WriteLine("Цифр в указанном вами числе: " + count);
            Console.ReadKey();

            #endregion

            #region Задача №3

            #region Описание задачи

            /* С клавиатуры вводятся числа, пока не будет введен 0.
             * Подсчитать сумму всех нечетных положительных чисел.*/

            #endregion

            int q, counter = 0;

            do
            {
                Console.Write("Введите любое число больше 0:");
                q = int.Parse(Console.ReadLine());
                if (q > 0 && q % 2 == 1)
                    counter += q;
            }

            while (q != 0);
            Console.WriteLine(counter);
            Console.ReadKey();

            #endregion

            #region Задача №5

            #region Описание задачи

           /*Написать программу, которая запрашивает массу и рост человека, 
             вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.*/

            #endregion

            Console.WriteLine("Пожалуйста, введите ваше имя");
            String name = Console.ReadLine();
            String text = "Привет, " + name + "! Данная программа поможет вычислить твой ИМТ (индекс массы тела).";
            Console.WriteLine(text);
            Console.ReadLine();

            Console.WriteLine("Введите ваш рост (в м)");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш вес (в кг)");
            double weight = double.Parse(Console.ReadLine());


            double I = weight / (height * height);
            Console.WriteLine($"Ваш ИМТ + {I}");
            Console.ReadLine();

            if (I <= 15.99)
            {
                Console.WriteLine("У вас выраженный дефицит массы тела. Необходима срочная консультация с врачом.");
                Console.ReadLine();
            }

            else if (I >= 16 && I <= 18.49)
            {
                Console.WriteLine("У вас недостаточная масса тела. Необходима консультация специалиста.");
                Console.ReadLine();
            }

            else if (I >= 18.50 && I <= 24.99)
            {
                Console.WriteLine("Ваш вес в норме.");
                Console.ReadLine();
            }

            else if (I >= 25.00 && I <= 29.99)
            {
                Console.WriteLine("У вас избыточная масса тела (предожирение). Необходима консультация специалиста");
                Console.ReadLine();
            }

            else if (I >= 30.00 && I <= 34.99)
            {
                Console.WriteLine("У вас ожирение первой степени. Необходима консультация специалиста.");
                Console.ReadLine();
            }

            else if (I >= 35.00 && I <= 39.99)
            {
                Console.WriteLine("У вас ожирение второй степени. Необходима консультация специалиста.");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("У вас ожирение третьей степени (морбидное). Необходима срочная консультация специалиста.");
                Console.ReadLine();
            }

            #endregion

        }

            #region Задача №4

        #region Описание задачи

        /*Реализовать метод проверки логина и пароля. 
        На вход метода подается логин и пароль.
        На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password: GeekBrains). 
        Используя метод проверки логина и пароля, написать программу: 
        пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
        С помощью цикла do while ограничить ввод пароля тремя попытками.*/

        #endregion

        static bool LogInPassword(string login, string password)
        {
            if (login == "root" && password == "GeekBrains")
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа проверки логина и пароля!");
            int AmountOfTries = 3;

            do
            {
                Console.Write("Введите логин:");
                string login = Console.ReadLine();
                Console.Write("Введите пароль:");
                string password = Console.ReadLine();

                if (LogInPassword(login, password))
                {
                    Console.WriteLine();
                    break;
                }

                else
                {
                    AmountOfTries--;
                    Console.WriteLine("Неверный логин или пароль. Оставшихся попыток: " + AmountOfTries);
                }

            }

            while (AmountOfTries > 0);
            Console.WriteLine("Авторизация прошла успешно!");
            Console.ReadKey();
        }

        #endregion
    }
}
