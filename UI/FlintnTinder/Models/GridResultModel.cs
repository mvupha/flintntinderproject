using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlintnTinder.Models
{
    public class ActionResult<T>
    {
        public ActionResult(List<T>data,int totalResults)
        {
            Results = data;
            RecordCount = totalResults;
        }

        public List<T> Results { get; set; }

        public int RecordCount { get; set; }
    }
}
