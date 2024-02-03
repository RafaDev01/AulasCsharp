using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaEx1
{
    internal class Conta
    {
        protected decimal Saldo { get; set; }
        protected int Numero { get; set; }
        protected string? NomeDoCliente { get; set; }
        internal Conta()
        {
            Saldo = 0M;
        }

        public virtual void Depositar(decimal valorDepositado)
        {
            Saldo += valorDepositado;
        }

        public virtual void Sacar(decimal valorDoSaque)
        {
            Saldo -= valorDoSaque;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine(
                                $"\nNúmero da conta: {Numero}\n" +
                                $"Proprietário: {NomeDoCliente}\n" +
                                $"Saldo: {Saldo}\n"
                              );
        }
    }
}
