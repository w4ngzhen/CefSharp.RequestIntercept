using System.Collections.Specialized;

namespace CefSharp.RequestIntercept.Schema.Event
{
    public class BeforeGetResponseDataEventArgs
    {
        public NameValueCollection Query { get; set; }
        public bool Abort { get; set; } = false;
    }
}