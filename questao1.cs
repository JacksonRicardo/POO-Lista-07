using System;

    class Program
    {
     public  static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores: ");
            double primeiro_valor = double.Parse(Console.ReadLine());
            double segundo_valor = double.Parse(Console.ReadLine());
            double c = Maior(primeiro_valor, segundo_valor);
            Console.WriteLine($"Maior valor: {c}");

            double d = Matematica.Maior(primeiro_valor, segundo_valor);
            Matematica m = new Matematica();

            double e = m.Menor(primeiro_valor, segundo_valor);
            Console.WriteLine($"Menor valor: {e}");
            Console.ReadKey();
        }
        public static double Maior(double x, double y)
        {
           
            return x > y ? x : y;
        }
    }
    class Matematica
    {
        public static double Maior(double x, double y)
        {
           
            return x > y ? x : y;
        }
        public double Menor(double x, double y)
        {
           
            return x < y ? x : y;
        }
    }
