using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004B6 RID: 1206
	[Serializable]
	public sealed class DebuggerNonUserCodeAttribute : Attribute
	{
		// Token: 0x06004732 RID: 18226 RVA: 0x0001ADC3 File Offset: 0x00018FC3
		// Note: this type is marked as 'beforefieldinit'.
		static DebuggerNonUserCodeAttribute()
		{
			Il2CppClassPointerStore<DebuggerNonUserCodeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "DebuggerNonUserCodeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebuggerNonUserCodeAttribute>.NativeClassPtr);
			DebuggerNonUserCodeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerNonUserCodeAttribute>.NativeClassPtr, 100673869);
		}

		// Token: 0x06004733 RID: 18227 RVA: 0x0014784C File Offset: 0x00145A4C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebuggerNonUserCodeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebuggerNonUserCodeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerNonUserCodeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004734 RID: 18228 RVA: 0x0001ADFC File Offset: 0x00018FFC
		public DebuggerNonUserCodeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040039BE RID: 14782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
