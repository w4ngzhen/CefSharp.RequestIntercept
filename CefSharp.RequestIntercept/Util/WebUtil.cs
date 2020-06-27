using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace CefSharp.RequestIntercept.Util
{
    public static class WebUtil
    {
        public static NameValueCollection Parse(this Uri uri)
        {
            string query = uri.Query;
            query = query.Substring(query.IndexOf('?'));
            List<string> keyValues = query.Split('&').ToList();
            NameValueCollection nameValueCollection = new NameValueCollection(keyValues.Count);
            keyValues.ForEach(kv =>
            {
                int equalIdx = kv.IndexOf('=');
                if (equalIdx == -1)
                {
                    return; // return current callback
                }
                string key = HttpUtility.UrlDecode(kv.Substring(0, equalIdx));
                string value = HttpUtility.UrlDecode(kv.Substring(equalIdx + 1, kv.Length));
                nameValueCollection[key] = value;
            });
            return nameValueCollection;
        }
    }
}