using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200006E RID: 110
	public class Int32Converter : BaseNumberConverter
	{
		// Token: 0x0600079C RID: 1948 RVA: 0x0000510E File Offset: 0x0000330E
		// Note: this type is marked as 'beforefieldinit'.
		static Int32Converter()
		{
			Il2CppClassPointerStore<Int32Converter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "Int32Converter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Int32Converter>.NativeClassPtr);
			Int32Converter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int32Converter>.NativeClassPtr, 100664283);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0002C85C File Offset: 0x0002AA5C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 40944, RefRangeEnd = 40950, XrefRangeStart = 40944, XrefRangeEnd = 40950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Int32Converter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Int32Converter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int32Converter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00005147 File Offset: 0x00003347
		public Int32Converter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
