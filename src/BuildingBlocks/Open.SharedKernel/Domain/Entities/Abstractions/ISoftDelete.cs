namespace Open.SharedKernel.Domain.Entities.Abstractions;

public interface ISoftDelete
{
    [JsonIgnore]
    bool IsDeleted { get; set; }

    void Delete();
}
