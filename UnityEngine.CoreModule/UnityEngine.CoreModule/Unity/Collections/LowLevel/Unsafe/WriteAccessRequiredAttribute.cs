using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000027 RID: 39
	public class WriteAccessRequiredAttribute : Attribute
	{
		// Token: 0x06000109 RID: 265 RVA: 0x00002BE1 File Offset: 0x00000DE1
		// Note: this type is marked as 'beforefieldinit'.
		static WriteAccessRequiredAttribute()
		{
			Il2CppClassPointerStore<WriteAccessRequiredAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "WriteAccessRequiredAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WriteAccessRequiredAttribute>.NativeClassPtr);
			WriteAccessRequiredAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteAccessRequiredAttribute>.NativeClassPtr, 100663343);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00019748 File Offset: 0x00017948
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WriteAccessRequiredAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WriteAccessRequiredAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteAccessRequiredAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002C1A File Offset: 0x00000E1A
		public WriteAccessRequiredAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
