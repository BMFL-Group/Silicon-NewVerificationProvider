using Microsoft.EntityFrameworkCore;
using NewVerificationProvider.Data.Entities;
using System.Collections.Generic;

namespace NewVerificationProvider.Data.Contexts;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<VerificationRequestEntity> VerificationRequests { get; set; }
}
