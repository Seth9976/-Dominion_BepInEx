using System;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	public sealed class TreePrototype
	{
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00002BFF File Offset: 0x00000DFF
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00002C0C File Offset: 0x00000E0C
		public GameObject prefab
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00002C19 File Offset: 0x00000E19
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00002C26 File Offset: 0x00000E26
		public float bendFactor
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00002C33 File Offset: 0x00000E33
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00002C40 File Offset: 0x00000E40
		public int navMeshLod
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00005684 File Offset: 0x00003884
		public override bool Equals(Object obj)
		{
			return this.Equals(obj.TryCast<TreePrototype>());
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000056A4 File Offset: 0x000038A4
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000056BC File Offset: 0x000038BC
		public bool Equals(TreePrototype other)
		{
			bool flag = other == null;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = other == this;
				if (flag3)
				{
					flag2 = true;
				}
				else
				{
					bool flag4 = base.GetType() != other.GetType();
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.prefab == other.prefab && this.bendFactor == other.bendFactor && this.navMeshLod == other.navMeshLod;
						flag2 = flag5;
					}
				}
			}
			return flag2;
		}
	}
}
