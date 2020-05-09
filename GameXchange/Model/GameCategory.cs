using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameXchange.Model
{
    public class GameCategory
    {
        public int GameCategoryId { get; set; }

        public string CategoryName { get; set; }

        List<GameInfo> GameInfos { get; set; }




    }
}
