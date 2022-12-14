<<<<<<< HEAD
using System.Diagnostics;
=======
>>>>>>> d46cf8619665219cc163a7b28984ced59ed9470d
using ParallelTasks;

namespace VRage.Library.Memory
{
<<<<<<< HEAD
	/// <summary>
	/// Manager for memory tracking systems.
	/// </summary>
	public class MyMemoryTracker : Singleton<MyMemoryTracker>
	{
		/// <summary>
		/// </summary>
		/// <autogeneratedoc />
		public interface ILogger
		{
			/// <summary>
			/// </summary>
			/// <param name="systemName"></param>
			/// <autogeneratedoc />
			void BeginSystem(string systemName);

			/// <summary>
			/// </summary>
			/// <param name="systemBytes"></param>
			/// <param name="totalAllocations"></param>
			/// <autogeneratedoc />
			void EndSystem(long systemBytes, int totalAllocations);
		}

		/// <summary>
		/// </summary>
		/// <autogeneratedoc />
		public const bool FEATURE_ENABLED = true;

		/// <summary>
		/// </summary>
		/// <autogeneratedoc />
		public const string FEATURE_SYMBOL = "FEATURE_MEMORY_TRACKING";

		/// <summary>
		/// </summary>
		/// <autogeneratedoc />
		public MyMemorySystem ProcessMemorySystem { get; }

		/// <summary>
		/// </summary>
		/// <autogeneratedoc />
=======
	public class MyMemoryTracker : Singleton<MyMemoryTracker>
	{
		public interface ILogger
		{
			void BeginSystem(string systemName);

			void EndSystem(long systemBytes, int totalAllocations);
		}

		public const bool ENABLED = true;

		public MyMemorySystem ProcessMemorySystem { get; }

>>>>>>> d46cf8619665219cc163a7b28984ced59ed9470d
		public MyMemoryTracker()
		{
			ProcessMemorySystem = MyMemorySystem.CreateRootMemorySystem("Systems");
		}

<<<<<<< HEAD
		/// <summary>
		/// </summary>
		/// <typeparam name="TLogger"></typeparam>
		/// <param name="logger"></param>
		/// <autogeneratedoc />
		[Conditional("FEATURE_MEMORY_TRACKING")]
=======
>>>>>>> d46cf8619665219cc163a7b28984ced59ed9470d
		public void LogMemoryStats<TLogger>(ref TLogger logger) where TLogger : struct, ILogger
		{
			ProcessMemorySystem.LogMemoryStats(ref logger);
		}
	}
}
