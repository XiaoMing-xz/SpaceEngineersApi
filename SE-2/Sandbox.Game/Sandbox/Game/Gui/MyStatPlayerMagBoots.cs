using Sandbox.Game.Entities.Character;
using Sandbox.Game.World;
using VRage.Utils;

namespace Sandbox.Game.GUI
{
	public class MyStatPlayerMagBoots : MyStatBase
	{
		public MyStatPlayerMagBoots()
		{
			base.Id = MyStringHash.GetOrCompute("player_magboots");
		}

		public override void Update()
		{
			MyCharacter localCharacter = MySession.Static.LocalCharacter;
			if (localCharacter != null)
			{
				if (MySession.Static != null && MySession.Static.ControlledEntity is MyCharacter)
				{
					base.CurrentValue = (localCharacter.IsMagneticBootsEnabled ? 1f : 0f);
				}
				else
				{
					base.CurrentValue = 0f;
				}
			}
		}
	}
}
