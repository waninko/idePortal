using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ideportal.backend.Models
{
    public class Submit
    {
        public long Id { get; set; }
        public string SubmitName { get; set; }
        public string SubmitLink { get; set; }
        public string SubmitCategory { get; set; }
    }
}
