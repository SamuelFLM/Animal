using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using Xunit;

namespace Tests.Animals
{
    public class CachorroTests
    {

        public Cachorro Construtor(string nome, int idade, string raca)
        {
            Cachorro _cachorro = new Cachorro(nome, idade, raca);
            return _cachorro;
        }

        [Theory]
        [InlineData("Doguinho", 2, "Alemão")]
        public void DeveSalvarOsDadosCorretamente(string nome, int idade, string raca)
        {
            var cachorro = Construtor(nome, idade, raca);

            Assert.Equal("Doguinho", cachorro.Nome);
            Assert.Equal("Alemão", cachorro.Raca);
        }

        [Fact]
        public void DeveRetornarExceptionAoTentaSalvarONome()
        {
            Assert.Throws<Exception>(() =>
            Construtor("", 0, "raca"));
        }

    }
}