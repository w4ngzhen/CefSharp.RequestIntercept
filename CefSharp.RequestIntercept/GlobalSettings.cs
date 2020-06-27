using CefSharp.WinForms;

namespace CefSharp.RequestIntercept
{
    public static class GlobalSettings
    {
        public static void Init()
        {
            CefSettings cefSettings = new CefSettings();
            Cef.Initialize(cefSettings);
        }
    }
}