using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.CandyMachine
{
    public class Pulparindo:Product
    {

        public string Flavor { get; set; }

        public override string Despachar()
        {
            return "Despachando Pulparindo";
        }

        public override string Despachar(int x)
        {
            return "x = 10";
        }
    }
}
