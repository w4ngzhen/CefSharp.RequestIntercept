using System.Windows.Forms;
using CefSharp.WinForms;

namespace CefSharp.RequestIntercept
{
    public class CefSharpViewModel
    {
        private ChromiumWebBrowser _webBrowser;

        public CefSharpViewModel()
        {
            this.Init();
        }

        private void Init()
        {
            GlobalSettings.Init();
            this._webBrowser = new ChromiumWebBrowser("");
        }

        public void Load(string address)
        {
            this._webBrowser.Load(address);
        }

        public void Back()
        {
            this._webBrowser.Back();
        }

        public void Forward()
        {
            this._webBrowser.Forward();
        }

        public void Refresh()
        {
            this._webBrowser.Refresh();
        }

        public void AddToControl(Control control)
        {
            control.Controls.Add(this._webBrowser);
        }
    }
}