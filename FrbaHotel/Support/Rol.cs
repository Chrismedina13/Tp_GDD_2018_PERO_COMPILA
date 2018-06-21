using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FrbaHotel.Support
{
    public class Rol
    {
        public String nombre { get; set;}
        public String id  {get;set;}
        public Boolean estaHabilitado {get;set;}

        public Rol(String nombre, String id, Boolean estaHab) {
            this.nombre = nombre;
            this.id = id;
            this.estaHabilitado = estaHab;
        }

    }
}
