﻿using ShopeeFoodBE.DAL.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopeeFoodBE.BLL.IServices
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllCategory();
    }
}