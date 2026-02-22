using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000F3 RID: 243
	public class XmlSchemaInfo : Object
	{
		// Token: 0x06000EB7 RID: 3767 RVA: 0x00045410 File Offset: 0x00043610
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaInfo()
		{
			Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr);
			XmlSchemaInfo.NativeFieldInfoPtr_isDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, "isDefault");
			XmlSchemaInfo.NativeFieldInfoPtr_isNil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, "isNil");
			XmlSchemaInfo.NativeFieldInfoPtr_schemaElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, "schemaElement");
			XmlSchemaInfo.NativeFieldInfoPtr_schemaAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, "schemaAttribute");
			XmlSchemaInfo.NativeFieldInfoPtr_schemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, "schemaType");
			XmlSchemaInfo.NativeFieldInfoPtr_memberType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, "memberType");
			XmlSchemaInfo.NativeFieldInfoPtr_validity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, "validity");
			XmlSchemaInfo.NativeFieldInfoPtr_contentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, "contentType");
			XmlSchemaInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100665442);
			XmlSchemaInfo.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaValidity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100665443);
			XmlSchemaInfo.NativeMethodInfoPtr_get_Validity_Public_Virtual_Final_New_get_XmlSchemaValidity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100665444);
			XmlSchemaInfo.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100665445);
			XmlSchemaInfo.NativeMethodInfoPtr_get_IsNil_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100665446);
			XmlSchemaInfo.NativeMethodInfoPtr_get_MemberType_Public_Virtual_Final_New_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100665447);
			XmlSchemaInfo.NativeMethodInfoPtr_get_SchemaType_Public_Virtual_Final_New_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100665448);
			XmlSchemaInfo.NativeMethodInfoPtr_get_SchemaElement_Public_Virtual_Final_New_get_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100665449);
			XmlSchemaInfo.NativeMethodInfoPtr_get_SchemaAttribute_Public_Virtual_Final_New_get_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100665450);
			XmlSchemaInfo.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100665451);
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x000455A8 File Offset: 0x000437A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24786, XrefRangeEnd = 24787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x000455E4 File Offset: 0x000437E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24787, XrefRangeEnd = 24788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaInfo(XmlSchemaValidity validity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref validity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaValidity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06000EBA RID: 3770 RVA: 0x0004562C File Offset: 0x0004382C
		public unsafe virtual XmlSchemaValidity Validity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_Validity_Public_Virtual_Final_New_get_XmlSchemaValidity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06000EBB RID: 3771 RVA: 0x00045668 File Offset: 0x00043868
		public unsafe virtual bool IsDefault
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x000456A4 File Offset: 0x000438A4
		public unsafe virtual bool IsNil
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_IsNil_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06000EBD RID: 3773 RVA: 0x000456E0 File Offset: 0x000438E0
		public unsafe virtual XmlSchemaSimpleType MemberType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_MemberType_Public_Virtual_Final_New_get_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x00045720 File Offset: 0x00043920
		public unsafe virtual XmlSchemaType SchemaType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_SchemaType_Public_Virtual_Final_New_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06000EBF RID: 3775 RVA: 0x00045760 File Offset: 0x00043960
		public unsafe virtual XmlSchemaElement SchemaElement
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_SchemaElement_Public_Virtual_Final_New_get_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x000457A0 File Offset: 0x000439A0
		public unsafe virtual XmlSchemaAttribute SchemaAttribute
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_SchemaAttribute_Public_Virtual_Final_New_get_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x000457E0 File Offset: 0x000439E0
		[CallerCount(0)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00006F4D File Offset: 0x0000514D
		public XmlSchemaInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x00045814 File Offset: 0x00043A14
		// (set) Token: 0x06000EC4 RID: 3780 RVA: 0x00006F56 File Offset: 0x00005156
		public unsafe bool isDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_isDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_isDefault)) = value;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x0004583C File Offset: 0x00043A3C
		// (set) Token: 0x06000EC6 RID: 3782 RVA: 0x00006F71 File Offset: 0x00005171
		public unsafe bool isNil
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_isNil);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_isNil)) = value;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x00045864 File Offset: 0x00043A64
		// (set) Token: 0x06000EC8 RID: 3784 RVA: 0x00006F8C File Offset: 0x0000518C
		public unsafe XmlSchemaElement schemaElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_schemaElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_schemaElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x00045894 File Offset: 0x00043A94
		// (set) Token: 0x06000ECA RID: 3786 RVA: 0x00006FAB File Offset: 0x000051AB
		public unsafe XmlSchemaAttribute schemaAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_schemaAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_schemaAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x000458C4 File Offset: 0x00043AC4
		// (set) Token: 0x06000ECC RID: 3788 RVA: 0x00006FCA File Offset: 0x000051CA
		public unsafe XmlSchemaType schemaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_schemaType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_schemaType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x000458F4 File Offset: 0x00043AF4
		// (set) Token: 0x06000ECE RID: 3790 RVA: 0x00006FE9 File Offset: 0x000051E9
		public unsafe XmlSchemaSimpleType memberType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_memberType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_memberType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06000ECF RID: 3791 RVA: 0x00045924 File Offset: 0x00043B24
		// (set) Token: 0x06000ED0 RID: 3792 RVA: 0x00007008 File Offset: 0x00005208
		public unsafe XmlSchemaValidity validity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_validity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_validity)) = value;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x0004594C File Offset: 0x00043B4C
		// (set) Token: 0x06000ED2 RID: 3794 RVA: 0x00007023 File Offset: 0x00005223
		public unsafe XmlSchemaContentType contentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_contentType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_contentType)) = value;
			}
		}

		// Token: 0x04000AE3 RID: 2787
		private static readonly IntPtr NativeFieldInfoPtr_isDefault;

		// Token: 0x04000AE4 RID: 2788
		private static readonly IntPtr NativeFieldInfoPtr_isNil;

		// Token: 0x04000AE5 RID: 2789
		private static readonly IntPtr NativeFieldInfoPtr_schemaElement;

		// Token: 0x04000AE6 RID: 2790
		private static readonly IntPtr NativeFieldInfoPtr_schemaAttribute;

		// Token: 0x04000AE7 RID: 2791
		private static readonly IntPtr NativeFieldInfoPtr_schemaType;

		// Token: 0x04000AE8 RID: 2792
		private static readonly IntPtr NativeFieldInfoPtr_memberType;

		// Token: 0x04000AE9 RID: 2793
		private static readonly IntPtr NativeFieldInfoPtr_validity;

		// Token: 0x04000AEA RID: 2794
		private static readonly IntPtr NativeFieldInfoPtr_contentType;

		// Token: 0x04000AEB RID: 2795
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000AEC RID: 2796
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaValidity_0;

		// Token: 0x04000AED RID: 2797
		private static readonly IntPtr NativeMethodInfoPtr_get_Validity_Public_Virtual_Final_New_get_XmlSchemaValidity_0;

		// Token: 0x04000AEE RID: 2798
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefault_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000AEF RID: 2799
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNil_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000AF0 RID: 2800
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_Virtual_Final_New_get_XmlSchemaSimpleType_0;

		// Token: 0x04000AF1 RID: 2801
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaType_Public_Virtual_Final_New_get_XmlSchemaType_0;

		// Token: 0x04000AF2 RID: 2802
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaElement_Public_Virtual_Final_New_get_XmlSchemaElement_0;

		// Token: 0x04000AF3 RID: 2803
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaAttribute_Public_Virtual_Final_New_get_XmlSchemaAttribute_0;

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;
	}
}
