using System;

namespace T4Eje4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numero1 = 0, numero2 = 0;
            bool entrada = false;
            do
            {
                try
                {
                    Console.WriteLine("Ingrese el primer número");
                    numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el siguiente número");
                    numero2 = Convert.ToInt32(Console.ReadLine());
                    entrada = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Valor introducido no es un entero");
                }

            } while (!entrada);

            if (entrada)
            {
                if (numero1 > numero2)
                {
                    Console.WriteLine("El número " + numero1 + " es mayor.");
                }
                else if (numero2 > numero1)
                {
                    Console.WriteLine("El numero " + numero2 + " es mayor.");
                }
                else
                {
                    Console.WriteLine("Son iguales");
                }
            }
        }
    }
}
