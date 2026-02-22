using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000444 RID: 1092
	public sealed class ComImportAttribute : Attribute
	{
		// Token: 0x060042AB RID: 17067 RVA: 0x0001982E File Offset: 0x00017A2E
		// Note: this type is marked as 'beforefieldinit'.
		static ComImportAttribute()
		{
			Il2CppClassPointerStore<ComImportAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "ComImportAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComImportAttribute>.NativeClassPtr);
			ComImportAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComImportAttribute>.NativeClassPtr, 100672967);
		}

		// Token: 0x060042AC RID: 17068 RVA: 0x00132714 File Offset: 0x00130914
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComImportAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComImportAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComImportAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042AD RID: 17069 RVA: 0x00019867 File Offset: 0x00017A67
		public ComImportAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400367B RID: 13947
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
