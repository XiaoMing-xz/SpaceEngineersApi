using System;
using System.CodeDom.Compiler;
using EmptyKeys.UserInterface.Data;
using Sandbox.Game.Screens.ViewModels;

namespace EmptyKeys.UserInterface.Generated.ContractsBlockView_Gamepad_Bindings
{
	[GeneratedCode("Empty Keys UI Generator", "3.2.0.0")]
	public class MyContractsBlockViewModel_SelectedAvailableContractIndex_PropertyInfo : IPropertyInfo
	{
		public Type PropertyType => typeof(int);

		public bool IsResolved => true;

		public object GetValue(object obj)
		{
			return ((MyContractsBlockViewModel)obj).SelectedAvailableContractIndex;
		}

		public object GetValue(object obj, object[] index)
		{
			return null;
		}

		public void SetValue(object obj, object value)
		{
			((MyContractsBlockViewModel)obj).SelectedAvailableContractIndex = (int)value;
		}

		public void SetValue(object obj, object value, object[] index)
		{
		}
	}
}