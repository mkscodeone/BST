using System;

namespace AjaxSearch.Data
{
    public class Contact
    {
        public Contact(Guid id, string name, string company)
        {
            Id = id;
            Name = name;
            Company = company;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Company { get; private set; }
    }
}