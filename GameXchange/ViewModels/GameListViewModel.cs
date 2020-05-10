using GameXchange.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameXchange.ViewModels
{
    public class GameListViewModel
    {
        public IEnumerable<GameInfo> GameInfos { get; set; }
        public string CurrentCategory { get; set; }
    }
}
