using GRAPHENE_SENSOR.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GRAPHENE_SENSOR.data
{
    public class AppDbContext : IdentityDbContext<Users>
    {
public AppDbContext(DbContextOptions options) : base(options){ }
    }
}
