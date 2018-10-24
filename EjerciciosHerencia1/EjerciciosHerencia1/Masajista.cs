using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosHerencia1
{
    class Masajista: SeleccionFutbol
    {
        private string titulacion;
        private int aniosExperiencia;

        //Constructor
        public Masajista()
        {

        }
        public Masajista(int id, string nombre, string apellidos, int edad, string titulacion,
            int aniosExperiencia) : base(id, nombre, apellidos, edad)
        {
            this.titulacion = titulacion;
            this.aniosExperiencia = aniosExperiencia;

        }
        //Getters y Setters
        public string GetTitulacion()
        {
            return titulacion;
        }
        public int GetAniosExperiencia()
        {
            return aniosExperiencia;
        }

        public  bool DarMasaje()
        {
            //PrepararPartido()
            Console.WriteLine("Da un masaje");
            return true;
        }
        public override void PrepararPartido()
        {
            DarMasaje();
        }
        public override void JugandoPartido()
        {
            DarMasaje();
        }
        //este es el overrride
        public string MostrarDatos()
        {
            string descripcion =  base.MostrarDatos();
            descripcion += "dorsal etc etc etc";
            return descripcion;

        }


    }
}
