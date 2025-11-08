using EntityLayer.Concreta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstarct
{
    public interface IAdminService
    {
        List<Admin> GetList();
        void AdminAdd(Admin admin);
        Admin GetbyId(int id);
        void AdminDelete(Admin admin);
        void AdminUpdate(Admin admin);
    }
}
