using System;
using System.IO;
using System.Windows.Forms;

namespace CefSharp.RequestIntercept
{
    public partial class MainForm : Form
    {

        private CefSharpViewModel _cefSharpViewModel;

        public string Address
        {
            get => this.TxtAddress.Text.Trim();
            set => this.TxtAddress.Text = value;
        }

        public MainForm()
        {
            InitializeComponent();
            this.Init();
        }

        private void Init()
        {
            _cefSharpViewModel = new CefSharpViewModel();
            this.BtnLoad_Click(null, null);
        }

        private void BtnBack_Click(object sender, System.EventArgs e)
        {
            this._cefSharpViewModel.Back();
        }

        private void BtnForward_Click(object sender, System.EventArgs e)
        {
            this._cefSharpViewModel.Forward();
        }

        private void BtnRefresh_Click(object sender, System.EventArgs e)
        {
            this._cefSharpViewModel.Refresh();
        }

        private void BtnLoad_Click(object sender, System.EventArgs e)
        {
            this._cefSharpViewModel.Load(this.Address);
        }
    }
}
