using System;
using System.Diagnostics;

namespace Types
{
    public class Types
    {
        public virtual void ValueTypes(int i, double d, string s)
        {
            Debug.WriteLine(i);
            Debug.WriteLine(d);
            Debug.WriteLine(s);
        
            Console.WriteLine($"Значення = {i}==>Тип: {i.GetType()}.");  
            Console.WriteLine($"Значення = {d}==>Тип: {d.GetType()}.");  
            Console.WriteLine($"Значення = {s}==>Тип: {s.GetType()}.");
            Console.ResetColor();

            Console.WriteLine();
        }
    }

    public class Types2 : Types
    {
        public override void ValueTypes(int i, double d, string s)
        {
            Debug.WriteLine(i);
            Debug.WriteLine(d);
            Debug.WriteLine(s);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Значення = {i}==>Тип: {i.GetType()}.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Значення = {d}==>Тип: {d.GetType()}.");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Значення = {s}==>Тип: {s.GetType()}.");

            Console.WriteLine();
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть цiле число: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ведiть дробове число: ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введiть букву або слово: ");
            string s = Console.ReadLine();
            Console.WriteLine();

            Types types = new Types();
            types.ValueTypes(i, d, s);

            Console.Write("Введiть цiле число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ведiть дробове число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введiть букву або слово: ");
            string c = Console.ReadLine();
            Console.WriteLine();

            Types2 types2 = new Types2();
            types2.ValueTypes(a,b,c);

            Console.ReadKey();
        }
    }
}