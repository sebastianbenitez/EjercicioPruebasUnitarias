using System;
using Entidades;
using Xunit;

namespace Entidades.Tests
{
    public class MascotaTest
    {
        [Theory]
        [InlineData(true, false)]
        [InlineData(false, true)]
        public void Comer_EstaLlenoODormido_DeberiaFallar(bool dormido, bool lleno)
        {
            // Arrange
            var mascota = new Mascota { Dormido = dormido, Lleno = lleno };

            // Act

            // Assert
            Assert.Throws<Exception>(() => mascota.Comer());
        }

        [Fact]
        public void Comer_EstaDespiertoYNoEstaLLeno_DeberiaPasar()
        {
            // Arrange
            var mascota = new Mascota { Dormido = false, Lleno = false };

            // Act
            var resultado = mascota.Comer();

            // Assert
            Assert.Equal("Comiendo", resultado);
        }

        [Theory]
        [InlineData(false, false)]
        [InlineData(true, false)]
        public void IrAlBanio_NoEstaLLenoOEstaDormido_DeberiaFallar(bool dormido, bool lleno)
        {
            // Arrange
            var mascota = new Mascota { Dormido = dormido, Lleno = lleno };

            // Act

            // Assert
            Assert.Throws<Exception>(() => mascota.IrAlBanio());
        }

        [Fact]
        public void IrAlBanio_EstaLLenoYDespierto_DeberiaPasar()
        {
            // Arrange
            var mascota = new Mascota { Dormido = false, Lleno = true };

            // Act
            var resultado = mascota.IrAlBanio();

            // Assert
            Assert.Equal("Yendo al baño", resultado);
        }

        [Theory]
        [InlineData(false, false)]
        [InlineData(true, false)]
        public void Jugar_NoEstaLLenoOEstaDormido_DeberiaFallar(bool dormido, bool lleno)
        {
            // Arrange
            var mascota = new Mascota { Dormido = dormido, Lleno = lleno };

            // Act

            // Assert
            Assert.Throws<Exception>(() => mascota.Jugar());
        }

        [Fact]
        public void Jugar_EstaLLenoYDespierto_DeberiaPasar()
        {
            // Arrange
            var mascota = new Mascota { Dormido = false, Lleno = true };

            // Act
            var resultado = mascota.Jugar();

            // Assert
            Assert.Equal("Jugando", resultado);
        }

        [Fact]
        public void Dormir_YaEstaDormido_DeberiaFallar()
        {
            // Arrange
            var mascota = new Mascota { Dormido = true, Lleno = false };

            // Act

            // Assert
            Assert.Throws<Exception>(() => mascota.Dormir());
        }
        [Fact]
        public void Dormir_EstaDespierto_DeberiaPasar()
        {
            // Arrange
            var mascota = new Mascota { Dormido = false, Lleno = false };

            // Act
            var resultado = mascota.Dormir();

            // Assert
            Assert.Equal("Durmiendo", resultado);
        }
        [Fact]
        public void Despertarse_YaEstaDespierto_DeberiaFallar()
        {
            // Arrange
            var mascota = new Mascota { Dormido = false, Lleno = false };

            // Act

            // Assert
            Assert.Throws<Exception>(() => mascota.Despertarse());
        }
        [Fact]
        public void Despertarse_EstaDurmiendo_DeberiaPasar()
        {
            // Arrange
            var mascota = new Mascota { Dormido = true, Lleno = false };

            // Act
            var resultado = mascota.Despertarse();

            // Assert
            Assert.Equal("Despertando", resultado);
        }
    }
}
