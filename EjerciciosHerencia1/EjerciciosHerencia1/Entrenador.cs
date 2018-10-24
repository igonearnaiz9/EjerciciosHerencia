using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosHerencia1
{
    class Entrenador: SeleccionFutbol
{
        private string idFederacion;
        //Constructor
        public Entrenador()
        {

        }
        public Entrenador(int id, string nombre, string apellidos, int edad, string idFederacion)
            : base(id, nombre, apellidos, edad)
        {
            this.idFederacion = idFederacion;
           
        }
        //Getters y Setters
        public string GetIdFederacion()
        {
            return idFederacion;
        }
        public void DirigirPartido()
        {
                        
        }
        public override void PrepararPartido()
        {
            DirigirEntrenamiento();
        }
        public override void JugandoPartido()
        {
            DirigirPartido();
        }
        public void DirigirEntrenamiento()
        {
            //PrepararPartido()
            //Console.WriteLine("Dirige el entrenamiento");
        }
        public string MostrarDatos()
        {
            string descripcion = base.MostrarDatos();
            descripcion += "dorsal etc etc etc";
            return descripcion;
        }
    }
}
