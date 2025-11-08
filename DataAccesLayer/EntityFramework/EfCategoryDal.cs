using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete.Repositories;
using EntityLayer.Concreta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFramework
{
    public class EfCategoryDal: GenericRepository<Category>,ICategoryDal
    {
        
    }
}
