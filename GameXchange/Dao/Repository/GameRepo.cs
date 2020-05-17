using GameXchange.Dao.Interface;
using GameXchange.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GameXchange.Dao.Repository
{
    public class GameRepo : IGameRepo
    {
        private readonly ApplicationDbContext _appDbContext;

        public GameRepo(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<GameInfo> GameInfos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEnumerable<GameInfo> GamePrices { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public GameInfo GetGameById(int gameId)
        {
            throw new NotImplementedException();
        }
    }
}
