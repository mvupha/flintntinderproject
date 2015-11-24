using FlintnTinder.BL.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FlintnTinder.BL.Provider
{
    public class JobsProvider : IJobProvider
    {
        public string GetJobs()
        {
            string job;
            using (StreamReader reader = new StreamReader(@"C:\Users\Lawrence\Documents\RepoProjects\FlintnTInder\BL\FlintnTinder.BL\Objects\jobs.json"))
            {
                job = reader.ReadToEnd();
                Jobs jobs = JsonConvert.DeserializeObject<Jobs>(job);
            }
            return job;
        }

        public string PostJobs()
        {
            string json = JsonConvert.SerializeObject(GetJobs(), Formatting.Indented);
            return json;
        }

    }
}
