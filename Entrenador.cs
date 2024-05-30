using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaInterfaz
{
    internal class Entrenador:Integrante
    {
        public int experiencia;

        public Entrenador(string nombre, string apellido, int edad, int experiencia) : base(nombre, apellido, edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.experiencia = experiencia;
        }
        public override void MostrarInfo()
        {
            Console.WriteLine("informacion del entrenador");
            Console.WriteLine("nombre: {0}\napellido: {1}\nedad: {2}\nexperiencia: {3} años \n", nombre, apellido, edad, experiencia);
        }

    }
}
