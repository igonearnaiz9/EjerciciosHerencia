using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosHerencia1
{
    class SeleccionFutbol
    {
        private int id;
        private string nombre;
        private string apellidos;
        private int edad;
        
        private static int numeroIntegrantes = 0;
        
        //Constructor
        public SeleccionFutbol()
        {

        }
        public SeleccionFutbol(int id, string nombre,string apellidos, int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
        //2.-Añade un contador a la clase padre que contabilice el número total de integrantes de la selección.
            numeroIntegrantes++;
        }
        //Getters y Setters
        public int GetId()
        {
            return id;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetApellidos()
        {
            return apellidos;
        }
        public void SetApellidos(string apellidos)
        {
            this.apellidos = apellidos;
        }
        public int GetEdad()
        {
            return edad;
        }
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
        public int GetNumeroIntegrantes()
        {
            return numeroIntegrantes;
        }


        public bool Concentrarse()
        {
            return true;
        }
        public bool Viajar()
        {
            return true;
        }
        public string MostrarDatos()
        {
            return "Id: " + this.id + ", Nombre: "+this.nombre +", Apellidos " +this.apellidos+", Edad " + this.edad;
        }
        public virtual void PrepararPartido()
        {

        }
        //e)      JugarPartido()  Consiste en realizar las siguientes operaciones:
        //        Los entrenadores: dirigir partido
        //Los masajistas : dar masaje
        //Los futbolistas: jugar partido

        public virtual void JugandoPartido()
        {

        }



    }
}
