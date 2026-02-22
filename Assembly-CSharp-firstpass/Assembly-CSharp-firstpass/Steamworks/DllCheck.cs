using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002C1 RID: 705
	public class DllCheck : Object
	{
		// Token: 0x0600285B RID: 10331 RVA: 0x000AF120 File Offset: 0x000AD320
		// Note: this type is marked as 'beforefieldinit'.
		static DllCheck()
		{
			Il2CppClassPointerStore<DllCheck>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "DllCheck");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DllCheck>.NativeClassPtr);
			DllCheck.NativeMethodInfoPtr_Test_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllCheck>.NativeClassPtr, 100668459);
			DllCheck.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllCheck>.NativeClassPtr, 100668460);
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x000AF178 File Offset: 0x000AD378
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Test()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DllCheck.NativeMethodInfoPtr_Test_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x000AF1A8 File Offset: 0x000AD3A8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DllCheck()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DllCheck>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DllCheck.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x000104CD File Offset: 0x0000E6CD
		public DllCheck(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400274E RID: 10062
		private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Static_Boolean_0;

		// Token: 0x0400274F RID: 10063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
