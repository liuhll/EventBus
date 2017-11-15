using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventBus.Demo.EventHandlers;
using EventBus.Demo.Events;

namespace EventBus.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            EventBus.Demo.Infrastructure.EventBus.Instance.Subscribe(new OrderAddedEventHandler_SendEmail());
            var entity = new OrderGeneratorEvent { OrderID = 1 };
            Console.WriteLine("生成一个订单，单号为{0}", entity.OrderID);
            EventBus.Demo.Infrastructure.EventBus.Instance.Publish(entity);
            Console.ReadKey();

       
        }
    }
}
