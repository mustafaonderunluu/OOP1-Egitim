using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Array 

            //string[] isimler = new string[] {"Engin","Murat","Kerem","Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            
            ////Ekleme yapamazsınız 
            //isimler[4] = "Mehmet";
            //Console.WriteLine(isimler[4]);


            List<string> isimler2 = new List<string>();
            isimler2.Add("Engin");

            List<string> isimler3 = new List<string> {"murat","Kerem","Halil" };
            Console.WriteLine(isimler3[0]);
            Console.WriteLine(isimler3[1]);
            Console.WriteLine(isimler3[2]);
            isimler3.Add("ilker");
            Console.WriteLine(isimler3[3]);
            Console.ReadKey();

        }
    }
}
 