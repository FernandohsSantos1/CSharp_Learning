using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Estacionamento.Models
{
    public class Estacionamento
    {
        public decimal ValorInicial { get; set; }
        public decimal ValorHora { get; set; }
        public List<string> Veiculos = new List<string> { };

        public void Cadastrar()
        {
            Console.WriteLine("Digite a placa do veículo:");
            string placa = Console.ReadLine();
            Veiculos.Add(placa);
            Console.WriteLine("Veículo adicionado com sucesso!");
        }

        public void Remover()
        { 
            Console.WriteLine("Digite a placa do veículo:");
            string placa = Console.ReadLine();

            if (Veiculos.Contains(placa))
            {
                Console.WriteLine("Digite a quantidade de horas estacionadas:");
                int horas = int.Parse(Console.ReadLine());
                Console.WriteLine($"Valor total: R${(this.ValorInicial + this.ValorHora * horas)},00");
                Veiculos.Remove(placa);
                Console.WriteLine("Veículo removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Placa não encontrada!");
            }
        }

        public void Listar()
        {
            Console.WriteLine("Listando veículos: \n");

            foreach (string veiculo in Veiculos)
            {
                Console.WriteLine(veiculo);
            }
        }
    }
}