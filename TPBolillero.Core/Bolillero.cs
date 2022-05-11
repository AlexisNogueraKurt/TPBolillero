using System;
using System.Collections.Generic;

namespace TPBolillero.Core
{
    public class Bolillero : ICloneable
    {
        public List<byte> Adentro {get; set;}
        public List<byte> Afuera {get; set;}
        public IAzar Azar {get; set;}
        
        public Bolillero(){}
        private Bolillero(Bolillero original)
        {
            Adentro = new List<byte>(original.Adentro);
            Afuera = new List<byte>(original.Afuera);
        }

        public Bolillero(byte bol) 
            => CrearBolillas(bol);
            
        private void CrearBolillas(byte numero)
        {
            Adentro = new List<byte>();
            Afuera = new List<byte>();
            for (byte bol = 0; bol < numero; bol ++)
            {
                Adentro.Add(bol);
            } 
        }
        public void ReIngresar()
        {
            Adentro.AddRange(Afuera);
            Afuera.Clear();
        }
        public byte SacarBolilla()
        {
            byte bol = Azar.SacarBolilla(Adentro);
            Adentro.Remove(bol);
            Afuera.Add(bol);
            return bol;
        }
        public bool Jugar( List<byte> bol )
            => bol.TrueForAll(b => b == SacarBolilla());

        public long JugarN(List<byte> jugada, long cantidad)
        {
            long Contador = 0;

            for (int i = 0; i < cantidad ; i ++)
            {
                ReIngresar();

                if(Jugar(jugada))
                {
                    Contador ++;
                }
            }
            return Contador;
        }

        public object Clone()
        {
            //this hace referencia al objeto que estás usando en le momento en tu código,
            return new Bolillero(this);
        }
    }
}