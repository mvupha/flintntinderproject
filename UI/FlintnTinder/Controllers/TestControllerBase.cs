using FlintnTinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace FlintnTinder.Controllers
{
    public class TestControllerBase :ApiController
    {
        public int SetupGridParams(GridModel model)
        {
            if (string.IsNullOrWhiteSpace(model.SearchFor))
            {
                model.SearchFor = "null";
            }
            if (string.IsNullOrWhiteSpace(model.SortKey))
            {
                model.SortKey = string.Empty;
            }
            if (string.IsNullOrWhiteSpace(model.SortOrder))
            {
                model.SortOrder = "ASC";
            }

            model.SortKey = model.SortKey.ToLower();

            if (model.CurrentPage == null)
            {
                model.CurrentPage = 1;
            }
            if (model.RecordsPerPage == null)
            {
                model.RecordsPerPage = 100;
            }

            int begin = (model.CurrentPage.Value - 1) * model.RecordsPerPage.Value;
            return begin;
        }
    }
}
