using Cadastro_Pessoas_PBE10.Interfaces;

namespace Cadastro_Pessoas_PBE10.Classes
{
    //classe Pessoa Fisica que herda da superclasse Pessoa
    public class PessoaFisica : Pessoa, UC9_PBE_10.Interfaces.IPessoaFisica
    {
        //atributos da classe Pessoa Fisica
        public string? Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 1500)
            {
                return 0;
            }
            else if (rendimento >= 1501 && rendimento <= 3500)
            {
                return rendimento * 0.02f;
            }
            else if (rendimento >= 3501 && rendimento <= 6000)
            {
                return rendimento * 0.035f;
            }
            else
            {
                return rendimento * 0.05f;
            }
        }

        public bool ValidarDataNascimento(DateTime datanascimento)
        {
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - datanascimento).TotalDays / 365;

            if (anos >= 18)
            {
                return true;
            }

            return false;
        }

        public bool ValidarDataNascimento(string datanascimento)
        {
            DateTime dataConvertida;

            if (DateTime.TryParse(datanascimento, out dataConvertida))
            {
                DateTime dataAtual = DateTime.Today;

                double anos = (dataAtual - dataConvertida).TotalDays / 365;

                if (anos >= 18)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}