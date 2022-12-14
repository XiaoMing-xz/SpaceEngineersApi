using System.Collections.Generic;
using VRageMath;
using VRageMath.PackedVector;
using VRageRender;
using VRageRender.Vertex;

namespace VRage.Render11.Profiler.Internal
{
	internal class MyRenderProfilerLineBatch
	{
		private List<MyVertexFormatPositionColor> m_list = new List<MyVertexFormatPositionColor>();

		private List<MyVertexFormatPositionColor> m_onScreenList = new List<MyVertexFormatPositionColor>();

		internal MyRenderProfilerLineBatch(Matrix view, Matrix projection, int size)
		{
		}

		internal void Begin()
		{
		}

		internal void End()
		{
			if (m_list.Count > 0)
			{
				MyLinesBatch myLinesBatch = MyLinesRenderer.CreateBatch();
				for (int i = 0; i < m_list.Count; i++)
				{
					myLinesBatch.Add(m_list[i]);
				}
				myLinesBatch.Commit();
			}
			if (m_onScreenList.Count > 0)
			{
				MyLinesBatch myLinesBatch2 = MyLinesRenderer.CreateBatch();
				for (int j = 0; j < m_onScreenList.Count; j++)
				{
					myLinesBatch2.Add(m_onScreenList[j]);
				}
				myLinesBatch2.CustomViewProjection = Matrix.Identity;
				myLinesBatch2.Commit();
			}
			m_list.Clear();
			m_onScreenList.Clear();
		}

		internal void DrawLine(Vector3 v0, Vector3 v1, Color color)
		{
			m_list.Add(new MyVertexFormatPositionColor(new Vector3(v0.X, v0.Y, v0.Z), new Byte4(color.PackedValue)));
			m_list.Add(new MyVertexFormatPositionColor(new Vector3(v1.X, v1.Y, v1.Z), new Byte4(color.PackedValue)));
		}

		internal void DrawOnScreenLine(Vector3 v0, Vector3 v1, Color color)
		{
			m_onScreenList.Add(new MyVertexFormatPositionColor(new Vector3(v0.X, v0.Y, v0.Z), new Byte4(color.PackedValue)));
			m_onScreenList.Add(new MyVertexFormatPositionColor(new Vector3(v1.X, v1.Y, v1.Z), new Byte4(color.PackedValue)));
		}

		internal Vector3 Mul(Matrix m, Vector3 v)
		{
			return new Vector3(v.X * m.M11 + v.Y * m.M21 + v.Z * m.M31, v.X * m.M12 + v.Y * m.M22 + v.Z * m.M32, v.X * m.M13 + v.Y * m.M23 + v.Z * m.M33);
		}
	}
}
