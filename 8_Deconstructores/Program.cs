using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Deconstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo 7: Deconstructores
            /*
            var coords = ArmarTupla();
            Console.WriteLine($"Coordenadas de {coords.ciudad} " +
                           $"\n Latitud: {coords.lat}" +
                           $"\n Longitud: {coords.lon}");
                           */
            (int id, string ciudad, decimal lat, decimal lon) = ArmarTupla();
            Console.WriteLine($"Coordenadas de {ciudad} " +
                           $"\n Latitud: {lat}" +
                           $"\n Longitud: {lon}");

            Console.ReadLine();
        }

        static public (int id, string ciudad, decimal lat, decimal lon) ArmarTupla() //A
        {
            //traer info de la BD y asignarla a la tupla
            int id = 2;
            string ciudad = "CDMX";
            decimal lat = 19.43m;
            decimal lon = -74.00m;

            return (id, ciudad, lat, lon);
        }
    }
}
