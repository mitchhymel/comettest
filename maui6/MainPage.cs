using System;
using System.Collections.Generic;
using Comet;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.HotReload;

namespace maui6
{
	public class MainPage : Comet.View
	{
		public MainPage(List<MenuItem> additionalPage = null)
		{
			//This is only required since there is a parameter for the view
			//MauiHotReloadHelper.Register(this, additionalPage);

			this.Title("UI Samples");

			Body = () => new VStack
			{
				new Text("hi")
			};

		}
	}
}