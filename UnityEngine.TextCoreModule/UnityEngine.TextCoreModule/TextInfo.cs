using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.TextCore
{
	// Token: 0x02000032 RID: 50
	public class TextInfo
	{
		// Token: 0x060001DD RID: 477 RVA: 0x00003033 File Offset: 0x00001233
		public void Clear()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00003040 File Offset: 0x00001240
		public void ClearMeshInfo(bool updateMesh)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000304D File Offset: 0x0000124D
		public void ClearLineInfo()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000075B0 File Offset: 0x000057B0
		public static void Resize<T>(ref Il2CppArrayBase<T> array, int size)
		{
			int num = ((size > 1024) ? (size + 256) : Mathf.NextPowerOfTwo(size));
			Array.Resize<T>(ref array, num);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000075E0 File Offset: 0x000057E0
		public static void Resize<T>(ref Il2CppArrayBase<T> array, int size, bool isBlockAllocated)
		{
			if (isBlockAllocated)
			{
				size = ((size > 1024) ? (size + 256) : Mathf.NextPowerOfTwo(size));
			}
			bool flag = size == array.Length;
			if (!flag)
			{
				Array.Resize<T>(ref array, size);
			}
		}
	}
}
