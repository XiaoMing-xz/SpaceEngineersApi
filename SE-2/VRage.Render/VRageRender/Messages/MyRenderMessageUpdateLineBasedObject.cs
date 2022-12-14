using VRageMath;

namespace VRageRender.Messages
{
	public class MyRenderMessageUpdateLineBasedObject : MyRenderMessageBase
	{
		public uint ID;

		public Vector3D WorldPointA;

		public Vector3D WorldPointB;

		public override MyRenderMessageType MessageClass => MyRenderMessageType.StateChangeOnce;

		public override MyRenderMessageEnum MessageType => MyRenderMessageEnum.UpdateLineBasedObject;
	}
}
