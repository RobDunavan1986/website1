using GameOnProject.Shared.Services.Interface;
using GameOnProject.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOnProject.Shared.Services
{
    public class PlayerScore : IPlayerScore
    {
        private readonly IHighScore _highScore;
        
        public PlayerScore(IHighScore highScore)
        {
            _highScore = highScore;
        }
        public bool IsThisYourHighScore(PersonViewModel player)
        {
            return player.HighScore == _highScore.Value();
        }
    }
}
