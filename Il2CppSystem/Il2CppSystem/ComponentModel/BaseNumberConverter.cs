using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000076 RID: 118
	public class BaseNumberConverter : TypeConverter
	{
		// Token: 0x060007CE RID: 1998 RVA: 0x000052FF File Offset: 0x000034FF
		// Note: this type is marked as 'beforefieldinit'.
		static BaseNumberConverter()
		{
			Il2CppClassPointerStore<BaseNumberConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "BaseNumberConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseNumberConverter>.NativeClassPtr);
			BaseNumberConverter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseNumberConverter>.NativeClassPtr, 100664305);
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x0002D0BC File Offset: 0x0002B2BC
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseNumberConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseNumberConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseNumberConverter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00005338 File Offset: 0x00003538
		public BaseNumberConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
