using System;
using System.Collections.Generic;

namespace _4_1订单和账本
{
    // 打折账本
    class DisCountOrder : OrderForm
    {
        public float discount;
        public DisCountOrder(string name, int num, float price,float discount)
            :base(name,num,price)
        {
            this.discount = discount;
        }
        public override float GetPrice()
        {
            return num * price * discount;
        }
    }

    // 满减账本
    class FullSubOrder : OrderForm
    {
        public float full;
        public float sub;
        public FullSubOrder(string name, int num, float price,float full,float sub)
            : base(name, num, price)
        {
            this.full = full;
            this.sub = sub;
        }
        public override float GetPrice()
        {
            float s = num * price;
            if(s > full)
            {
                s -= sub;
            }
            return s;
        }

    }


    
    class Program
    {
        static void Main(string[] args)
        {
            OrderForm o1 = new OrderForm("苹果", 3, 1);
            OrderForm o2 = new OrderForm("香蕉", 34, 0.5f);
            OrderForm o3 = new OrderForm("橙子", 1, 90);
            FullSubOrder o4 = new FullSubOrder("车厘子", 20, 0.3f, 5, 1);
            DisCountOrder o5 = new DisCountOrder("西瓜", 1, 20, 0.8f);



            AccountBook book = new AccountBook();
            book.AddOrderForm(o1);
            book.AddOrderForm(o2);
            book.AddOrderForm(o3);
            book.AddOrderForm(o4);
            book.AddOrderForm(o5);

            Console.WriteLine($"总价是{book.GetTotalPrice()}");
        }
        
        
    }
}
