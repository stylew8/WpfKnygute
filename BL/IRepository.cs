using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfKnygute.DAL.Models;

namespace WpfKnygute.BL
{
    public interface IRepository
    {
        void Add(Contact contact);
        void Delete(int id);
        void Update(Contact contact);
    }
}
