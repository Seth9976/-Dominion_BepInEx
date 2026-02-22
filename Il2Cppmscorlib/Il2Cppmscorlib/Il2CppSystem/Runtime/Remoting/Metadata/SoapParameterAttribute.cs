using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Metadata
{
	// Token: 0x020003DC RID: 988
	public sealed class SoapParameterAttribute : SoapAttribute
	{
		// Token: 0x06003EC4 RID: 16068 RVA: 0x00017B01 File Offset: 0x00015D01
		// Note: this type is marked as 'beforefieldinit'.
		static SoapParameterAttribute()
		{
			Il2CppClassPointerStore<SoapParameterAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Metadata", "SoapParameterAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoapParameterAttribute>.NativeClassPtr);
			SoapParameterAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapParameterAttribute>.NativeClassPtr, 100672501);
		}

		// Token: 0x06003EC5 RID: 16069 RVA: 0x00124C78 File Offset: 0x00122E78
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoapParameterAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoapParameterAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapParameterAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EC6 RID: 16070 RVA: 0x00017B3A File Offset: 0x00015D3A
		public SoapParameterAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040033A6 RID: 13222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
