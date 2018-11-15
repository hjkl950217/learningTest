using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class CwdUser
    {
        public CwdUser()
        {
            CwdMembership = new HashSet<CwdMembership>();
            CwdUserAttribute = new HashSet<CwdUserAttribute>();
            CwdUserCredentialRecord = new HashSet<CwdUserCredentialRecord>();
        }

        public decimal Id { get; set; }
        public string UserName { get; set; }
        public string LowerUserName { get; set; }
        public string Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string FirstName { get; set; }
        public string LowerFirstName { get; set; }
        public string LastName { get; set; }
        public string LowerLastName { get; set; }
        public string DisplayName { get; set; }
        public string LowerDisplayName { get; set; }
        public string EmailAddress { get; set; }
        public string LowerEmailAddress { get; set; }
        public string ExternalId { get; set; }
        public decimal DirectoryId { get; set; }
        public string Credential { get; set; }

        public CwdDirectory Directory { get; set; }
        public ICollection<CwdMembership> CwdMembership { get; set; }
        public ICollection<CwdUserAttribute> CwdUserAttribute { get; set; }
        public ICollection<CwdUserCredentialRecord> CwdUserCredentialRecord { get; set; }
    }
}
