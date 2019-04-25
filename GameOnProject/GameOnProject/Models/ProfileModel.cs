using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOnProject.Web.Models
{
    public class ProfileModel
    {
       // public Guid UserId { get; set; }
        //public string FirstName {

        //    get
        //    {
        //        return HttpContext.Current.Session["username"] as string;
        //    }
            

        //    set {
        //        HttpContext.Current.Session["username"] = value; }
        //    }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

    }
}