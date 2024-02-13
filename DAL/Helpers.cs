using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfKnygute.DAL.Models;

namespace WpfKnygute.DAL
{
    public class Helpers
    {
        public static List<Contact> Contacts { get; set; } = new List<Contact>();
        public static Contact ContactModel { get; set; } = new Contact();
        public static TypeOfFunction Function { get; set; }
    }
}
