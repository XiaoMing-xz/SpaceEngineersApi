namespace System
{
	/// <summary>
	/// Specifies that this class requires preload before running the game
	/// Preload is be done when starting the app
	/// </summary>
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public class PreloadRequiredAttribute : Attribute
	{
	}
}
