using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOnProject.Domain;
using GameOnProject.Shared.ViewModels;

namespace GameOnProject.Shared.Orchestrators
{
    public class HighScoreOrchestrator
    {
        private readonly PlayerContext _playerContext;

        public HighScoreOrchestrator()
        {
            _playerContext = new PlayerContext();
        }

        public List<HighScoreViewModel> GetAllHighScores()
        {
            var highscores = _playerContext.HighScore.Select(y => new HighScoreViewModel
            {
                HighScoreId = y.HighScoreId,
                PersonId = y.PersonId,
                Score = y.Score,
                DateAttained = y.DateAttained
            }).ToList();

            return highscores;
        }
    }
}
