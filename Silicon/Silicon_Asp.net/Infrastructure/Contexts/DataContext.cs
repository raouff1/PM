using Infrastructure.Entites;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts;

public class DataContext(DbContextOptions<DataContext> options) : IdentityDbContext<UserEntity>(options)
{
    public DbSet<SubscribeEntity> Subscribes { get; set; }
    public DbSet<AddressEntity> Addresses { get; set; }
}
