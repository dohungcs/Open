namespace Open.SharedKernel.Domain.DomainEvents;

public interface IGeneratesDomainEvents
{
    public void RegisterDomainEvent(DomainEventRecord record);

    public void RemoveDomainEvent(DomainEventRecord record);

    public void ClearDomainEvents();
}
