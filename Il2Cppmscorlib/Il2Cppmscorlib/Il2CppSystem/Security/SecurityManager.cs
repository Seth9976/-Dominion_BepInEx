using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security
{
	// Token: 0x020002C0 RID: 704
	public static class SecurityManager : Object
	{
		// Token: 0x06002F2D RID: 12077 RVA: 0x000EDCAC File Offset: 0x000EBEAC
		// Note: this type is marked as 'beforefieldinit'.
		static SecurityManager()
		{
			Il2CppClassPointerStore<SecurityManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security", "SecurityManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecurityManager>.NativeClassPtr);
			SecurityManager.NativeMethodInfoPtr_CheckElevatedPermissions_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityManager>.NativeClassPtr, 100670778);
			SecurityManager.NativeMethodInfoPtr_EnsureElevatedPermissions_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityManager>.NativeClassPtr, 100670779);
		}

		// Token: 0x06002F2E RID: 12078 RVA: 0x000EDD04 File Offset: 0x000EBF04
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckElevatedPermissions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityManager.NativeMethodInfoPtr_CheckElevatedPermissions_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F2F RID: 12079 RVA: 0x000EDD34 File Offset: 0x000EBF34
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureElevatedPermissions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityManager.NativeMethodInfoPtr_EnsureElevatedPermissions_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x00010777 File Offset: 0x0000E977
		public SecurityManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040028C8 RID: 10440
		private static readonly IntPtr NativeMethodInfoPtr_CheckElevatedPermissions_Internal_Static_Boolean_0;

		// Token: 0x040028C9 RID: 10441
		private static readonly IntPtr NativeMethodInfoPtr_EnsureElevatedPermissions_Internal_Static_Void_0;
	}
}
