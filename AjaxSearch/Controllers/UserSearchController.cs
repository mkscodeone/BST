using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AjaxSearch.Data;
using AjaxSearch.Models.Home;

namespace AjaxSearch.Controllers
{
    public class UserSearchController : ApiController
    {
        public List<Contact> Get(string filter)
        {
            ///Implemented REST WebAPI
            ///For better performance limit the number of records to render in UI
            return TestData.Contacts.Where(c => c.Name.IndexOf(filter ?? string.Empty,StringComparison.CurrentCultureIgnoreCase) >= 0 ).OrderBy(nm=> nm.Name).Take(100).ToList();
        }
    }
}
