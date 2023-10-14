using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PartialClass;

public partial class MinhaPartialClass
{
    public TimeSpan CalculaIdade(DateTime DataNascimento)
    {
        return (DateTime.Now.Date - DataNascimento);
    }

    public TimeSpan DiferencaEntreDatas(DateTime date1, DateTime date2) 
    {
        var diferenca = date1.Subtract(date2);
        return diferenca;
    }
}
