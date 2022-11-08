using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Cuisine.Core.Domain
{
    public class Recette
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateRecette { get; set; }
       
    }
}
