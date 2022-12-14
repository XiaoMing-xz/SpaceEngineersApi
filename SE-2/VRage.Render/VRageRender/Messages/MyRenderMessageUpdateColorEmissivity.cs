using VRageMath;

namespace VRageRender.Messages
{
	public class MyRenderMessageUpdateColorEmissivity : MyRenderMessageBase
	{
		public uint ID;

		public int LOD;

		public string MaterialName;

		public Color DiffuseColor;

		public float Emissivity;

		public override MyRenderMessageType MessageClass => MyRenderMessageType.StateChangeOnce;

		public override MyRenderMessageEnum MessageType => MyRenderMessageEnum.UpdateColorEmissivity;
	}
}
