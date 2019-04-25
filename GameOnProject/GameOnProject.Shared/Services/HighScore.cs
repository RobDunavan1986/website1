using GameOnProject.Shared.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOnProject.Shared.Services
{
    public class HighScore : IHighScore
    {
        public int Value()
        {
            return int.MaxValue;
        }
    }
}
