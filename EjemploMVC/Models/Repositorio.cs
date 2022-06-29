namespace EjemploMVC.Models;
public static class Repositorio
{
    private static List<Invitacion> invitaciones = new List<Invitacion>();
    public static IEnumerable<Invitacion> Invitaciones => invitaciones;
    public static void AgregarInvitacion(Invitacion invitacion) => invitaciones.Add(invitacion);
    public static IEnumerable<Invitacion> InvitacionesAceptadas
        => invitaciones.Where(i => i.Vendra == true);
}