using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.CandyMachine
{
    public class Product
    {
        //Get means it can be read and Set means it can be written
        public string Name { get; set; }        
        public double Cost { get; set; }
        public int Weight { get; set; }

        public virtual string Despachar()
        {
            return "Despachando";
        }

        public virtual string Despachar(int x)
        {
            return "x";                
        }
    }

    public abstract class ProductAbstract: Product
    {
        public abstract string DespacharMazapan();
    }

    public interface IProduct
    {
        string Despachando();
        string Despachando(int a);
    }

    public struct Prod
    {
        public decimal CostPulparindo;
        public int CostMazapan;
        public int CostPaleta;
    }
}
