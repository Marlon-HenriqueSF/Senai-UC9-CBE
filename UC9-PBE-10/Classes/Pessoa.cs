using UC9_PBE_10.Interfaces;

namespace UC9_PBE_10.Classes
{
    public abstract class Pessoa : IPessoa 
    {
         public string? Nome { get; set; }
        public Endereco? Endereco { get; set; }
        public float Rendimento { get; set; }

        public abstract float PagarImposto(float Rendimento);
        
    }
}