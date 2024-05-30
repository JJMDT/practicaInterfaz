using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaInterfaz
{
    internal class Jugador:Integrante,IIntegrante
    {
        public int posicion;
        public string categoria;

        public Jugador(string nombre,string apellido,int edad, int posicion, string categoria) : base(nombre, apellido, edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.posicion = posicion;
            this.categoria = categoria;
        }

       
        public override void MostrarInfo()
        {
            Console.WriteLine("informacion del jugador");
            Console.WriteLine("nombre: {0}\napellido: {1}\nedad: {2}\nposicion: {3}\ncategoria: {4}\n",nombre,apellido,edad,posicion,categoria) ;
        }
        
      
    }
}
