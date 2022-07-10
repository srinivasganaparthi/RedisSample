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

sub.Subscribe("messages").OnMessage(async channelMessage => {
    await Task.Delay(1000);
    int value = Convert.ToInt32(channelMessage.Message);
    if (value % 2 != 0)
        Console.WriteLine(Convert.ToString(channelMessage.Message));
});

Console.ReadLine();