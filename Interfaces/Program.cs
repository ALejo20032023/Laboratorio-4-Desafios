using System;

interface INotificable
{
    void Notificar(string mensaje);
}

class NotificacionEmail : INotificable
{
    public string DireccionCorreo { get; }

    public NotificacionEmail(string direccionCorreo)
    {
        DireccionCorreo = direccionCorreo;
    }

    public void Notificar(string mensaje)
    {
        Console.WriteLine($"Enviando correo electrónico a {DireccionCorreo}: {mensaje}");
    }
}

class NotificacionWhatsapp : INotificable
{
    public string NumeroTelefono { get; }

    public NotificacionWhatsapp(string numeroTelefono)
    {
        NumeroTelefono = numeroTelefono;
    }

    public void Notificar(string mensaje)
    {
        Console.WriteLine($"Enviando mensaje de WhatsApp al número {NumeroTelefono}: {mensaje}");
    }
}

class NotificacionSMS : INotificable
{
    public string NumeroTelefono { get; }

    public NotificacionSMS(string numeroTelefono)
    {
        NumeroTelefono = numeroTelefono;
    }

    public void Notificar(string mensaje)
    {
        Console.WriteLine($"Enviando SMS al número {NumeroTelefono}: {mensaje}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear instancias de cada implementación
        NotificacionEmail emailNotificacion = new NotificacionEmail("ejemplo@correo.com");
        NotificacionWhatsapp whatsappNotificacion = new NotificacionWhatsapp("12345678");
        NotificacionSMS smsNotificacion = new NotificacionSMS("98765432");

        // Ejemplos de uso
        emailNotificacion.Notificar("¡Hola desde el correo electrónico!");
        whatsappNotificacion.Notificar("¡Hola desde WhatsApp!");
        smsNotificacion.Notificar("¡Hola desde SMS!");
    }
}
