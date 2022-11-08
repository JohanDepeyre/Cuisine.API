using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuisine.Core.Photos.Domain
{
    public interface IPhotoRepository
    {
        ICollection<Photo> GetAll();
    }
}
