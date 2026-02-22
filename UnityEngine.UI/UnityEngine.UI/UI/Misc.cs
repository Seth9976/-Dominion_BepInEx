using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI
{
	// Token: 0x0200002D RID: 45
	public static class Misc : Object
	{
		// Token: 0x06000525 RID: 1317 RVA: 0x0001AE38 File Offset: 0x00019038
		// Note: this type is marked as 'beforefieldinit'.
		static Misc()
		{
			Il2CppClassPointerStore<Misc>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Misc");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Misc>.NativeClassPtr);
			Misc.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Misc>.NativeClassPtr, 100664055);
			Misc.NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Misc>.NativeClassPtr, 100664056);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0001AE90 File Offset: 0x00019090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116396, XrefRangeEnd = 116411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Destroy(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Misc.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0001AEC8 File Offset: 0x000190C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 116421, RefRangeEnd = 116423, XrefRangeStart = 116411, XrefRangeEnd = 116421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyImmediate(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Misc.NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00003C1C File Offset: 0x00001E1C
		public Misc(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0;
	}
}
