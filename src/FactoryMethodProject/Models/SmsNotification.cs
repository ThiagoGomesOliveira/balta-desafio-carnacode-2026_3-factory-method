using FactoryMethodProject.Interfaces;

namespace FactoryMethodProject.Models;

public class SmsNotification  : INotification
{
    private readonly SmsParams _smsParams;
    public SmsNotification(SmsParams smsParams)
    {
            _smsParams = smsParams;
    }

    public void Send()
    {
        Console.WriteLine($"📱 Enviando SMS para {_smsParams.PhoneNumber}");
        Console.WriteLine($"   Mensagem: {_smsParams.Message}");
    }
}
