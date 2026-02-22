using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000072 RID: 114
	public class TimeSpanConverter : TypeConverter
	{
		// Token: 0x060007A8 RID: 1960 RVA: 0x00005216 File Offset: 0x00003416
		// Note: this type is marked as 'beforefieldinit'.
		static TimeSpanConverter()
		{
			Il2CppClassPointerStore<TimeSpanConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "TimeSpanConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeSpanConverter>.NativeClassPtr);
			TimeSpanConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanConverter>.NativeClassPtr, 100664287);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0002C94C File Offset: 0x0002AB4C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpanConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeSpanConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0000524F File Offset: 0x0000344F
		public TimeSpanConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
