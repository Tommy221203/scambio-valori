using System;

namespace scambio_valori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il primo numero:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("inserisci il secondo numero:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"il primo numero vale {a} e il secondo numero vale {b}");
            if (a > b)
            {
                int c = 0;
                c = a;
                a = b;
                b = c;
                Console.WriteLine($"il primo numero vale {a} e il secondo numero vale {b}");
            }
            else
            {
                Console.WriteLine("l'ordine dei numeri non può essere cambiato");
            }
            Console.ReadLine();
        }
    }
}
