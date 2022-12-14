using System;
using VRage;
using VRage.Utils;

namespace Sandbox.Game.Screens
{
	public class MyLoadingException : Exception
	{
		public MyLoadingException(MyStringId message, Exception innerException = null)
			: base(MyTexts.GetString(message), innerException)
		{
		}

		public MyLoadingException(string message, Exception innerException = null)
			: base(message.ToString(), innerException)
		{
		}
	}
}
