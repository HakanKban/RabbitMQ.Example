using MassTransit;
using RabbitMQ.MassTransit.Consumer.Consumer;
using RabbitMQ.MassTransit.Shared.Messages;

string rabbitMQUri = "amqps://cyauarfr:Ph63wx0KMCvmbd8WLp9V9Px3i51_20L_@chimpanzee.rmq.cloudamqp.com/cyauarfr";

string queueName = "example-queue";
var bus = Bus.Factory.CreateUsingRabbitMq(factory =>
{
    factory.Host(rabbitMQUri);
    factory.ReceiveEndpoint(queueName,endpoint =>
    {
        endpoint.Consumer<ExampleMessageConsumer>();
    });
});

await bus.StartAsync();
Console.ReadLine(); 
