using System.Collections.Generic;

namespace VRageRender.Animations
{
	/// <summary>
	/// Class that contains additional information attached to the model and
	/// shared with the runtime.
	/// </summary>
	public class ModelAnimations
	{
		/// <summary>
		/// The bone indices for the skeleton associated with any
		/// skinned model.
		/// </summary>
		private List<int> skeleton = new List<int>();

		/// <summary>
		/// Any associated animation clips
		/// </summary>
		private List<MyAnimationClip> clips = new List<MyAnimationClip>();

		/// <summary>
		/// The bone indices for the skeleton associated with any
		/// skinned model.
		/// </summary>
		public List<int> Skeleton
		{
			get
			{
				return skeleton;
			}
			set
			{
				skeleton = value;
			}
		}

		/// <summary>
		/// Animation clips associated with this model
		/// </summary>
		public List<MyAnimationClip> Clips
		{
			get
			{
				return clips;
			}
			set
			{
				clips = value;
			}
		}
	}
}
