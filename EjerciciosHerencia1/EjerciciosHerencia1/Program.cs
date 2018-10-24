using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosHerencia1
   // 1.-Realiza la implementación de la siguiente jerarquía de clases.Añade constructores en todas las clases,
   //así como método mostrarDatos()/* En SeleccionFutbol*/

{
    class Program
    {
        static void Main(string[] args)
        {
            SeleccionFutbol s1 = new SeleccionFutbol();// hay que instanciar la clase selecciónfutbol para  
                                                       // poder acceder a sus métodos
            List<Futbolista> listaFutbolistas = new List<Futbolista>();
            List<Entrenador> listaEntrenadores = new List<Entrenador>();
            List<Masajista> listaMasajistas = new List<Masajista>();
            Futbolista f1 = new Futbolista(001," Marco ","Van Vasten ",28,9," defensa");
            Futbolista f2 = new Futbolista(002, " Michel ", "Platini ", 30, 6, " delantero");
            Futbolista f3 = new Futbolista(003, " Ruud ", "Gullit ", 19, 11, " extremo");
            Futbolista f4 = new Futbolista(004, " Lothar ", "Matthäus ", 31, 5, " centrocampista");
            listaFutbolistas.Add(f1);
            listaFutbolistas.Add(f2);
            listaFutbolistas.Add(f3);
            listaFutbolistas.Add(f4);

            foreach (Futbolista f in listaFutbolistas)
            {
                Console.WriteLine("Futbolistas: " +f.MostrarDatos());
            }
            Console.WriteLine();
            Entrenador e1 = new Entrenador(101," Michael ","Laudrup ",40," E101");
            listaEntrenadores.Add(e1);
            foreach (Entrenador e in listaEntrenadores)
            {
                Console.WriteLine("Entrenador: "+e.MostrarDatos());
            }
            Console.WriteLine();

            Masajista m1 = new Masajista(201, " Paco ", "Torres ", 28," Fisioterapeuta ",20 );
            Masajista m2 = new Masajista(202, " Pepe ", "Castillo ", 30,  " Fisioterapeuta ",15);
            listaMasajistas.Add(m1);
            listaMasajistas.Add(m2);
            foreach (Masajista m in listaMasajistas)
            {
                Console.WriteLine("Masajistas: "+m.MostrarDatos());
            }
            Console.WriteLine();

            Console.WriteLine("La selección de fútbol está formada por: " +s1.GetNumeroIntegrantes()+" integrantes");
            Console.WriteLine("-----------------------------------------------");

        //4.-Se va a celebrar un partido en Londres, por lo que todos deberán realizar las siguientes operaciones:
//           Ø Viajar
//          Ø Concentrarse
//          Ø Una vez que han llegado al destino cada uno deberá hacer su tarea,
//              o   si es futbolista à Entrenar
//              o   si es entrenador à Dirigir entrenamiento
//              o si es masajista à dar masajes

            foreach(Futbolista f in listaFutbolistas)
            {
                f.Viajar();
                Console.WriteLine("El futbolista " + f.GetNombre() + f.GetApellidos() + " viaja");
                f.Concentrarse();
                Console.WriteLine("El futbolista " + f.GetNombre() + f.GetApellidos() + " se concentra");
                f.Entrenar();
                Console.WriteLine("El futbolista " + f.GetNombre() + f.GetApellidos() + " entrena");
                Console.WriteLine("*******************************************");
            }
            foreach (Entrenador e in listaEntrenadores)
            {
                e.Viajar();
                Console.WriteLine("El entrenador " + e.GetNombre() + e.GetApellidos() + " viaja");
                e.Concentrarse();
                Console.WriteLine("El entrenador " + e.GetNombre() + e.GetApellidos() + " se concentra");
                e.DirigirEntrenamiento();
                Console.WriteLine("El entrenador " + e.GetNombre() + e.GetApellidos() + " dirige el entrenamiento");
                Console.WriteLine("*******************************************");
            }
            foreach (Masajista m in listaMasajistas)
            {
                m.Viajar();
                Console.WriteLine("El masajista " + m.GetNombre() + m.GetApellidos() + " viaja");
                m.Concentrarse();
                Console.WriteLine("El masajista " + m.GetNombre() + m.GetApellidos() + " se concentra");
                m.DarMasaje();
                Console.WriteLine("El masajista " + m.GetNombre() + m.GetApellidos() + " da masajes");
                Console.WriteLine("*******************************************");
            }


            List<SeleccionFutbol> listaParticipantesSeleccion = new List<SeleccionFutbol>()//lleno la lista
            {
                f1, f2,f3,f4,e1,m1,m2
            };
            //lp1.AinadirJugador(f1);
            //lp1.AinadirJugador(f2);
            //lp1.AinadirJugador(f3);
            
            //a) MostrarDatosSelección(): Muestra el nombre del país, el número de integrantes y sus datos.

            SeleccionPais seleccionados = new SeleccionPais("Europa", listaParticipantesSeleccion);
            seleccionados.MostrarDatosSelección();
            //b)boolean AltaSeleccion ( ) Permite si hay hueco , dar de alta a un nuevo integrante y 
            //contabilizarlo (El tope de participantes son 30. El máximo de masajistas son 4 y entrenadores 2)
            seleccionados.AltaSeleccion(new Futbolista(8," ppppp "," ooooo ",19,25," ffff "));
            seleccionados.AltaSeleccion(new Entrenador(25,"Entrenador "," martinez ",54," Federación "));
            seleccionados.AltaSeleccion(new Entrenador(69, "Entrenador2 ", " ooooo ", 25, " ffff "));
            //seleccionados.AltaSeleccion(new Entrenador(69, "Entrenador3 ", " ooooo ", 25, " ffff "));

            seleccionados.MostrarDatosSelección();
            Console.WriteLine();

            seleccionados.BajaSeleccion();
            Console.WriteLine();
            seleccionados.MostrarDatosSelección();

            //3.- Realiza una aplicación mediante un menú con las siguientes opciones:
            //1.Alta participante
            //2.Baja participante
            //3.Mostrar Selección Mostrar datos de participantes y número de  Entrenadores,
            //Masajistas y   Futbolistas
            // 4.Preparar partido
            // 5.Jugar partido
            // 6.Salir


            Console.ReadKey();
        }

        public static  void Menu()
        {
            const int ALTA = 1, BAJA = 2, MOSTRAR = 3, PREP = 4, JUGAR = 5, SALIR = 6;
            int option;

            Console.WriteLine("Menú Aplicación");
            Console.WriteLine("1.Alta participante");
            Console.WriteLine("2.Baja participante");
            Console.WriteLine("3.Mostrar Selección");
            Console.WriteLine("4.Preparar partido");
            Console.WriteLine("5.Jugar partido");
            Console.WriteLine("6.Salir");

        }









    }
}
