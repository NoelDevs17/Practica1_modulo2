using Practica1_modulo2.Entidades;

internal class Program
{
    private static void Main(string[] args)
    {

        Club club = new Club();

        club.AgregarSocio(new Socio("Juan Pérez", 10));
        club.AgregarSocio(new Socio("Ana López", 5));
        club.AgregarSocio(new Socio("Carlos Gómez", 12));

        SocioMayorAntiguedad socioMayorAntiguedad = club.ObtenerSocioMayorAntiguedad();

        if (socioMayorAntiguedad != null)
        {
            Console.WriteLine("Socio con mayor antigüedad:");
            Console.WriteLine($"Nombre: {socioMayorAntiguedad.Nombre}");
            Console.WriteLine($"Antigüedad: {socioMayorAntiguedad.Antiguedad} años");
        }
        else
        {
            Console.WriteLine("No hay socios registrados");
        }

    }
}