using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace TPBolillero.Core
{
    public class Simulacion
    {
        //Atributo Bolillero,List jugadas, long cantidad
        public long SimularSinHilos(Bolillero copia, List<byte> jugadas, long cantidad )
        {
            return copia.JugarN(jugadas, cantidad);
        }

        public long SimularConHilos(Bolillero copia, List<byte> jugadas, long cantidad, long hilos)
        {
            Task<long>[] tareas = new Task<long>[hilos];
            
            for(long i = 0; i < cantidad; i ++ )
            {
                var clon = (Bolillero)copia.Clone();
                tareas[i] = Task.Run(() => SimularSinHilos(clon,jugadas,hilos));
            }
            var Division = hilos/cantidad;
            Task<long>.WaitAll(tareas);
            return tareas.Sum(x => x.Result);
        }
        public async Task<long> SimularConHilosAsync(Bolillero copia, List<byte> jugadas, long cantidad, long hilos)
        {
            Task<long>[] tareas = new Task<long>[hilos];
            
            for(long i = 0; i < cantidad; i ++ )
            {
                var clon = (Bolillero)copia.Clone();
                tareas[i] = Task.Run(() => SimularSinHilos(clon,jugadas,hilos));
            }
            var Division = hilos/cantidad;
            await Task<long>.WhenAll(tareas);
            return tareas.Sum(x => x.Result);
        }
        public async Task<long> SimularPararellAsync(Bolillero bolillero, List<byte> jugadas, long cantidadSimulacion, long  cantidadHilos)
        {
            long [] resultado = new long [cantidadSimulacion];
            await Task.Run( () =>
                Parallel.For(0,
                cantidadHilos,
                i =>
                { 
                    var clon = (Bolillero)bolillero.Clone();
                    resultado [i] = SimularSinHilos(clon,jugadas,cantidadSimulacion / cantidadHilos);
                }
                );
            );
            return resultado.Sum();
    }
}

    
            
    
