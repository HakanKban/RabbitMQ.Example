using MassTransit;
using RabbitMQ.MassTransit.Shared.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ.MassTransit.Consumer.Consumer
{
    public class ExampleMessageConsumer : IConsumer<IMessage>
    {
        public Task Consume(ConsumeContext<IMessage> context)
        {
            Console.WriteLine($"gelen mesaj :{context.Message.Text}");
            return Task.CompletedTask;
        }
    }
}
