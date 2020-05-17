using GameXchange.Dao.Interface;
using GameXchange.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameXchange.Dao.Repository
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly ApplicationDbContext _appDbContext;

        public CategoryRepo(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<GameCategory> GameCategories => throw new NotImplementedException();
    }
}
