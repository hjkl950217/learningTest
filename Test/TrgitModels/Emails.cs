using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Emails
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string ConfirmationToken { get; set; }
        public DateTime? ConfirmedAt { get; set; }
        public DateTime? ConfirmationSentAt { get; set; }
    }
}
