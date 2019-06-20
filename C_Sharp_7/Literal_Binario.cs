using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_7
{
    class Literal_Binario
    {
        static void Main(string[] args)
        {
            //Ejemplo 1: Literal binario y separadores
            int numA = 1_001; //1,001
            int[] arrA = { 1, 2, 3, 4, 5 };
            int numB = 0x3E9;

            int numBin = 0b1111101001;
            int numBinB = 0b11_1110_1001;
            int[] arrBin = { 0b1, 0b1_0, 0b1__1, 0b1_00, 0b1__01 };
        }
    }
}
