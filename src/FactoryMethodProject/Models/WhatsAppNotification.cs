using FactoryMethodProject.Interfaces;

namespace FactoryMethodProject.Models;

public class WhatsAppNotification : INotification
{
    private readonly WhatsAppParams _whatsAppParams;
    public WhatsAppNotification(WhatsAppParams whatsAppParams)
    {
        _whatsAppParams = whatsAppParams;
    }

    public void Send()
    {
        Console.WriteLine($"💬 Enviando WhatsApp para {_whatsAppParams.PhoneNumber}");
        Console.WriteLine($"   Mensagem: {_whatsAppParams.Message}");
        Console.WriteLine($"   Template: {_whatsAppParams.  UseTemplate}");
    }
}
