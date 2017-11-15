using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Demo.Infrastructure
{
    public class ActionDelegatedEventHandler<TEvent> : IEventHandler<TEvent> where TEvent : IEvent
    {
        /// <summary>
        /// 定义Action的引用，并通过构造函数传参初始化
        /// </summary>
        public Action<TEvent> Action { get; private set; }

        public ActionDelegatedEventHandler(Action<TEvent> handler)
        {
            Action = handler;
        }

        /// <summary>
        /// 调用具体的Action来处理事件逻辑
        /// </summary>
        /// <param name="eventData"></param>
        public void Handle(TEvent eventData)
        {
            Action(eventData);
        }
    }
}
