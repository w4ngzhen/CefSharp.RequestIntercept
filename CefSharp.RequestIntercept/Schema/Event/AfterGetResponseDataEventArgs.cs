using Microsoft.SqlServer.Server;

namespace CefSharp.RequestIntercept.Schema.Event
{
    public class AfterGetResponseDataEventArgs
    {
        public string SchemaName { get; set; }
        public string ResponseData { get; set; }
        public bool Abort { get; set; }
    }
}