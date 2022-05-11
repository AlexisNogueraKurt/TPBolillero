using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace TPBolillero.Core
{
    public class Simulacion
    {
        //Atributo Bolillero,List jugadas, lomg cantidad
        public long SimularSinHilos(Bolillero copia, List<byte> jugadas, long cantidad )
        {
            return copia.JugarN(jugadas, cantidad);
        }

        public long SimularConHilos(Bolillero copia, List<byte> jugadas, long cantidad, long hilos)
        {
            Task<long>[] tareas = new Task<long>[hilos];
            
            for(long i = 0; i < cantidad; i ++ )
            {
                copia.Clone();
                

            }
        
            
            return tareas.Sum(x => x.Result);

        
        }
    }
}