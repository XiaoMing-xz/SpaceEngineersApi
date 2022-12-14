namespace VRage.Game
{
	public struct MyFontEnum
	{
		public const string Debug = "Debug";

		public const string Red = "Red";

		public const string Green = "Green";

		public const string Blue = "Blue";

		public const string White = "White";

		public const string DarkBlue = "DarkBlue";

		public const string UrlNormal = "UrlNormal";

		public const string UrlHighlight = "UrlHighlight";

		public const string ErrorMessageBoxCaption = "ErrorMessageBoxCaption";

		public const string ErrorMessageBoxText = "ErrorMessageBoxText";

		public const string InfoMessageBoxCaption = "InfoMessageBoxCaption";

		public const string InfoMessageBoxText = "InfoMessageBoxText";

		public const string ScreenCaption = "ScreenCaption";

		public const string GameCredits = "GameCredits";

		public const string LoadingScreen = "LoadingScreen";

		public const string BuildInfo = "BuildInfo";

		public const string BuildInfoHighlight = "BuildInfoHighlight";

		private string m_value;

		public MyFontEnum(string value)
		{
			m_value = value;
		}

		public override string ToString()
		{
			return m_value;
		}

		public static implicit operator MyFontEnum(string input)
		{
			return new MyFontEnum(input);
		}

		public static implicit operator string(MyFontEnum input)
		{
			return input.m_value;
		}
	}
}
