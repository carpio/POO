using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using POO.CandyMachine;
using System.Data.SqlClient;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = "LAPTOP-M75PVFAN\\SQLEXPRESS";            
            var database = "ZOOS";
            var user = "zoouser_";
            var pass = "zoouser_";

            string command = "SELECT * FROM geo.T_Ciudades";

            SqlConnectionStringBuilder sqlbuilder = new SqlConnectionStringBuilder();
            //sqlbuilder.UserID = user;
            //sqlbuilder.Password = pass;
            sqlbuilder.IntegratedSecurity = true;
            sqlbuilder.InitialCatalog = database;
            sqlbuilder.DataSource = server;
            
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = sqlbuilder.ConnectionString;

            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

            try
            {
                Console.WriteLine("Try opening connection...");
                sqlConnection.Open();
                Console.WriteLine("Execute command...");
                sqlCommand.ExecuteNonQuery();
                var dataset = sqlCommand.ExecuteNonQuery();
                Console.WriteLine(dataset);
                sqlConnection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error...");
            }
            //Pulparindo pulparindo = new Pulparindo();
            //pulparindo.Name = "Pulparindo rojo";
            //pulparindo.Cost = 4.5;
            //var despachando = pulparindo.Despachar();

            //Console.WriteLine(despachando);

            //Mazapan mazapan = new Mazapan();
            //mazapan.Name = "Mazapan de la rosa";
            //mazapan.Weight = 300;
            //var despacharMazapan = mazapan.Despachar(1);
            //var despacharMazapan_ = mazapan.DespacharMazapan();

            //Console.WriteLine(despacharMazapan);
            //Console.WriteLine(despacharMazapan_);

            //Paleta paleta = new Paleta();
            //paleta.Name = "Paleta";

            //Console.WriteLine(paleta.Name);
            //Console.WriteLine(paleta.Despachando());
            //Console.WriteLine(paleta.Despachando(1));
            
            ////Find Prodcut from ProductList with Marca = Marca_11
            //var productMarca11 = listaProductos.Where(m => m.Marca == "Marca_11").FirstOrDefault();

            //Console.WriteLine(productMarca11.Marca);
            //Console.WriteLine(productMarca11.Code);

            //var productosContienen1 = listaProductos.Where(q => q.Name.Contains("1"));

            //foreach (var producto in productosContienen1)
            //{
            //    Console.WriteLine(producto.Code);
            //    Console.WriteLine(producto.Cost);
            //    Console.WriteLine(producto.Marca);
            //    Console.WriteLine(producto.Name);
            //}

            Console.ReadLine();
        }
    }
}
