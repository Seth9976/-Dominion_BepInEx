using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000E4 RID: 228
	public class XmlSchemaAnnotated : XmlSchemaObject
	{
		// Token: 0x06000E44 RID: 3652 RVA: 0x00006BD2 File Offset: 0x00004DD2
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaAnnotated()
		{
			Il2CppClassPointerStore<XmlSchemaAnnotated>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaAnnotated");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaAnnotated>.NativeClassPtr);
			XmlSchemaAnnotated.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnnotated>.NativeClassPtr, 100665394);
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x00043AF8 File Offset: 0x00041CF8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaAnnotated()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaAnnotated>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnnotated.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x00006C0B File Offset: 0x00004E0B
		public XmlSchemaAnnotated(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A8B RID: 2699
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
