using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UC9_PBE_10.Interfaces
{
    public interface IPessoaFisica
    {
        bool ValidarDataNascimento(DateTime datanascimento);
    }
}