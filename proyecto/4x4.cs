using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class _4x4 : Autos
    {

        public int m1 { get; set; }
        public int m2 { get; set; }

        public string marcha { get; set; }
        public string f3()
        {
            return "Jeep Wrangler";
        }
        public string f4()
        {
            return "Volkswagen Touareg";
        }


        public string op()
        {
            return "NUMERO  " + m1 + " M " + m2 + "  CORTAS ";
        }

        public string po()
        {
            return "METER   " + marcha + " MARCHA";
        }
    }
}
