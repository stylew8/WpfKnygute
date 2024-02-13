using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfKnygute.DAL;
using WpfKnygute.DAL.Models;

namespace WpfKnygute.BL
{
    public class Repository : IRepository
    {
        private readonly IRepositoryDAL reposDAL;

        public Repository(IRepositoryDAL r)
        {
            this.reposDAL = r;
        }

        public void Add(Contact contact)
        {
            reposDAL.Add(contact);
            Helpers.Contacts.Add(contact);
        }

        public void Delete(int id)
        {
            reposDAL.Delete(id);

            var itemToRemove = Helpers.Contacts.FirstOrDefault(x => x.Id == id);
            if (itemToRemove != null)
            {
                Helpers.Contacts.Remove(itemToRemove);
            }
        }

        public void Update(Contact contact)
        {
            reposDAL.Update(contact);

            var itemToUpdate = Helpers.Contacts.FirstOrDefault(x => x.Id == contact.Id);
            if (itemToUpdate != null)
            {
                Helpers.Contacts.Remove(itemToUpdate);
                itemToUpdate.Id = contact.Id;
                itemToUpdate.FullName = contact.FullName;
                itemToUpdate.Number = contact.Number;
                itemToUpdate.DateOfBirth = contact.DateOfBirth;
                Helpers.Contacts.Add(itemToUpdate);
            }


        }
    }
}
