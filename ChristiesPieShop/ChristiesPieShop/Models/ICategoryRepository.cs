using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChristiesPieShop.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
