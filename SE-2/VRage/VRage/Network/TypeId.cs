namespace VRage.Network
{
	public struct TypeId
	{
		internal uint Value;

		public TypeId(uint value)
		{
			Value = value;
		}

		public static implicit operator uint(TypeId tp)
		{
			return tp.Value;
		}

		public override string ToString()
		{
			return Value.ToString();
		}
	}
}
