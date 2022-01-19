using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Bytebank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conta Corrente do Bruno
            ContaCorrente contaBruno = new ContaCorrente();

            contaBruno.titular = "Bruno";

            Console.WriteLine($" SaldoBruno: {contaBruno.saldo}");

            //****************************************
            //Conta Corrente da Gabriela
            ContaCorrente contaGabriela = new ContaCorrente();

            contaGabriela.titular = "Gabriela";

            Console.WriteLine($" SaldoGabriela: {contaGabriela.saldo}");

            //****************************************
            //Teste do Sacar
            contaBruno.Sacar(50);

            Console.WriteLine($" SaldoBruno: {contaBruno.saldo}");

            //****************************************
            //Teste do Depositar
            contaBruno.Depositar(50);

            Console.WriteLine($" SaldoBruno: {contaBruno.saldo}");

            //****************************************
            //Teste do Tranferir
            bool resTranferencia = contaBruno.Transferir(50, contaGabriela);

            Console.WriteLine($"Resultado da tranfeerencia: {resTranferencia}");

            Console.WriteLine($" SaldoBruno: {contaBruno.saldo}; SaldoGabi: {contaGabriela.saldo}");


            Console.ReadLine();
        }
    }
}
