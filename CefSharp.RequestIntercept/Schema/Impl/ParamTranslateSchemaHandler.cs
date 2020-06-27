using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace CefSharp.RequestIntercept.Schema.Impl
{
    [SchemaHandlerMeta(Name = "ParamTranslate")]
    public class ParamTranslateSchemaHandler : SchemaHandler
    {
        public static Dictionary<string, string> ParamList = new Dictionary<string, string>()
        {
            { "Hello", "你好"},
            { "World", "世界"}
        };

        public override string GetResponseData(NameValueCollection query)
        {
            string paramName = query["paramName"];
            if (!ParamList.ContainsKey(paramName))
            {
                throw new Exception("Unknown Param Name: " + paramName);
            }

            return ParamList[paramName];
        }
    }
}