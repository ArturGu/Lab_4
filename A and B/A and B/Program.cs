using System;

namespace A_and_B
{
    public class A
    {
        public A(B derivative1)
        {
            Console.WriteLine($"Клас: {derivative1}");
            Console.WriteLine("Базовий клас: B");
            Console.WriteLine($"Властивостi: {derivative1.GetType().GetProperties()}");
            Console.WriteLine();
        }
        public A(B derivative1, B derivative2)
        {
            Console.WriteLine($"Клас: {derivative1}");
            Console.WriteLine("Базовий клас: B");
            Console.WriteLine($"Властивостi: {derivative1.GetType().GetProperties()}");
            Console.WriteLine();

            Console.WriteLine($"Клас: {derivative2}");
            Console.WriteLine("Базовий клас: B");
            Console.WriteLine($"Властивостi: {derivative2.GetType().GetProperties()}");
        }
        public A(B derivative1, B derivative2, B derivative3)
        {
            Console.WriteLine($"Клас: {derivative1}");
            Console.WriteLine("Базовий клас: B");
            Console.WriteLine($"Властивостi: {derivative1.GetType().GetProperties()}");
            Console.WriteLine();

            Console.WriteLine($"Клас: {derivative2}");
            Console.WriteLine("Базовий клас: B");
            Console.WriteLine($"Властивостi: {derivative2.GetType().GetProperties()}");
            Console.WriteLine();

            Console.WriteLine($"Клас: {derivative3}");
            Console.WriteLine("Базовий клас: B");
            Console.WriteLine($"Властивостi: {derivative3.GetType().GetProperties()}");
        }
    }

    public abstract class B
    {
        public abstract double Math(double a, double b);
    }

    internal class DerivativeClass1 : B
    {
        public override double Math(double a, double b)
        {
            double s = a + b;
            Console.WriteLine($"Результат = {s}");
            return s;
        }
    }

    internal class DerivativeClass2 : B
    {
        public override double Math(double a, double b)
        {
            double s = a * b;
            Console.WriteLine($"Результат = {s}");
            return s;
        }
    }

    internal class DerivativeClass3 : B
    {
        public override double Math(double a, double b)
        {
            double s = a / b;
            Console.WriteLine($"Результат = {s}");
            return s;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Додавання;");
            Console.WriteLine("2.Множення;");
            Console.WriteLine("3.Дiлення.");
            Console.Write("Виберiть операцiю: ");
            int action = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введiть перше число: ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введiть друге число: ");
            double y = Convert.ToInt32(Console.ReadLine());

            DerivativeClass1 derivclass1 = new DerivativeClass1();
            DerivativeClass2 derivclass2 = new DerivativeClass2();
            DerivativeClass3 derivclass3 = new DerivativeClass3();

            switch (action)
            {
                case 1:

                    double action1 = derivclass1.Math(x, y);
                    break;

                case 2:

                    double action2 = derivclass2.Math(x, y);
                    break;

                case 3:
                    double action3 = derivclass3.Math(x, y);
                    break;

                default:
                    Console.WriteLine("Помилка!");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Властивостi яких похiдних класiв потрiбно вiдобразити?");
            Console.Write("Виберiть '1' або '1,2' або '1,2,3': ");
            string p = Console.ReadLine();
            Console.WriteLine();

            if (p == "1")
            {
                A a = new A(derivclass1);
            }

            else if (p == "1,2")
            {
                A a = new A(derivclass1, derivclass2);
            }

            else if (p == "1,2,3")
            {
                A a = new A(derivclass1, derivclass2, derivclass3);
            }

            else
            {
                Console.WriteLine("Помилка!");
            }
            Console.ReadKey();
        }
    }
}