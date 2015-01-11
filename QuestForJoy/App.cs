using System;
using Xamarin.Forms;

namespace QuestForJoy
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new NavigationPage(new MainPage());
		}
	}
}

