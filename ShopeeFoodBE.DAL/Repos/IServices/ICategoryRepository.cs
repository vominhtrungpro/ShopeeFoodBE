using ShopeeFoodBE.DAL.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopeeFoodBE.DAL.Repos.IServices
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAllCategory();
    }
}
