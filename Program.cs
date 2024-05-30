using System.Threading.Channels;

namespace practicaInterfaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Integrante[] personas = new Integrante[3];
            //personas[0] = new Jugador("juan", "la terra", 32, 10, "1 division");
            //personas[2] = new Jugador("mario", "kempes", 22, 30, "1 division");
            //personas[1] = new Entrenador("jose", "armando",40,7);



            //MostrarJugadores(personas);
            //MostrarEntrenadores(personas);
            //personas[1].GetNombre();
            //personas[1].SetNombre("kevin");
            //MostrarEntrenadores(personas);
            
            //***** cambie el array del comienzo por una lista para poder usar un while y decidir cuando parar.


            List<Integrante> integrantes = new List<Integrante>();
            
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("ingrese una opcion");
                Console.WriteLine(" 1-agregar jugador \n 2-agregar entrenador \n 3-ver reporte de jugadores \n 4-ver reporte de entrenadores \n 5-salir");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        bool agregarJugador = true;
                        while (agregarJugador)
                        {

                        Console.WriteLine("carga de datos del jugador");
                        Console.WriteLine("ingresar nombre");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("ingresar apellido");
                        string apellido = Console.ReadLine();
                        Console.WriteLine("ingresar edad");
                        int edad = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingresar nro de posicion");
                        int posicion = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingresar la categoria");
                        string categoria = Console.ReadLine();

                        integrantes.Add(new Jugador(nombre, apellido, edad, posicion, categoria));

                            Console.WriteLine("queres agregar otro jugador? s/n");
                            string resp= Console.ReadLine();
                            
                            if(resp != "s" )
                            {
                                agregarJugador= false;
                            }
                        }
                        break;

                    case 2:
                        bool agregarEntrenador = true;
                        while (agregarEntrenador)
                        {

                        Console.WriteLine("carga de datos del entrenador");
                        Console.WriteLine("ingresar nombre");
                        string nombreE= Console.ReadLine();
                        Console.WriteLine("ingresar apellido");
                        string apellidoE = Console.ReadLine();
                        Console.WriteLine("ingresar edad");
                        int edadE = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingresar años de experiencia");
                        int expE = int.Parse(Console.ReadLine());

                        integrantes.Add(new Entrenador(nombreE, apellidoE, edadE, expE));

                            Console.WriteLine("agregar otro entrenador? s/n");
                            string resp = Console.ReadLine();
                            if(resp != "s")
                            {
                                agregarEntrenador= false;
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("mostrando reporte");
                        foreach (var item in integrantes)
                        {
                            if( item is Jugador jugador)
                            {
                                jugador.MostrarInfo();
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("reporte de entrenadores");
                        foreach (var item in integrantes)
                        {
                            if(item is Entrenador entrenador)
                            {
                                entrenador.MostrarInfo();
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("saliendo");
                        continuar = false;
                        break;
                }
            }
        
        }
        static void MostrarJugadores(Integrante[] personas)
        {
            foreach (var item in personas)
            {
                if(item is Jugador jugador)
                {
                    jugador.MostrarInfo();
                }
            }
        }

        static void MostrarEntrenadores(Integrante[] personas)
        {
            foreach( var item in personas)
            {
                if( item is Entrenador entrenador)
                {
                    entrenador.MostrarInfo();
                }
            }
        }
    }
}