using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.Abstract;

namespace Models
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome, int idade, string raca) : base(nome, idade)
        {
            Raca = raca;
        }
        private string _raca;
        public string Raca
        {
            get => _raca;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _raca = value;
                else
                    throw new Exception("Raca não pode ser vazio");
            }
        }

        public override string EmitirSom()
        {
            return "AU AU";
        }

        public override string Mover()
        {
            return "Correndo";
        }
    }
}