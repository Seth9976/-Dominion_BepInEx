using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000069 RID: 105
	public class DoubleConverter : BaseNumberConverter
	{
		// Token: 0x06000788 RID: 1928 RVA: 0x0000501F File Offset: 0x0000321F
		// Note: this type is marked as 'beforefieldinit'.
		static DoubleConverter()
		{
			Il2CppClassPointerStore<DoubleConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "DoubleConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleConverter>.NativeClassPtr);
			DoubleConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleConverter>.NativeClassPtr, 100664277);
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0002C550 File Offset: 0x0002A750
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 40944, RefRangeEnd = 40950, XrefRangeStart = 40943, XrefRangeEnd = 40944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoubleConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00005058 File Offset: 0x00003258
		public DoubleConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
