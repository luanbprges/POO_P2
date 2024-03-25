using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2
{
    internal abstract class Veiculo
    {
        //Atributos
        string placa;
        int ano;

        public string Placa { get => placa; set => placa = value; }
        public int Ano { get => ano; set => ano = value; }


        //Metodos
        public Veiculo(string _placa, int _ano)
        {
            placa = _placa;
            ano = _ano;
        }

        public abstract double Alugar();
    }
}
