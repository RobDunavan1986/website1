using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOnProject.Shared.ViewModels
{
    public class ProfileViewModel
    {
       // public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<ProfileViewModel> Profiles { get; set; }

        //public static implicit operator ProfileViewModel(ProfileViewModel v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
