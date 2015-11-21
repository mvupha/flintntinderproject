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
    public class JobsProvider
    {
        public string GetJobs()
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\Lawrence\Documents\Visual Studio 2015\Projects\FlintnTInder\BL\FlintnTinder.BL\Objects\jobs.json"))
            {
                string job = reader.ReadToEnd();
                Jobs jobs = JsonConvert.DeserializeObject<Jobs>(job);
                return job;
            }
        }
    }
}
