using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao
{
    public class Funcionario : Pessoa
    {
        private int matricula { get; set; }
        private string PlacaVeiculo { get; set; }

        public bool VerificarVeiculo(Automovel automovel)
        {

            if (automovel.Placa.Length == 7)
            {
                Console.WriteLine("Sim, possui 7");
                return true;
            }
            else
            {
                Console.WriteLine("Não possui 7");
                return false;
            }
        }

        public int RetornarNovaMatricula()
        {
            return matricula;
        }
    }
}
