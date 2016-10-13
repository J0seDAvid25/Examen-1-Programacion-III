using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_I_Programación_III_JDAV
{
    public class CamelCase
    { public string Calculate(string cadena)
        { string dato= " ";

           
            int cont;
            char[] delimitadores = { '|',/*'Aa-zA-Z' ,*/ '/', ',', '.', ':', ';' };//delimitadores integrados
            
            Console.WriteLine("Original :'{0}'", cadena.Length); // impresion del texto que se recibe
            string[] palabras = cadena.Split(delimitadores); //iniciacion  y separacion del texto en el arreglo
            for (int i = 0; i < palabras.Length; i++)
            {
                cadena.Split(delimitadores);
            }
            Console.WriteLine("{0} palabras  en el  texto:", palabras.Length);  //impresion
            foreach (string clc in palabras)
            {
                Console.WriteLine(clc);
            }
            Console.Write("-------------------------------------------------------");

            return dato;
                
            Console.ReadKey();
           
            //
    }
        
    }
    
}
