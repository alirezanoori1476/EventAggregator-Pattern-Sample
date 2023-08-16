using EventAggregatorSample.Framework.Abstraction;

namespace EventAggregatorSample.Events;

public sealed class MyRandomEventEvent : IEvent
{
    public Guid Id { get; private set; } //Random Data

    private MyRandomEventEvent(Guid id)
    {
        Id = id;
    }

    public static MyRandomEventEvent CreateNewOne(Guid guid)
    {
        return new MyRandomEventEvent(guid);
    }
}