using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using POO.CandyMachine;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Machine maquina = new Machine(22);
            
            Console.WriteLine(maquina.Name);

            var listaProductos = maquina._productList;

            //Select from Product list, product with code = 4
            var productoCode4 = listaProductos.Where(s => s.Code == 4).FirstOrDefault();

            Console.WriteLine(productoCode4.Code);
            Console.WriteLine(productoCode4.Name);

            //Find Prodcut from ProductList with Marca = Marca_11
            var productMarca11 = listaProductos.Where(m => m.Marca == "Marca_11").FirstOrDefault();

            Console.WriteLine(productMarca11.Marca);
            Console.WriteLine(productMarca11.Code);

            var productosContienen1 = listaProductos.Where(q => q.Name.Contains("1"));

            foreach (var producto in productosContienen1)
            {
                Console.WriteLine(producto.Code);
                Console.WriteLine(producto.Cost);
                Console.WriteLine(producto.Marca);
                Console.WriteLine(producto.Name);
            }

            Console.ReadLine();
        }
    }
}
