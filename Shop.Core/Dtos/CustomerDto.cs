using Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Dtos
{
    public class CustomerDto
    {
        public string UserName { get; set; }
        public int Id { get; set; }
        public string AshrayDetails { get; set; }
    }
}
