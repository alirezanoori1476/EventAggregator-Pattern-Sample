using EventAggregatorSample.Events;
using EventAggregatorSample.Framework;

var aggregator = EventAggregator.CreateNewOne;

aggregator.Subscribe(new DelegatingHandler<MyRandomEventEvent>(a => Console.WriteLine(a.Id)));

while (true)
{
    var myRandomData = Guid.NewGuid();

    aggregator.Publish(MyRandomEventEvent.CreateNewOne(myRandomData));

    Thread.Sleep(1000);
}