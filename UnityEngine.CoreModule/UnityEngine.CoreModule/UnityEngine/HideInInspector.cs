using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000A5 RID: 165
	public sealed class HideInInspector : Attribute
	{
		// Token: 0x06000FE9 RID: 4073 RVA: 0x00009ED1 File Offset: 0x000080D1
		// Note: this type is marked as 'beforefieldinit'.
		static HideInInspector()
		{
			Il2CppClassPointerStore<HideInInspector>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "HideInInspector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideInInspector>.NativeClassPtr);
			HideInInspector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideInInspector>.NativeClassPtr, 100664328);
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x00041A90 File Offset: 0x0003FC90
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HideInInspector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HideInInspector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideInInspector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x00009F0A File Offset: 0x0000810A
		public HideInInspector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
