using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000FA RID: 250
	public class XmlSchemaSimpleTypeContent : XmlSchemaAnnotated
	{
		// Token: 0x06000F18 RID: 3864 RVA: 0x00007285 File Offset: 0x00005485
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaSimpleTypeContent()
		{
			Il2CppClassPointerStore<XmlSchemaSimpleTypeContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaSimpleTypeContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaSimpleTypeContent>.NativeClassPtr);
			XmlSchemaSimpleTypeContent.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeContent>.NativeClassPtr, 100665475);
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x000466F4 File Offset: 0x000448F4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSimpleTypeContent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaSimpleTypeContent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeContent.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x000072BE File Offset: 0x000054BE
		public XmlSchemaSimpleTypeContent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B1C RID: 2844
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
