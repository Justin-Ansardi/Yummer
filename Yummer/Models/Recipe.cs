namespace Yummer.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; } = "Untitled";
        public string? Ingredients { get; set; }
        public string? Tags { get; set; }
        public string? ImageUrl { get; set; }
        public int CookingTime { get; set; } = 0;
        public int? Yeild { get; set; }
        public string? Steps { get; set; }
        public int? Rating  { get; set; }



    }
}
