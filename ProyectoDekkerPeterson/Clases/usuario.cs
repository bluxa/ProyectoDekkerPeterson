using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDekkerPeterson.Clases
{
    public class usuario
    {
        string nombre;
        string apellido;
        int edad;
        int telefono;

        public usuario(string nombre, string apellido, int edad, int telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.telefono = telefono;
        }

        public usuario()
        {
        }
    }
}
