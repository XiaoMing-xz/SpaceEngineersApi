namespace Sandbox.Engine.Utils
{
	public class MyObfuscation
	{
		public static readonly bool Enabled = new MyObfuscation().GetType().Name != "MyObfuscation";

		private MyObfuscation()
		{
		}
	}
}
