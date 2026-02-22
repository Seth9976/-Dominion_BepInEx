using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000D4 RID: 212
	public class MiscFacetsChecker : FacetsChecker
	{
		// Token: 0x06000CED RID: 3309 RVA: 0x00006350 File Offset: 0x00004550
		// Note: this type is marked as 'beforefieldinit'.
		static MiscFacetsChecker()
		{
			Il2CppClassPointerStore<MiscFacetsChecker>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "MiscFacetsChecker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiscFacetsChecker>.NativeClassPtr);
			MiscFacetsChecker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscFacetsChecker>.NativeClassPtr, 100665213);
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x0003EAB8 File Offset: 0x0003CCB8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MiscFacetsChecker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MiscFacetsChecker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscFacetsChecker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x00006389 File Offset: 0x00004589
		public MiscFacetsChecker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
