using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000446 RID: 1094
	public sealed class PreserveSigAttribute : Attribute
	{
		// Token: 0x060042B3 RID: 17075 RVA: 0x00019898 File Offset: 0x00017A98
		// Note: this type is marked as 'beforefieldinit'.
		static PreserveSigAttribute()
		{
			Il2CppClassPointerStore<PreserveSigAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "PreserveSigAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreserveSigAttribute>.NativeClassPtr);
			PreserveSigAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreserveSigAttribute>.NativeClassPtr, 100672969);
		}

		// Token: 0x060042B4 RID: 17076 RVA: 0x0013281C File Offset: 0x00130A1C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PreserveSigAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreserveSigAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreserveSigAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042B5 RID: 17077 RVA: 0x000198D1 File Offset: 0x00017AD1
		public PreserveSigAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400367E RID: 13950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
