using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StWR
{
    class Program{

        struct Abiturient {

           public string fio;
           public string podgotovka;
           public string bithday;
        
        }
        

        static void Main(string[] args) {
            Abiturient A1 = new Abiturient();

            A1.fio = "Лунева Яна Александровна";
            A1.podgotovka = "Прикладная инф";
            A1.bithday = "02.02.1993";
            //StreamWriter Fq = new StreamWriter();
        //string F = "Лунёва", I = "Яна", O = "Александровна";

        //StreamWriter F1 = new StreamWriter("proba.txt");
        //F1.WriteLine(F + " " + I + " " + O);
        //F1.Close();
            //StreamReader FR = new StreamReader("proba.txt");
            //while (!FR.EndOfStream) { 
            //Console.WriteLine(FR.ReadLine());//endofstr смотрит конец 
            //}
            //FR.Close();



            StreamWriter F1 = new StreamWriter("proba.txt");
            F1.WriteLine(A1.fio + " " + A1.podgotovka + " " + A1.bithday);
            F1.Close();
            Console.ReadKey();
         }
            
    }
}

//StreamWriter Fq = new StreamWriter();
            //string F = "Лунёва", I = "Яна", O = "Александровна";
