using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameXchange.Dao.Interface;
using GameXchange.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GameXchange.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IGameRepo _gameRepo;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IGameRepo gameRepo, ShoppingCart shoppingCart)
        {
            _gameRepo = gameRepo;
            _shoppingCart = shoppingCart;
        }

        [Authorize]
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

        [Authorize]
        public RedirectToActionResult AddToShoppingCart(int gameId)
        {
            var selectedGame = _gameRepo.GameInfos.FirstOrDefault(p => p.GameId == gameId);
            if (selectedGame != null)
            {
                _shoppingCart.AddToCart(selectedGame, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int gameId)
        {
            var selectedGame = _gameRepo.GameInfos.FirstOrDefault(p => p.GameId == gameId);
            if (selectedGame != null)
            {
                _shoppingCart.RemoveFromCart(selectedGame);
            }
            return RedirectToAction("Index");
        }

    }
}