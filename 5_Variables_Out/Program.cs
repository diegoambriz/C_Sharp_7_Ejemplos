using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Variables_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo 4: Variables out
            //antes
            // int miNum;
            //Cambiar(out miNum);
            //C#7
            Cambiar(out int miNum);
            Console.WriteLine($"Valor de miNum después de Cambiar(): {miNum}");

            Console.ReadKey();
        }

        #region Funciones
        static void Cambiar(out int x)
        {
            x = 100;
        }
        #endregion
    }
}
