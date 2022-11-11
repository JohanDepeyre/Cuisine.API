using Cuisine.Core.Infrastructures.Data;
using Cuisine.Core.Domain;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuisine.Core.Framework;
using Cuisine.Core.Domain.Repository;
using Cuisine.Core.Domain.Entity;

namespace Cuisine.Core.Infrastructures.Repository
{
    public class DefaultEtapeRepository : IEtapeRepository
    {
        public readonly DatabaseContext _context;
        public DefaultEtapeRepository(DatabaseContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IUnitOfWork unitOfWork => this._context;

      
        public Etape AddOne(Etape photo)
        {
            throw new NotImplementedException();
        }

        public ICollection<Etape> GetAll()
        {
            return _context.Etapes.ToList();
        }

      
    }
}
