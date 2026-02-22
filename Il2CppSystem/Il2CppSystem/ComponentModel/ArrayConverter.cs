using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000064 RID: 100
	public class ArrayConverter : CollectionConverter
	{
		// Token: 0x06000771 RID: 1905 RVA: 0x00004F16 File Offset: 0x00003116
		// Note: this type is marked as 'beforefieldinit'.
		static ArrayConverter()
		{
			Il2CppClassPointerStore<ArrayConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ArrayConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayConverter>.NativeClassPtr);
			ArrayConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayConverter>.NativeClassPtr, 100664268);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x0002C188 File Offset: 0x0002A388
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00004F4F File Offset: 0x0000314F
		public ArrayConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
