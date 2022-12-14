using System;
using VRage.Library.Collections;

namespace VRage.Serialization
{
	public interface IDynamicResolver
	{
		void Serialize(BitStream stream, Type baseType, ref Type obj);
	}
}
