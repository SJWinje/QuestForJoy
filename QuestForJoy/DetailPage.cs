using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace QuestForJoy
{
	public class DetailPage : ContentPage
	{	
		public static Scripture scripture;
		ScrollView scroll;
		StackLayout stack;

		public DetailPage (Scripture s)
		{
			//InitializeComponent ();
			scripture = s;

			stack = new StackLayout ();
			scroll = new ScrollView ();

			stack = new StackLayout {
				Spacing = 10, Padding = 20,
				VerticalOptions = LayoutOptions.Start,
				Children = {
					new Label { Text = scripture.Heading, FontAttributes=FontAttributes.Bold },
					new Label { Text = scripture.Verse, FontAttributes=FontAttributes.Italic },
					new Label { Text = scripture.Description },
				}
			};

			scroll.Content = stack;
			Content = scroll;

		}

	}
}

