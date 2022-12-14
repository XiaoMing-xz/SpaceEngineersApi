using System.Xml.Serialization;
using VRageMath;

namespace Sandbox.Game.WorldEnvironment.ObjectBuilders
{
	public class MyProceduralEnvironmentMapping
	{
		[XmlElement("Material")]
		public string[] Materials;

		[XmlElement("Biome")]
		public int[] Biomes;

		[XmlElement("Item")]
		public MyEnvironmentItemInfo[] Items;

		public SerializableRange Height = new SerializableRange(0f, 1f);

		public SymmetricSerializableRange Latitude = new SymmetricSerializableRange(-90f, 90f);

		public SerializableRange Longitude = new SerializableRange(-180f, 180f);

		public SerializableRange Slope = new SerializableRange(0f, 90f);
	}
}
