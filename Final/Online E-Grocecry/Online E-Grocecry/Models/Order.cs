using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_E_Grocecry.Models
{
    public class Order
    {
        public int orderId
        {
            get;
            set;
        }
        public string itemName
        {
            get;
            set;
        }
        public string orderPlace
        {
            get;
            set;
        }
    }
}
