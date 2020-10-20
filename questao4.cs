using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informa os valores: ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            int mmc = MMC(number1, number2);
            Console.WriteLine($"O MMC entre os valores {number1} e {number2} é: {mmc}");
            Console.ReadKey();
        }
        public static int MMC(int number1, int number2)
        {
            
            int a = number1; int b = number2;
            
            int r = number1 % number2;
            while (r != 0)
            {
               
                number1 = number2;
                number2 = r;

                r = number1 % number2;
            }
            return a * b / number2;
        }
    }
