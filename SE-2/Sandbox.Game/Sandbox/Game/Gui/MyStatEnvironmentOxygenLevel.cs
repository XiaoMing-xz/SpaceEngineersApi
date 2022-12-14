using Sandbox.Game.Entities.Character;
using Sandbox.Game.World;
using VRage.Utils;

namespace Sandbox.Game.GUI
{
	public class MyStatEnvironmentOxygenLevel : MyStatBase
	{
		public MyStatEnvironmentOxygenLevel()
		{
			base.Id = MyStringHash.GetOrCompute("environment_oxygen_level");
		}

		public override void Update()
		{
			MyCharacter localCharacter = MySession.Static.LocalCharacter;
			if (localCharacter == null || localCharacter.OxygenComponent == null)
			{
				base.CurrentValue = 0f;
			}
			else
			{
				base.CurrentValue = localCharacter.EnvironmentOxygenLevel;
			}
		}
	}
}
