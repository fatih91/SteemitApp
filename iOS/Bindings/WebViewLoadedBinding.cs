using System;
using MvvmCross.Binding;
using MvvmCross.Binding.Bindings.Target;
using MvvmCross.Core.ViewModels;
using UIKit;

namespace SteemitApp.iOS
{
    public class WebViewLoadedBinding : MvxTargetBinding
    {
        private readonly UIWebView webView;

        private MvxCommand<float> command = null;

        public WebViewLoadedBinding(UIWebView WebView): base(WebView)
        {
            webView = WebView;

            webView.LoadFinished += (sender, e) => 
            {
                var offsetHeight = webView.EvaluateJavascript("document.body.offsetHeight");
                float height = 0;
                if (float.TryParse(offsetHeight, out height))
                {
                    this.webView.Frame = new CoreGraphics.CGRect(0,
                                                                 0,
                                                                 this.webView.Frame.Width,
                                                                 height);

                    if (command != null) 
                    { 
                        command.Execute(height);
                    }
                }
            };
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
                command = (MvxCommand<float>)value;
            }
        }
    }
}
