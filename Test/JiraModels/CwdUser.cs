using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class CwdUser
    {
        public decimal Id { get; set; }
        public decimal? DirectoryId { get; set; }
        public string UserName { get; set; }
        public string LowerUserName { get; set; }
        public int? Active { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string FirstName { get; set; }
        public string LowerFirstName { get; set; }
        public string LastName { get; set; }
        public string LowerLastName { get; set; }
        public string DisplayName { get; set; }
        public string LowerDisplayName { get; set; }
        public string EmailAddress { get; set; }
        public string LowerEmailAddress { get; set; }
        public string Credential { get; set; }
        public int? DeletedExternally { get; set; }
        public string ExternalId { get; set; }
    }
}
