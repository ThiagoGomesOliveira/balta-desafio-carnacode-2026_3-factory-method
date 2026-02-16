using FactoryMethodProject.Interfaces;

namespace FactoryMethodProject.Models;

public class PushNotification : INotification
{
    private readonly PushParams _pushNotificationParams;

    public PushNotification(PushParams pushNotificationParams)
    {
        _pushNotificationParams = pushNotificationParams;
    }

    public void Send()
    {
        Console.WriteLine($"🔔 Enviando Push para dispositivo {_pushNotificationParams.DeviceToken}");
        Console.WriteLine($"   Título: {_pushNotificationParams.Title}");
        Console.WriteLine($"   Mensagem: {_pushNotificationParams.Message}");
    }
}
