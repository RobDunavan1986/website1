namespace GameOnProject.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigrationWithPersonHighscoreAndProfileTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Guid(nullable: false),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(),
                        DateCreated = c.DateTime(),
                        Email = c.String(),
                        ProfileId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.PersonId)
                .ForeignKey("dbo.Profiles", t => t.ProfileId, cascadeDelete: true)
                .Index(t => t.ProfileId);
            
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                       // ProfileId = c.Guid(nullable: false),
                       // UserId = c.Guid(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Email);
            
            CreateTable(
                "dbo.HighScores",
                c => new
                    {
                        HighScoreId = c.Guid(nullable: false),
                        PersonId = c.Guid(nullable: false),
                        Score = c.Single(nullable: false),
                        DateAttained = c.DateTime(),
                    })
                .PrimaryKey(t => t.HighScoreId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "ProfileId", "dbo.Profiles");
            DropIndex("dbo.People", new[] { "ProfileId" });
            DropTable("dbo.HighScores");
            DropTable("dbo.Profiles");
            DropTable("dbo.People");
        }
    }
}
