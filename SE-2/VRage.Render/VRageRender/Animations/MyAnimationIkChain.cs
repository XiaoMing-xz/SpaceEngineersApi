using VRageMath;

namespace VRageRender.Animations
{
	/// <summary>
	/// Tiny structure describing IK chain.
	/// </summary>
	public class MyAnimationIkChain
	{
		public int BoneIndex = -1;

		public string BoneName;

		public int ChainLength;

		public bool AlignBoneWithTerrain;

		public Matrix? EndBoneTransform;

		public float MinEndPointRotation = -20f;

		public float MaxEndPointRotation = 90f;
	}
}
