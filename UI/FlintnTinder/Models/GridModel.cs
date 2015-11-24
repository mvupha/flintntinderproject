using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlintnTinder.Models
{
    public class GridModel
    {
        public int? CurrentPage { get; set; }

        public  int? RecordsPerPage { get; set; }

        public string SortKey { get; set; }

        public string SortOrder { get; set; }

        public string SearchFor { get; set; }
    }
}
