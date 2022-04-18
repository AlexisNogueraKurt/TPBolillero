using System;
using System.Collections.Generic;




namespace Bolillero.Core
{
    public class Bolillero 
    {
        private List<byte> Adentro {get; set;}
        private List<byte> Afuera {get; set;}
        private IAzar Azar {get; set;}
        public Bolillero(IAzar azar){

        
        Adentro =  new List<byte>();
        Afuera =  new List<byte>();
        azar = Azar;
        
        }
        public Bolillero( IAzar Azar,byte numeros) 
        => CrearBolilla(numeros);
        
        private byte CrearBolilla(byte bolillas){
            
        return bolillas;

        }
        public void ReIngresar()
        {
            Afuera.AddRange(Adentro);
            Afuera.Clear();
        }

        public byte SacarBolilla(){
            var bol = Azar.SacarBolilla(Adentro);
            Adentro.Add(bol);
            Afuera.Remove(bol);
            return bol;

        }
        public bool Jugar(List<byte> j ) => j.Count();
        public long JugarN(){

        }






    
    }
}