namespace WorldArchive.Domain.Models.Base
{
    public interface IEntityBase
    {
        int Id { get; set; }
        DateTime CreatedAt { get; }
        DateTime? UpdatedAt { get; }
    }
}
