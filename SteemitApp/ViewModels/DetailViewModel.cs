using System;
using System.Text.RegularExpressions;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace SteemitApp.Core
{
    public class DetailViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService navigation;

        public DetailViewModel(IMvxNavigationService Navigation, PostPresentation Post)
        {
            navigation = Navigation;
            this.Post = Post;
        }

        public override System.Threading.Tasks.Task Initialize()
        {
            Regex expression = new Regex(@"(http)?s?:?(\/\/[^""']*\.(?:png|jpg|jpeg|gif|png|svg))");
            var matches = expression.Matches(post.Body);

            foreach (var match in matches)
            {
                try
                {
                    string img = match.ToString();
                    post.Body = post.Body.Replace(img, $"<img src=\"{img}\" />");
                }
                catch (Exception ex)
                {

                }
            }

            string cssStyle = "<style type=\"text/css\">img { width: 100%; }</style>";
            post.Body = cssStyle + post.Body;

            return base.Initialize();
        }

        private PostPresentation post;
        public PostPresentation Post
        {
            get { return post; }
            set { SetProperty(ref post, value); }
        }


    }
}
