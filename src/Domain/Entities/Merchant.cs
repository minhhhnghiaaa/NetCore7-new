namespace NetCore7.Domain.Entities;

public class Merchant : BaseAuditableEntity
{
    public Merchant()
    {
        Members = new HashSet<Member>();
    }

    public string Name { get; set; } = String.Empty;
    public string BankName { get; set; } = String.Empty;
    public string AccountNumber { get; set; } = String.Empty;
    public string SwiftCode { get; set; } = String.Empty;
    public int Balance { get; set; }

    public virtual ICollection<Member> Members { get; set; }
}