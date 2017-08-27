using System;
using MvvmCross.Core.ViewModels;

namespace SteemitApp.Core
{
    public class TabItemPresentation
    {
    	public TabItemPresentation()
    	{
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
    		set { title = value; }
        }
    }

}
