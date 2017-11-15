using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventBus.Demo.Events;
using EventBus.Demo.Infrastructure;

namespace EventBus.Demo.EventHandlers
{
    /// <summary>
    /// 发邮件功能
    /// </summary>
    public class OrderAddedEventHandler_SendEmail : IEventHandler<OrderGeneratorEvent>
    {
        public void Handle(OrderGeneratorEvent evt)
        {
            Console.WriteLine("Order_Number:{0},Send a Email.", evt.OrderID);
        }
    }
}
