using System;
using System.CodeDom.Compiler;
using EmptyKeys.UserInterface.Data;
using Sandbox.Game.Screens.Models;

namespace EmptyKeys.UserInterface.Generated.DataTemplatesContracts_Bindings
{
	[GeneratedCode("Empty Keys UI Generator", "3.2.0.0")]
	public class MyContractModelHunt_RewardReputation_PropertyInfo : IPropertyInfo
	{
		public Type PropertyType => typeof(int);

		public bool IsResolved => true;

		public object GetValue(object obj)
		{
			return ((MyContractModelHunt)obj).RewardReputation;
		}

		public object GetValue(object obj, object[] index)
		{
			return null;
		}

		public void SetValue(object obj, object value)
		{
			((MyContractModelHunt)obj).RewardReputation = (int)value;
		}

		public void SetValue(object obj, object value, object[] index)
		{
		}
	}
}
