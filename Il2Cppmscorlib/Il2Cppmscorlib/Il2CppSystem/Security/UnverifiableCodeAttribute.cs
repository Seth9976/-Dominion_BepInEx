using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security
{
	// Token: 0x020002BA RID: 698
	public sealed class UnverifiableCodeAttribute : Attribute
	{
		// Token: 0x06002ED8 RID: 11992 RVA: 0x000105A8 File Offset: 0x0000E7A8
		// Note: this type is marked as 'beforefieldinit'.
		static UnverifiableCodeAttribute()
		{
			Il2CppClassPointerStore<UnverifiableCodeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security", "UnverifiableCodeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnverifiableCodeAttribute>.NativeClassPtr);
			UnverifiableCodeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnverifiableCodeAttribute>.NativeClassPtr, 100670727);
		}

		// Token: 0x06002ED9 RID: 11993 RVA: 0x000EC7B4 File Offset: 0x000EA9B4
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnverifiableCodeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnverifiableCodeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnverifiableCodeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EDA RID: 11994 RVA: 0x000105E1 File Offset: 0x0000E7E1
		public UnverifiableCodeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002887 RID: 10375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
