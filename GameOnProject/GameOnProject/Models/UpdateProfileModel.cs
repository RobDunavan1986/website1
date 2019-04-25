using GameOnProject.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOnProject.Models
{
    public class UpdateProfileModel
    {
        
 public List<ProfileViewModel> Profiles { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}