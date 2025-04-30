namespace Open.SharedKernel.Domain.Entities.Abstractions;

public interface IEntity
{
    object?[] GetKeys();
}


public interface IEntity<TKey> : IEntity
{
    TKey Id { get; }
}
