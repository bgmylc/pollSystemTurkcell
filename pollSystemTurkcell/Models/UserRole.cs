using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pollSystemTurkcell.Models
{
    public class UserRole
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IList<User> Users { get; set; }
    }
}
