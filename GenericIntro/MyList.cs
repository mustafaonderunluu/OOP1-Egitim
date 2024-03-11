using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenericIntro
{
    public class MyList <T>
    {
        T[] ıtems;
        //constructor
        public MyList()
        {
            ıtems= new T[0];

        }
        public void Add(T ıtem)
        {
            T[] tempArray = ıtems;
        ıtems = new T[ıtems.Length+1];

        }

    }
}
