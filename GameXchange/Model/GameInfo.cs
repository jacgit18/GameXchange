using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameXchange.Model
{
    public class GameInfo
    {
        public int GameId { get; set; }

        public string Name { get; set; }


        public string ImageUrl { get; set; }

        public string ImageThumbnailUrl { get; set; }


        public string GameDescription { get; set; }

        public decimal GamePrice { get; set; }

        public bool GameQuantity { get; set; }

        public int GameCategoryId { get; set; }

        public virtual GameCategory Category { get; set; }


    }
}
