using System;
using CefSharp.RequestIntercept.Schema;

namespace CefSharp.RequestIntercept.Util
{
    public static class ReflectionUtil
    {
        public static TResult GetAttribute<TResult>(Type type) where TResult : Attribute
        {
            Type attributeType = typeof(TResult);
            object[] customAttributes = type.GetCustomAttributes(attributeType, true);
            if (customAttributes.Length <= 0)
            {
                return null;
            }

            return (TResult) customAttributes[0];
        }
    }
}