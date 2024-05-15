using Microsoft.AspNetCore.Http;
using NewVerificationProvider.Models;

namespace NewVerificationProvider.Interfaces
{
    public interface IValidateVerificationCodeService
    {
        Task<ValidateRequest> UnpackValidateRequestAsync(HttpRequest req);
        Task<bool> ValidateCodeAsync(ValidateRequest validateRequest);
    }
}