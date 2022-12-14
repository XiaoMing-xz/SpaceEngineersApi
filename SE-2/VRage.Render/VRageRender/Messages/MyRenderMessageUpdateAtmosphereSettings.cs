namespace VRageRender.Messages
{
	public class MyRenderMessageUpdateAtmosphereSettings : MyRenderMessageBase
	{
		public uint ID;

		public MyAtmosphereSettings Settings;

		public override MyRenderMessageType MessageClass => MyRenderMessageType.StateChangeOnce;

		public override MyRenderMessageEnum MessageType => MyRenderMessageEnum.UpdateAtmosphereSettings;
	}
}
