namespace EventAggregatorSample.Framework.Abstraction;

public interface IEventPublisher
{
    ISubscription Subscribe<T>(IEventHandler<T> handler) where T : IEvent;
}