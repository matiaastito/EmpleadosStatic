using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibEntidades
{
    public class Empleado
    {
        public Empleado()
        {
        }

        public Empleado(decimal Comision, int id, string nombre, string apellido)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            comision = Comision;

        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private static decimal comision = 0;

        public static decimal Comision
        {
            get { return comision; }
        }


    }
}
