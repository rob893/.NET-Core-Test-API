using System.Collections.Generic;

namespace TestAPI.Models
{
    public class Person
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string[] Emails { get; set; }
        public string Gender { get; set; }
        public long Concurrency { get; set; }
        public Dictionary<string, dynamic>[] AddressInfo { get; set; }

    }
}