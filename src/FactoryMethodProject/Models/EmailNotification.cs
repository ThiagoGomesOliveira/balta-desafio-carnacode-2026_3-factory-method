using FactoryMethodProject.Interfaces;

namespace FactoryMethodProject.Models;

public class EmailNotification : INotification
{
    private readonly EmailParams _emailParams;
    public EmailNotification(EmailParams emailParams)
    {
        _emailParams = emailParams;
    }

    public void Send()
    {
        Console.WriteLine($"📧 Enviando Email para {_emailParams.Recipient}");
        Console.WriteLine($"   Assunto: {_emailParams.Subject}");
        Console.WriteLine($"   Mensagem: {_emailParams.Body}");
    }
}
