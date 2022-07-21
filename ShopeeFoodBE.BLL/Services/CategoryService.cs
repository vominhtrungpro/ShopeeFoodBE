using ShopeeFoodBE.BLL.IServices;
using ShopeeFoodBE.DAL.EF.Entities;
using ShopeeFoodBE.DAL.Repos.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopeeFoodBE.BLL.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryrepository;
        public CategoryService(ICategoryRepository categoryrepository)
        {
            _categoryrepository = categoryrepository;
        }

        public Task<List<Category>> GetAllCategory()
        {
            return _categoryrepository.GetAllCategory();
        }
    }
}
