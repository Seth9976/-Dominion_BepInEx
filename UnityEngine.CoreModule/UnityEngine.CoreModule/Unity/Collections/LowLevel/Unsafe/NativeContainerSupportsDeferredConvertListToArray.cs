using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000024 RID: 36
	public sealed class NativeContainerSupportsDeferredConvertListToArray : Attribute
	{
		// Token: 0x06000102 RID: 258 RVA: 0x00002B43 File Offset: 0x00000D43
		// Note: this type is marked as 'beforefieldinit'.
		static NativeContainerSupportsDeferredConvertListToArray()
		{
			Il2CppClassPointerStore<NativeContainerSupportsDeferredConvertListToArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeContainerSupportsDeferredConvertListToArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeContainerSupportsDeferredConvertListToArray>.NativeClassPtr);
			NativeContainerSupportsDeferredConvertListToArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeContainerSupportsDeferredConvertListToArray>.NativeClassPtr, 100663342);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0001970C File Offset: 0x0001790C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeContainerSupportsDeferredConvertListToArray()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeContainerSupportsDeferredConvertListToArray>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeContainerSupportsDeferredConvertListToArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002B7C File Offset: 0x00000D7C
		public NativeContainerSupportsDeferredConvertListToArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
