using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Users
    {
        public Users()
        {
            LocalMembers = new HashSet<LocalMembers>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime? Created { get; set; }
        public string Fullname { get; set; }

        public ICollection<LocalMembers> LocalMembers { get; set; }
    }
}
