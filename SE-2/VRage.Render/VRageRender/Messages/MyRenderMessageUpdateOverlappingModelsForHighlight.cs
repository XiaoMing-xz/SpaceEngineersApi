namespace VRageRender.Messages
{
	public class MyRenderMessageUpdateOverlappingModelsForHighlight : MyRenderMessageBase
	{
		public uint OverlappingModelID;

		public bool Enable;

		public override MyRenderMessageType MessageClass => MyRenderMessageType.StateChangeOnce;

		public override MyRenderMessageEnum MessageType => MyRenderMessageEnum.UpdateOverlappingModelsForHighlight;
	}
}
