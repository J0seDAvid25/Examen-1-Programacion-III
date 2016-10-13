using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_I_Programación_III_JDAV
{
    public class DiagonalDifference
    {
        public int matrix(string texto)
        {
            //variables
            int sumadgl1 = 0;
            int sumadgl2 = 0;
            int diferenciadiagonales = 0;
            char[] delimitadores = { '|', '/', ',', '.', ':', '\t' };//delimitadores integrados
            Console.WriteLine("Original :'{0}'", texto); // impresion del texto que se recibe
            string[] palabras = texto.Split(delimitadores); //iniciacion  y separacion del texto en el arreglo
            Console.WriteLine("caracteres en el texto:", palabras.Length);  //impresion
            foreach (string ax in palabras) //recorre string en el arreglo palabras
            {
                Console.WriteLine(ax);    //impresion de auxiliar

            }
            for (int i = 0; i < palabras.Length; i++)//recorre arreglo 
            {
                for (int j = 0; j < palabras.Length; j++) 
                {
                    if ((palabras.Length) == (i + j + 1))//compara arreglo con fila y column
                    {
                        sumadgl2 += palabras[i][j]; //
                    }
                    else
                    {
                        sumadgl1 += palabras[i][j];
                    }
                }
            }
            //impresiones
            diferenciadiagonales = sumadgl1 - sumadgl2;
            int valor = 0;
            valor = diferenciadiagonales;
            
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("La suma de la primera diagonal es: " + sumadgl1);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("La suma de la segunda diagonal es: " + sumadgl2);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("La diferencia entre las diagonales es: " + diferenciadiagonales);
            Console.WriteLine("***********************************************");
            Console.WriteLine("Presione nuevamente para avanzar.");//finalizacion
            Console.ReadKey();

            return diferenciadiagonales;
        }


    }


}

