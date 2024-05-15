using Azure.Messaging.ServiceBus;
using NewVerificationProvider.Models;

namespace NewVerificationProvider.Interfaces
{
    public interface IVerificationService
    {
        string GenerateCode();
        EmailRequest GenerateEmailRequest(VerificationRequest verificationRequst, string code);
        string GenerateServiceBusEmailRequest(EmailRequest emailRequest);
        Task<bool> SaveVerificationRequest(VerificationRequest verificationRequst, string code);
        VerificationRequest UnPackVerificationRequest(ServiceBusReceivedMessage message);
    }
}