using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x02000011 RID: 17
	public class NativeAsStructAttribute : Attribute
	{
		// Token: 0x06000070 RID: 112 RVA: 0x00002435 File Offset: 0x00000635
		// Note: this type is marked as 'beforefieldinit'.
		static NativeAsStructAttribute()
		{
			Il2CppClassPointerStore<NativeAsStructAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "NativeAsStructAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeAsStructAttribute>.NativeClassPtr);
			NativeAsStructAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeAsStructAttribute>.NativeClassPtr, 100663330);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000389C File Offset: 0x00001A9C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeAsStructAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeAsStructAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeAsStructAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000246E File Offset: 0x0000066E
		public NativeAsStructAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
