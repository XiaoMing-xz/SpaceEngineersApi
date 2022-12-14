using System;

namespace VRageRender
{
	[Flags]
	internal enum MyShaderUnifiedFlags
	{
		NONE = 0x0,
		DEPTH_ONLY = 0x1,
		ALPHA_MASKED = 0x2,
		TRANSPARENT = 0x4,
		USE_SHADOW_CASCADES = 0x10,
		ALPHA_MASK_ARRAY = 0x20,
		STATIC_DECAL = 0x80,
		STATIC_DECAL_CUTOUT = 0x100,
		USE_SKINNING = 0x200,
		USE_VOXEL_DATA = 0x400,
		USE_VOXEL_MORPHING = 0x800,
		USE_CUBE_INSTANCING = 0x1000,
		USE_DEFORMED_CUBE_INSTANCING = 0x2000,
		USE_GENERIC_INSTANCING = 0x4000,
		USE_MERGE_INSTANCING = 0x8000,
		USE_SINGLE_INSTANCE = 0x10000,
		USE_TEXTURE_INDICES = 0x20000,
		USE_COLORMETAL_TEXTURE = 0x100000,
		USE_NORMALGLOSS_TEXTURE = 0x200000,
		USE_EXTENSIONS_TEXTURE = 0x400000,
		LQ = 0x800000,
		MQ = 0x1000000,
		DISTANCE_FADE = 0x4000000,
		METALNESS_COLORABLE = 0x8000000,
		USE_SIMPLE_INSTANCING = 0x10000000,
		USE_SIMPLE_INSTANCING_COLORING = 0x20000000
	}
}
