using System;

namespace GameOnProject.Domain.Entities
{
    public class Profile
    {
        public Guid ProfileId { get; set; }
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
