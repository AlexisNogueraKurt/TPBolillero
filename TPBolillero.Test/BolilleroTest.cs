using System;
using Xunit;
using TPBolillero.Core;
using System.Collections.Generic;
using System.Linq;


namespace TPBolillero.Test
{ 
    public class BolilleroTest
    {
        public Bolillero bol {get ; set;}
        public BolilleroTest()
        {
            bol = new Bolillero(10);
            bol.Azar = new Primero();
        }
        [Fact]
        public void SacarBolilla()
        {
            Assert.Equal(0,bol.SacarBolilla());
            Assert.Equal(9,bol.Adentro.Count);
            Assert.Equal(1,bol.Afuera.Count);
        }

        [Fact]
        public void ReIngresar()
        {
            bol.SacarBolilla();
            bol.ReIngresar();
            Assert.Equal(10,bol.Adentro.Count);
            Assert.Equal(0,bol.Afuera.Count);
        }

        [Fact]
        public void JugarGana()
        {
            List<byte> juego = new List<byte>{0,1,2,3};
            Assert.True(bol.Jugar(juego));
        }
        [Fact]
        public void JugarPierde()
        {
            List<byte> juego = new List<byte>{4,2,1};
            Assert.False(bol.Jugar(juego));
        }
        [Fact]
        public void GanarN()
        {
            List<byte> juego = new List<byte>{0,1};
            Assert.Equal(1,bol.JugarN(juego,1));
        }
    }
}
