using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using ProtoBuf;
using VRage.Network;
using VRage.ObjectBuilders;
using VRage.Utils;
using VRageMath;

namespace VRage.Game.ObjectBuilders
{
	[ProtoContract]
	[MyObjectBuilderDefinition(null, null)]
	[XmlSerializerAssembly("VRage.Game.XmlSerializers")]
	public class MyObjectBuilder_EnvironmentalParticleLogicGrassland : MyObjectBuilder_EnvironmentalParticleLogic
	{
		protected class VRage_Game_ObjectBuilders_MyObjectBuilder_EnvironmentalParticleLogicGrassland_003C_003EMaterial_003C_003EAccessor : VRage_Game_ObjectBuilders_MyObjectBuilder_EnvironmentalParticleLogic_003C_003EMaterial_003C_003EAccessor, IMemberAccessor<MyObjectBuilder_EnvironmentalParticleLogicGrassland, string>
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Set(ref MyObjectBuilder_EnvironmentalParticleLogicGrassland owner, in string value)
			{
				Set(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyObjectBuilder_EnvironmentalParticleLogic>(ref owner), in value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Get(ref MyObjectBuilder_EnvironmentalParticleLogicGrassland owner, out string value)
			{
				Get(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyObjectBuilder_EnvironmentalParticleLogic>(ref owner), out value);
			}
		}

		protected class VRage_Game_ObjectBuilders_MyObjectBuilder_EnvironmentalParticleLogicGrassland_003C_003EParticleColor_003C_003EAccessor : VRage_Game_ObjectBuilders_MyObjectBuilder_EnvironmentalParticleLogic_003C_003EParticleColor_003C_003EAccessor, IMemberAccessor<MyObjectBuilder_EnvironmentalParticleLogicGrassland, Vector4>
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Set(ref MyObjectBuilder_EnvironmentalParticleLogicGrassland owner, in Vector4 value)
			{
				Set(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyObjectBuilder_EnvironmentalParticleLogic>(ref owner), in value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Get(ref MyObjectBuilder_EnvironmentalParticleLogicGrassland owner, out Vector4 value)
			{
				Get(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyObjectBuilder_EnvironmentalParticleLogic>(ref owner), out value);
			}
		}

		protected class VRage_Game_ObjectBuilders_MyObjectBuilder_EnvironmentalParticleLogicGrassland_003C_003EMaxSpawnDistance_003C_003EAccessor : VRage_Game_ObjectBuilders_MyObjectBuilder_EnvironmentalParticleLogic_003C_003EMaxSpawnDistance_003C_003EAccessor, IMemberAccessor<MyObjectBuilder_EnvironmentalParticleLogicGrassland, float>
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Set(ref MyObjectBuilder_EnvironmentalParticleLogicGrassland owner, in float value)
			{
				Set(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyObjectBuilder_EnvironmentalParticleLogic>(ref owner), in value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Get(ref MyObjectBuilder_EnvironmentalParticleLogicGrassland owner, out float value)
			{
				Get(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyObjectBuilder_EnvironmentalParticleLogic>(ref owner), out value);
			}
		}

		protected class VRage_Game_ObjectBuilders_MyObjectBuilder_EnvironmentalParticleLogicGrassland_003C_003EDespawnDistance_003C_003EAccessor : VRage_Game_ObjectBuilders_MyObjectBuilder_EnvironmentalParticleLogic_003C_003EDespawnDistance_003C_003EAccessor, IMemberAccessor<MyObjectBuilder_EnvironmentalParticleLogicGrassland, float>
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Set(ref MyObjectBuilder_EnvironmentalParticleLogicGrassland owner, in float value)
			{
				Set(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyObjectBuilder_EnvironmentalParticleLogic>(ref owner), in value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Get(ref MyObjectBuilder_EnvironmentalParticleLogicGrassland owner, out float value)
			{
				Get(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyObjectBuilder_EnvironmentalParticleLogic>(ref owner), out value);
			}
		}

		protected class VRage_Game_ObjectBuilders_MyObjectBuilder_EnvironmentalParticleLogicGrassland_003C_003EDensity_003C_003EAccessor : VRage_Game_ObjectBuilders_MyObjectBuilder_EnvironmentalParticleLogic_003C_003EDensity_003C_003EAccessor, IMemberAccessor<MyObjectBuilder_EnvironmentalParticleLogicGrassland, float>
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Set(ref MyObjectBuilder_EnvironmentalParticleLogicGrassland owner, in float value)
			{
				Set(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyObjectBuilder_EnvironmentalParticleLogic>(ref owner), in value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Get(ref MyObjectBuilder_EnvironmentalParticleLogicGrassland owner, out float value)
			{
				Get(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyObjectBuilder_EnvironmentalParticleLogic>(ref owner), out value);
			}
		}

		protected class VRage_Game_ObjectBuilders_MyObjectBuilder_EnvironmentalParticleLogicGrassland_003C_003EMaxLifeTime_003C_003EAccessor : VRage_Game_ObjectBuilders_MyObjectBuilder_EnvironmentalParticleLogic_003C_003EMaxLifeTime_003C_003EAccessor, IMemberAccessor<MyObjectBuilder_EnvironmentalParticleLogicGrassland, int>
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Set(ref MyObjectBuilder_EnvironmentalParticleLogicGrassland owner, in int value)
			{
				Set(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyObjectBuilder_EnvironmentalParticleLogic>(ref owner), in value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Get(ref MyObjectBuilder_EnvironmentalParticleLogicGrassland owner, out int value)
			{
				Get(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyObjectBuilder_EnvironmentalParticleLogic>(ref owner), out value);
			}
		}

		protected class VRage_Game_ObjectBuilders_MyObjectBuilder_EnvironmentalParticleLogicGrassland_003C_003EMaxParticles_003C_003EAccessor : VRage_Game_ObjectBuilders_MyObjectBuilder_EnvironmentalParticleLogic_003C_003EMaxParticles_003C_003EAccessor, IMemberAccessor<MyObjectBuilder_EnvironmentalParticleLogicGrassland, int>
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Set(ref MyObjectBuilder_EnvironmentalParticleLogicGrassland owner, in int value)
			{
				Set(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyObjectBuilder_EnvironmentalParticleLogic>(ref owner), in value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Get(ref MyObjectBuilder_EnvironmentalParticleLogicGrassland owner, out int value)
			{
				Get(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyObjectBuilder_EnvironmentalParticleLogic>(ref owner), out value);
			}
		}

		protected class VRage_Game_ObjectBuilders_MyObjectBuilder_EnvironmentalParticleLogicGrassland_003C_003EMaterialPlanet_003C_003EAccessor : VRage_Game_ObjectBuilders_MyObjectBuilder_EnvironmentalParticleLogic_003C_003EMaterialPlanet_003C_003EAccessor, IMemberAccessor<MyObjectBuilder_EnvironmentalParticleLogicGrassland, string>
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Set(ref MyObjectBuilder_EnvironmentalParticleLogicGrassland owner, in string value)
			{
				Set(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyObjectBuilder_EnvironmentalParticleLogic>(ref owner), in value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Get(ref MyObjectBuilder_EnvironmentalParticleLogicGrassland owner, out string value)
			{
				Get(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyObjectBuilder_EnvironmentalParticleLogic>(ref owner), out value);
			}
		}

		protected class VRage_Game_ObjectBuilders_MyObjectBuilder_EnvironmentalParticleLogicGrassland_003C_003EParticleColorPlanet_003C_003EAccessor : VRage_Game_ObjectBuilders_MyObjectBuilder_EnvironmentalParticleLogic_003C_003EParticleColorPlanet_003C_003EAccessor, IMemberAccessor<MyObjectBuilder_EnvironmentalParticleLogicGrassland, Vector4>
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Set(ref MyObjectBuilder_EnvironmentalParticleLogicGrassland owner, in Vector4 value)
			{
				Set(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyObjectBuilder_EnvironmentalParticleLogic>(ref owner), in value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Get(ref MyObjectBuilder_EnvironmentalParticleLogicGrassland owner, out Vector4 value)
			{
				Get(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyObjectBuilder_EnvironmentalParticleLogic>(ref owner), out value);
			}
		}

		protected class VRage_Game_ObjectBuilders_MyObjectBuilder_EnvironmentalParticleLogicGrassland_003C_003Em_subtypeId_003C_003EAccessor : VRage_ObjectBuilders_MyObjectBuilder_Base_003C_003Em_subtypeId_003C_003EAccessor, IMemberAccessor<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyStringHash>
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Set(ref MyObjectBuilder_EnvironmentalParticleLogicGrassland owner, in MyStringHash value)
			{
				Set(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyObjectBuilder_Base>(ref owner), in value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Get(ref MyObjectBuilder_EnvironmentalParticleLogicGrassland owner, out MyStringHash value)
			{
				Get(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyObjectBuilder_Base>(ref owner), out value);
			}
		}

		protected class VRage_Game_ObjectBuilders_MyObjectBuilder_EnvironmentalParticleLogicGrassland_003C_003Em_subtypeName_003C_003EAccessor : VRage_ObjectBuilders_MyObjectBuilder_Base_003C_003Em_subtypeName_003C_003EAccessor, IMemberAccessor<MyObjectBuilder_EnvironmentalParticleLogicGrassland, string>
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Set(ref MyObjectBuilder_EnvironmentalParticleLogicGrassland owner, in string value)
			{
				Set(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyObjectBuilder_Base>(ref owner), in value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Get(ref MyObjectBuilder_EnvironmentalParticleLogicGrassland owner, out string value)
			{
				Get(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyObjectBuilder_Base>(ref owner), out value);
			}
		}

		protected class VRage_Game_ObjectBuilders_MyObjectBuilder_EnvironmentalParticleLogicGrassland_003C_003Em_serializableSubtypeId_003C_003EAccessor : VRage_ObjectBuilders_MyObjectBuilder_Base_003C_003Em_serializableSubtypeId_003C_003EAccessor, IMemberAccessor<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyStringHash>
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Set(ref MyObjectBuilder_EnvironmentalParticleLogicGrassland owner, in MyStringHash value)
			{
				Set(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyObjectBuilder_Base>(ref owner), in value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Get(ref MyObjectBuilder_EnvironmentalParticleLogicGrassland owner, out MyStringHash value)
			{
				Get(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyObjectBuilder_Base>(ref owner), out value);
			}
		}

		protected class VRage_Game_ObjectBuilders_MyObjectBuilder_EnvironmentalParticleLogicGrassland_003C_003ESubtypeName_003C_003EAccessor : VRage_ObjectBuilders_MyObjectBuilder_Base_003C_003ESubtypeName_003C_003EAccessor, IMemberAccessor<MyObjectBuilder_EnvironmentalParticleLogicGrassland, string>
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Set(ref MyObjectBuilder_EnvironmentalParticleLogicGrassland owner, in string value)
			{
				Set(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyObjectBuilder_Base>(ref owner), in value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public sealed override void Get(ref MyObjectBuilder_EnvironmentalParticleLogicGrassland owner, out string value)
			{
				Get(ref System.Runtime.CompilerServices.Unsafe.As<MyObjectBuilder_EnvironmentalParticleLogicGrassland, MyObjectBuilder_Base>(ref owner), out value);
			}
		}

		private class VRage_Game_ObjectBuilders_MyObjectBuilder_EnvironmentalParticleLogicGrassland_003C_003EActor : IActivator, IActivator<MyObjectBuilder_EnvironmentalParticleLogicGrassland>
		{
			private sealed override object CreateInstance()
			{
				return new MyObjectBuilder_EnvironmentalParticleLogicGrassland();
			}

			object IActivator.CreateInstance()
			{
				//ILSpy generated this explicit interface implementation from .override directive in CreateInstance
				return this.CreateInstance();
			}

			private sealed override MyObjectBuilder_EnvironmentalParticleLogicGrassland CreateInstance()
			{
				return new MyObjectBuilder_EnvironmentalParticleLogicGrassland();
			}

			MyObjectBuilder_EnvironmentalParticleLogicGrassland IActivator<MyObjectBuilder_EnvironmentalParticleLogicGrassland>.CreateInstance()
			{
				//ILSpy generated this explicit interface implementation from .override directive in CreateInstance
				return this.CreateInstance();
			}
		}
	}
}
