using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000399 RID: 921
	public class FormatterData : ProviderData
	{
		// Token: 0x06003C0E RID: 15374 RVA: 0x00016A7A File Offset: 0x00014C7A
		// Note: this type is marked as 'beforefieldinit'.
		static FormatterData()
		{
			Il2CppClassPointerStore<FormatterData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "FormatterData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatterData>.NativeClassPtr);
			FormatterData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterData>.NativeClassPtr, 100672149);
		}

		// Token: 0x06003C0F RID: 15375 RVA: 0x0011ABBC File Offset: 0x00118DBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350240, RefRangeEnd = 350241, XrefRangeStart = 350239, XrefRangeEnd = 350240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormatterData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatterData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C10 RID: 15376 RVA: 0x00016AB3 File Offset: 0x00014CB3
		public FormatterData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040031DE RID: 12766
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
