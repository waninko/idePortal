using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ideportal.backend.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectLink { get; set; }
        public string ProjectCategory { get; set; }
    }
}
