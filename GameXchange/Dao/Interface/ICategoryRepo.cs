using GameXchange.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameXchange.Dao.Interface
{
    public interface ICategoryRepo
    {

        IEnumerable<GameCategory> GameCategories { get; }

    }
}
