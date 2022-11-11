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
    public interface IPhotoRepository : IRepository
    {/// <summary>
     /// recupére pout les photos
     /// </summary>
     /// <returns></returns>
        ICollection<Photo> GetAll();
        /// <summary>
        /// ajoute une photo
        /// </summary>
        /// <param name="photo"></param>
        /// <returns></returns>
        Photo AddOne(Photo photo);
    }
}
