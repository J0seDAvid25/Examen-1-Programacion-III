using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_I_Programación_III_JDAV
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            DiagonalDifference df = new DiagonalDifference();
            string texto = "11  2  4| 4  5  6|10  8 -12 -";
            int aux = df.matrix(texto);

            //Se puede dividir por medio de comas o palabras


            Console.WriteLine("***********************************************");
            CamelCase cml = new CamelCase();
            string cadena = "estoEsUnaPruebaDeConsola";
            cml.Calculate(cadena);
            Console.ReadLine();          
           
        }

    }
}
