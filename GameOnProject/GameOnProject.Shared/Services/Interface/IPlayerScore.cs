using GameOnProject.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOnProject.Shared.Services.Interface
{
  public  interface IPlayerScore
    {
        bool IsThisYourHighScore(PersonViewModel player);
    }
}
