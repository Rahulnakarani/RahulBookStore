using RahulBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RahulBooks.DataAccess.Repository.IRepository
{
    interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
