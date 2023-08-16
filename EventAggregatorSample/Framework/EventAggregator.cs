using EventAggregatorSample.Framework.Abstraction;

namespace EventAggregatorSample.Framework;

public sealed class EventAggregator : IEventListener, IEventPublisher
{
    private readonly List<object> _handlers = new();

    public ISubscription Subscribe<T>(IEventHandler<T> handler) where T : IEvent
    {
        _handlers.Add(handler);

        return new DelegatingSubscription(() => _handlers.Remove(handler));
    }

    public void Publish<T>(T eventToPublish) where T : IEvent
    {
        var candidates = _handlers.OfType<IEventHandler<T>>().ToList();

        candidates.ForEach(a => a.Handle(eventToPublish));
    }

    public static EventAggregator CreateNewOne => new();
}