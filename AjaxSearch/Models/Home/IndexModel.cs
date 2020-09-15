using System.Collections.Generic;
using AjaxSearch.Data;

namespace AjaxSearch.Models.Home
{
    public class IndexModel
    {
        public SearchFilter Filter { get; set; }
        public IEnumerable<Contact> Contacts { get; set; }
    }
}