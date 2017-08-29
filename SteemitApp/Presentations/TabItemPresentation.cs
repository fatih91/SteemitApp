using System;
using MvvmCross.Core.ViewModels;

namespace SteemitApp.Core
{
    public class TabItemPresentation
    {
    	public TabItemPresentation(string Title, string ImageName, Type ViewModelType)
    	{
            this.Title = Title;
            this.ImageName = ImageName;
            this.ViewModelType = ViewModelType;
    	}

    	public Type ViewModelType;

    	private string title;
    	public string Title
    	{
    		get { return title; }
    		set { title = value; }
    	}

    	private string imageName;
    	public string ImageName
    	{
    		get { return imageName; }
    		set { imageName = value; }
        }
    }

}
