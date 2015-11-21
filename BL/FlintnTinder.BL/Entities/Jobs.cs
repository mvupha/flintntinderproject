using FlintnTinder.BL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlintnTinder.BL.Entities
{
    public class Jobs
    {
        public string Client { get; set; }

        public int JobNumber { get; set; }

        public string JobName { get; set; }

        public DateTime DueDate { get; set; }

        public StatusType Status { get; set; }
    }
}
