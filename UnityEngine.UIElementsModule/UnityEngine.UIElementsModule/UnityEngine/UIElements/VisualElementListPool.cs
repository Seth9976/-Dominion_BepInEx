using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200003F RID: 63
	public static class VisualElementListPool : Object
	{
		// Token: 0x0600033A RID: 826 RVA: 0x0001623C File Offset: 0x0001443C
		// Note: this type is marked as 'beforefieldinit'.
		static VisualElementListPool()
		{
			Il2CppClassPointerStore<VisualElementListPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VisualElementListPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualElementListPool>.NativeClassPtr);
			VisualElementListPool.NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementListPool>.NativeClassPtr, "pool");
			VisualElementListPool.NativeMethodInfoPtr_Get_Public_Static_List_1_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementListPool>.NativeClassPtr, 100663580);
			VisualElementListPool.NativeMethodInfoPtr_Release_Public_Static_Void_List_1_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementListPool>.NativeClassPtr, 100663581);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000162A8 File Offset: 0x000144A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93052, RefRangeEnd = 93054, XrefRangeStart = 93039, XrefRangeEnd = 93052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<VisualElement> Get(int initialCapacity = 0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialCapacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementListPool.NativeMethodInfoPtr_Get_Public_Static_List_1_VisualElement_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<VisualElement>>(intPtr3) : null;
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x000162E8 File Offset: 0x000144E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93073, RefRangeEnd = 93075, XrefRangeStart = 93054, XrefRangeEnd = 93073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(List<VisualElement> elements)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elements);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementListPool.NativeMethodInfoPtr_Release_Public_Static_Void_List_1_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00003886 File Offset: 0x00001A86
		public VisualElementListPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00016320 File Offset: 0x00014520
		// (set) Token: 0x0600033F RID: 831 RVA: 0x0000388F File Offset: 0x00001A8F
		public unsafe static ObjectPool<List<VisualElement>> pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualElementListPool.NativeFieldInfoPtr_pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<List<VisualElement>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElementListPool.NativeFieldInfoPtr_pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00016348 File Offset: 0x00014548
		public static List<VisualElement> Copy(List<VisualElement> elements)
		{
			List<VisualElement> list = VisualElementListPool.pool.Get();
			list.AddRange(elements);
			return list;
		}

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeFieldInfoPtr_pool;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_List_1_VisualElement_Int32_0;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_List_1_VisualElement_0;
	}
}
