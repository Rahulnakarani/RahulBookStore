using RahulBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RahulBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository: IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
