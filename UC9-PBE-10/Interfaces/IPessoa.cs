using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_Pessoas_PBE10.Interfaces
{
    public interface IPessoa
    {
       /// <summary>
       /// método para calcular imposto
       /// </summary>
       /// <param name="rendimento">rendimento para basear o calculo de imposto</param>
       /// <returns>valor do imposto a ser pago</returns>
        float PagarImposto(float rendimento);
    }
}