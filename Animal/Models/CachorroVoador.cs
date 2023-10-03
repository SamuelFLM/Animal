using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.Abstract;

namespace Models
{
    public class CachorroVoador : Cachorro
    {
        public CachorroVoador(string nome, int idade, string raca, int asas) : base(nome, idade, raca)
        {
            Asas = asas;
        }
        private int _asas;
        public int Asas
        {
            get => _asas;
            set
            {
                if (value > 0)
                    _asas = value;
                else
                    throw new Exception("Asas não pode ser menor que zero.");
            }
        }

        public override string EmitirSom()
        {
           return "AU AU VOADOR";
        }

        public override string Mover()
        {
           return "VOANDO";
        }
    }
}