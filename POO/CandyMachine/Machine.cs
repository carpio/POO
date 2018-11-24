using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.CandyMachine;

namespace POO.CandyMachine
{
    public class Machine:CandyBase
    {
        public string Size { get; set; }
        public IList<Product> _productList { get; set; }
        
        public Machine()
        {
            Name = "Mi máquina de dulces";
            Size = "2m";
            _productList = new List<Product>();
            _productList = CreateProducts(40);
        }

        public Machine(int numberOfProducts)
        {
            Name = "Mi máquina de dulces";
            Size = "2m";
            _productList = new List<Product>();
            _productList = CreateProducts(numberOfProducts);
        }
        
        //Public is the access type
        //IList<Product> is what it will return
        //CreateProducts is Method name
        //(int numberOfProducts) is the parameter that method needs
        public IList<Product> CreateProducts(int numberOfProducts)
        {
            IList<Product> listaProductos = new List<Product>();

            for(int i = 0; i < numberOfProducts; i++)
            {
                Product product = new Product();
                product.Code = i;
                product.Cost = i + 10;
                product.Marca = "Marca_" + i;
                product.Name = "Nombre_" + i;
                listaProductos.Add(product);
            }

            return listaProductos;
        }
    }
}
