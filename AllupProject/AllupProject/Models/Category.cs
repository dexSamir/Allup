using AllupProject.Models.Base;

namespace AllupProject.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = null!; 
        public string ImageUrl { get; set; } = null!;

    }
}
