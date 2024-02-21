using CRUDApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDApplication.Entities
{
    public class Instructor:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
