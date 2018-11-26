using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.CandyMachine
{
    public class Paleta : Product, IProduct
    {
        public string Despachando()
        {
            return "Despachando paleta";
        }

        public string Despachando(int a)
        {
            return "Despachando con X";
        }
    }
}
