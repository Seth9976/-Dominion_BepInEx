using System;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020001D4 RID: 468
	public struct BoundsInt
	{
		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001C54 RID: 7252 RVA: 0x00061F60 File Offset: 0x00060160
		// (set) Token: 0x06001C55 RID: 7253 RVA: 0x0000F961 File Offset: 0x0000DB61
		public int x
		{
			get
			{
				return this.m_Position.x;
			}
			set
			{
				this.m_Position.x = value;
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001C56 RID: 7254 RVA: 0x00061F80 File Offset: 0x00060180
		// (set) Token: 0x06001C57 RID: 7255 RVA: 0x0000F971 File Offset: 0x0000DB71
		public int y
		{
			get
			{
				return this.m_Position.y;
			}
			set
			{
				this.m_Position.y = value;
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001C58 RID: 7256 RVA: 0x00061FA0 File Offset: 0x000601A0
		// (set) Token: 0x06001C59 RID: 7257 RVA: 0x0000F981 File Offset: 0x0000DB81
		public int z
		{
			get
			{
				return this.m_Position.z;
			}
			set
			{
				this.m_Position.z = value;
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001C5A RID: 7258 RVA: 0x00061FC0 File Offset: 0x000601C0
		public Vector3 center
		{
			get
			{
				return new Vector3((float)this.x + (float)this.m_Size.x / 2f, (float)this.y + (float)this.m_Size.y / 2f, (float)this.z + (float)this.m_Size.z / 2f);
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001C5B RID: 7259 RVA: 0x00062028 File Offset: 0x00060228
		// (set) Token: 0x06001C5C RID: 7260 RVA: 0x0000F991 File Offset: 0x0000DB91
		public Vector3Int min
		{
			get
			{
				return new Vector3Int(this.xMin, this.yMin, this.zMin);
			}
			set
			{
				this.xMin = value.x;
				this.yMin = value.y;
				this.zMin = value.z;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001C5D RID: 7261 RVA: 0x00062054 File Offset: 0x00060254
		// (set) Token: 0x06001C5E RID: 7262 RVA: 0x0000F9BE File Offset: 0x0000DBBE
		public Vector3Int max
		{
			get
			{
				return new Vector3Int(this.xMax, this.yMax, this.zMax);
			}
			set
			{
				this.xMax = value.x;
				this.yMax = value.y;
				this.zMax = value.z;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001C5F RID: 7263 RVA: 0x00062080 File Offset: 0x00060280
		// (set) Token: 0x06001C60 RID: 7264 RVA: 0x000620BC File Offset: 0x000602BC
		public int xMin
		{
			get
			{
				return Math.Min(this.m_Position.x, this.m_Position.x + this.m_Size.x);
			}
			set
			{
				int xMax = this.xMax;
				this.m_Position.x = value;
				this.m_Size.x = xMax - this.m_Position.x;
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001C61 RID: 7265 RVA: 0x000620F8 File Offset: 0x000602F8
		// (set) Token: 0x06001C62 RID: 7266 RVA: 0x00062134 File Offset: 0x00060334
		public int yMin
		{
			get
			{
				return Math.Min(this.m_Position.y, this.m_Position.y + this.m_Size.y);
			}
			set
			{
				int yMax = this.yMax;
				this.m_Position.y = value;
				this.m_Size.y = yMax - this.m_Position.y;
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001C63 RID: 7267 RVA: 0x00062170 File Offset: 0x00060370
		// (set) Token: 0x06001C64 RID: 7268 RVA: 0x000621AC File Offset: 0x000603AC
		public int zMin
		{
			get
			{
				return Math.Min(this.m_Position.z, this.m_Position.z + this.m_Size.z);
			}
			set
			{
				int zMax = this.zMax;
				this.m_Position.z = value;
				this.m_Size.z = zMax - this.m_Position.z;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001C65 RID: 7269 RVA: 0x000621E8 File Offset: 0x000603E8
		// (set) Token: 0x06001C66 RID: 7270 RVA: 0x0000F9EB File Offset: 0x0000DBEB
		public int xMax
		{
			get
			{
				return Math.Max(this.m_Position.x, this.m_Position.x + this.m_Size.x);
			}
			set
			{
				this.m_Size.x = value - this.m_Position.x;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001C67 RID: 7271 RVA: 0x00062224 File Offset: 0x00060424
		// (set) Token: 0x06001C68 RID: 7272 RVA: 0x0000FA07 File Offset: 0x0000DC07
		public int yMax
		{
			get
			{
				return Math.Max(this.m_Position.y, this.m_Position.y + this.m_Size.y);
			}
			set
			{
				this.m_Size.y = value - this.m_Position.y;
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001C69 RID: 7273 RVA: 0x00062260 File Offset: 0x00060460
		// (set) Token: 0x06001C6A RID: 7274 RVA: 0x0000FA23 File Offset: 0x0000DC23
		public int zMax
		{
			get
			{
				return Math.Max(this.m_Position.z, this.m_Position.z + this.m_Size.z);
			}
			set
			{
				this.m_Size.z = value - this.m_Position.z;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001C6B RID: 7275 RVA: 0x0006229C File Offset: 0x0006049C
		// (set) Token: 0x06001C6C RID: 7276 RVA: 0x0000FA3F File Offset: 0x0000DC3F
		public Vector3Int position
		{
			get
			{
				return this.m_Position;
			}
			set
			{
				this.m_Position = value;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001C6D RID: 7277 RVA: 0x000622B4 File Offset: 0x000604B4
		// (set) Token: 0x06001C6E RID: 7278 RVA: 0x0000FA49 File Offset: 0x0000DC49
		public Vector3Int size
		{
			get
			{
				return this.m_Size;
			}
			set
			{
				this.m_Size = value;
			}
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x0000FA53 File Offset: 0x0000DC53
		public void SetMinMax(Vector3Int minPosition, Vector3Int maxPosition)
		{
			this.min = minPosition;
			this.max = maxPosition;
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x000622CC File Offset: 0x000604CC
		public void ClampToBounds(BoundsInt bounds)
		{
			this.position = new Vector3Int(Math.Max(Math.Min(bounds.xMax, this.position.x), bounds.xMin), Math.Max(Math.Min(bounds.yMax, this.position.y), bounds.yMin), Math.Max(Math.Min(bounds.zMax, this.position.z), bounds.zMin));
			this.size = new Vector3Int(Math.Min(bounds.xMax - this.position.x, this.size.x), Math.Min(bounds.yMax - this.position.y, this.size.y), Math.Min(bounds.zMax - this.position.z, this.size.z));
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x000623E0 File Offset: 0x000605E0
		public bool Contains(Vector3Int position)
		{
			return position.x >= this.xMin && position.y >= this.yMin && position.z >= this.zMin && position.x < this.xMax && position.y < this.yMax && position.z < this.zMax;
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x00062450 File Offset: 0x00060650
		public override string ToString()
		{
			return this.ToString(null, null);
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x0006246C File Offset: 0x0006066C
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x0000FA66 File Offset: 0x0000DC66
		public string ToString(string format, IFormatProvider formatProvider)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x00062488 File Offset: 0x00060688
		public static bool operator ==(BoundsInt lhs, BoundsInt rhs)
		{
			return lhs.m_Position == rhs.m_Position && lhs.m_Size == rhs.m_Size;
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x000624C4 File Offset: 0x000606C4
		public static bool operator !=(BoundsInt lhs, BoundsInt rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x000624E0 File Offset: 0x000606E0
		public override bool Equals(Object other)
		{
			bool flag = !(other is BoundsInt);
			return !flag && this.Equals((BoundsInt)other);
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x00062514 File Offset: 0x00060714
		public bool Equals(BoundsInt other)
		{
			return this.m_Position.Equals(other.m_Position) && this.m_Size.Equals(other.m_Size);
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x00062550 File Offset: 0x00060750
		public override int GetHashCode()
		{
			return this.m_Position.GetHashCode() ^ (this.m_Size.GetHashCode() << 2);
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001C7A RID: 7290 RVA: 0x00062588 File Offset: 0x00060788
		public BoundsInt.PositionEnumerator allPositionsWithin
		{
			get
			{
				return new BoundsInt.PositionEnumerator(this.min, this.max);
			}
		}

		// Token: 0x04001673 RID: 5747
		public Vector3Int m_Position;

		// Token: 0x04001674 RID: 5748
		public Vector3Int m_Size;

		// Token: 0x02000AA9 RID: 2729
		public struct PositionEnumerator
		{
		}
	}
}
