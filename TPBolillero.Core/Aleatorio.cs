using System;
using System.Collections.Generic;
using System.Linq;


namespace TPBolillero.Core
{
    class Aleatorio 
    {
        private Random r = new Random();
        
        public byte SacarBolilla(List<byte> bol)
        {
            int Cantidad = bol.Count;
            var Cbyte = Convert.ToByte( r.Next(0, bol.Count));
            return bol[Cbyte];
        }
        
    }
}


