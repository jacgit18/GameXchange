using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameXchange.Model
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public GameInfo GameInfo { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
