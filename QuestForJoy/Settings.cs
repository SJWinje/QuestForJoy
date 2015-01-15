using System;
using System.Collections.Generic;
using Xamarin.Forms;
using QuestForJoy.Helpers.Settings;

namespace QuestForJoy
{
	public class Settings : ContentPage
	{
		public Settings ()
		{
			/*
			 * Commented out until other languages are added to the dictionary
			 * 
			Picker languagePicker = new Picker() 
			{
				Title = "Display Language",
			};
			languagePicker.Items.Add("English");
			languagePicker.SelectedIndex = (int)QuestForJoy.Helpers.Settings.DisplayLanguage;

			languagePicker.SelectedIndexChanged += (sender, args) =>
			{
				switch (languagePicker.SelectedIndex)
				{
				case (int)QuestForJoy.Helpers.Settings.DisplayLanguageValues.English:
					QuestForJoy.Helpers.Settings.DisplayLanguage = QuestForJoy.Helpers.Settings.DisplayLanguageValues.English;
					// System.Diagnostics.Debug.WriteLine ("Selected Display Language to be English");
					break;
				case (int)QuestForJoy.Helpers.Settings.DisplayLanguageValues.Spanish:
					QuestForJoy.Helpers.Settings.DisplayLanguage = QuestForJoy.Helpers.Settings.DisplayLanguageValues.Spanish;
					// System.Diagnostics.Debug.WriteLine ("Selected Display Language to be Spanish");
					break;
				default:
					// System.Diagnostics.Debug.WriteLine ("no Display Language selection");
					break;
				}
			};
			*/

			Label header = new Label
			{
				Text = "Text Size: " + QuestForJoy.Helpers.Settings.TextSize.ToString(),
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			header.FontSize = Device.GetNamedSize (QuestForJoy.Helpers.Settings.TextSize, typeof(Label));

			Stepper stepper = new Stepper
			{
				Minimum = 1,
				Maximum = 4,
				Increment = 1,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			stepper.Value = (double)QuestForJoy.Helpers.Settings.TextSize;
			stepper.ValueChanged += (sender, args) => {
				int val = (int)args.NewValue;
				NamedSize textSize = QuestForJoy.Helpers.Settings.TextSize;
				switch (val) {
				case 1:
					textSize = NamedSize.Micro;
					break;
				case 2:
					textSize = NamedSize.Small;
					break;
				case 3:
					textSize = NamedSize.Medium;
					break;
				case 4:
					textSize = NamedSize.Large;
					break;
				}
				header.Text = String.Format("Text Size: {0}", textSize.ToString());
				header.FontSize = Device.GetNamedSize (textSize, typeof(Label));
				System.Diagnostics.Debug.WriteLine ("Stepper Selected: " + textSize.ToString());
				QuestForJoy.Helpers.Settings.TextSize = textSize;
			};

			// Create table to hold the setting controls
			TableView tview = new TableView {
				Intent = TableIntent.Settings,
				Root = new TableRoot {
					/*
					 * Commented out until other languages are added to the dictionary
					 * 
					new TableSection ("Display Language") {
						new ViewCell {View = languagePicker}
					},
					*/
					new TableSection ("Text Size") {
						new ViewCell { View = stepper },
						new ViewCell { View = header }
					},

				},
			};

			StackLayout s = new StackLayout ();
			s.VerticalOptions = LayoutOptions.Start;
			s.Children.Add (tview);
			this.Content = s;
		}
	}
}

