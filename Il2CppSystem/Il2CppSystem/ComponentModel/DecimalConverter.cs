using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000067 RID: 103
	public class DecimalConverter : BaseNumberConverter
	{
		// Token: 0x0600077C RID: 1916 RVA: 0x00004FB5 File Offset: 0x000031B5
		// Note: this type is marked as 'beforefieldinit'.
		static DecimalConverter()
		{
			Il2CppClassPointerStore<DecimalConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "DecimalConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecimalConverter>.NativeClassPtr);
			DecimalConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecimalConverter>.NativeClassPtr, 100664271);
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0002C2BC File Offset: 0x0002A4BC
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecimalConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecimalConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecimalConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00004FEE File Offset: 0x000031EE
		public DecimalConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
