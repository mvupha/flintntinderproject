using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlintnTinder.BL.Provider;

namespace FlintnTinder.BL.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetJobs()
        {
            IJobProvider provider = new JobsProvider();
            string getAllJobs = provider.GetJobs();
        }

        [TestMethod]
        public void PostJobs()
        {
            IJobProvider provider = new JobsProvider();
            string postAllJobs = provider.PostJobs();
        }
    }
}
