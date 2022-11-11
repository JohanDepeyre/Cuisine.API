using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Cuisine.Core.Framework;
using Cuisine.Core.Domain.Entity;

namespace Cuisine.Core.Domain.Repository
{
    /// <summary>
    /// Repository pour gerer Photo
    /// </summary>
    public interface IRecetteRepository : IRepository
    {/// <summary>
     /// recupére pout les photos
     /// </summary>
     /// <returns></returns>
        ICollection<Recette> GetAll();
        /// <summary>
        /// ajoute une photo
        /// </summary>
        /// <param name="photo"></param>
        /// <returns></returns>
        Recette AddOne(Recette photo);
    }
}
