using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.ComponentModel;

namespace Il2CppSystem
{
	// Token: 0x02000045 RID: 69
	public class UriTypeConverter : TypeConverter
	{
		// Token: 0x060003E9 RID: 1001 RVA: 0x000035D2 File Offset: 0x000017D2
		// Note: this type is marked as 'beforefieldinit'.
		static UriTypeConverter()
		{
			Il2CppClassPointerStore<UriTypeConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "UriTypeConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UriTypeConverter>.NativeClassPtr);
			UriTypeConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriTypeConverter>.NativeClassPtr, 100663906);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00020284 File Offset: 0x0001E484
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UriTypeConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UriTypeConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriTypeConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0000360B File Offset: 0x0000180B
		public UriTypeConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
