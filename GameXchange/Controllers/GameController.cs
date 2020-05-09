using GameXchange.Dao.Interface;
using GameXchange.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameXchange.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameRepo _gameRepo;
        private readonly ICategoryRepo _categoryRepo;

        public GameController(IGameRepo gameRepo, ICategoryRepo categoryRepo)
        {
            _gameRepo = gameRepo;
            _categoryRepo = categoryRepo;
        }

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<GameInfo> gameInfos;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                gameInfos = _gameRepo.GameInfos.OrderBy(p => p.GameId);
                currentCategory = "All drinks";
            }
            else
            {
                if (string.Equals("Alcoholic", _category, StringComparison.OrdinalIgnoreCase))
                    gameInfos = _gameRepo.GameInfos.Where(p => p.Category.CategoryName.Equals("Alcoholic")).OrderBy(p => p.Name);
                else
                    gameInfos = _gameRepo.GameInfos.Where(p => p.Category.CategoryName.Equals("Non-alcoholic")).OrderBy(p => p.Name);

                currentCategory = _category;
            }

            return View(new GamesListViewModel
            {
                GameInfos = gameInfos,
                CurrentCategory = currentCategory
            });
        }

        //public ViewResult Search(string searchString)
        //{
        //    string _searchString = searchString;
        //    IEnumerable<GameInfo> gameInfos;
        //    string currentCategory = string.Empty;

        //    if (string.IsNullOrEmpty(_searchString))
        //    {
        //        gameInfos = _gameRepo.GameInfos.OrderBy(p => p.GameId);
        //    }
        //    else
        //    {
        //        gameInfos = _gameRepo.GameInfos.Where(p => p.Name.ToLower().Contains(_searchString.ToLower()));
        //    }

        //    return View("~/Views/Drink/List.cshtml", new DrinksListViewModel { GameInfos = gameInfos, CurrentCategory = "All drinks" });
        //}

        //public ViewResult Details(int gameId)
        //{
        //    var game = _gameRepo.GameInfos.FirstOrDefault(d => d.GameId == gameId);
        //    if (game == null)
        //    {
        //        return View("~/Error.cshtml");
        //    }
        //    return View(game);
    }
}

