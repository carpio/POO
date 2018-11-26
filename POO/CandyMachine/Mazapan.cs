using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.CandyMachine
{
    public class Mazapan : ProductAbstract
    {
        public override string DespacharMazapan()
        {
            return "Despachando Mazapan";
        }

        public override string Despachar(int x)
        {
            return "Método con x";
        }
    }
}
