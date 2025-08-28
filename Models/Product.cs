using System.Security.Principal;

namespace ERPSystem.Models
{
    public class Product : BaseEntity<int>
    {

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Rate { get; set; }
        public string thumbnailUrl { get; set; }
        public List<string> ImagesUrls { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        



        

    }
}
