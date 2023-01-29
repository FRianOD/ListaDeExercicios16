using System;
namespace ListaDeExercicios16.Entities
{
    class PessoaFisica : Contribuinte
    {
        public double GastosComSaude { get; set; }
        
        public PessoaFisica()
        {

        }
        public PessoaFisica(string name,double rendaAnual,double gastosComSaude) : base(name, rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }

        public override double Impostos()
        {
            double imposto = 0.0;
            if (RendaAnual < 20000.00)
            {
                imposto = (RendaAnual * 0.15) - (GastosComSaude * 0.50);
            } else if (RendaAnual >= 20000.00)
            {
                imposto = (RendaAnual * 0.25) - (GastosComSaude * 0.50);
            }
            return imposto;
        }
    }
}
