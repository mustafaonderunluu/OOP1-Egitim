﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class ProductManager
        //Operasyonlar Bulunur
    {
        //encapsulated
        public void Add(Product product)
        {

            Console.WriteLine(product.ProductName + "Eklendi"  );

        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName +"Güncellendi "  );
        }


        //public int Topla(int s1, int s2) { 
        
        
        //return s1 + s2;
        // }
        //public void  Topla2(int s1, int s2)
        //{

        //    Console.WriteLine(s1+s2);
        //}


    }
}
