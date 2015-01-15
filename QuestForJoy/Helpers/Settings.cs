// Helpers/Settings.cs
using Refractored.Xam.Settings;
using Refractored.Xam.Settings.Abstractions;
using Xamarin.Forms;

namespace QuestForJoy.Helpers
{
  /// <summary>
  /// This is the Settings static class that can be used in your Core solution or in any
  /// of your client applications. All settings are laid out the same exact way with getters
  /// and setters. 
  /// </summary>
  public static class Settings
  {
    private static ISettings AppSettings
    {
      get
      {
        return CrossSettings.Current;
      }
    }

	public static readonly Thickness PagePadding =
		new Thickness(5, Device.OnPlatform(20, 0, 0), 5, 0);

	public static readonly Font TitleFont = 
		Font.SystemFontOfSize(Device.OnPlatform(35, 40, 50), FontAttributes.Bold);

	#region Setting Constants

	private const string SettingsKey = "settings_key";
	private static readonly string SettingsDefault = string.Empty;

	// DisplayLanguage
	private const string DisplayLanguageKey = "display_language_key";
	private static readonly DisplayLanguageValues DisplayLanguageDefault = DisplayLanguageValues.English;

	// TextSize
	private const string TextSizeKey = "text_size_key";
	private static readonly NamedSize TextSizeDefault = NamedSize.Default;

	#endregion


    public static string GeneralSettings
    {
      get
      {
        return AppSettings.GetValueOrDefault(SettingsKey, SettingsDefault);
      }
      set
      {
        AppSettings.AddOrUpdateValue(SettingsKey, value);
      }
    }

		public static DisplayLanguageValues DisplayLanguage
	{
		get
		{
			return AppSettings.GetValueOrDefault(DisplayLanguageKey, DisplayLanguageDefault);
		}
		set
		{
			AppSettings.AddOrUpdateValue(DisplayLanguageKey, value);
		}
	}

		public enum DisplayLanguageValues : int {
			English = 0,
			Spanish = 1
		}

		public static NamedSize TextSize
		{
			get
			{
				return AppSettings.GetValueOrDefault(TextSizeKey, TextSizeDefault);
			}
			set
			{
				AppSettings.AddOrUpdateValue(TextSizeKey, value);
			}
		}

  }
}