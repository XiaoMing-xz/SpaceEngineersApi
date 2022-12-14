using System;
using VRage.Library.Utils;

namespace VRage.Noise
{
	public class MyCompositeNoise : MyModule
	{
		private IMyModule[] m_noises;

		private float[] m_amplitudeScales;

		private float m_normalizationFactor = 1f;

		private int m_numNoises;

		public MyCompositeNoise(int numNoises, float startFrequency)
		{
			m_numNoises = numNoises;
			m_noises = new IMyModule[m_numNoises];
			m_amplitudeScales = new float[m_numNoises];
			m_normalizationFactor = 2f - 1f / (float)Math.Pow(2.0, m_numNoises - 1);
			float num = startFrequency;
			for (int i = 0; i < m_numNoises; i++)
			{
				m_amplitudeScales[i] = 1f / (float)Math.Pow(2.0, i);
				m_noises[i] = new MySimplexFast(MyRandom.Instance.Next(), num);
				num *= 2.01f;
			}
		}

		private double NormalizeValue(double value)
		{
			return 0.5 * value / (double)m_normalizationFactor + 0.5;
		}

		public override double GetValue(double x)
		{
			double num = 0.0;
			for (int i = 0; i < m_numNoises; i++)
			{
				num += (double)m_amplitudeScales[i] * m_noises[i].GetValue(x);
			}
			return NormalizeValue(num);
		}

		public override double GetValue(double x, double y)
		{
			double num = 0.0;
			for (int i = 0; i < m_numNoises; i++)
			{
				num += (double)m_amplitudeScales[i] * m_noises[i].GetValue(x, y);
			}
			return NormalizeValue(num);
		}

		public override double GetValue(double x, double y, double z)
		{
			double num = 0.0;
			for (int i = 0; i < m_numNoises; i++)
			{
				num += (double)m_amplitudeScales[i] * m_noises[i].GetValue(x, y, z);
			}
			return NormalizeValue(num);
		}

		public float GetValue(double x, double y, double z, int numNoises)
		{
			double num = 0.0;
			for (int i = 0; i < numNoises; i++)
			{
				num += (double)m_amplitudeScales[i] * m_noises[i].GetValue(x, y, z);
			}
			return (float)(0.5 * num + 0.5);
		}
	}
}
