namespace VRageRender.Messages
{
	public class MyRenderMessageSetVideoVolume : MyRenderMessageBase
	{
		public uint ID;

		public float Volume;

		public override MyRenderMessageType MessageClass => MyRenderMessageType.StateChangeOnce;

		public override MyRenderMessageEnum MessageType => MyRenderMessageEnum.SetVideoVolume;
	}
}
