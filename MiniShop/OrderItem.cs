using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    class OrderItem
    {
        private Product product;
        private int qnty;

        public double ProductPrice { get { return product.Price; } }
        public int Qnty { 
            get { return qnty; } 
            set { qnty = value; }
        }
        public Product Product { 
            get
            {
                return product;
            }
        }

        public OrderItem(Product product, int qnty)
        {
            this.product = product;
            this.qnty = qnty;
        }
    }
}
