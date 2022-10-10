using System;
using System.CodeDom.Compiler;
using EmptyKeys.UserInterface.Data;
using Sandbox.Game.Screens.Models;

namespace EmptyKeys.UserInterface.Generated.DataTemplatesEditFaction_Bindings
{
	[GeneratedCode("Empty Keys UI Generator", "3.2.0.0")]
	public class MyFactionIconModel_Opacity_PropertyInfo : IPropertyInfo
	{
		public Type PropertyType => typeof(float);

		public bool IsResolved => true;

		public object GetValue(object obj)
		{
			return ((MyFactionIconModel)obj).Opacity;
		}

		public object GetValue(object obj, object[] index)
		{
			return null;
		}

		public void SetValue(object obj, object value)
		{
		}

		public void SetValue(object obj, object value, object[] index)
		{
		}
	}
}
