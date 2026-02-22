using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000FB RID: 251
	public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent
	{
		// Token: 0x06000F1B RID: 3867 RVA: 0x00046730 File Offset: 0x00044930
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaSimpleTypeList()
		{
			Il2CppClassPointerStore<XmlSchemaSimpleTypeList>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaSimpleTypeList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaSimpleTypeList>.NativeClassPtr);
			XmlSchemaSimpleTypeList.NativeFieldInfoPtr_itemTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleTypeList>.NativeClassPtr, "itemTypeName");
			XmlSchemaSimpleTypeList.NativeFieldInfoPtr_itemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleTypeList>.NativeClassPtr, "itemType");
			XmlSchemaSimpleTypeList.NativeFieldInfoPtr_baseItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleTypeList>.NativeClassPtr, "baseItemType");
			XmlSchemaSimpleTypeList.NativeMethodInfoPtr_set_ItemType_Public_set_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeList>.NativeClassPtr, 100665476);
			XmlSchemaSimpleTypeList.NativeMethodInfoPtr_get_BaseItemType_Public_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeList>.NativeClassPtr, 100665477);
			XmlSchemaSimpleTypeList.NativeMethodInfoPtr_set_BaseItemType_Public_set_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeList>.NativeClassPtr, 100665478);
			XmlSchemaSimpleTypeList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeList>.NativeClassPtr, 100665479);
		}

		// Token: 0x1700059F RID: 1439
		// (set) Token: 0x06000F1C RID: 3868 RVA: 0x000467EC File Offset: 0x000449EC
		public unsafe XmlSchemaSimpleType ItemType
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeList.NativeMethodInfoPtr_set_ItemType_Public_set_Void_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06000F1D RID: 3869 RVA: 0x00046830 File Offset: 0x00044A30
		// (set) Token: 0x06000F1E RID: 3870 RVA: 0x00046870 File Offset: 0x00044A70
		public unsafe XmlSchemaSimpleType BaseItemType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeList.NativeMethodInfoPtr_get_BaseItemType_Public_get_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeList.NativeMethodInfoPtr_set_BaseItemType_Public_set_Void_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x000468B4 File Offset: 0x00044AB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 24900, RefRangeEnd = 24903, XrefRangeStart = 24895, XrefRangeEnd = 24900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSimpleTypeList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaSimpleTypeList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x000072C7 File Offset: 0x000054C7
		public XmlSchemaSimpleTypeList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x000468F0 File Offset: 0x00044AF0
		// (set) Token: 0x06000F22 RID: 3874 RVA: 0x000072D0 File Offset: 0x000054D0
		public unsafe XmlQualifiedName itemTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeList.NativeFieldInfoPtr_itemTypeName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeList.NativeFieldInfoPtr_itemTypeName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x00046920 File Offset: 0x00044B20
		// (set) Token: 0x06000F24 RID: 3876 RVA: 0x000072EF File Offset: 0x000054EF
		public unsafe XmlSchemaSimpleType itemType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeList.NativeFieldInfoPtr_itemType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeList.NativeFieldInfoPtr_itemType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x00046950 File Offset: 0x00044B50
		// (set) Token: 0x06000F26 RID: 3878 RVA: 0x0000730E File Offset: 0x0000550E
		public unsafe XmlSchemaSimpleType baseItemType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeList.NativeFieldInfoPtr_baseItemType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeList.NativeFieldInfoPtr_baseItemType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeFieldInfoPtr_itemTypeName;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeFieldInfoPtr_itemType;

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeFieldInfoPtr_baseItemType;

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemType_Public_set_Void_XmlSchemaSimpleType_0;

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseItemType_Public_get_XmlSchemaSimpleType_0;

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseItemType_Public_set_Void_XmlSchemaSimpleType_0;

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
