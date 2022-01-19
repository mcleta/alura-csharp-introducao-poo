using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

    // Maneira mais na mão de fazer o Get e Set de algo
    //public void SetSaldo(double _saldo)
    //{
    //    if (_saldo < 0)
    //    {
    //        return;
    //    }

    //    this._saldo = _saldo;
    //}
    //public double GetSaldo()
    //{
    //    return _saldo;
    //}

    public bool Sacar(double valor)
    {
        if (this._saldo < valor)
        {
            return false;
        }

        this._saldo -= valor;
        return true;

    }

    public void Depositar(double valor)
    {
        this._saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (this._saldo < valor)
        {
            return false;
        }

        this._saldo -= valor;

        contaDestino.Depositar(valor);

        return true;

    }
}
}