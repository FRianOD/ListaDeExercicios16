using System;
namespace ListaDeExercicios16.Entities
{
    abstract class Contribuinte
    {
        public string Name { get; set; }
        public double RendaAnual { get; set; }

        public Contribuinte()
        {

        }
        public Contribuinte(string name, double rendaAnual)
        {
            Name = name;
            RendaAnual = rendaAnual;
        }

        public abstract double Impostos();
    }
}
