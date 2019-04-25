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
    [Route("api/v1/highscores")]
    public class HighScoreApiController : ApiController
    {
        private readonly HighScoreOrchestrator _highScoreOrchestrator;

        public HighScoreApiController()
        {
            _highScoreOrchestrator = new HighScoreOrchestrator();
        }

        [HttpGet]

        public List<HighScoreViewModel> GetAllHighScores()
        {
            List<HighScoreViewModel> highscores = _highScoreOrchestrator.GetAllHighScores();
            return highscores;
        }
    }
}
