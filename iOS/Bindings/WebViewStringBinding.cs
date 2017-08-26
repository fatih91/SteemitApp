using System;
using MvvmCross.Binding;
using MvvmCross.Binding.Bindings.Target;
using UIKit;

namespace SteemitApp.iOS
{
    public class WebViewStringBinding : MvxTargetBinding
    {
        private readonly UIWebView webView;

        public WebViewStringBinding(UIWebView WebView): base(WebView)
        {
            webView = WebView;
        }

        public override MvxBindingMode DefaultMode
        {
            get
            {
                return MvxBindingMode.Default;
            }
        }

        public override Type TargetType
        {
            get
            {
                return typeof(UIWebView);
            }
        }

        public override void SetValue(object value)
        {
            if (value != null) 
            {
                string html = (string)value;
                webView.LoadHtmlString(html, new Foundation.NSUrl(""));
            }
        }
    }
}
