using AllupProject.Models.Base;

namespace AllupProject.Models
{
    public class Slider : BaseEntity
    {
        public string Title { get; set; } = null!;
        public string Subtitle { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? Offer { get; set; }
        public string ImageUrl { get; set; } = null!;
    }
}
