using System;
using System.Collections.Generic;
using System.Text;

namespace _4_1订单和账本
{
    class OrderForm
    {
        public string name;
        public int num;
        public float price;
        public OrderForm(string name, int num, float price)
        {
            this.name = name;
            this.num = num;
            this.price = price;
        }
        public virtual float GetPrice()
        { return num * price; }
    }

    class AccountBook
    {
        List<OrderForm> lists = new List<OrderForm>();
        public void AddOrderForm(OrderForm o)
        {
            lists.Add(o);
        }

        float sum = 0;
        public float GetTotalPrice()
        {
            foreach (var o in lists)
            {
                sum += o.GetPrice();
            }
            return sum;
        }
    }

}
