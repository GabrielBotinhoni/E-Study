using E_Study.Application;
using E_Study.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;


namespace E_Study.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>().HasData(
                new User { ID = Guid.Parse("98c4a5e4-4a8a-4316-81c5-db6c29a13989"), 
                    Name = "Gabriel", 
                    LastName = "Administrador", 
                    Email = "gabrielbotinhoni@gmail.com",
                    Password = Util.HashPassword("Administrador123"),
                    Enabled = true,
                    EmailConfirmed = false,
                    userType = UserType.Administrator}
            );
            return builder;
        }
    }
}
