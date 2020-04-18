using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{

    enum OrderStatus
    {
        NewOrder,
        Complete,
        Confirmed,
        Shipped,
        Returned,
        Cancelled
    }

    public class Order
    {
        private String orderNumber;
        private List<OrderItem> items = new List<OrderItem>();
        private byte discount = 0; //wartosc procentowa
        private Customer customerName;
        private String shipAddress;
        private DateTime orderDate;
        private OrderStatus status = OrderStatus.NewOrder;
        //

        public bool AddProduct(Product product, int qnty)
        {
            if (status == OrderStatus.NewOrder)
            {
                items.Add(new OrderItem(product, qnty));
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveProduct(Product product)
        {
            if (status == OrderStatus.NewOrder)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Clear()
        {
            if (status == OrderStatus.NewOrder)
            {
                items.Clear();
                return true;
            }
            else
            {
                return false;
            }
        }

        private double CalcTotalAmount()
        {
            double amount = 0.0;
            foreach (OrderItem item in items)
            {
                amount += item.ProductPrice * item.Qnty;
            }

            if (discount>0 && discount<=100)
            {
                amount *= (100 - discount)/100.0;
            }
            return amount;
        }

    }
}
