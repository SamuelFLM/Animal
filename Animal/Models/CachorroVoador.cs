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
                if (value > 0 && string.IsNullOrWhiteSpace(value.ToString()))
                    _asas = value;
                else
                    throw new Exception("Asas não pode ser menor que zero.");
            }
        }

        public override void EmitirSom()
        {
            Console.WriteLine("AU AU VOADOR");
        }

        public override void Mover()
        {
            Console.WriteLine("VOANDO.......");
        }
    }
}