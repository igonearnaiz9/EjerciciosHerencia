using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosHerencia1
{
    class Futbolista:SeleccionFutbol/*!!!!!!!!!!!!!*/
    {
        private int dorsal;
        private string demarcacion;
        //Constructores
        public Futbolista()
        {

        }
        public Futbolista(int id, string nombre, string apellidos, int edad, int dorsal, string demarcacion)
            : base(id, nombre, apellidos, edad)
        {
            this.dorsal = dorsal;
            this.demarcacion = demarcacion;
        }
        //Getters y Setters
        public int GetDorsal()
        {
            return dorsal;
        }
        public string GetDemarcacion()
        {
            return demarcacion;
        }

        public void JugarPartido()
        {

        }
        public void Entrenar()
        {

        }
        public override void PrepararPartido()
        {
            Entrenar();
        }
        public override void JugandoPartido()
        {
            JugarPartido();
        }
        //ste es el override
        public string MostrarDatos()
        {
            string descripcion = base.MostrarDatos();
            descripcion += "dorsal etc etc etc";
            return descripcion;
        }
    }
}
