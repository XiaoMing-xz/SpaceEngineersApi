using System;
using System.CodeDom.Compiler;
using EmptyKeys.UserInterface.Data;
using Sandbox.Game.Screens.Models;

namespace EmptyKeys.UserInterface.Generated.DataTemplatesContractsDataGrid_Bindings
{
	[GeneratedCode("Empty Keys UI Generator", "3.2.0.0")]
	public class MyContractModelCustom_FactionIconTooltip_PropertyInfo : IPropertyInfo
	{
		public Type PropertyType => typeof(string);

		public bool IsResolved => true;

		public object GetValue(object obj)
		{
			return ((MyContractModelCustom)obj).FactionIconTooltip;
		}

		public object GetValue(object obj, object[] index)
		{
			return null;
		}

		public void SetValue(object obj, object value)
		{
			((MyContractModelCustom)obj).FactionIconTooltip = (string)value;
		}

		public void SetValue(object obj, object value, object[] index)
		{
		}
	}
}
