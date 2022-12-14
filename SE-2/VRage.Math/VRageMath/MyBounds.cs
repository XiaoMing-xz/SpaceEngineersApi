namespace VRageMath
{
	public struct MyBounds
	{
		public float Min;

		public float Max;

		public float Default;

		public MyBounds(float min, float max, float def)
		{
			Min = min;
			Max = max;
			Default = def;
		}

		/// <summary>
		/// Normalize value inside the bounds so that 0 is Min and 1 is Max.
		/// </summary>
		public float Normalize(float value)
		{
			return (value - Min) / (Max - Min);
		}

		public float Clamp(float value)
		{
			return MathHelper.Clamp(value, Min, Max);
		}

		public override string ToString()
		{
			return $"Min={Min}, Max={Max}, Default={Default}";
		}
	}
}
