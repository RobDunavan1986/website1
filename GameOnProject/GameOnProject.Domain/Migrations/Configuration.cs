namespace GameOnProject.Domain.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using GameOnProject.Domain.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<GameOnProject.Domain.PlayerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GameOnProject.Domain.PlayerContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.HighScore.AddOrUpdate(new HighScore
            {
                HighScoreId = Guid.Parse("ba9ded69-ac3b-48c0-b388-924c9f0d04ad"),
                PersonId = Guid.Parse("ba9ded69-ac3b-48c0-b388-924c9f0d04ad"),
                Score = 16f,
                DateAttained = new DateTime(2019, 4, 15)
            });
            context.HighScore.AddOrUpdate(new HighScore
            {
                HighScoreId = Guid.Parse("8e5c76dc-9a77-459c-8e0f-3bf1cf971fea"),
                PersonId = Guid.Parse("4f2c1e03-47a6-43b1-a460-42e75b06b8db"),
                Score = 30f,
                DateAttained = new DateTime(2019, 5, 16)
            });
            context.HighScore.AddOrUpdate(new HighScore
            {
                HighScoreId = Guid.Parse("a5c92df0-69dd-41d9-868d-3dba952dbaa6"),
                PersonId = Guid.Parse("7f7db62c-66e4-43fb-9a11-2907e4b9249b"),
                Score = 20f,
                DateAttained = new DateTime(2019, 2, 14)
            });

            context.HighScore.AddOrUpdate(new HighScore
            {
                HighScoreId = Guid.Parse("1285bcbf-19f1-415b-8bd9-f55a38ed3de7"),
                PersonId = Guid.Parse("53357363-4205-483b-a8a9-fba606741186"),
                Score = 20f,
                DateAttained = new DateTime(2019, 2, 14)
            });
            context.HighScore.AddOrUpdate(new HighScore
            {
                HighScoreId = Guid.Parse("fe61c0fe-7cb9-40e8-a8ae-32bc3b6872ad"),
                PersonId = Guid.Parse("ccf49af0-4e9a-4cad-afbb-5fc4b0a4b875"),
                Score = 20f,
                DateAttained = new DateTime(2019, 2, 14)
            });
            context.Profiles.AddOrUpdate(new Profile
            {
                FirstName = "Rob",
                LastName = "Dunavan",
                Email = "DunavanRob1986@gmail.com",
                PhoneNumber = "515 - 444 - 4444"
            });
           
           
            context.Errors.AddOrUpdate(new Error
            {
                Id = Guid.Parse("7753c952-da0f-4cd9-bf86-4cf25c1d5398"),
                ErrorMessage = "None",
                StackTrace = "Have Fun",
                InnerException = "Try again",
                ErrorDateTime = new DateTime(2019, 1, 12)
            });
        }
    }
}


