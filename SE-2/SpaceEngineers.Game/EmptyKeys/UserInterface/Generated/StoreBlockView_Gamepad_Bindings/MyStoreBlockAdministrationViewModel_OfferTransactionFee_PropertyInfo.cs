using System;
using System.CodeDom.Compiler;
using EmptyKeys.UserInterface.Data;
using Sandbox.Game.Screens.ViewModels;

namespace EmptyKeys.UserInterface.Generated.StoreBlockView_Gamepad_Bindings
{
	[GeneratedCode("Empty Keys UI Generator", "3.2.0.0")]
	public class MyStoreBlockAdministrationViewModel_OfferTransactionFee_PropertyInfo : IPropertyInfo
	{
		public Type PropertyType => typeof(string);

		public bool IsResolved => true;

		public object GetValue(object obj)
		{
			return ((MyStoreBlockAdministrationViewModel)obj).OfferTransactionFee;
		}

		public object GetValue(object obj, object[] index)
		{
			return null;
		}

		public void SetValue(object obj, object value)
		{
			((MyStoreBlockAdministrationViewModel)obj).OfferTransactionFee = (string)value;
		}

		public void SetValue(object obj, object value, object[] index)
		{
		}
	}
}
