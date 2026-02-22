using System;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200023F RID: 575
	public struct SnapAxisFilter
	{
		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001F3C RID: 7996 RVA: 0x00065E30 File Offset: 0x00064030
		public float x
		{
			get
			{
				return ((this.m_Mask & SnapAxis.X) == SnapAxis.X) ? 1f : 0f;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001F3D RID: 7997 RVA: 0x00065E5C File Offset: 0x0006405C
		public float y
		{
			get
			{
				return ((this.m_Mask & SnapAxis.Y) == SnapAxis.Y) ? 1f : 0f;
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001F3E RID: 7998 RVA: 0x00065E88 File Offset: 0x00064088
		public float z
		{
			get
			{
				return ((this.m_Mask & SnapAxis.Z) == SnapAxis.Z) ? 1f : 0f;
			}
		}

		// Token: 0x06001F3F RID: 7999 RVA: 0x00065EB4 File Offset: 0x000640B4
		public override string ToString()
		{
			return String.Format("{{{0}, {1}, {2}}}", this.x, this.y, this.z);
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06001F40 RID: 8000 RVA: 0x00065EF4 File Offset: 0x000640F4
		public int active
		{
			get
			{
				int num = 0;
				bool flag = (this.m_Mask & SnapAxis.X) > SnapAxis.None;
				if (flag)
				{
					num++;
				}
				bool flag2 = (this.m_Mask & SnapAxis.Y) > SnapAxis.None;
				if (flag2)
				{
					num++;
				}
				bool flag3 = (this.m_Mask & SnapAxis.Z) > SnapAxis.None;
				if (flag3)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x06001F41 RID: 8001 RVA: 0x00065F44 File Offset: 0x00064144
		public static implicit operator Vector3(SnapAxisFilter mask)
		{
			return new Vector3(mask.x, mask.y, mask.z);
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x00065F70 File Offset: 0x00064170
		public static explicit operator SnapAxisFilter(Vector3 v)
		{
			return new SnapAxisFilter(v);
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x00065F88 File Offset: 0x00064188
		public static explicit operator SnapAxis(SnapAxisFilter mask)
		{
			return mask.m_Mask;
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x00065FA0 File Offset: 0x000641A0
		public static SnapAxisFilter operator |(SnapAxisFilter left, SnapAxisFilter right)
		{
			return new SnapAxisFilter(left.m_Mask | right.m_Mask);
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x00065FC4 File Offset: 0x000641C4
		public static SnapAxisFilter operator &(SnapAxisFilter left, SnapAxisFilter right)
		{
			return new SnapAxisFilter(left.m_Mask & right.m_Mask);
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x00065FE8 File Offset: 0x000641E8
		public static SnapAxisFilter operator ^(SnapAxisFilter left, SnapAxisFilter right)
		{
			return new SnapAxisFilter(left.m_Mask ^ right.m_Mask);
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x0006600C File Offset: 0x0006420C
		public static SnapAxisFilter operator ~(SnapAxisFilter left)
		{
			return new SnapAxisFilter(~left.m_Mask);
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x0006602C File Offset: 0x0006422C
		public static Vector3 operator *(SnapAxisFilter mask, float value)
		{
			return new Vector3(mask.x * value, mask.y * value, mask.z * value);
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x00066060 File Offset: 0x00064260
		public static Vector3 operator *(SnapAxisFilter mask, Vector3 right)
		{
			return new Vector3(mask.x * right.x, mask.y * right.y, mask.z * right.z);
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x000660A4 File Offset: 0x000642A4
		public static Vector3 operator *(Quaternion rotation, SnapAxisFilter mask)
		{
			int active = mask.active;
			bool flag = active > 2;
			Vector3 vector;
			if (flag)
			{
				vector = mask;
			}
			else
			{
				Vector3 vector2 = rotation * mask;
				vector2 = new Vector3(Mathf.Abs(vector2.x), Mathf.Abs(vector2.y), Mathf.Abs(vector2.z));
				bool flag2 = active > 1;
				if (flag2)
				{
					vector = new Vector3((float)((vector2.x > vector2.y || vector2.x > vector2.z) ? 1 : 0), (float)((vector2.y > vector2.x || vector2.y > vector2.z) ? 1 : 0), (float)((vector2.z > vector2.x || vector2.z > vector2.y) ? 1 : 0));
				}
				else
				{
					vector = new Vector3((float)((vector2.x > vector2.y && vector2.x > vector2.z) ? 1 : 0), (float)((vector2.y > vector2.z && vector2.y > vector2.x) ? 1 : 0), (float)((vector2.z > vector2.x && vector2.z > vector2.y) ? 1 : 0));
				}
			}
			return vector;
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x000661E8 File Offset: 0x000643E8
		public static bool operator ==(SnapAxisFilter left, SnapAxisFilter right)
		{
			return left.m_Mask == right.m_Mask;
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x00066208 File Offset: 0x00064408
		public static bool operator !=(SnapAxisFilter left, SnapAxisFilter right)
		{
			return !(left == right);
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06001F4D RID: 8013 RVA: 0x00066224 File Offset: 0x00064424
		// (set) Token: 0x06001F4E RID: 8014 RVA: 0x00066260 File Offset: 0x00064460
		public float Item
		{
			get
			{
				bool flag = i < 0 || i > 2;
				if (flag)
				{
					throw new IndexOutOfRangeException();
				}
				return (float)(SnapAxis.X & (this.m_Mask >> (i & 31))) * 1f;
			}
			set
			{
				bool flag = i < 0 || i > 2;
				if (flag)
				{
					throw new IndexOutOfRangeException();
				}
				this.m_Mask &= (SnapAxis)(~(SnapAxis)(1 << i));
				this.m_Mask |= (SnapAxis)(((value > 0f) ? 1 : 0) << (i & 31));
			}
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x000662B8 File Offset: 0x000644B8
		public bool Equals(SnapAxisFilter other)
		{
			return this.m_Mask == other.m_Mask;
		}

		// Token: 0x06001F50 RID: 8016 RVA: 0x000662D8 File Offset: 0x000644D8
		public override bool Equals(Object obj)
		{
			bool flag = obj == null;
			return !flag && obj is SnapAxisFilter && this.Equals((SnapAxisFilter)obj);
		}

		// Token: 0x06001F51 RID: 8017 RVA: 0x00066310 File Offset: 0x00064510
		public override int GetHashCode()
		{
			return this.m_Mask.GetHashCode();
		}

		// Token: 0x040018B9 RID: 6329
		public const SnapAxis X = SnapAxis.X;

		// Token: 0x040018BA RID: 6330
		public const SnapAxis Y = SnapAxis.Y;

		// Token: 0x040018BB RID: 6331
		public const SnapAxis Z = SnapAxis.Z;

		// Token: 0x040018BC RID: 6332
		public SnapAxis m_Mask;
	}
}
