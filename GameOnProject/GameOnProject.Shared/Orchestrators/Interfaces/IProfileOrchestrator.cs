using System;
using System.Collections.Generic;

using System.Threading.Tasks;
using GameOnProject.Shared.ViewModels;

namespace GameOnProject.Shared.Orchestrators.Interfaces
{
    public interface IProfileOrchestrator
    {
        ProfileViewModel GetProfileByEmail(string email);
        Task<int> CreateProfileAsync(ProfileViewModel profile);
        Task<bool> UpdateProfile(ProfileViewModel profile);
        Task <ProfileViewModel>SearchProfile(string searchString);
        Task<List<ProfileViewModel>> GetAllProfile();
        //Task<List<string>> GetAllProfile();
    }
}
