// See https://aka.ms/new-console-template for more information
using StackExchange.Redis;

ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(
        new ConfigurationOptions
        {
            EndPoints = { "127.0.0.1:6379" }
        });
var db = redis.GetDatabase();
var pong = await db.PingAsync();
Console.WriteLine(pong);


ISubscriber sub = redis.GetSubscriber();
PublishMessages();

void PublishMessages()
{
    Console.WriteLine("Enter Number");
    var message = Console.ReadLine();

    sub.Publish("messages", message);

    PublishMessages();
}


