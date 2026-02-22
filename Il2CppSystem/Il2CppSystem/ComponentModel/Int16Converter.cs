using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200006D RID: 109
	public class Int16Converter : BaseNumberConverter
	{
		// Token: 0x06000799 RID: 1945 RVA: 0x000050CC File Offset: 0x000032CC
		// Note: this type is marked as 'beforefieldinit'.
		static Int16Converter()
		{
			Il2CppClassPointerStore<Int16Converter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "Int16Converter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Int16Converter>.NativeClassPtr);
			Int16Converter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int16Converter>.NativeClassPtr, 100664282);
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0002C820 File Offset: 0x0002AA20
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 40944, RefRangeEnd = 40950, XrefRangeStart = 40944, XrefRangeEnd = 40950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Int16Converter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Int16Converter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int16Converter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00005105 File Offset: 0x00003305
		public Int16Converter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
