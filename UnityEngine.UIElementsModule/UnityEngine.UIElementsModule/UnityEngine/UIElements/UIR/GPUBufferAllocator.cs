using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020000DB RID: 219
	public class GPUBufferAllocator : Object
	{
		// Token: 0x06000C4D RID: 3149 RVA: 0x00031EF4 File Offset: 0x000300F4
		// Note: this type is marked as 'beforefieldinit'.
		static GPUBufferAllocator()
		{
			Il2CppClassPointerStore<GPUBufferAllocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "GPUBufferAllocator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUBufferAllocator>.NativeClassPtr);
			GPUBufferAllocator.NativeFieldInfoPtr_m_Low = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUBufferAllocator>.NativeClassPtr, "m_Low");
			GPUBufferAllocator.NativeFieldInfoPtr_m_High = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUBufferAllocator>.NativeClassPtr, "m_High");
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x00007C7A File Offset: 0x00005E7A
		public GPUBufferAllocator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x00031F4C File Offset: 0x0003014C
		// (set) Token: 0x06000C50 RID: 3152 RVA: 0x00007C83 File Offset: 0x00005E83
		public unsafe BestFitAllocator m_Low
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPUBufferAllocator.NativeFieldInfoPtr_m_Low);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BestFitAllocator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPUBufferAllocator.NativeFieldInfoPtr_m_Low), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000C51 RID: 3153 RVA: 0x00031F7C File Offset: 0x0003017C
		// (set) Token: 0x06000C52 RID: 3154 RVA: 0x00007CA2 File Offset: 0x00005EA2
		public unsafe BestFitAllocator m_High
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPUBufferAllocator.NativeFieldInfoPtr_m_High);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BestFitAllocator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPUBufferAllocator.NativeFieldInfoPtr_m_High), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00031FAC File Offset: 0x000301AC
		public Alloc Allocate(uint size, bool shortLived)
		{
			bool flag = !shortLived;
			Alloc alloc;
			if (flag)
			{
				alloc = this.m_Low.Allocate(size);
			}
			else
			{
				alloc = this.m_High.Allocate(size);
				alloc.start = this.m_High.totalSize - alloc.start - alloc.size;
			}
			alloc.shortLived = shortLived;
			bool flag2 = this.HighLowCollide() && alloc.size > 0U;
			Alloc alloc2;
			if (flag2)
			{
				this.Free(alloc);
				alloc2 = null;
			}
			else
			{
				alloc2 = alloc;
			}
			return alloc2;
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x00032040 File Offset: 0x00030240
		public void Free(Alloc alloc)
		{
			bool flag = !alloc.shortLived;
			if (flag)
			{
				this.m_Low.Free(alloc);
			}
			else
			{
				alloc.start = this.m_High.totalSize - alloc.start - alloc.size;
				this.m_High.Free(alloc);
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x0003209C File Offset: 0x0003029C
		public bool isEmpty
		{
			get
			{
				return this.m_Low.highWatermark == 0U && this.m_High.highWatermark == 0U;
			}
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x000320CC File Offset: 0x000302CC
		public bool HighLowCollide()
		{
			return this.m_Low.highWatermark + this.m_High.highWatermark > this.m_Low.totalSize;
		}

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeFieldInfoPtr_m_Low;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeFieldInfoPtr_m_High;
	}
}
