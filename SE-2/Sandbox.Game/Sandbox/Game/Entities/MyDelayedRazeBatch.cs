using System.Collections.Generic;
using VRageMath;

namespace Sandbox.Game.Entities
{
	public class MyDelayedRazeBatch
	{
		public Vector3I Pos;

		public Vector3UByte Size;

		public HashSet<MyCockpit> Occupied;

		public MyDelayedRazeBatch(Vector3I pos, Vector3UByte size)
		{
			Pos = pos;
			Size = size;
		}
	}
}
