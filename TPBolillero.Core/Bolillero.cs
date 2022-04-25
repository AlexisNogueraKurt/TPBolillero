using System;
using System.Collections.Generic;

namespace TPBolillero.Core
{
    public class Bolillero 
    {
        public List<byte> Adentro {get; set;}
        public List<byte> Afuera {get; set;}
        public IAzar Azar {get; set;}
        public Bolillero(){}

        public Bolillero(IAzar azar)
        {
        Adentro =  new List<byte>();
        Afuera =  new List<byte>();
        azar = Azar; 
        }
        public Bolillero( IAzar Azar,byte numeros) 
            => CrearBolillas(numeros);
            
        private void CrearBolillas(byte numeros)
        {
            for (byte i = 0; i < numeros; i ++)
            Adentro.Add(i);
        }
        public void ReIngresar()
        {
            Afuera.AddRange(Adentro);
            Afuera.Clear();
        }
        public byte SacarBolilla()
        {
            var bol = Azar.SacarBolilla(Adentro);
            Adentro.Add(bol);
            Afuera.Remove(bol);
            return bol;
        }
        public bool Jugar( List<byte> bol )
            => bol.TrueForAll(b => b == SacarBolilla());
        public long JugarN(List<byte> jugada, int cantidad)
        {
            long Contador = 0;

            for (int i = 0; i < cantidad ; i ++)
            {
                if(Jugar(jugada))
                {
                    Contador ++;
                }
            }
            return Contador;
        }
    
    }
}