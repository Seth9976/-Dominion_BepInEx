using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000066 RID: 102
	public class CollectionConverter : TypeConverter
	{
		// Token: 0x06000779 RID: 1913 RVA: 0x00004F73 File Offset: 0x00003173
		// Note: this type is marked as 'beforefieldinit'.
		static CollectionConverter()
		{
			Il2CppClassPointerStore<CollectionConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "CollectionConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionConverter>.NativeClassPtr);
			CollectionConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionConverter>.NativeClassPtr, 100664270);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x0002C280 File Offset: 0x0002A480
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CollectionConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectionConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00004FAC File Offset: 0x000031AC
		public CollectionConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
