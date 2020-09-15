using System;

namespace NewCode1.Data
{
    public class Contact
    {
        public Contact(Guid id, string name, string company)
        {
            Id = id;
            Name = name;
            Company = company;
        }

        public Guid Id { get; }
        public string Name { get; }
        public string Company { get; }
    }
}