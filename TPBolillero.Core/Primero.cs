using System;
using System.Collections.Generic;

namespace TPBolillero.Core
{
    public class Primero : IAzar
    {
        public byte SacarBolilla(List<byte> bol) => bol[0];
    }
}