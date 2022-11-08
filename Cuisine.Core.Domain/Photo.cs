using System.ComponentModel.DataAnnotations.Schema;

namespace Cuisine.Core.Domain
{
    /// <summary>
    /// réprensente un photo en rapport avec la recette
    /// </summary>
    public class Photo
    {
        public int Id { get; set; } 
        public string ImagePath { get; set; }
        public string Title { get; set; }
        [ForeignKey("Recette")]
        public int IdRecette { get; set; }
    }
}
