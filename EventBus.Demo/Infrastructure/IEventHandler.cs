using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Demo.Infrastructure
{

    /// <summary>
    /// 事件处理基类
    /// </summary>
    /// <typeparam name="TEvent">继承IEvent对象的事件源对象</typeparam>
    public interface IEventHandler<TEvent>
        where TEvent : IEvent
    {
        void Handle(TEvent evt);
    }
}
