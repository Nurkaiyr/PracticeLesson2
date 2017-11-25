using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practika
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
            ThirdTask();
            FourthTask();
            FifthTask();
            SixthTask();
            SeventhTask();
            EighthTask();
        }

        private static void EighthTask()
        {
            bool x = true;
            bool y = false;
            Console.WriteLine(!x && !y);
            Console.WriteLine(x || !x && y);
            Console.WriteLine(!x && y || y);

            Console.ReadKey();
        }

        private static void SeventhTask()
        {
            int x = 456; // в заданий дано Х=456;
            int second, third;
            int first = 4;
            second = x / 10 % 10;
            third = x % 10;

            Console.WriteLine("x=" + first + third + second);
            Console.ReadKey();

        }

        private static void SixthTask()
        {
            int chislo, pervoechiso, vtoroechislo, tretechislo, chetvertoechislo, summa, proizdevenie;
            Console.WriteLine("Введите 4х значное число:");
            chislo = int.Parse(Console.ReadLine());
            pervoechiso = chislo / 1000;
            vtoroechislo = chislo / 100 % 10;

            tretechislo = chislo / 10 % 10;
            chetvertoechislo = chislo % 10;

            summa = pervoechiso + vtoroechislo + tretechislo + chetvertoechislo;
            proizdevenie = pervoechiso * vtoroechislo * tretechislo * chetvertoechislo;

            Console.WriteLine("Сумма:" + summa);
            Console.WriteLine("Произведение:" + proizdevenie);
            Console.ReadKey();
        }

        private static void FifthTask()
        {
            int desyat = 10;
            int chislo, desyatki, edinicy, summa, proizvedenie;
            Console.WriteLine("Введите 2х значное число: ");
            chislo = int.Parse(Console.ReadLine());
            desyatki = chislo / desyat;
            edinicy = chislo % desyat;
            summa = desyatki + edinicy;
            proizvedenie = desyatki * edinicy;

            Console.WriteLine("Число десятков: " + desyatki);
            Console.WriteLine("Число единиц: " + edinicy);
            Console.WriteLine("Сумма цифр: " + summa);
            Console.WriteLine("Произведение цифр: " + proizvedenie);
        }

        private static void FourthTask()
        {
            int nedeli = 7;
            int dni = 234;
            int weeks;
            Console.WriteLine("С некоторого момента прошло 234 дня");
            weeks = dni / nedeli;
            Console.WriteLine("С тех пор прошло полных недель: " + weeks);
            Console.ReadKey();
        }

        private static void ThirdTask()
        {
            double cmtom = 0.01;
            double cm, m;
            Console.WriteLine("Введите расстояние в сантиметрах:");
            cm = double.Parse(Console.ReadLine());
            m = cm * cmtom;
            Console.WriteLine("Расстояние в метрах" + m);
            Console.ReadKey();
        }

        private static void SecondTask()
        {
            double r, c, s, d;
            Console.WriteLine("Введите радиус окружности(круга):");
            r = double.Parse(Console.ReadLine());
            d = r + r;
            c = Math.PI * d;
            s = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Длина окружности:" + c);
            Console.WriteLine("Площадь круга:" + s);
            Console.ReadKey();

        }

        private static void FirstTask()
        {
            double x, y;
            Console.WriteLine("Введите пожалуйста значение х:");
            x = double.Parse(Console.ReadLine());
            y = 7 * Math.Pow(x, 2) - 3 * x + 4;
            Console.WriteLine("Результат y:" + y);
        }
    }
}