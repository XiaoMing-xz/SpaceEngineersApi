using Sandbox.Game.Entities;
using VRage.Voxels;
using VRageMath;

namespace Sandbox.Game.AI.Pathfinding
{
	/// <summary>
	/// For BW compatibility only to allow separation of Cestmir's pathfinding
	/// </summary>
	public interface IMyPathfindingLog
	{
		void LogStorageWrite(MyVoxelBase map, MyStorageData source, MyStorageDataTypeFlags dataToWrite, Vector3I voxelRangeMin, Vector3I voxelRangeMax);
	}
}
