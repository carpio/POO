using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.CandyMachine
{
    public class Product:CandyBase
    {
        //Get means it can be read and Set means it can be written
        public int Code { get; set; }        
        public decimal Cost { get; set; }
        public string Marca { get; set; }

        public Product CreateProduct()
        {
            Product productEjemplo = new Product();
            productEjemplo.Code = 11;
            productEjemplo.Cost = 33;
            productEjemplo.Marca = "De la Rosa";
            productEjemplo.Name = "Pulparindo";

            return productEjemplo;
        }

        public Product CreateProduct(string name)
        {
            Product productEjemplo = new Product();
            productEjemplo.Code = 22;
            productEjemplo.Cost = 44;
            productEjemplo.Marca = "De la Rosa";
            productEjemplo.Name = name;

            return productEjemplo;
        }

        public Product CreateProduct(int Code)
        {
            Product productoEjemplo = new Product();
            productoEjemplo.Name = StaticProduct.Name;
            productoEjemplo.Cost = StaticProduct.Cost;
            productoEjemplo.Code = 99;
            productoEjemplo.Marca = "Sabritas";

            return productoEjemplo;
        }
    }
}
