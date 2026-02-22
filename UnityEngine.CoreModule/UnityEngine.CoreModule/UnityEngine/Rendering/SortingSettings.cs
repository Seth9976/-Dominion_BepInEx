using System;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020002B3 RID: 691
	public struct SortingSettings
	{
		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x060021BA RID: 8634 RVA: 0x000697BC File Offset: 0x000679BC
		// (set) Token: 0x060021BB RID: 8635 RVA: 0x000140B5 File Offset: 0x000122B5
		public Matrix4x4 worldToCameraMatrix
		{
			get
			{
				return this.m_WorldToCameraMatrix;
			}
			set
			{
				this.m_WorldToCameraMatrix = value;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060021BC RID: 8636 RVA: 0x000697D4 File Offset: 0x000679D4
		// (set) Token: 0x060021BD RID: 8637 RVA: 0x000140BF File Offset: 0x000122BF
		public Vector3 cameraPosition
		{
			get
			{
				return this.m_CameraPosition;
			}
			set
			{
				this.m_CameraPosition = value;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060021BE RID: 8638 RVA: 0x000697EC File Offset: 0x000679EC
		// (set) Token: 0x060021BF RID: 8639 RVA: 0x000140C9 File Offset: 0x000122C9
		public Vector3 customAxis
		{
			get
			{
				return this.m_CustomAxis;
			}
			set
			{
				this.m_CustomAxis = value;
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060021C0 RID: 8640 RVA: 0x00069804 File Offset: 0x00067A04
		// (set) Token: 0x060021C1 RID: 8641 RVA: 0x000140D3 File Offset: 0x000122D3
		public SortingCriteria criteria
		{
			get
			{
				return this.m_Criteria;
			}
			set
			{
				this.m_Criteria = value;
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060021C2 RID: 8642 RVA: 0x0006981C File Offset: 0x00067A1C
		// (set) Token: 0x060021C3 RID: 8643 RVA: 0x000140DD File Offset: 0x000122DD
		public DistanceMetric distanceMetric
		{
			get
			{
				return this.m_DistanceMetric;
			}
			set
			{
				this.m_DistanceMetric = value;
			}
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x00069834 File Offset: 0x00067A34
		public bool Equals(SortingSettings other)
		{
			return this.m_WorldToCameraMatrix.Equals(other.m_WorldToCameraMatrix) && this.m_CameraPosition.Equals(other.m_CameraPosition) && this.m_CustomAxis.Equals(other.m_CustomAxis) && this.m_Criteria == other.m_Criteria && this.m_DistanceMetric == other.m_DistanceMetric && this.m_PreviousVPMatrix.Equals(other.m_PreviousVPMatrix) && this.m_NonJitteredVPMatrix.Equals(other.m_NonJitteredVPMatrix);
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x000698C4 File Offset: 0x00067AC4
		public override bool Equals(Object obj)
		{
			bool flag = obj == null;
			return !flag && obj is SortingSettings && this.Equals((SortingSettings)obj);
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x000698FC File Offset: 0x00067AFC
		public override int GetHashCode()
		{
			int num = this.m_WorldToCameraMatrix.GetHashCode();
			num = (num * 397) ^ this.m_CameraPosition.GetHashCode();
			num = (num * 397) ^ this.m_CustomAxis.GetHashCode();
			num = (num * 397) ^ (int)this.m_Criteria;
			num = (num * 397) ^ (int)this.m_DistanceMetric;
			num = (num * 397) ^ this.m_PreviousVPMatrix.GetHashCode();
			return (num * 397) ^ this.m_NonJitteredVPMatrix.GetHashCode();
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x000699A8 File Offset: 0x00067BA8
		public static bool operator ==(SortingSettings left, SortingSettings right)
		{
			return left.Equals(right);
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x000699C4 File Offset: 0x00067BC4
		public static bool operator !=(SortingSettings left, SortingSettings right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04001B81 RID: 7041
		public Matrix4x4 m_WorldToCameraMatrix;

		// Token: 0x04001B82 RID: 7042
		public Vector3 m_CameraPosition;

		// Token: 0x04001B83 RID: 7043
		public Vector3 m_CustomAxis;

		// Token: 0x04001B84 RID: 7044
		public SortingCriteria m_Criteria;

		// Token: 0x04001B85 RID: 7045
		public DistanceMetric m_DistanceMetric;

		// Token: 0x04001B86 RID: 7046
		public Matrix4x4 m_PreviousVPMatrix;

		// Token: 0x04001B87 RID: 7047
		public Matrix4x4 m_NonJitteredVPMatrix;
	}
}
