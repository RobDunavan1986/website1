using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GameOnProject.Shared.Orchestrators;
using GameOnProject.Shared.ViewModels;

namespace GameOnProject.Api
{
    [Route("api/v1/persons")]
    public class PersonApiController : ApiController
    {
        private readonly PersonOrchestrator _personOrchestrator;

        public PersonApiController()
        {
            _personOrchestrator = new PersonOrchestrator();
        }

        [HttpGet]

        public List<PersonViewModel> GetAllPersons()
        {
            List<PersonViewModel> persons = _personOrchestrator.GetAllPersons();
            return persons;
        }
    }
}
