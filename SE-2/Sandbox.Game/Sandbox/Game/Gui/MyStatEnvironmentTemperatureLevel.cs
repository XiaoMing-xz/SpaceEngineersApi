using Sandbox.Game.Entities.Character;
using Sandbox.Game.World;
using VRage.Utils;

namespace Sandbox.Game.GUI
{
	public class MyStatEnvironmentTemperatureLevel : MyStatBase
	{
		public MyStatEnvironmentTemperatureLevel()
		{
			base.Id = MyStringHash.GetOrCompute("environment_temperature_level");
		}

		public override void Update()
		{
			MyCharacter localCharacter = MySession.Static.LocalCharacter;
			if (localCharacter == null)
			{
				base.CurrentValue = 0f;
			}
			else
			{
				base.CurrentValue = localCharacter.GetOutsideTemperature();
			}
		}
	}
}
