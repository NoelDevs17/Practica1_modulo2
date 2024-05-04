using Practica1_modulo2.Entidades;
using Practica1_modulo2.Interface;

//clase Club
namespace Practica1_modulo2.Entidades
{

    public class Club
    {
        private ISocioName[] socios;


        public Club()
        {
            socios = new ISocioName[3];
        }

        public void AgregarSocio(ISocioName socio)
        {
            for (int i = 0; i < socios.Length; i++)
            {
                if (socios[i] == null)
                {
                    socios[i] = socio;
                    return;
                }
            }

            throw new Exception("No hay mas espacio para socios");
        }

        public SocioMayorAntiguedad ObtenerSocioMayorAntiguedad()
        {

            SocioMayorAntiguedad socioMayorAntiguedad = new SocioMayorAntiguedad(socios);
            return socioMayorAntiguedad;

        }
    }

    public class SocioMayorAntiguedad
    {
        private ISocioName[] socios;

        public SocioMayorAntiguedad(ISocioName[] socios)
        {
            this.socios = socios;
        }

        public ISocioName ObtenerSocioConMayorAntiguedad()
        {
            ISocioName socioMayorAntiguedad = null;

            foreach (ISocioName socio in socios)
            {
                if (socio != null && (socioMayorAntiguedad == null || ((ISocioAntiguedad)socio).Antiguedad > ((ISocioAntiguedad)socioMayorAntiguedad).Antiguedad))
                {
                    socioMayorAntiguedad = socio;
                }
            }
            return socioMayorAntiguedad;
        }
        }

    }
