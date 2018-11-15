using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class WebHookLogs
    {
        public int Id { get; set; }
        public int WebHookId { get; set; }
        public string Trigger { get; set; }
        public string Url { get; set; }
        public string RequestHeaders { get; set; }
        public string RequestData { get; set; }
        public string ResponseHeaders { get; set; }
        public string ResponseBody { get; set; }
        public string ResponseStatus { get; set; }
        public double? ExecutionDuration { get; set; }
        public string InternalErrorMessage { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public WebHooks WebHook { get; set; }
    }
}
