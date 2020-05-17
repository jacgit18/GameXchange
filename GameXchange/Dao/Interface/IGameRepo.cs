using GameXchange.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameXchange.Dao.Interface
{
    public interface IGameRepo
    {
        IEnumerable<GameInfo> GameInfos { get;}

        IEnumerable<GameInfo> GamePrices { get; }

        GameInfo GetGameById(int gameId);

    }
}
