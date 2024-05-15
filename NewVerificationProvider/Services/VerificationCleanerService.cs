using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NewVerificationProvider.Data.Contexts;
using NewVerificationProvider.Interfaces;

namespace NewVerificationProvider.Services;

public class VerificationCleanerSerivce(ILogger<VerificationCleanerSerivce> logger, DataContext context) : IVerificationCleanerSerivce
{
    private readonly ILogger<VerificationCleanerSerivce> _logger = logger;
    private readonly DataContext _context = context;

    public async Task RemoveExpiredRecordsAsync()
    {
        try
        {
            var expired = await _context.VerificationRequests.Where(x => x.ExpiryDate <= DateTime.Now).ToListAsync();
            _context.RemoveRange(expired);
            await _context.SaveChangesAsync();

        }
        catch (Exception ex)
        {
            _logger.LogError($"ERROR : VerificationCleanerSerivce.RemoveExpiredRecordsAsync() :: {ex.Message} ");
        }
    }
}