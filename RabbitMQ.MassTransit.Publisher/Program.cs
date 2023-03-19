using MassTransit;
using RabbitMQ.MassTransit.Shared.Messages;

string rabbitMQUri = "amqps://cyauarfr:Ph63wx0KMCvmbd8WLp9V9Px3i51_20L_@chimpanzee.rmq.cloudamqp.com/cyauarfr";

string queueName = "example-queue";
var bus = Bus.Factory.CreateUsingRabbitMq(factory =>
{
    factory.Host(rabbitMQUri);
});

ISendEndpoint sendEndpoint = await bus.GetSendEndpoint(new($"{rabbitMQUri}/{queueName}"));
Console.WriteLine("Gönderilecek Mesaj :");
string message = Console.ReadLine();
sendEndpoint.Send<IMessage>(new ExcampleMessage()
{
    Text = message
});