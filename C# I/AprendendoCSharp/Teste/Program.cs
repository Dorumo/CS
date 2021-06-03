using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 1000;

            for(int contador = 1; contador <= 12; contador++)
            {
                valor *= 1.0036;
                Console.WriteLine("Após " + contador + " meses, você terá R$" + valor);
            }

            Console.ReadLine();
        }
    }
}
