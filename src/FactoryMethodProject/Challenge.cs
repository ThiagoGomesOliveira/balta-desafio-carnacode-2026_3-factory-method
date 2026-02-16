using FactoryMethodProject.Enums;
using FactoryMethodProject.factories;
using FactoryMethodProject.Interfaces;
using FactoryMethodProject.Models;

namespace FactoryMethodProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Notificações ===\n");

            // Cliente 1 prefere Email
            var emailParameter = new EmailParams
            {
                Recipient = "cliente@email.com",
                Subject = "Confirmação de Pedido",
                Body = $"Seu pedido 12345 foi confirmado!",
                IsHtml = true
            };

            INotification notificationEmail = new NotificationFactory().CreateShipment(ShippingType.Email, emailParameter);
            notificationEmail.Send();

            
            Console.WriteLine();

            // Cliente 2 prefere SMS

            var smsParameters = new SmsParams
            {
                PhoneNumber = "+5511999999999",
                Message = $"Pedido 12346 confirmado!"
            };

            INotification notificationSms = new NotificationFactory().CreateShipment(ShippingType.SMS, smsParameters);
            notificationSms.Send();
          
            Console.WriteLine();

            var pushParams = new PushParams
            {
                DeviceToken = "device-token-abc123",
                Title = "Pedido Confirmado",
                Message = $"Pedido BR123456789 confirmado!"
            };

            INotification pushNotification = new NotificationFactory().CreateShipment(ShippingType.Push, pushParams);
            pushNotification.Send();

            Console.WriteLine();

            var whatsAppParams = new WhatsAppParams
            {
                PhoneNumber = "+5511888888888",
                Message = $"✅ Seu pedido BR123456789 foi confirmado!",
                UseTemplate = true
            };

            INotification whatsAppNotification = new NotificationFactory().CreateShipment(ShippingType.WhatsApp, whatsAppParams);
            whatsAppNotification.Send();
        }
    }
}
