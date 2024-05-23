using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Entities
{
    public class Customer
    {
        public string UserName { get; set; }
        public int Id { get; set; }
        public string Password { get; set; }
        public string AshrayDetails { get; set; }
    }
}
