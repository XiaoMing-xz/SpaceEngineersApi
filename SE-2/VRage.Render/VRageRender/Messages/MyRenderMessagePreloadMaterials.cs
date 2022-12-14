namespace VRageRender.Messages
{
	public class MyRenderMessagePreloadMaterials : MyRenderMessageBase
	{
		public string Name;

		public override MyRenderMessageType MessageClass => MyRenderMessageType.StateChangeOnce;

		public override MyRenderMessageEnum MessageType => MyRenderMessageEnum.PreloadMaterials;
	}
}
