using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000435 RID: 1077
	[Serializable]
	public sealed class StringFreezingAttribute : Attribute
	{
		// Token: 0x0600425D RID: 16989 RVA: 0x000195D7 File Offset: 0x000177D7
		// Note: this type is marked as 'beforefieldinit'.
		static StringFreezingAttribute()
		{
			Il2CppClassPointerStore<StringFreezingAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "StringFreezingAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringFreezingAttribute>.NativeClassPtr);
			StringFreezingAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringFreezingAttribute>.NativeClassPtr, 100672940);
		}

		// Token: 0x0600425E RID: 16990 RVA: 0x0013172C File Offset: 0x0012F92C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringFreezingAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringFreezingAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringFreezingAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600425F RID: 16991 RVA: 0x00019610 File Offset: 0x00017810
		public StringFreezingAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040035F6 RID: 13814
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
