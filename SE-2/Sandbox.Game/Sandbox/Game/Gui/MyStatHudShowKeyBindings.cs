using VRage.Utils;

namespace Sandbox.Game.GUI
{
	public class MyStatHudShowKeyBindings : MyStatBase
	{
		public MyStatHudShowKeyBindings()
		{
			base.Id = MyStringHash.GetOrCompute("hud_show_keys");
		}

		public override void Update()
		{
			base.CurrentValue = 1f;
		}
	}
}
