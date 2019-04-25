using AutoMoq;
using GameOnProject.Shared.Services;
using GameOnProject.Shared.Services.Interface;
using GameOnProject.Shared.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOnProject.Test
{
    [TestClass]
  public  class PlayerScoreTest
    {
        private readonly AutoMoqer _mocker = new AutoMoqer();

        public int HighScore { get; private set; }

        [TestMethod]
        public void HighScore_ReturnsTrue_WhenHighScoreMatchesMaxValue()
        {
            _mocker.GetMock<IHighScore>()
                .Setup(x => x.Value())
                .Returns(HighScore = 1);

            var player1 = new PersonViewModel
            {
                PersonId = Guid.NewGuid(),
                FirstName = "Rob",
                LastName = "Dunavan",
                HighScore = 555

            };
            var player2 = new PersonViewModel
            {
                PersonId = Guid.NewGuid(),
                FirstName = "jeff",
                LastName = "george",
                HighScore = 4

            };
            var PlayerScore = _mocker.Create<PlayerScore>();
            var isMaxValue = PlayerScore.IsThisYourHighScore(player1);
            var isMaxValue1 = PlayerScore.IsThisYourHighScore(player2);
            Assert.IsTrue(isMaxValue);
            Assert.IsTrue(isMaxValue1);
        }
    }
}
