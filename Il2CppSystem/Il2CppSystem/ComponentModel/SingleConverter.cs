using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000070 RID: 112
	public class SingleConverter : BaseNumberConverter
	{
		// Token: 0x060007A2 RID: 1954 RVA: 0x00005192 File Offset: 0x00003392
		// Note: this type is marked as 'beforefieldinit'.
		static SingleConverter()
		{
			Il2CppClassPointerStore<SingleConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "SingleConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleConverter>.NativeClassPtr);
			SingleConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleConverter>.NativeClassPtr, 100664285);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0002C8D4 File Offset: 0x0002AAD4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 40944, RefRangeEnd = 40950, XrefRangeStart = 40944, XrefRangeEnd = 40950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SingleConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x000051CB File Offset: 0x000033CB
		public SingleConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
