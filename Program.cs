using System;

namespace suma_de_multiplos_de_3_y_5_jmsandovalp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dame un numero: ");
            String numeroi = Console.ReadLine();
            int num1;
            int suma=0;
            if (int.TryParse(numeroi, out num1))
            {
                for (int j=0; j<=num1;j++)
                {
                    if ((j % 3 == 0) || (j % 5 == 0))  
                    {
                        suma = suma + j;
                    }
                }
                
            }
            else
            {
                Console.WriteLine("Escribe un numero valido");
            }
            Console.WriteLine("La suma de los múltiplos de 3 y 5 hasta el número " + numeroi + " son: " + suma);
        }
    }
}
