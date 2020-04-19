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
        public double TotalAmount { 
            get { 
                return CalcTotalAmount(); 
            } 
        }

        private int GetProductIndex(Product product)
        {
            int result = -1;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Product.Equals(product))
                {
                    return i;
                }
            }
            return result;
        }

        public bool AddProduct(Product product, int qnty)
        {
            if (status == OrderStatus.NewOrder && qnty>0 && product!=null)
            {

                //int productIndex = GetProductIndex(product);
                //if (productIndex == -1)
                //{
                //    items.Add(new OrderItem(product, qnty));
                //} else
                //{
                //    items[productIndex].Qnty += qnty;
                //}
                OrderItem found = items.Find(x => x.Product.Equals(product));
                if (found==null)
                {
                    items.Add(new OrderItem(product, qnty));
                } else
                {
                    found.Qnty += qnty;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveProduct(Product product, int qnty=0)
        {
            if (!(status == OrderStatus.NewOrder && qnty >= 0 && product != null))
            {
                return false;
            }

            //int productIndex = GetProductIndex(product);
            int productIndex = items.FindIndex(e => e.Product.Equals(product));
            if (productIndex == -1) return false;

            if (qnty > items[productIndex].Qnty) return false;

            if (qnty==0 || qnty== items[productIndex].Qnty)
            {
                items.RemoveAt(productIndex);
                return true;
            }



            //aktualizacja Qnty dla danego produktu
            items[productIndex].Qnty -= qnty;

            return true;
           
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
            //foreach (OrderItem item in items)
            //{
            //    amount += item.ProductPrice * item.Qnty;
            //}
            items.ForEach(e => amount += e.ProductPrice * e.Qnty);

            if (discount>0 && discount<=100)
            {
                amount *= (100 - discount)/100.0;
            }
            return amount;
        }

        private int GetLongestTitle()
        {
            int result = 0;
            foreach (OrderItem item in items)
            {
                if (item.Product.Name.Length > result)
                    result = item.Product.Name.Length;
            }
            return result+2;
        }

        public void Print()
        {
            Console.WriteLine("Elementy zamówienia:");
            items.ForEach(e =>
             Console.WriteLine("{0,-" + GetLongestTitle() + "}|{1,10}|{2,10:0.00}|{3,10:0.00}|",
                    e.Product.Name, e.Qnty, e.ProductPrice, e.Qnty * e.ProductPrice)
            );
            //foreach (OrderItem item in items)
            //{
            //    Console.WriteLine("{0,-"+ GetLongestTitle() +"}|{1,10}|{2,10:0.00}|{3,10:0.00}|", 
            //        item.Product.Name, item.Qnty, item.ProductPrice, item.Qnty * item.ProductPrice);
            //}
            Console.WriteLine("Kwota: {0}", CalcTotalAmount());
        }

    }
}
