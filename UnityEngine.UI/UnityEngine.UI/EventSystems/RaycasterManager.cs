using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200006E RID: 110
	public static class RaycasterManager : Object
	{
		// Token: 0x06000AF1 RID: 2801 RVA: 0x00031660 File Offset: 0x0002F860
		// Note: this type is marked as 'beforefieldinit'.
		static RaycasterManager()
		{
			Il2CppClassPointerStore<RaycasterManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "RaycasterManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RaycasterManager>.NativeClassPtr);
			RaycasterManager.NativeFieldInfoPtr_s_Raycasters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycasterManager>.NativeClassPtr, "s_Raycasters");
			RaycasterManager.NativeMethodInfoPtr_AddRaycaster_Public_Static_Void_BaseRaycaster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycasterManager>.NativeClassPtr, 100664899);
			RaycasterManager.NativeMethodInfoPtr_GetRaycasters_Public_Static_List_1_BaseRaycaster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycasterManager>.NativeClassPtr, 100664900);
			RaycasterManager.NativeMethodInfoPtr_RemoveRaycasters_Public_Static_Void_BaseRaycaster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycasterManager>.NativeClassPtr, 100664901);
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x000316E0 File Offset: 0x0002F8E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123255, RefRangeEnd = 123256, XrefRangeStart = 123242, XrefRangeEnd = 123255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddRaycaster(BaseRaycaster baseRaycaster)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseRaycaster);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycasterManager.NativeMethodInfoPtr_AddRaycaster_Public_Static_Void_BaseRaycaster_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00031718 File Offset: 0x0002F918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123256, XrefRangeEnd = 123260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<BaseRaycaster> GetRaycasters()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycasterManager.NativeMethodInfoPtr_GetRaycasters_Public_Static_List_1_BaseRaycaster_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<BaseRaycaster>>(intPtr3) : null;
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0003174C File Offset: 0x0002F94C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123273, RefRangeEnd = 123274, XrefRangeStart = 123260, XrefRangeEnd = 123273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveRaycasters(BaseRaycaster baseRaycaster)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseRaycaster);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycasterManager.NativeMethodInfoPtr_RemoveRaycasters_Public_Static_Void_BaseRaycaster_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00005E2C File Offset: 0x0000402C
		public RaycasterManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x00031784 File Offset: 0x0002F984
		// (set) Token: 0x06000AF7 RID: 2807 RVA: 0x00005E35 File Offset: 0x00004035
		public unsafe static List<BaseRaycaster> s_Raycasters
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RaycasterManager.NativeFieldInfoPtr_s_Raycasters, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BaseRaycaster>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RaycasterManager.NativeFieldInfoPtr_s_Raycasters, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeFieldInfoPtr_s_Raycasters;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeMethodInfoPtr_AddRaycaster_Public_Static_Void_BaseRaycaster_0;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeMethodInfoPtr_GetRaycasters_Public_Static_List_1_BaseRaycaster_0;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRaycasters_Public_Static_Void_BaseRaycaster_0;
	}
}
