using System;

namespace Sandbox.Game
{
	[Flags]
	public enum MyExplosionFlags
	{
		CREATE_DEBRIS = 0x1,
		AFFECT_VOXELS = 0x2,
		APPLY_FORCE_AND_DAMAGE = 0x4,
		CREATE_DECALS = 0x8,
		FORCE_DEBRIS = 0x10,
		CREATE_PARTICLE_EFFECT = 0x20,
		CREATE_SHRAPNELS = 0x40,
		APPLY_DEFORMATION = 0x80,
		CREATE_PARTICLE_DEBRIS = 0x100
	}
}
