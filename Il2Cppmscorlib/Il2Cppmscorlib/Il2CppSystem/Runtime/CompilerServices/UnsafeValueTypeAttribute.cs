using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000434 RID: 1076
	[Serializable]
	public sealed class UnsafeValueTypeAttribute : Attribute
	{
		// Token: 0x0600425A RID: 16986 RVA: 0x00019595 File Offset: 0x00017795
		// Note: this type is marked as 'beforefieldinit'.
		static UnsafeValueTypeAttribute()
		{
			Il2CppClassPointerStore<UnsafeValueTypeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "UnsafeValueTypeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeValueTypeAttribute>.NativeClassPtr);
			UnsafeValueTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeValueTypeAttribute>.NativeClassPtr, 100672939);
		}

		// Token: 0x0600425B RID: 16987 RVA: 0x001316F0 File Offset: 0x0012F8F0
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnsafeValueTypeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsafeValueTypeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeValueTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600425C RID: 16988 RVA: 0x000195CE File Offset: 0x000177CE
		public UnsafeValueTypeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040035F5 RID: 13813
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
