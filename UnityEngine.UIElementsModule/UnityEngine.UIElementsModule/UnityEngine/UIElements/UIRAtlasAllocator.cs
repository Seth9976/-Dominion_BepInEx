using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000181 RID: 385
	public class UIRAtlasAllocator
	{
		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001092 RID: 4242 RVA: 0x0000AB12 File Offset: 0x00008D12
		public int maxAtlasSize
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x0000AB1F File Offset: 0x00008D1F
		public int maxImageWidth
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001094 RID: 4244 RVA: 0x0000AB2C File Offset: 0x00008D2C
		public int maxImageHeight
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06001095 RID: 4245 RVA: 0x0000AB39 File Offset: 0x00008D39
		// (set) Token: 0x06001096 RID: 4246 RVA: 0x0000AB46 File Offset: 0x00008D46
		public int virtualWidth
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

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x0000AB53 File Offset: 0x00008D53
		// (set) Token: 0x06001098 RID: 4248 RVA: 0x0000AB60 File Offset: 0x00008D60
		public int virtualHeight
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

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x0000AB6D File Offset: 0x00008D6D
		// (set) Token: 0x0600109A RID: 4250 RVA: 0x0000AB7A File Offset: 0x00008D7A
		public int physicalWidth
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

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x0000AB87 File Offset: 0x00008D87
		// (set) Token: 0x0600109C RID: 4252 RVA: 0x0000AB94 File Offset: 0x00008D94
		public int physicalHeight
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

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x0000ABA1 File Offset: 0x00008DA1
		// (set) Token: 0x0600109E RID: 4254 RVA: 0x0000ABAE File Offset: 0x00008DAE
		public bool disposed
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

		// Token: 0x0600109F RID: 4255 RVA: 0x0000ABBB File Offset: 0x00008DBB
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x0000ABCD File Offset: 0x00008DCD
		public virtual void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x0003759C File Offset: 0x0003579C
		public static int GetLog2OfNextPower(int n)
		{
			float num = (float)Mathf.NextPowerOfTwo(n);
			float num2 = Mathf.Log(num, 2f);
			return Mathf.RoundToInt(num2);
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x0000ABDA File Offset: 0x00008DDA
		public bool TryAllocate(int width, int height, out RectInt location)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x0000ABE7 File Offset: 0x00008DE7
		public bool TryPartitionArea(UIRAtlasAllocator.AreaNode areaNode, int rowIndex, int rowHeight, int minWidth)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x0000ABF4 File Offset: 0x00008DF4
		public void BuildAreas()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x02000279 RID: 633
		public class Row
		{
		}

		// Token: 0x0200027A RID: 634
		public class AreaNode
		{
		}
	}
}
