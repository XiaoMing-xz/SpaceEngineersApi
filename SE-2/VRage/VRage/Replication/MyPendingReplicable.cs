using System.Collections.Generic;
using VRage.Network;

namespace VRage.Replication
{
	public class MyPendingReplicable
	{
		public readonly List<NetworkId> StateGroupIds = new List<NetworkId>();

		public Dictionary<NetworkId, MyPendingReplicable> DependentReplicables;

		public IMyReplicable Replicable;

		public bool IsStreaming;

		public NetworkId StreamingGroupId;

		public NetworkId ParentID;
	}
}
