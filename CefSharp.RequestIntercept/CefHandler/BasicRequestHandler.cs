using System;
using System.Collections.Specialized;
using CefSharp.Handler;
using CefSharp.RequestIntercept.Schema;
using CefSharp.RequestIntercept.Util;

namespace CefSharp.RequestIntercept.CefHandler
{
    public class BasicRequestHandler : RequestHandler
    {
        public const string CustomScheme = "MyCustomScheme";

        private SchemaHandlerFactory _schemaHandlerFactory;

        public BasicRequestHandler()
        {
            _schemaHandlerFactory = new SchemaHandlerFactory();
            _schemaHandlerFactory.Load();
        }

        protected override bool OnBeforeBrowse(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, bool userGesture,
            bool isRedirect)
        {
            Uri uri = new Uri(request.Url);
            if (!CustomScheme.Equals(uri.Scheme, StringComparison.CurrentCultureIgnoreCase))
            {
                return base.OnBeforeBrowse(chromiumWebBrowser, browser, frame, request, userGesture, isRedirect);
            }
            NameValueCollection query = uri.Parse();
            SchemaHandler schemaHandler = _schemaHandlerFactory.GetSchemaHandler(query);
            schemaHandler.Execute(query);
            return true;
        }
    }
}