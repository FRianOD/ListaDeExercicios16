using System;
using System.Globalization;
using System.Collections.Generic;
using ListaDeExercicios16.Entities;

namespace ListaDeExercicios16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> contribuintes = new List<Contribuinte>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nTax payer #{i} data:");
                Console.Write("Individual or Company (i/c): ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(resp == 'i' || resp == 'I') 
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    contribuintes.Add(new PessoaFisica(name,anualIncome,healthExpenditures));
                } else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    contribuintes.Add(new PessoaJuridica(name,anualIncome,employees));
                }
            }

            Console.WriteLine("\nTAXES PAID: ");
            foreach (Contribuinte contribuinte in contribuintes)
            {
                Console.WriteLine($"{contribuinte.Name}: ${contribuinte.Impostos().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            double sum = 0.0;
            foreach(Contribuinte contribuinte in contribuintes)
            {
                sum += contribuinte.Impostos();
            }

            Console.WriteLine($"\nTOTAL TAXES: {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}