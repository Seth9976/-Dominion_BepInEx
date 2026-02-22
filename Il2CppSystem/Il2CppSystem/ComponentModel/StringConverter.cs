using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000071 RID: 113
	public class StringConverter : TypeConverter
	{
		// Token: 0x060007A5 RID: 1957 RVA: 0x000051D4 File Offset: 0x000033D4
		// Note: this type is marked as 'beforefieldinit'.
		static StringConverter()
		{
			Il2CppClassPointerStore<StringConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "StringConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringConverter>.NativeClassPtr);
			StringConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringConverter>.NativeClassPtr, 100664286);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0002C910 File Offset: 0x0002AB10
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0000520D File Offset: 0x0000340D
		public StringConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
