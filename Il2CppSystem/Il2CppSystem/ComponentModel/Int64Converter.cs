using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200006F RID: 111
	public class Int64Converter : BaseNumberConverter
	{
		// Token: 0x0600079F RID: 1951 RVA: 0x00005150 File Offset: 0x00003350
		// Note: this type is marked as 'beforefieldinit'.
		static Int64Converter()
		{
			Il2CppClassPointerStore<Int64Converter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "Int64Converter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Int64Converter>.NativeClassPtr);
			Int64Converter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int64Converter>.NativeClassPtr, 100664284);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0002C898 File Offset: 0x0002AA98
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 40944, RefRangeEnd = 40950, XrefRangeStart = 40944, XrefRangeEnd = 40950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Int64Converter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Int64Converter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64Converter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00005189 File Offset: 0x00003389
		public Int64Converter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
