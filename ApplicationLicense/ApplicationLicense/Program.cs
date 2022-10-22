using System;

namespace ApplicationLicense
{
    public class ApplicationLicense
    {
        public void AllowCommon()
        {
            Console.WriteLine("Безкоштовна версiя");
        }

        public void AllowTrial()
        {
            Console.WriteLine("Триальний режим");
        }

        public void AllowPro()
        {
            Console.WriteLine("Платна версiя");
        }
    }

    public class KeyNumber: ApplicationLicense
    {
        private string key;
        public KeyNumber(string Key)
        {
            this.key = Key;
        }

        public void AccessCheck()
        {
            if (key == "1111")
            {
                AllowTrial();
            }

            else if (key == "12345")
            {
                AllowPro();
            }

            else
            {
                AllowCommon();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть номер ключа: ");
            string key = Console.ReadLine();
            Console.Write("Доступ до програми: ");

            KeyNumber number = new KeyNumber(key);
            number.AccessCheck();

            Console.ReadKey();
        }
    }
}