using System;
using System.CodeDom.Compiler;
using EmptyKeys.UserInterface.Data;
using EmptyKeys.UserInterface.Media.Imaging;
using Sandbox.Game.Screens.Models;

namespace EmptyKeys.UserInterface.Generated.DataTemplatesStoreBlock_Bindings
{
	[GeneratedCode("Empty Keys UI Generator", "3.2.0.0")]
	public class MyStoreItemModel_Icon_PropertyInfo : IPropertyInfo
	{
		public Type PropertyType => typeof(BitmapImage);

		public bool IsResolved => true;

		public object GetValue(object obj)
		{
			return ((MyStoreItemModel)obj).Icon;
		}

		public object GetValue(object obj, object[] index)
		{
			return null;
		}

		public void SetValue(object obj, object value)
		{
			((MyStoreItemModel)obj).Icon = (BitmapImage)value;
		}

		public void SetValue(object obj, object value, object[] index)
		{
		}
	}
}
