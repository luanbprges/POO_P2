using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2
{
    internal class Onibus : Veiculo
    {
        //Atributos
        int assentos;

        public int Assentos { get => assentos; set => assentos = value; }


        //Metodos
        public Onibus(string _placa, int _ano, int _assentos):base(_placa, _ano)
        {
            assentos = _assentos;
        }

        public override double Alugar()
        {
            double diaria;
            int anoAtual = 2024;

            diaria = (30 * Assentos) - (anoAtual - Ano) * 70;

            return diaria;
        }
    }
}
