using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventBus.Demo.Infrastructure;

namespace EventBus.Demo.Events
{
    public class OrderGeneratorEvent : IEvent
    {
        public int OrderID { get; set; }
    }
}
