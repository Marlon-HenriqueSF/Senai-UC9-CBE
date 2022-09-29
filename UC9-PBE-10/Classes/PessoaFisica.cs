using UC9_PBE_10.Interfaces;

namespace UC9_PBE_10.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica 
    {
       public string? Cpf { get; set; } 
        public DateTime DataNascimento { get; set; }

        public override float PagarImposto(float Rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNascimento(DateTime datanascimento)
        {
            throw new NotImplementedException();
        }
    }
}