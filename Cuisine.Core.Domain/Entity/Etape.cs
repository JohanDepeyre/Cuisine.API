using Cuisine.Core.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Cuisine.Core.Domain.Entity
{
    public class Etape : IBaseModel
    {
        public string Titre { get; set; }
        
        public string Description { get; set; }
        public int RecetteId { get; set; }
        public Recette Recette { get; set; }

    }
}
