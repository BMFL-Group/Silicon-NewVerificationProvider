namespace NewVerificationProvider.Interfaces
{
    public interface IVerificationCleanerSerivce
    {
        Task RemoveExpiredRecordsAsync();
    }
}