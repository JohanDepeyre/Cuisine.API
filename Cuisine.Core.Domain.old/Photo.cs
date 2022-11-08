namespace Cuisine.Core.Photos.Domain
{
    /// <summary>
    /// réprensente un photo en rapport avec la recette
    /// </summary>
    public class Photo
    {
        public int Id { get; set; } 
        public string ImagePath { get; set; }
        public string Title { get; set; }
        public Recette Recette { get; set; }
    }
}
