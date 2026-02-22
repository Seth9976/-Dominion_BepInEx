using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000E9 RID: 233
	public sealed class XmlSchemaCompilationSettings : Object
	{
		// Token: 0x06000E65 RID: 3685 RVA: 0x0004402C File Offset: 0x0004222C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaCompilationSettings()
		{
			Il2CppClassPointerStore<XmlSchemaCompilationSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaCompilationSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaCompilationSettings>.NativeClassPtr);
			XmlSchemaCompilationSettings.NativeFieldInfoPtr_enableUpaCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaCompilationSettings>.NativeClassPtr, "enableUpaCheck");
			XmlSchemaCompilationSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCompilationSettings>.NativeClassPtr, 100665403);
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x00044084 File Offset: 0x00042284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24466, XrefRangeEnd = 24467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaCompilationSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaCompilationSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCompilationSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x00006D2E File Offset: 0x00004F2E
		public XmlSchemaCompilationSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x000440C0 File Offset: 0x000422C0
		// (set) Token: 0x06000E69 RID: 3689 RVA: 0x00006D37 File Offset: 0x00004F37
		public unsafe bool enableUpaCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCompilationSettings.NativeFieldInfoPtr_enableUpaCheck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCompilationSettings.NativeFieldInfoPtr_enableUpaCheck)) = value;
			}
		}

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeFieldInfoPtr_enableUpaCheck;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
