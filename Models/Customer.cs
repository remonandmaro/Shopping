namespace ERPSystem.Models
{
    public class Customer : BaseEntity<int>
    {

        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Password { get; set; }

    }
}
