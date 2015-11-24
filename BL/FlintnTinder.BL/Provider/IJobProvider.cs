using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlintnTinder.BL.Provider
{
    public interface IJobProvider
    {
        string GetJobs();
        string PostJobs();
    }
}
