using System;
using System.Collections.Generic;




namespace Bolillero.Core
{
    public class Bolillero 
    {
        private List<byte> Adentro {get; set;}
        private List<byte> Afuera {get; set;}
        private IAzar azar {get; set;}
        public Bolillero(IAzar Azar){

        
        Adentro =  new List<byte>();
        Afuera =  new List<byte>();
        Azar = azar;
        
        }
        public Bolillero( byte numero){



        }
        private byte CrearBolilla(byte bolillas){
            


        }
        public void ReIngresar()
        {
            Afuera.AddRange(Adentro);
            Afuera.Clear();


        }

        public byte SacarBolilla(){

        }
        public bool Jugar(List<byte> j ){

        }
        public long JugarN(){

        }






    
    }
}