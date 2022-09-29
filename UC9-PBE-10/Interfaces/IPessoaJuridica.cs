using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UC9_PBE_10.Interfaces
{
    public interface IPessoaJuridica
    {
        /// <summary>
        /// Metodo para validar CNPJ
        /// </summary>
        /// <param name="cnpj">CNPJ da Pessoa Juridica</param>
        /// <returns>Verdaderio ou Falso</returns>
        bool ValidarCnpj(string cnpj);
    }
}