using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Tuplas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo 6: Tuplas 

            var coordA = new Tuple<int, string, decimal, decimal>(
                                  1, "Nueva York", 40.71m, -74.00m);

            var coordB = Tuple.Create(2, "CDMX", 19.43m, -99.13m);

            Console.WriteLine($"Coordenadas de {coordB.Item2} " +
                            $"\n Latitud: {coordB.Item3}" +
                            $"\n Longitud: {coordB.Item4}");


            //TODO Tipo tupla
            int id;
            string ciudad;
            decimal lat;
            decimal lon;
            (id, ciudad, lat, lon) = (3, "Nueva York", 40.71m, -74.00m);
            Console.WriteLine($"Coordenadas de {ciudad} " +
                           $"\n Latitud: {lat}" +
                           $"\n Longitud: {lon}");


            //TODO Literal tupla
            var coordC = (3, "Nueva York", 40.71m, -74.00m);
            Console.WriteLine($"Coordenadas de {coordC.Item2} " +
                           $"\n Latitud: {coordC.Item3}" +
                           $"\n Longitud: {coordC.Item4}");

            var coordD = (Id: 3, Ciudad: "Nueva York", Lat: 40.71m, Lon: -74.00m);
            Console.WriteLine($"Coordenadas de {coordD.Ciudad} " +
                           $"\n Latitud: {coordD.Lat}" +
                           $"\n Longitud: {coordD.Lon}");

            Console.ReadLine();
        }
    }
}
