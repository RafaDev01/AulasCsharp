using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HerancaEx1
{
    internal class ContaInvestimento : Conta
    {
        public ContaInvestimento(int numeroDaConta, string nomeDoCliente)
        {
            Numero = numeroDaConta;
            NomeDoCliente = nomeDoCliente;
        }

        public override void Depositar(decimal valorDepositado)
        {
            Saldo += valorDepositado;
            Saldo += Saldo * (0.9m / 100);
        }

        public override void Sacar(decimal valorDoSaque)
        {
            if (valorDoSaque >= Saldo)
            {
                Console.WriteLine("Não é possivel realizar um saque maior o saldo da conta");
            }
            else
            {
                Saldo -= valorDoSaque; 
                Saldo -= Saldo * (0.1m / 100);
            }
        }
    }
}
