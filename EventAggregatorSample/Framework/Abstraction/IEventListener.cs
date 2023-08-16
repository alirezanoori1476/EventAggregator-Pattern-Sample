namespace EventAggregatorSample.Framework.Abstraction;

public interface IEventListener
{
    void Publish<T>(T eventToPublish) where T : IEvent;
}