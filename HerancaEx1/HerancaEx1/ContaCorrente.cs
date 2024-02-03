using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaEx1
{
    internal class ContaCorrente : Conta
    {
        public ContaCorrente(int numeroDaConta, string nomeDoCliente)
        {
            Numero = numeroDaConta;
            NomeDoCliente = nomeDoCliente;
        }
    }
}
