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

        public CachorroVoador ConstrutorCachorroVoador(string nome, int idade, string raca, int asas)
        {
            CachorroVoador _cachorroVoador = new CachorroVoador(nome, idade, raca, asas);
            return _cachorroVoador;
        }

        [Fact]
        public void DeveSalvarOsDadosCorretamente()
        {
            var cachorro = Construtor("Doguinho", 2, "Alemão");

            Assert.Equal("Doguinho", cachorro.Nome);
            Assert.Equal("Alemão", cachorro.Raca);
        }

        [Fact]
        public void DeveRetornarExceptionAoTentaSalvarONome()
        {
            Assert.Throws<Exception>(() =>
            Construtor("", 0, "raca"));
        }

        [Fact(DisplayName = "Exception DoguinhoVoador")]
        public void DeveRetornarExceptionAoTentarSalvarAsas()
        {
            Assert.Throws<Exception>(() =>
            ConstrutorCachorroVoador("doguinho", 1, "pet", -1));
        }

        [Fact(DisplayName = "Doguinho Voando")]
        public void DeveRetornarDoguinhoVoando()
        {
            // Given
            var cachorroVoador = ConstrutorCachorroVoador("doguinho", 1, "pet", 1);
            // When
            string mover = cachorroVoador.Mover();

            // Then
            Assert.Equal("VOANDO", mover);
        }

        [Fact(DisplayName = "Doguinho Terrestre")]
        public void DeveRetornarDoguinhoMovendo()
        {
            // Given
            var cachorro = Construtor("doguinho", 1, "pet");
            // When
            string mover = cachorro.Mover();
            // Then
            Assert.Equal("Correndo", mover);
        }

        [Fact]
        public void DeveTestarSomDoCachorroTerrestre()
        {
            // Given
            var cachorro = Construtor("doguinho", 1, "pet");
            // When
            string som = cachorro.EmitirSom();
            // Then
            Assert.False("AU AU" == "Au");
            Assert.Equal("AU AU", som);
        }
        [Fact]
        public void DeveTestarSomDoCachorroVoador()
        {
            // Given
            var cachorro = ConstrutorCachorroVoador("doguinho", 1, "pet", 2);
            // When
            string som = cachorro.EmitirSom();
            // Then
            Assert.Equal("AU AU VOADOR", som);
        }
    }
}