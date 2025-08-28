namespace ERPSystem.Models
{
    public class Address :BaseEntity<int>
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
    }
}
