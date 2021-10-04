using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class Autos
    {
        public string color { get; set; }
        
        public string fabricante { get; set; }

        public string marca { get; set; }
        public string modelo { get; set; }
       
        public string aceleracion { get; set; }
        public Boolean word { get; set; }


        public string getinformacion()
        {
            var froms = "";
            if (word == true)
            {
                froms = " 6 velocidades ";
            }

            else
            {
                froms = " 8 velocidades ";
            }
            return "el auto cuenta con" + froms;


        }

     public string colores(string color)
        {

            return "el auto es de color " + color;
            
        }

       public string hg()
        {
            return "EL FABRICANTE ES :   " + fabricante;
        }
      
        public string aceleracion2()
        {
            return "ACELERACION DE 0 A 100km/h  : " + aceleracion+ " SEGUNDOS ";
        }



    }
}
