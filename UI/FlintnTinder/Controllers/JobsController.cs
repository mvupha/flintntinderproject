using FlintnTinder.BL.Provider;
using FlintnTinder.Models;
using FlintnTinder.Models.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FlintnTinder.Controllers
{
    public class JobsController : Controller
    {
        IJobProvider provider = new JobsProvider();

        [HttpPost]
        public ActionResult<JobsGridModel> JobsGrid(GridModel model)
        {
            TestControllerBase testControllerBase = new TestControllerBase();
            JobsGridModel jobsGridModel = new JobsGridModel();
            int begin = testControllerBase.SetupGridParams(model);
            var filteredQuery = provider.PostJobs().Select(a => new JobsGridModel()
            {
                Client = jobsGridModel.Client,
                DueDate = jobsGridModel.DueDate,
                JobName = jobsGridModel.JobName,
                JobNumber = jobsGridModel.JobNumber,
                Status = jobsGridModel.Status
            });

            if (model.SearchFor != "null")
            {
                filteredQuery = filteredQuery.Where(
                                              a => a.Client.Contains(model.SearchFor)
                                              || a.JobName.Contains(model.SearchFor));
            }

            var totalNumberOfRecords = filteredQuery.Count();

            if (String.IsNullOrWhiteSpace(model.SortKey))
            {
                filteredQuery = filteredQuery.OrderBy(a => a.Client);
            }

            if (!string.IsNullOrWhiteSpace(model.SortKey))
            {
                model.SortKey = model.SortKey.ToLower();

            }
            switch (model.SortOrder)
            {
                case "ASC":
                    switch (model.SortKey)
                    {
                        case "client":
                            filteredQuery = filteredQuery.OrderBy(a => a.Client);
                            break;
                        case "duedate":
                            filteredQuery = filteredQuery.OrderBy(a => a.DueDate);
                            break;
                        case "jobname":
                            filteredQuery = filteredQuery.OrderBy(a => a.JobName);
                            break;
                        case "jobnumber":
                            filteredQuery = filteredQuery.OrderBy(a => a.JobNumber);
                            break;
                        case "status":
                            filteredQuery = filteredQuery.OrderBy(a => a.Status);
                            break;
                    }
                    break;
                case "DESC":
                    switch (model.SortKey)
                    {
                        case "client":
                            filteredQuery = filteredQuery.OrderBy(a => a.Client);
                            break;
                        case "duedate":
                            filteredQuery = filteredQuery.OrderBy(a => a.DueDate);
                            break;
                        case "jobname":
                            filteredQuery = filteredQuery.OrderBy(a => a.JobName);
                            break;
                        case "jobnumber":
                            filteredQuery = filteredQuery.OrderBy(a => a.JobNumber);
                            break;
                        case "status":
                            filteredQuery = filteredQuery.OrderBy(a => a.Status);
                            break;
                    }
                    break;
            }
            filteredQuery = filteredQuery.Skip(begin).Take(model.RecordsPerPage.Value);

            return new ActionResult<JobsGridModel>(filteredQuery.ToList(), totalNumberOfRecords);
        }
    }
}
