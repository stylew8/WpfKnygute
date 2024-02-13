using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using WpfKnygute.DAL.Models;

namespace WpfKnygute.DAL
{
    public interface IRepositoryDAL
    {
        void Add(Contact contact);
        void Delete(int id);
        void Update(Contact contact);
        List<Contact> GetAllContacts();
    }
}
