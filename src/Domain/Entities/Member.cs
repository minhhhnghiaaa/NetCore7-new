namespace NetCore7.Domain.Entities;

public class Member : BaseAuditableEntity
{
    public string Name { get; set; } = String.Empty;
    public string Address { get; set; } = String.Empty;
    public int Age { get; set; }
    public string Email { get; set; } = String.Empty;
    public string Phone { get; set; } = String.Empty;

    public Guid MerchantId { get; set; }
    public virtual Merchant? Merchant { get; set; }
}