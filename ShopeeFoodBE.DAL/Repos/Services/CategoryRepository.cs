using Microsoft.EntityFrameworkCore;
using ShopeeFoodBE.DAL.EF.Data;
using ShopeeFoodBE.DAL.EF.Entities;
using ShopeeFoodBE.DAL.Repos.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopeeFoodBE.DAL.Repos.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _datacontext;

        public CategoryRepository(DataContext datacontext)
        {
            _datacontext = datacontext;
        }

        public async Task<List<Category>> GetAllCategory()
        {
            var data = await _datacontext.Category.ToListAsync();
            return data;
        }
    }
}
