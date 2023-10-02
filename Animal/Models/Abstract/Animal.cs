using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.Interfaces;

namespace Models.Abstract
{
    public abstract class Animal : IAnimal
    {
        public Animal() { }
        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;

        }
        private string _nome;
        public string Nome
        {
            get => _nome;
            set
            {
                if (value != "")
                    _nome = value;
                else
                    throw new NullReferenceException("Nome não pode ser vazio.");
            }
        }
        private int _idade;
        public int Idade
        {
            get => _idade;
            set
            {
                if (value > 0)
                    _idade = value;
                else
                    throw new Exception("Idade não pode ser menor que zero.");
            }
        }

        public abstract void EmitirSom();
        public abstract void Mover();
    }
}