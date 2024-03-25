using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Prova2
{
    internal class Caminhao : Veiculo
    {
        //Atributos
        int eixos;

        public int Eixos { get => eixos; set => eixos = value; }


        //Metodos
        public Caminhao(string _placa, int _ano, int _eixos) : base(_placa, _ano)
        {
            eixos = _eixos;
        }


        public override double Alugar()
        {
            double diaria;
            int anoAtual = 2024;

            diaria = (300 * Eixos) - (anoAtual - Ano) * 50;

            return diaria;
        }
    }
}
