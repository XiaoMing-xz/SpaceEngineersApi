namespace Sandbox.Game.Screens.Helpers
{
	internal interface IMyToolbarItemEntity
	{
		/// <summary>
		/// Returns true if the toolbar item is referring to the specified entity id.
		/// </summary>
		/// <param name="entityId">An entity id to compare this toolbar item with.</param>
		/// <returns>True if the toolbar item refers to the specified entity id, false otherwise.</returns>
		bool CompareEntityIds(long entityId);
	}
}
