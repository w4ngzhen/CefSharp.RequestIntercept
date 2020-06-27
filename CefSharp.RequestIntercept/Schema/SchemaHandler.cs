using System;
using System.Collections.Specialized;
using CefSharp.RequestIntercept.Schema.Event;

namespace CefSharp.RequestIntercept.Schema
{
    public abstract class SchemaHandler
    {
        public SchemaHandlerMetaAttribute SchemaHandlerMeta { get; set; }

        public event EventHandler<BeforeGetResponseDataEventArgs> BeforeGetResponseDataEvent;

        public event EventHandler<AfterGetResponseDataEventArgs> AfterGetResponseDataEvent;

        public virtual void Execute(NameValueCollection query)
        {
            
            if (BeforeGetResponseDataEvent != null)
            {
                BeforeGetResponseDataEventArgs eventArgs = new BeforeGetResponseDataEventArgs()
                {
                    Abort = false,
                    Query = query
                };
                BeforeGetResponseDataEvent(this, eventArgs);
                if (eventArgs.Abort)
                {
                    return;
                }
                query = eventArgs.Query;
            }

            string responseJsonData;
            try
            {
                responseJsonData = GetResponseData(query);
            }
            catch (Exception e)
            {
                responseJsonData = Response.Fail(this.SchemaHandlerMeta.Name, e.Message).ToJsonString();
            }

            if (AfterGetResponseDataEvent != null)
            {
                AfterGetResponseDataEventArgs eventArgs = new AfterGetResponseDataEventArgs()
                {
                    SchemaName = this.SchemaHandlerMeta.Name,
                    ResponseData = responseJsonData,
                    Abort = false
                };
                AfterGetResponseDataEvent(this, eventArgs);
                if (eventArgs.Abort)
                {
                    return;
                }
                responseJsonData = eventArgs.ResponseData;
            }
        }

        public virtual string GetResponseData(NameValueCollection query)
        {
            return string.Empty;
        }
    }
}