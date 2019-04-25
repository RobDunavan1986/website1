using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using System.Threading.Tasks;
using GameOnProject.Domain;
using GameOnProject.Domain.Entities;
using GameOnProject.Shared.Orchestrators.Interfaces;
using GameOnProject.Shared.ViewModels;

namespace GameOnProject.Shared.Orchestrators
{
    public class ProfileOrchestrator : IProfileOrchestrator
    {
        private readonly PlayerContext _playerContext;

        public ProfileOrchestrator()
        {
            _playerContext = new PlayerContext();
        }

        public async Task<int> CreateProfileAsync(ProfileViewModel profile)
        {
            _playerContext.Profiles.Add(new Profile
            {
                FirstName = profile.FirstName,
                LastName = profile.LastName,
                Gender = profile.Gender,
              //  Email = profile.Email,
                PhoneNumber = profile.PhoneNumber

            });
            return await _playerContext.SaveChangesAsync();
        }

        public async Task<List<ProfileViewModel>> GetAllProfile()
        {
            var profiles = await _playerContext.Profiles.Select(x => new ProfileViewModel
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
               // Email = x.Email,
                Gender = x.Gender,
                PhoneNumber = x.PhoneNumber
            }).ToListAsync();

            return profiles;
        }

        public ProfileViewModel GetProfileByEmail(string firstName)
        {
            //var people = _playerContext.Persons.Select(x => new PersonViewModel
            var profile = _playerContext.Profiles.Where(x => x.Email == firstName)
                .Select(x => new ProfileViewModel
                {
                    //Email = x.Email,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Gender = x.Gender,
                    PhoneNumber = x.PhoneNumber,
                    //UserId = x.UserId
                }).SingleOrDefault();
            if (profile == null)
            {
                profile = new ProfileViewModel
                {
                    FirstName = firstName
                };
            }

            return profile;
        }


        public async Task<ProfileViewModel> SearchProfile(string searchString)
        {
            var profile = await _playerContext.Profiles
                 .Where(x => x.FirstName.StartsWith(searchString))
                 .FirstOrDefaultAsync();
            if (profile == null)
            {
                return new ProfileViewModel();
            }
            var viewModel = new ProfileViewModel
            {
                FirstName = profile.FirstName,
                LastName = profile.LastName,
                //Email = profile.Email,
                Gender = profile.Gender,
                PhoneNumber = profile.PhoneNumber
            };
            return viewModel;
        }

        public async Task<bool> UpdateProfile(ProfileViewModel profile)
        {
            var updateEntity = await _playerContext.Profiles.FindAsync(profile.FirstName);

            if (updateEntity == null)
            {
                return false;
            }

            updateEntity.FirstName = profile.FirstName;
            updateEntity.LastName = profile.LastName;
            updateEntity.Gender = profile.Gender;
           // updateEntity.Email = profile.Email;
            updateEntity.PhoneNumber = profile.PhoneNumber;

            await _playerContext.SaveChangesAsync();

            return true;
        }

        //public async Task<List<string>> GetAllProfile()
        //{
        //    var profiles = await _playerContext.Profiles.Select(x => new ProfileViewModel
        //    {
        //        FirstName = x.FirstName,
        //        LastName = x.LastName,
        //        Email = x.Email,
        //        Gender = x.Gender,
        //        PhoneNumber = x.PhoneNumber
        //    }).ToListAsync();

        //    return profiles;
        //}
    
    }

}
