using Havok;
using VRageMath;
using VRageRender.Messages;

namespace VRageRender.Utils
{
	public class MyPhysicsMesh : IPhysicsMesh
	{
		private MyModelData m_data = new MyModelData();

		public MyModelData Data
		{
			set
			{
				m_data = value;
			}
		}

		void IPhysicsMesh.SetAABB(Vector3 min, Vector3 max)
		{
			m_data.AABB = new BoundingBox(min, max);
		}

		void IPhysicsMesh.AddSectionData(int indexStart, int triCount, string matName)
		{
			if (matName.Contains("/"))
			{
				matName = matName.Substring(matName.IndexOf('/') + 1);
			}
			MyRuntimeSectionInfo myRuntimeSectionInfo = default(MyRuntimeSectionInfo);
			myRuntimeSectionInfo.IndexStart = indexStart;
			myRuntimeSectionInfo.TriCount = triCount;
			myRuntimeSectionInfo.MaterialName = matName;
			MyRuntimeSectionInfo item = myRuntimeSectionInfo;
			m_data.Sections.Add(item);
		}

		void IPhysicsMesh.AddIndex(int index)
		{
			m_data.Indices.Add(index);
		}

		void IPhysicsMesh.AddVertex(Vector3 position, Vector3 normal, Vector3 tangent, Vector2 texCoord)
		{
			m_data.Positions.Add(position);
			m_data.Normals.Add(normal);
			m_data.Tangents.Add(tangent);
			m_data.TexCoords.Add(texCoord);
		}

		int IPhysicsMesh.GetSectionsCount()
		{
			return m_data.Sections.Count;
		}

		bool IPhysicsMesh.GetSectionData(int idx, ref int indexStart, ref int triCount, ref string matName)
		{
			if (idx < m_data.Sections.Count)
			{
				indexStart = m_data.Sections[idx].IndexStart;
				triCount = m_data.Sections[idx].TriCount;
				matName = m_data.Sections[idx].MaterialName;
				return true;
			}
			return false;
		}

		int IPhysicsMesh.GetIndicesCount()
		{
			return m_data.Indices.Count;
		}

		int IPhysicsMesh.GetIndex(int idx)
		{
			return m_data.Indices[idx];
		}

		int IPhysicsMesh.GetVerticesCount()
		{
			return m_data.Positions.Count;
		}

		bool IPhysicsMesh.GetVertex(int vertexId, ref Vector3 position, ref Vector3 normal, ref Vector3 tangent, ref Vector2 texCoord)
		{
			if (vertexId < m_data.Positions.Count)
			{
				position = m_data.Positions[vertexId];
				normal = m_data.Normals[vertexId];
				tangent = m_data.Tangents[vertexId];
				texCoord = m_data.TexCoords[vertexId];
				return true;
			}
			return false;
		}

		void IPhysicsMesh.Transform(Matrix m)
		{
			TransformInternal(ref m);
		}

		public void Transform(Matrix m)
		{
			TransformInternal(ref m);
		}

		private void TransformInternal(ref Matrix m)
		{
			for (int i = 0; i < m_data.Positions.Count; i++)
			{
				m_data.Positions[i] = Vector3.Transform(m_data.Positions[i], m);
			}
		}

		public BoundingBox GetAABB()
		{
			return m_data.AABB;
		}
	}
}
