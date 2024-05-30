using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaInterfaz
{
    internal class Administrativo:Integrante
    {
        public string profesion;
        public string puesto;

        public Administrativo(string nombre,string apellido,int edad,string profesion,string puesto):base(nombre,apellido,edad)
        {
          
            this.profesion = profesion;
            this.puesto = puesto;
        }
        public override void MostrarInfo()
        {
            Console.WriteLine("mostrar informacion del administrador");
        }

    }
}
