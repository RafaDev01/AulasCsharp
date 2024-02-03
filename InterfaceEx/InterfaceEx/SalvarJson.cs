using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx
{
    public class SalvarJson : ArquivoBase, ISalvar
    {
        public void Salvar()
        {
            Console.WriteLine("Salvado arquivo Json");
        }
        public override void Nome()
        {
            Console.WriteLine("Definir nome Json");
        }
    }
}
