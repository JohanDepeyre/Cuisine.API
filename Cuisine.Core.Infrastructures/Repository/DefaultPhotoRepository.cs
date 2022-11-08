using Cuisine.Core.Infrastructures.Data;
using Cuisine.Core.Domain;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuisine.Core.Framework;

namespace Cuisine.Core.Infrastructures.Repository
{
    public class DefaultPhotoRepository : IPhotoRepository
    {
        public readonly DatabaseContext _context;
        public DefaultPhotoRepository(DatabaseContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IUnitOfWork unitOfWork => this._context;

        public Photo AddOne(Photo photo)
        {
            return this._context.Add(photo).Entity;
        }
     
        public ICollection<Photo> GetAll()
        {
            return _context.Photos.ToList();
        }
    }
}
