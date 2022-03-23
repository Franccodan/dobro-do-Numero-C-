using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dobroNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numeroDobro = 0;

    
            Console.Write("Digite um número: ");
            numero1 = int.Parse(Console.ReadLine());

            numeroDobro = numero1 * 2;

            Console.Write("Olá, o dobro deste número é: " + numeroDobro);
            Console.ReadLine();
            
        }
    }
}
 