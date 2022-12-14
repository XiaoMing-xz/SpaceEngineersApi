using SharpDX.Direct3D11;
using VRageMath;

namespace VRage.Render11.Resources
{
	internal interface IResource
	{
		string Name { get; }

		Resource Resource { get; }

		Vector3I Size3 { get; }

		Vector2I Size { get; }
	}
}
