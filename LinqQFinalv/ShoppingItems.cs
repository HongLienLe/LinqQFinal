using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqQFinalv
{
    public class ShoppingItems
    {
        public string itemId;
        public string product;
        public int quantity;
        public ShoppingItems(string itemId, string product, int quantity)
        {
            this.itemId = itemId;
            this.product = product;
            this.quantity = quantity;

        }

        public List<ShoppingItems> shoppingList = new List<ShoppingItems>
        {
            new ShoppingItems("1", "Biscuit", 458),
            new ShoppingItems("2", "Chocolate", 650),
            new ShoppingItems("3", "Butter", 800),
            new ShoppingItems("4", "Butter", 900),
            new ShoppingItems("5", "Butter", 900),
            new ShoppingItems("6", "Biscuit", 700),

        };

}
}
