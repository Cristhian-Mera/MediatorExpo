public class Usuario
{
    public string Nombre { get; private set; }
    public IMediator Mediator { get; set; }

    public Usuario(string nombre, IMediator mediator)
    {
        Nombre = nombre;
        Mediator = mediator;
    }

    public void EnviarMensaje(string mensaje, Usuario destinatario)
    {
        Console.WriteLine($"{Nombre} envía mensaje para {destinatario.Nombre}: [{mensaje}]");
        Mediator.EnviarMensaje(mensaje, this, destinatario);
    }

    public void RecibirMensaje(string mensaje, Usuario remitente)
    {
        Console.WriteLine($"{Nombre} recibe mensaje de {remitente.Nombre}: [{mensaje}]");
    }
}