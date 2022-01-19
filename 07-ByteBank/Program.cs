using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(123, 123456789);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaG = new ContaCorrente(123, 123456789);

            ContaCorrente contaB = new ContaCorrente(123, 123456789);

            Console.WriteLine(ContaCorrente.TotalContas);


            Console.ReadLine();
        }
    }
}
