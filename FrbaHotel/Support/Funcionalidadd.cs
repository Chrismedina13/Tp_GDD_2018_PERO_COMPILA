using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Support
{
    class Funcionalidadd
    {
       
       public Funcionalidadd(string nombre1, String id1, bool p)
        {
            this.nombre = nombre1;
            this.id = id1;
            this.activado = p;
        }
        public String nombre { get; set; }
        public String id { get; set; }
        public Boolean activado { get; set; }

     
    }


    }

