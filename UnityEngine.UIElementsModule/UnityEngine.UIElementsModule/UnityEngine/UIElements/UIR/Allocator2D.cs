using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020001B4 RID: 436
	public class Allocator2D
	{
		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x060011AD RID: 4525 RVA: 0x0000B5FE File Offset: 0x000097FE
		public Vector2Int minSize
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x060011AE RID: 4526 RVA: 0x0000B60B File Offset: 0x0000980B
		public Vector2Int maxSize
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x0000B618 File Offset: 0x00009818
		public Vector2Int maxAllocSize
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x00038ABC File Offset: 0x00036CBC
		public static void BuildAreas(List<Allocator2D.Area> areas, Vector2Int minSize, Vector2Int maxSize)
		{
			int num = Mathf.Min(minSize.x, minSize.y);
			int num2 = num;
			areas.Add(new Allocator2D.Area(new RectInt(0, 0, num, num2)));
			while (num < maxSize.x || num2 < maxSize.y)
			{
				bool flag = num < maxSize.x;
				if (flag)
				{
					areas.Add(new Allocator2D.Area(new RectInt(num, 0, num, num2)));
					num *= 2;
				}
				bool flag2 = num2 < maxSize.y;
				if (flag2)
				{
					areas.Add(new Allocator2D.Area(new RectInt(0, num2, num, num2)));
					num2 *= 2;
				}
			}
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x0000B625 File Offset: 0x00009825
		public static Vector2Int ComputeMaxAllocSize(List<Allocator2D.Area> areas, int rowHeightBias)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x00038B68 File Offset: 0x00036D68
		public static Il2CppReferenceArray<Allocator2D.Row> BuildRowArray(int maxRowHeight, int rowHeightBias)
		{
			int num = UIRUtility.GetNextPow2Exp(maxRowHeight - rowHeightBias) + 1;
			return new Il2CppReferenceArray<Allocator2D.Row>((long)num);
		}

		// Token: 0x02000290 RID: 656
		public class Area
		{
		}

		// Token: 0x02000291 RID: 657
		public class Row : LinkedPoolItem<Allocator2D.Row>
		{
		}
	}
}
