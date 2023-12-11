class Program
{
    static void Main()
    {
        Mediator mediator = new Mediator();

        Usuario usuario1 = new Usuario("Cristhian", mediator);
        Usuario usuario2 = new Usuario("Samir", mediator);
        Usuario usuario3 = new Usuario("Diego", mediator);

        mediator.RegistrarUsuario(usuario1);
        mediator.RegistrarUsuario(usuario2);
        mediator.RegistrarUsuario(usuario3);
        
        usuario1.EnviarMensaje("Hola, ¿Como estas?", usuario2);
        usuario2.EnviarMensaje("Hola, Estoy bien, ¿y tu?", usuario1);
        usuario1.EnviarMensaje("bien, hazme un favor voy a organizar una reuinión, puedes envisarle a Diego", usuario2);
        usuario2.EnviarMensaje("Hola, como estas Diego, Cristhian va hacer una reunión me dijo que te avisará", usuario3);
        usuario3.EnviarMensaje("hola estoy bien, gracias por avisar, ahí estaré", usuario2);
    }
}