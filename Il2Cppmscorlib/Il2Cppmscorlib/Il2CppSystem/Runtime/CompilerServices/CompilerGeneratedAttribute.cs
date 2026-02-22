using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200042A RID: 1066
	[Serializable]
	public sealed class CompilerGeneratedAttribute : Attribute
	{
		// Token: 0x06004228 RID: 16936 RVA: 0x000193A2 File Offset: 0x000175A2
		// Note: this type is marked as 'beforefieldinit'.
		static CompilerGeneratedAttribute()
		{
			Il2CppClassPointerStore<CompilerGeneratedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "CompilerGeneratedAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompilerGeneratedAttribute>.NativeClassPtr);
			CompilerGeneratedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerGeneratedAttribute>.NativeClassPtr, 100672923);
		}

		// Token: 0x06004229 RID: 16937 RVA: 0x00130EC4 File Offset: 0x0012F0C4
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompilerGeneratedAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompilerGeneratedAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompilerGeneratedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600422A RID: 16938 RVA: 0x000193DB File Offset: 0x000175DB
		public CompilerGeneratedAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040035DE RID: 13790
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
