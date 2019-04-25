using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using GameOnProject.Models;
using GameOnProject.Shared.Orchestrators.Interfaces;
using GameOnProject.Shared.ViewModels;
using GameOnProject.Web.Models;

namespace GameOnProject.Controllers
{
    public class ProfileController : Controller
    {
         private readonly IProfileOrchestrator _profileOrchestrator;
      
       public ProfileController(IProfileOrchestrator profileOrchestrator)
        {
            _profileOrchestrator = profileOrchestrator;
        }
        // GET: Profile
        public async Task<ActionResult>Index()
        {
            var profileViewModel = new ProfileViewModel
          {
               Profiles = await _profileOrchestrator.GetAllProfile()
           };
            return View(profileViewModel);
        }
        public async Task<ActionResult> Create(ProfileModel profile)
        {
            if (string.IsNullOrWhiteSpace(profile.FirstName))
                return View();

            var updatedCount = await _profileOrchestrator.CreateProfileAsync(new ProfileViewModel
            {
               Email = profile.Email,
                FirstName = profile.FirstName,
                Gender = profile.Gender,
                LastName = profile.LastName,
                PhoneNumber = profile.PhoneNumber
            });
            return View();
        }


        public ActionResult Update()
        {
            var email = Session["Email"];
           var viewModel = _profileOrchestrator.GetProfileByEmail(email.ToString());

            return View(viewModel);
        }





        public async Task<JsonResult> UpdateProfile(UpdateProfileModel profile)

        {
            if (profile.Email == String.Empty)
                return Json(false, JsonRequestBehavior.AllowGet);

            var result = await _profileOrchestrator.UpdateProfile(new ProfileViewModel
            {
                Email = profile.Email,
                FirstName = profile.FirstName,
                Gender = profile.Gender,
                LastName = profile.LastName,
                PhoneNumber = profile.PhoneNumber
            });
            return Json(result, JsonRequestBehavior.AllowGet);
        }
            public async Task<JsonResult> Search(string searchString)

            {

                var viewModel = await _profileOrchestrator.SearchProfile(searchString);



                return Json(viewModel, JsonRequestBehavior.AllowGet);

            }

        }

    }



//public ActionResult Index()
//{
//    //var email = Session["Email"];
//    return View();
//}

//public ActionResult Update()
//{
//    var email = Session["Email"];
//    var viewModel = _profileOrchestrator.GetProfileByEmail(email.ToString());

//    return View(viewModel);
//}

//public async Task<JsonResult> UpdateProfile(ProfileModel profile)
//{
//    if (profile.Email == string.Empty)
//    {
//        return Json(false, JsonRequestBehavior.AllowGet);
//    }

//    var result = await _profileOrchestrator.UpdateProfile(new ProfileViewModel
//    {
//       // UserId = profile.UserId,
//        FirstName = profile.FirstName,
//        LastName = profile.LastName,
//        Gender = profile.Gender,
//        Email = profile.Email,
//        PhoneNumber = profile.PhoneNumber
//    });

//    return Json(result, JsonRequestBehavior.AllowGet);
//}
