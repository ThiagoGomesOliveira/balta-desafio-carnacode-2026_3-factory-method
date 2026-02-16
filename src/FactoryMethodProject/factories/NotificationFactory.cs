using FactoryMethodProject.Enums;
using FactoryMethodProject.Interfaces;
using FactoryMethodProject.Models;

namespace FactoryMethodProject.factories
{
    public class NotificationFactory
    {
        public INotification CreateShipment(ShippingType type, object param)
        {
            return type switch
            {
                ShippingType.Email => new EmailNotification(param as EmailParams),
                ShippingType.SMS => new SmsNotification(param as SmsParams),
                ShippingType.Push => new PushNotification(param as PushParams),
                ShippingType.WhatsApp => new WhatsAppNotification(param as WhatsAppParams),
                _ => throw new ArgumentException($"Tipo de notificação '{type}' não suportado"),
            };
        }
    }
}
