namespace Open.SharedKernel.Domain.Entities.Abstractions;

public interface IAuditedObject
{
    DateTime CreationTime { get; }
    
    Guid? CreatorId { get; }
    
    DateTime? LastModificationTime { get; set; }
    
    Guid? LastModifierId { get; set; }
}
