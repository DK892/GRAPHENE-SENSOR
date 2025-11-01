using Microsoft.AspNetCore.Identity;

namespace GRAPHENE_SENSOR.Models
{
    public class Users:IdentityUser

    {
        public required string FullName { get; set; }
    }
}
