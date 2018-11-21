using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StWR
{
    class Program{   

        static void Main(string[] args) {
            
            //StreamWriter Fq = new StreamWriter();
        //string F = "Лунёва", I = "Яна", O = "Александровна";

        //StreamWriter F1 = new StreamWriter("proba.txt");
        //F1.WriteLine(F + " " + I + " " + O);
        //F1.Close();
            StreamReader FR = new StreamReader("proba.txt");
            while (!FR.EndOfStream) { 
            Console.WriteLine(FR.ReadLine());//endofstr смотрит конец 
            }
            FR.Close();
            
            Console.ReadKey();
         }
            
    }
}
