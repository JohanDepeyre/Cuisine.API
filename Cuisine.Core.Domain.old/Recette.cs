using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Cuisine.Core.Photos.Domain
{
    public class Recette
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateRecette { get; set; }
        [JsonIgnore]
        public List<Photo> Photos { get; set; }
    }
}
