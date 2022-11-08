using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuisine.Core.Framework
{
    /// <summary>
    /// défini le repository
    /// </summary>
    public interface IRepository
    {
        IUnitOfWork unitOfWork { get; }
    }
}
