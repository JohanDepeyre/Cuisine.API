using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using Cuisine.Core.Domain.Interfaces;
using Newtonsoft.Json;

namespace Cuisine.Core.Domain.Entity
{
    public class Recette : IBaseModel
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateRecette { get; set; }
        public List<Etape> Etapes { get; set; }

    }
}
