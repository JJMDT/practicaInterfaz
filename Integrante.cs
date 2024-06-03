using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaInterfaz
{
    abstract class Integrante:IIntegrante
    {
        public string? nombre;
        public string? apellido;
        public int edad;

        public Integrante(string nombre, string apellido,int edad) { }

        public string GetNombre()
        {
            Console.WriteLine("{0} {1}",nombre,apellido);
            return nombre;
        }

        public abstract void MostrarInfo();
        

        public void SetNombre(string nuevoNombre)
        {
            nombre = nuevoNombre;
            Console.WriteLine("se cambio el nombre por {0}",nombre);
        }
    }
}
