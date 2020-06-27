using System.IO;
using Newtonsoft.Json;

namespace CefSharp.RequestIntercept.Util
{
    public class JsonUtil
    {
        public static string FormatJsonString(string jsonStr)
        {
            if (jsonStr == null)
            {
                return string.Empty;
            }
            JsonSerializer serializer = new JsonSerializer();
            TextReader tr = new StringReader(jsonStr);
            JsonTextReader jtr = new JsonTextReader(tr);
            object obj = serializer.Deserialize(jtr);
            if (obj != null)
            {
                StringWriter textWriter = new StringWriter();
                JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                {
                    Formatting = Formatting.Indented,
                    Indentation = 4,
                    IndentChar = ' '
                };
                serializer.Serialize(jsonWriter, obj);
                return textWriter.ToString();
            }
            else
            {
                return jsonStr;
            }
        }
    }
}