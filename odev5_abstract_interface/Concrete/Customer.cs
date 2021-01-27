using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev5_abstract_interface.Concrete
{
    public class Customer : IEntity
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string NationalityID { get; set; }
    }
}
