using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000CF RID: 207
	public sealed class NonSerializedAttribute : Attribute
	{
		// Token: 0x06000DEA RID: 3562 RVA: 0x00005993 File Offset: 0x00003B93
		// Note: this type is marked as 'beforefieldinit'.
		static NonSerializedAttribute()
		{
			Il2CppClassPointerStore<NonSerializedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "NonSerializedAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NonSerializedAttribute>.NativeClassPtr);
			NonSerializedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonSerializedAttribute>.NativeClassPtr, 100665638);
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x00061380 File Offset: 0x0005F580
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NonSerializedAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NonSerializedAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonSerializedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x000059CC File Offset: 0x00003BCC
		public NonSerializedAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BD5 RID: 3029
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
