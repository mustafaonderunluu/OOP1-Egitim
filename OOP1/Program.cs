using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 2 Farklı şekilde de eklenebilir.

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnıtPrice = 500;
            product1.UnıtPriceStock = 3;

            Product product2 = new Product {CategoryId=5,Id=2,ProductName="Kalem",
            UnıtPrice=50,UnıtPriceStock=5
                    
            };
            //Pascal Case = ilk harf büyük //Camel Case = ilk harf küçük sonrası büyük.
            //Case Sensitive 
            ProductManager productManager1 = new ProductManager();
            productManager1.Add(product1); //ilk başta eklenicek ama ne eklenicek ? ProductManager' dakiler.

            //Metotlar

            //productManager1.Topla2(3, 6);  //void git yap bitir

            //int ToplamaSonucu = productManager1.Topla(3, 6); //return
            //Console.WriteLine(ToplamaSonucu*2);

           







        }
    }
}
