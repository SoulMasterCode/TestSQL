namespace TestDataBase.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TestDataBase.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TestDataBase.Servicices.TestContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TestDataBase.Servicices.TestContext context)
        {
            Guid firstProjectId = Guid.Parse("1526695E-4B9D-4230-8576-CF4F1ED6D3D8");
            Guid firstUserId = Guid.Parse("DD056DAD-65C0-4733-B7A8-0E828214D803");
            Guid secondUserId = Guid.Parse("51BC82F3-851D-4D3B-9DAE-30E6452AC1B9");
            Guid firstStepId = Guid.Parse("D0339A8F-AEF6-4828-A0F4-65043D3CC91E");
            Guid secondStepId = Guid.Parse("45FD9A3A-9587-4718-8463-2F3FEFEC7761");
            Guid thirdStepId = Guid.Parse("64A772AB-DC28-4BE1-AC0A-11280F454029");
            Guid fourthStepId = Guid.Parse("E9D4CEE0-56DC-4845-91B8-955B8CAA48FE");
                                                                            

            context.Projects.AddOrUpdate(p => p.id, new Project { id = firstProjectId, name = "Make Cake"});

            context.Users.AddOrUpdate(u => u.id, new User { id = firstUserId, name = "Mary Maker" }, new User { id = secondUserId, name = "Tommy Tester" });

            context.Steps.AddOrUpdate(s => s.Id,
              new Step
              {
                  Id = firstStepId,
                  Name = "Ingredients",
                  Detail = "Gather all of the ingredients and mix thoroughly in a bowl",
                  Order = 1,
                  ProjectId = firstProjectId,
                  UserId = firstUserId
              },
              new Step { Id = secondStepId, Name = "Baking", Detail = "Put mixture in a cake tin and place in oven at 180 degrees for 25 minutes, then cool for 30 minute",
                Order = 2, ProjectId = firstProjectId, UserId = firstUserId },
              
              new Step { Id = thirdStepId, Name = "Testing", Detail = "Cut out and taste a small slice of cake – if it tastes good go to step 4, if bad go to step 1",
                Order = 3, ProjectId = firstProjectId, UserId = secondUserId },
  
              new Step { Id = fourthStepId, Name = "Serving", Detail = "Slice the cake into equal parts, one slice for each guest and prepare on a suitable plate",
                Order = 4, ProjectId = firstProjectId, UserId = firstUserId});
        }
    }
}
