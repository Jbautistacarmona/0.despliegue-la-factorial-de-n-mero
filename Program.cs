using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace despliegue_la_factorial_de_número
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número para calcular su factorial: ");
            int num = Convert.ToInt32(Console.ReadLine());           //Convierte la representación de cadena especificada de un número en un entero de 32 bits con signo equivalente

            int result = Factorial(num);
            Console.WriteLine("El factorial de " + num + " es " + result);
            Console.ReadLine();
        }

        static int Factorial(int n)             //es una variable que ha sido ubicada estáticamente y cuyo tiempo de vida se extiende durante toda la ejecución del programa
        {
            if (n == 0) //
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
