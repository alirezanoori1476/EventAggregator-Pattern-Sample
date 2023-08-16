using EventAggregatorSample.Framework.Abstraction;

namespace EventAggregatorSample.Framework;

public class DelegatingHandler<T> : IEventHandler<T> where T : IEvent
{
    private readonly Action<T> _action;

    public DelegatingHandler(Action<T> action)
    {
        _action = action;
    }

    public void Handle(T @event)
    {
        _action.Invoke(@event);
    }
}