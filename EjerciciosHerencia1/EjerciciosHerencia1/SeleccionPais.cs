using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosHerencia1
    //Continuación ejercicio: 

//1.-Se desea crear una clase SeleccionPais que guarde los datos de la selección de un pais.
//Los datos que debe almacenar son:
//Nombre pais
//Participantes: Contiene una lista de todos los participantes de la selección: futbolistas, entrenadores 
//y masajistas.El tope de participantes son 30. (El máximo de masajistas son 4 y entrenadores 2)
//Número real de participantes
//2.-Dicha clase deberá disponer de los siguientes métodos:
//a)      MostrarDatosSelección() : Muestra el nombre del país, el número de integrantes y sus datos.
// b)      boolean AltaSeleccion() Permite si hay hueco, dar de alta a un nuevo integrante y contabilizarlo
//(El tope de participantes son 30. El máximo de masajistas son 4 y entrenadores 2)
//Devuelve true si se ha podido completar la operación, false en caso contrario.
//c)      boolean BajaSeleccion() Se pide el id del integrante a dar de baja, si existe se da de baja 
//desplazando la lista de participantes y actualizando contadores.
//Devuelve true si se ha podido completar la operación, false en caso contrario.
//d)   PrepararPartido() Consiste en realizar las siguientes operaciones:
//a.Viajar a la sede del partido
//b.Concentrarse
//Los entrenadores: dirigir entrenamie
//Los masajistas : dar masaje
//Los futbolistas: entrenar
//e)      JugarPartido()  Consiste en realizar las siguientes operaciones:
//Los entrenadores: dirigir partido
//Los masajistas : dar masaje
//Los futbolistas: jugar partido

{
    class SeleccionPais
    {
        private string nombrePais;
        private List<SeleccionFutbol> listaParticipantesSeleccion; //instancia la lista
        //private int participantes;
        private int topeParticipantes = 30;
        private static int numeroEntrenadores;
        private static int numeroFutbolistas;
        private static int numeroMasajistas;
        

        //Constructor
        public SeleccionPais(string nombrePais)
        {
            this.nombrePais = nombrePais;
            //inicializa la lista
        }
        public SeleccionPais(string nombrePais, List<SeleccionFutbol> seleccionados)
        {
            this.nombrePais = nombrePais;
            foreach(SeleccionFutbol sf in seleccionados)
            {
                if (sf.GetType().Name == "Entrenador")
                {
                    numeroEntrenadores++;
                }
                else if (sf.GetType().Name == "Masajista")
                {
                    numeroFutbolistas++;
                }
                else if (sf.GetType().Name == "Futbolista")
                {
                    numeroMasajistas++;
                }
            }          
            
            listaParticipantesSeleccion = seleccionados;//inicializa la lista
        }
        //public SeleccionPais(List<SeleccionFutbol> lista)
        //{
        //    listaParticipantesSeleccion = lista;//inicializa la lista
        //}

        public void AinadirJugador(SeleccionFutbol seleccionados)
        {
            listaParticipantesSeleccion.Add(seleccionados);
        }



        //Getters y setters

        public string GetNombrePais()
        {
            return nombrePais;
        }
        public void SetNombrePais()
        {
            this.nombrePais = nombrePais;
        }
        //a)      MostrarDatosSelección(): Muestra el nombre del país, el número de integrantes y sus datos.

        public void MostrarDatosSelección()
        {
            Console.WriteLine("País: " + nombrePais + "\n Integrantes " + listaParticipantesSeleccion.Count);
            foreach (SeleccionFutbol sf in listaParticipantesSeleccion)
            {
                Console.WriteLine(sf.GetNombre() + sf.GetApellidos() + sf.GetEdad() + " " + sf.GetType().Name);
                //Quiero que me muestre los datos de los seleccionados, si no pongo el .Name,
                //me escribre la ruta de la Herencia
            }
            Console.ReadLine();
        }
        //b)boolean AltaSeleccion ( ) Permite si hay hueco , dar de alta a un nuevo integrante y 
        //contabilizarlo (El tope de participantes son 30. El máximo de masajistas son 4 y entrenadores 2)

        public bool AltaSeleccion(SeleccionFutbol s)
        {
            if (listaParticipantesSeleccion.Count < 30)
            {
                if (s.GetType().Name == "Entrenador" && numeroEntrenadores < 2)
                {
                    numeroEntrenadores++;                    
                    listaParticipantesSeleccion.Add(s);
                    Console.WriteLine("El seleccionado " + s.GetType().Name + " ha sido añadido.");
                }
                else if (s.GetType().Name == "Masajista" && numeroMasajistas < 4)
                {
                    numeroMasajistas++;
                    listaParticipantesSeleccion.Add(s);
                    Console.WriteLine("El seleccionado " + s.GetType().Name + " ha sido añadido.");
                }
                else if (s.GetType().Name == "Futbolista")
                {
                    numeroFutbolistas++;
                    listaParticipantesSeleccion.Add(s);
                    Console.WriteLine("El seleccionado " + s.GetType().Name + " ha sido añadido.");
                }
                else
                {
                    Console.WriteLine("No caben más " + s.GetType().Name + "s en la Selección");
                    return false;
                }
                Console.ReadLine();
                return true;
            }
            Console.WriteLine("No caben más miembros en la Selección");
            Console.ReadLine();
            return false;
            
        }
        //c)      boolean BajaSeleccion( ) Se pide el id del integrante a dar de baja, 
        //si existe se da de baja y actualizando contadores.
        //Devuelve true si se ha podido completar la operación, false en caso contrario.

        public bool BajaSeleccion()
        {
            Console.WriteLine("Introduce el id a dar de baja");
            int idBaja = Convert.ToInt32(Console.ReadLine());
            foreach (SeleccionFutbol desseleccionado in listaParticipantesSeleccion)
            {
                if (idBaja== desseleccionado.GetId() && desseleccionado.GetType().Name == "Entrenador")
                {
                    numeroEntrenadores--;
                    listaParticipantesSeleccion.Remove(desseleccionado);
                    Console.WriteLine("El " + desseleccionado.GetType().Name + " ha sido desseleccionado.");
                    return true;
                }
                else if (idBaja == desseleccionado.GetId() && desseleccionado.GetType().Name == "Masajista")
                {
                    numeroFutbolistas--;
                    listaParticipantesSeleccion.Remove(desseleccionado);
                    Console.WriteLine("El " + desseleccionado.GetType().Name + " ha sido desseleccionado.");
                    return true;
                }
                else if (idBaja == desseleccionado.GetId() && desseleccionado.GetType().Name == "Futbolista")
                {
                    numeroMasajistas--;
                    listaParticipantesSeleccion.Remove(desseleccionado);
                    Console.WriteLine("El " + desseleccionado.GetType().Name + " ha sido desseleccionado.");
                    return true;
                }
            }
            Console.ReadLine();
            return false;
        }
//        d)   PrepararPartido() Consiste en realizar las siguientes operaciones:
            //a.Viajar a la sede del partido
            //b.Concentrarse
            //Los entrenadores: dirigir entrenamie
            //Los masajistas : dar masaje
            //Los futbolistas: entrenar
        public void PrepararPartido()
        {
            foreach (SeleccionFutbol s in listaParticipantesSeleccion)
            {
                s.PrepararPartido();
            }
        }

        //e)      JugarPartido()  Consiste en realizar las siguientes operaciones:
        //    Los entrenadores: dirigir partido
        //    Los masajistas : dar masaje
        //    Los futbolistas: jugar partido
        public void JugandoPartido()
        {
            foreach (SeleccionFutbol s in listaParticipantesSeleccion)
            {
                s.JugandoPartido();
            }
        }

    }
}
