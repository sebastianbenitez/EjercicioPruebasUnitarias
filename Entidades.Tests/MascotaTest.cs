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
        public void Comer_EstaDormidoOLleno_DeberiaFallar(bool dormido, bool lleno)
        {
            // Arrange
            var mascota = new Mascota { Dormido = dormido, Lleno = lleno };

            // Act

            // Assert
            Assert.Throws<Exception>(() => mascota.Comer());
        }

        [Fact]
        public void Comer_NoEstaLLenoNiDormido_DeberiaPasar()
        {
            // Arrange
            var mascota = new Mascota { Dormido = false, Lleno = false };

            // Act
            var resultado = mascota.Comer();

            // Assert
            Assert.Equal("Comiendo", resultado);
        }
    }
}
