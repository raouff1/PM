using Microsoft.EntityFrameworkCore;
using Subscribe_WebAPI.Entities;
using System.Collections.Generic;

namespace WebApi.Contexts;

public class ApiContext(DbContextOptions<ApiContext> options) : DbContext(options)
{
    public DbSet<SubscribeEntity> Subscribers { get; set; }
}