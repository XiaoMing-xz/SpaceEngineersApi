using System;
using System.CodeDom.Compiler;
using EmptyKeys.UserInterface.Data;
using Sandbox.Game.Screens.Models;

namespace EmptyKeys.UserInterface.Generated.DataTemplatesStoreBlock_Bindings
{
	[GeneratedCode("Empty Keys UI Generator", "3.2.0.0")]
	public class MyStoreItemModel_IsOrder_PropertyInfo : IPropertyInfo
	{
		public Type PropertyType => typeof(bool);

		public bool IsResolved => true;

		public object GetValue(object obj)
		{
			return ((MyStoreItemModel)obj).IsOrder;
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
