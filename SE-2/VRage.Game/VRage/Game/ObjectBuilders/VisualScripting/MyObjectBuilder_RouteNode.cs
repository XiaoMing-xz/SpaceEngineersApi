using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using ProtoBuf;
using VRage.Network;
using VRage.ObjectBuilders;
using VRage.Utils;
using VRageMath;

namespace VRage.Game.ObjectBuilders.VisualScripting
{
	[MyObjectBuilderDefinition(null, null)]
	[ProtoContract]
	[XmlSerializerAssembly("VRage.Game.XmlSerializers")]
	public class MyObjectBuilder_RouteNode : MyObjectBuilder_ScriptNode
	{
		protected class VRage_Game_ObjectBuilders_VisualScripting_MyObjectBuilder_RouteNode_003C_003EInput_003C_003EAccessor : IMemberAccessor<MyObjectBuilder_RouteNode, MyVariableIdentifier>
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Set(ref MyObjectBuilder_RouteNode owner, in MyVariableIdentifier value)
			{
				owner.Input = value;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Get(ref MyObjectBuilder_RouteNode owner, out MyVariableIdentifier value)
			{
				value = owner.Input;
			}
		}

		protected class VRage_Game_ObjectBuilders_VisualScripting_MyObjectBuilder_RouteNode_003C_003EOutputs_003C_003EAccessor : IMemberAccessor<MyObjectBuilder_RouteNode, List<MyVariableIdentifier>>
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Set(ref MyObjectBuilder_RouteNode owner, in List<MyVariableIdentifier> value)
			{
				owner.Outputs = value;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Get(ref MyObjectBuilder_RouteNode owner, out List<MyVariableIdentifier> value)
			{
				value = owner.Outputs;
			}
		}

		protected class VRage_Game_ObjectBuilders_VisualScripting_MyObjectBuilder_RouteNode_003C_003EID_003C_003EAccessor : VRage_Game_MyObjectBuilder_ScriptNode_003C_003EID_003C_003EAccessor, IMemberAccessor<MyObjectBuilder_RouteNode, int>
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Set(ref MyObjectBuilder_RouteNode owner, in int value)
			{
				Set(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_RouteNode, MyObjectBuilder_ScriptNode>(ref owner), in value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Get(ref MyObjectBuilder_RouteNode owner, out int value)
			{
				Get(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_RouteNode, MyObjectBuilder_ScriptNode>(ref owner), out value);
			}
		}

		protected class VRage_Game_ObjectBuilders_VisualScripting_MyObjectBuilder_RouteNode_003C_003EPosition_003C_003EAccessor : VRage_Game_MyObjectBuilder_ScriptNode_003C_003EPosition_003C_003EAccessor, IMemberAccessor<MyObjectBuilder_RouteNode, Vector2>
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Set(ref MyObjectBuilder_RouteNode owner, in Vector2 value)
			{
				Set(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_RouteNode, MyObjectBuilder_ScriptNode>(ref owner), in value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Get(ref MyObjectBuilder_RouteNode owner, out Vector2 value)
			{
				Get(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_RouteNode, MyObjectBuilder_ScriptNode>(ref owner), out value);
			}
		}

		protected class VRage_Game_ObjectBuilders_VisualScripting_MyObjectBuilder_RouteNode_003C_003Em_subtypeId_003C_003EAccessor : VRage_ObjectBuilders_MyObjectBuilder_Base_003C_003Em_subtypeId_003C_003EAccessor, IMemberAccessor<MyObjectBuilder_RouteNode, MyStringHash>
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Set(ref MyObjectBuilder_RouteNode owner, in MyStringHash value)
			{
				Set(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_RouteNode, MyObjectBuilder_Base>(ref owner), in value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Get(ref MyObjectBuilder_RouteNode owner, out MyStringHash value)
			{
				Get(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_RouteNode, MyObjectBuilder_Base>(ref owner), out value);
			}
		}

		protected class VRage_Game_ObjectBuilders_VisualScripting_MyObjectBuilder_RouteNode_003C_003Em_subtypeName_003C_003EAccessor : VRage_ObjectBuilders_MyObjectBuilder_Base_003C_003Em_subtypeName_003C_003EAccessor, IMemberAccessor<MyObjectBuilder_RouteNode, string>
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Set(ref MyObjectBuilder_RouteNode owner, in string value)
			{
				Set(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_RouteNode, MyObjectBuilder_Base>(ref owner), in value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Get(ref MyObjectBuilder_RouteNode owner, out string value)
			{
				Get(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_RouteNode, MyObjectBuilder_Base>(ref owner), out value);
			}
		}

		protected class VRage_Game_ObjectBuilders_VisualScripting_MyObjectBuilder_RouteNode_003C_003Em_serializableSubtypeId_003C_003EAccessor : VRage_ObjectBuilders_MyObjectBuilder_Base_003C_003Em_serializableSubtypeId_003C_003EAccessor, IMemberAccessor<MyObjectBuilder_RouteNode, MyStringHash>
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Set(ref MyObjectBuilder_RouteNode owner, in MyStringHash value)
			{
				Set(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_RouteNode, MyObjectBuilder_Base>(ref owner), in value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Get(ref MyObjectBuilder_RouteNode owner, out MyStringHash value)
			{
				Get(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_RouteNode, MyObjectBuilder_Base>(ref owner), out value);
			}
		}

		protected class VRage_Game_ObjectBuilders_VisualScripting_MyObjectBuilder_RouteNode_003C_003ESubtypeName_003C_003EAccessor : VRage_ObjectBuilders_MyObjectBuilder_Base_003C_003ESubtypeName_003C_003EAccessor, IMemberAccessor<MyObjectBuilder_RouteNode, string>
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Set(ref MyObjectBuilder_RouteNode owner, in string value)
			{
				Set(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_RouteNode, MyObjectBuilder_Base>(ref owner), in value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Get(ref MyObjectBuilder_RouteNode owner, out string value)
			{
				Get(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_RouteNode, MyObjectBuilder_Base>(ref owner), out value);
			}
		}

		private class VRage_Game_ObjectBuilders_VisualScripting_MyObjectBuilder_RouteNode_003C_003EActor : IActivator, IActivator<MyObjectBuilder_RouteNode>
		{
			private sealed override object CreateInstance()
			{
				return new MyObjectBuilder_RouteNode();
			}

			object IActivator.CreateInstance()
			{
				//ILSpy generated this explicit interface implementation from .override directive in CreateInstance
				return this.CreateInstance();
			}

			private sealed override MyObjectBuilder_RouteNode CreateInstance()
			{
				return new MyObjectBuilder_RouteNode();
			}

			MyObjectBuilder_RouteNode IActivator<MyObjectBuilder_RouteNode>.CreateInstance()
			{
				//ILSpy generated this explicit interface implementation from .override directive in CreateInstance
				return this.CreateInstance();
			}
		}

		[ProtoMember(5)]
		public MyVariableIdentifier Input;

		[ProtoMember(10)]
		public List<MyVariableIdentifier> Outputs = new List<MyVariableIdentifier>();
	}
}
