using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela = new ContaCorrente();

            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 123;
            contaGabriela.numero = 123456;
            contaGabriela.saldo = 200;

            Console.WriteLine(contaGabriela.saldo);

            //******************************************************************

            ContaCorrente contaGabriru = new ContaCorrente();

            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 123;
            contaGabriela.numero = 123456;
            contaGabriela.saldo = 200;

            Console.WriteLine(contaGabriru.saldo);

            //******************************************************************

            Console.WriteLine(contaGabriru == contaGabriela);

            int idade1 = 10;
            int idade2 = 10;

            Console.WriteLine(idade1 == idade2);

            //******************************************************************
            //Passagem por referencia
            contaGabriru = contaGabriela;

            Console.WriteLine(contaGabriru == contaGabriela);

            Console.WriteLine(contaGabriela.ativo);

            Console.ReadLine();
        }
    }
}
