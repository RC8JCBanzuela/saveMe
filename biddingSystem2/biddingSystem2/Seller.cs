using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biddingSystem2
{
    internal class Seller
    {
        public string sellerName;
        public int itemPrice;
        public string itemName;

        public Seller(string sellerName, int itemPrice, string itemName)
        {
            this.sellerName = sellerName;
            this.itemName = itemName;
            this.itemPrice = itemPrice;
        }
    }
}
