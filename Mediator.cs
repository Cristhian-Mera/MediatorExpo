public class Mediator : IMediator
{
    private Dictionary<string, Usuario> usuarios = new Dictionary<string, Usuario>();
    public void RegistrarUsuario(Usuario usuario)
    {
        if(!usuarios.ContainsKey(usuario.Nombre))
        {
            usuarios.Add(usuario.Nombre, usuario);
            usuario.Mediator = this;
        }
    }
    public void EnviarMensaje(string mensaje, Usuario remitente, Usuario destinatario)
    {
        if (usuarios.ContainsValue(destinatario))
        {
            destinatario.RecibirMensaje(mensaje, remitente);
        }
        else
        {

        }
    }
}