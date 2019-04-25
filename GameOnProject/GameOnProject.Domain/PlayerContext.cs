using System.Data.Entity;
using GameOnProject.Domain.Entities;

namespace GameOnProject.Domain
{
    public class PlayerContext: DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<HighScore> HighScore { get; set; }
        public DbSet<Profile> Profiles { get; set; }
       public DbSet<Error> Errors { get; set; }
    }
}
