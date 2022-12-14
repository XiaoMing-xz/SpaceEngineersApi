namespace Sandbox.Game.AI.Pathfinding
{
	/// <summary>
	/// This class contains information about the high-level components of a navigation group.
	///
	/// High-level navigation groups should not know about the implementation of their low-level counterparts, so this
	/// is done as an interface that the specific navigation groups can implement as they see fit.
	/// </summary>
	public interface IMyHighLevelComponent
	{
		bool IsFullyExplored { get; }

		bool Contains(MyNavigationPrimitive primitive);
	}
}
