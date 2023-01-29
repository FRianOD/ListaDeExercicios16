using System;
namespace ListaDeExercicios16.Entities
{
    class PessoaJuridica : Contribuinte
    {
        public int Funcionarios { get; set; }

        public PessoaJuridica()
        {

        }

        public PessoaJuridica(string name, double rendaAnual,int funcionarios) : base(name,rendaAnual)
        {
            Funcionarios = funcionarios;
        }

        public override double Impostos()
        {
            double impostos = 0.0;
            if (Funcionarios > 10)
            {
                impostos = RendaAnual * 0.14;
            } else if (Funcionarios <= 10)
            {
                impostos = RendaAnual * 0.16;
            }

            return impostos;
        }
    }
}
