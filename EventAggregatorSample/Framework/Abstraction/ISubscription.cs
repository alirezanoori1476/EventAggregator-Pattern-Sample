namespace EventAggregatorSample.Framework.Abstraction;

public interface ISubscription : IDisposable
{
    void Unsubscribe();
}