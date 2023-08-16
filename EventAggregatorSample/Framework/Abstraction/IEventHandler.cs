namespace EventAggregatorSample.Framework.Abstraction;

public interface IEventHandler<T> where T : IEvent
{
    void Handle(T @event);
}