using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000FC RID: 252
	public class XmlSchemaSimpleTypeRestriction : XmlSchemaSimpleTypeContent
	{
		// Token: 0x06000F27 RID: 3879 RVA: 0x00046980 File Offset: 0x00044B80
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaSimpleTypeRestriction()
		{
			Il2CppClassPointerStore<XmlSchemaSimpleTypeRestriction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaSimpleTypeRestriction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaSimpleTypeRestriction>.NativeClassPtr);
			XmlSchemaSimpleTypeRestriction.NativeFieldInfoPtr_baseTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleTypeRestriction>.NativeClassPtr, "baseTypeName");
			XmlSchemaSimpleTypeRestriction.NativeFieldInfoPtr_facets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleTypeRestriction>.NativeClassPtr, "facets");
			XmlSchemaSimpleTypeRestriction.NativeMethodInfoPtr_set_BaseTypeName_Public_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeRestriction>.NativeClassPtr, 100665480);
			XmlSchemaSimpleTypeRestriction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeRestriction>.NativeClassPtr, 100665481);
		}

		// Token: 0x170005A3 RID: 1443
		// (set) Token: 0x06000F28 RID: 3880 RVA: 0x00046A00 File Offset: 0x00044C00
		public unsafe XmlQualifiedName BaseTypeName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 24909, RefRangeEnd = 24912, XrefRangeStart = 24903, XrefRangeEnd = 24909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeRestriction.NativeMethodInfoPtr_set_BaseTypeName_Public_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x00046A44 File Offset: 0x00044C44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 24921, RefRangeEnd = 24924, XrefRangeStart = 24912, XrefRangeEnd = 24921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSimpleTypeRestriction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaSimpleTypeRestriction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeRestriction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0000732D File Offset: 0x0000552D
		public XmlSchemaSimpleTypeRestriction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x00046A80 File Offset: 0x00044C80
		// (set) Token: 0x06000F2C RID: 3884 RVA: 0x00007336 File Offset: 0x00005536
		public unsafe XmlQualifiedName baseTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeRestriction.NativeFieldInfoPtr_baseTypeName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeRestriction.NativeFieldInfoPtr_baseTypeName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x00046AB0 File Offset: 0x00044CB0
		// (set) Token: 0x06000F2E RID: 3886 RVA: 0x00007355 File Offset: 0x00005555
		public unsafe XmlSchemaObjectCollection facets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeRestriction.NativeFieldInfoPtr_facets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeRestriction.NativeFieldInfoPtr_facets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeFieldInfoPtr_baseTypeName;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeFieldInfoPtr_facets;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseTypeName_Public_set_Void_XmlQualifiedName_0;

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
