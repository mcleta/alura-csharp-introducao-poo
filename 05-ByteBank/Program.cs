using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();

            //gabriela.nome = "Gabriela";
            //gabriela.cpf = "123.456.789-00";
            //gabriela.profissao = "Dev C#";

            //**********************************************
            ContaCorrente conta = new ContaCorrente();

            //conta.titular = gabriela;

            if (args.Length == 0)
            {
                Console.WriteLine("Ops, a referencia conta.titular é NULL!");
            }

            conta.agencia = 123;
            conta.numero = 456789;
            conta.saldo = 500;


        }
    }
}
