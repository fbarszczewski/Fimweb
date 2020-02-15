namespace Fimweb.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SingupFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}