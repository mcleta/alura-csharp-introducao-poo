using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            Cliente cliente = new Cliente();

            cliente.Nome = "Jose";
            cliente.CPF = "123.456.789-00";
            cliente.Profissao = "Dev";

            conta.Saldo = -10;

            Console.WriteLine(conta.Saldo);
            Console.WriteLine(cliente.Nome);
            Console.WriteLine(cliente.CPF);
            Console.WriteLine(cliente.Profissao);

            Console.ReadLine();
        }
    }
}
