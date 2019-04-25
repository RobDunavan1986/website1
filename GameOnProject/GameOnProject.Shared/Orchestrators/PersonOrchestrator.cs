using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOnProject.Domain;
using GameOnProject.Shared.ViewModels;

namespace GameOnProject.Shared.Orchestrators
{
    public class PersonOrchestrator
    {
        private readonly PlayerContext _playerContext;

        public PersonOrchestrator()
        {
            _playerContext = new PlayerContext();
        }

        public List<PersonViewModel> GetAllPersons()
        {

            var people = _playerContext.Persons.Select(x => new PersonViewModel
            {
                PersonId = x.PersonId,
                FirstName = x.FirstName,
                LastName = x.LastName,
                DateCreated = x.DateCreated,
                Email = x.Email, 
                PhoneNumber = x.Profile.PhoneNumber,
                Gender = x.Profile.Gender
            }).ToList();


            return people;
        }
    }
}
