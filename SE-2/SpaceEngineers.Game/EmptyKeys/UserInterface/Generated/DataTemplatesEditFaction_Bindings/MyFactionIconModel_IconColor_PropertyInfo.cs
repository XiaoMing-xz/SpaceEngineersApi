using System;
using System.CodeDom.Compiler;
using EmptyKeys.UserInterface.Data;
using EmptyKeys.UserInterface.Media;
using Sandbox.Game.Screens.Models;

namespace EmptyKeys.UserInterface.Generated.DataTemplatesEditFaction_Bindings
{
	[GeneratedCode("Empty Keys UI Generator", "3.2.0.0")]
	public class MyFactionIconModel_IconColor_PropertyInfo : IPropertyInfo
	{
		public Type PropertyType => typeof(ColorW);

		public bool IsResolved => true;

		public object GetValue(object obj)
		{
			return ((MyFactionIconModel)obj).IconColor;
		}

		public object GetValue(object obj, object[] index)
		{
			return null;
		}

		public void SetValue(object obj, object value)
		{
			((MyFactionIconModel)obj).IconColor = (ColorW)value;
		}

		public void SetValue(object obj, object value, object[] index)
		{
		}
	}
}
