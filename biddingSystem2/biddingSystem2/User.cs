using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biddingSystem2
{
    internal class User
    {
        public string nameOfUser;
        public int bidCost;

        public User(string nameOfUser, int bidCost)
        {
            this.nameOfUser = nameOfUser;
            this.bidCost = bidCost;
        }
    }
}
