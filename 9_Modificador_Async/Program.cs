using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Modificador_Async
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo 8: Modificador Async

            Console.WriteLine("Ingresa texto");
            while (true)
            {
                //TareaAsync();
                string texto = Console.ReadLine();
                Console.WriteLine("Ingresaste: " + texto);
                var total = TareaAsync();
            }
        }

        static async ValueTask<int> TareaAsync()
        {
            int total = await Task.Run(() => Contar());
            Console.WriteLine("Total: " + total);
            return total;
        }

        static int Contar()
        {
            int cont = 0;
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 1000000; j++)
                {
                    string val = j.ToString();
                    if (val == null)
                    {
                        return 0;
                    }
                    cont += val.Length;
                }
            }
            return cont;
        }
    }
}
