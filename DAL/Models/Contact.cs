using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfKnygute.DAL.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Number { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Contact(string fullName, int id, string number, DateTime dateOfBirth)
        {
            this.FullName = fullName;
            this.Id = id;
            this.Number = number;
            this.DateOfBirth = dateOfBirth;
        }

        public Contact()
        {
                
        }

    }
}
