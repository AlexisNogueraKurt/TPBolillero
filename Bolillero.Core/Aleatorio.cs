﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace Bolillero.Core
{
    class Aleatorio 
    {
        private Random r = new Random();
        
        public byte SacarBolilla(List<byte> bol)
        {
            var Cbyte = Convert.ToByte( r.Next(0, bol.Count));
            return bol[Cbyte];
        }
        
    }
}


