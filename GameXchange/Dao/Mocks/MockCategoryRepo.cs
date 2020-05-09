using GameXchange.Dao.Interface;
using GameXchange.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameXchange.Dao.Mocks
{
    public class MockCategoryRepo : ICategoryRepo
    {

        public IEnumerable<GameCategory> GameCategories
        {
            get
            {

                return new List<GameCategory>
                     {


                new GameCategory { CategoryName = "Alcoholic", },
                         new GameCategory { CategoryName = "Non-alcoholic" }
                     };
            }
        }

        IEnumerable<GameCategory> ICategoryRepo.GameCategories => throw new NotImplementedException();
    }
}