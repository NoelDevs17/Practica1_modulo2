
using Practica1_modulo2.Interface;

//Clase socio
namespace Practica1_modulo2.Entidades
{
    public class Socio : ISocioName, ISocioAntiguedad
    {
        private string nombre;
        private int antiguedad;

        public Socio(string nombre, int antiguedad)
        {
            this.nombre = nombre;
            this.antiguedad = antiguedad;
        }

        public string Nombre => nombre;

        public int Antiguedad => antiguedad;
    }
}
