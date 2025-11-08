using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete.Repositories;
using EntityLayer.Concreta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataAccesLayer.Concrete;


namespace DataAccesLayer.EntityFramework
{
    public class EfContentDal : GenericRepository<Content>, IContentDal
    {
        public List<Content> GetListByHeadingID(int id)
        {
            using (var context = new Context())
            {
                return context.Contents
                              .Include(x => x.Writer)  // Writer bilgilerini de getir
                              .Where(x => x.HeadingID == id)
                              .ToList();
            }
        }

    }
}
