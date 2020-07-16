using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ideportal.backend.Models
{
    public class Admin
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
