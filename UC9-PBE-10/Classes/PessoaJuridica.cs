using UC9_PBE_10.Interfaces;

namespace UC9_PBE_10.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
         public string? RazaoSocial { get; set; }
        public string? Cnpj { get; set; }

        public override float PagarImposto(float Rendimento)
        {
            if (Rendimento <= 3000)
            {
                return Rendimento * 0.03f;
            }
            else if (Rendimento >= 3001 && Rendimento <= 6000)
            {
                return Rendimento * 0.05f;
            }  
            else if (Rendimento >= 6001 && Rendimento <= 10000)
            {
                return Rendimento * 0.07f;
            }
            else 
            {
                return Rendimento * 0.09f;
            }
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}