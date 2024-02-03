using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaEComposicao
{
    internal class Macado : Animal
    {
        private readonly ComportamentoAndar _comportamentoAndar;

        public Macado(ComportamentoAndar comportamentoAndar)
        {
            _comportamentoAndar = comportamentoAndar;
        }

        public void Locomocao()
        {
            Console.WriteLine(nameof(Macado));
            _comportamentoAndar.Andar();
        }
    }
}
