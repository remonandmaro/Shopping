namespace ERPSystem.Models
{
    public class BaseEntity<TKey>
    {
        public virtual TKey Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

    }
}