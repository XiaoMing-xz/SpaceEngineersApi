using System;
using System.CodeDom.Compiler;
using EmptyKeys.UserInterface.Data;
using EmptyKeys.UserInterface.Input;
using Sandbox.Game.Screens.ViewModels;

namespace EmptyKeys.UserInterface.Generated.StoreBlockView_Bindings
{
	[GeneratedCode("Empty Keys UI Generator", "3.2.0.0")]
	public class MyStoreBlockViewModel_ShowPreviewCommand_PropertyInfo : IPropertyInfo
	{
		public Type PropertyType => typeof(ICommand);

		public bool IsResolved => true;

		public object GetValue(object obj)
		{
			return ((MyStoreBlockViewModel)obj).ShowPreviewCommand;
		}

		public object GetValue(object obj, object[] index)
		{
			return null;
		}

		public void SetValue(object obj, object value)
		{
			((MyStoreBlockViewModel)obj).ShowPreviewCommand = (ICommand)value;
		}

		public void SetValue(object obj, object value, object[] index)
		{
		}
	}
}