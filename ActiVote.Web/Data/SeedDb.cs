﻿namespace ActiVote.Web.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;
    using Helpers;
    using Microsoft.AspNetCore.Identity;
  
    public class SeedDb
    {
        private readonly DataContext context;
        private readonly IUserHelper userHelper;
        private readonly Random random;

        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            this.context = context;
            this.userHelper = userHelper;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            var user = await this.userHelper.GetUserByEmailAsync("joan.guisao@gmail.com");
            if (user == null)
            {
                user = new User
                {
                    FirstName = "Sebastian",
                    LastName = "Guisao",
                    Email = "joan.guisa@gmail.com",
                    UserName = "joan.guisa@gmail.com"
                };

                var result = await this.userHelper.AddUserAsync(user, "123456");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }
            }



            if (!this.context.Events.Any())
            {
                this.AddEvent("First Event", user);
                this.AddEvent("Second Event", user);
                this.AddEvent("Third Event", user);
                await this.context.SaveChangesAsync();
            }
        }

        private void AddEvent(string name, User user)
        {
            this.context.Events.Add(new Event
            {
                EventName = name,
                Description = "Prueba description",
                User =  user
                
            });
        }
    }
}
