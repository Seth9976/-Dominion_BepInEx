using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x02000014 RID: 20
	public class UnmarshalledAttribute : Attribute
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00002521 File Offset: 0x00000721
		// Note: this type is marked as 'beforefieldinit'.
		static UnmarshalledAttribute()
		{
			Il2CppClassPointerStore<UnmarshalledAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "UnmarshalledAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnmarshalledAttribute>.NativeClassPtr);
			UnmarshalledAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmarshalledAttribute>.NativeClassPtr, 100663340);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00003D60 File Offset: 0x00001F60
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnmarshalledAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnmarshalledAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmarshalledAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000255A File Offset: 0x0000075A
		public UnmarshalledAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
