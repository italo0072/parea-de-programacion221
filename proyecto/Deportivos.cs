using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class Deportivos : Autos
    {
        public int silindros { get; set; }

        public string kl()
        {
            return "Mazda MX-5";
        }
        public string k3()
        {
            return "Porsche 911";
        }
        public string kk2()
        {
            return "Alpine A110";
        }

       public string silindro2()
        {
            return "NUMERO " + silindros + "  SILINDROS";
        }
    }
}
