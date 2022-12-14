using VRage.BitCompression;
using VRage.Library.Collections;
using VRageMath;

namespace System
{
	public static class BitCompressionExtensions
	{
		/// <summary>
		/// Serializes normalized quaternion into 29 bits
		/// </summary>
		public static Quaternion ReadQuaternionNormCompressed(this BitStream stream)
		{
			return CompressedQuaternion.Read(stream);
		}

		/// <summary>
		/// Serializes normalized quaternion into 29 bits
		/// </summary>
		public static void WriteQuaternionNormCompressed(this BitStream stream, Quaternion value)
		{
			CompressedQuaternion.Write(stream, value);
		}

		/// <summary>
		/// Serializes normalized quaternion into 29 bits
		/// </summary>
		public static void SerializeNormCompressed(this BitStream stream, ref Quaternion quat)
		{
			if (stream.Reading)
			{
				quat = stream.ReadQuaternionNormCompressed();
			}
			else
			{
				stream.WriteQuaternionNormCompressed(quat);
			}
		}

		/// <summary>
		/// Serializes normalized quaternion into 1 or 30 bits
		/// </summary>
		public static Quaternion ReadQuaternionNormCompressedIdentity(this BitStream stream)
		{
			if (stream.ReadBool())
			{
				return Quaternion.Identity;
			}
			return CompressedQuaternion.Read(stream);
		}

		/// <summary>
		/// Serializes normalized quaternion into 1 or 30 bits
		/// </summary>
		public static void WriteQuaternionNormCompressedIdentity(this BitStream stream, Quaternion value)
		{
			bool flag = value == Quaternion.Identity;
			stream.WriteBool(flag);
			if (!flag)
			{
				CompressedQuaternion.Write(stream, value);
			}
		}

		/// <summary>
		/// Serializes normalized quaternion into 1 or 30 bits
		/// </summary>
		public static void SerializeNormCompressedIdentity(this BitStream stream, ref Quaternion quat)
		{
			if (stream.Reading)
			{
				quat = stream.ReadQuaternionNormCompressedIdentity();
			}
			else
			{
				stream.WriteQuaternionNormCompressedIdentity(quat);
			}
		}
	}
}
