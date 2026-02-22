using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000EA RID: 234
	public class XmlSchemaComplexType : XmlSchemaType
	{
		// Token: 0x06000E6A RID: 3690 RVA: 0x000440E8 File Offset: 0x000422E8
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaComplexType()
		{
			Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaComplexType");
			XmlSchemaComplexType.NativeFieldInfoPtr_block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "block");
			XmlSchemaComplexType.NativeFieldInfoPtr_contentTypeParticle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "contentTypeParticle");
			XmlSchemaComplexType.NativeFieldInfoPtr_attributeWildcard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "attributeWildcard");
			XmlSchemaComplexType.NativeFieldInfoPtr_anyTypeLax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "anyTypeLax");
			XmlSchemaComplexType.NativeFieldInfoPtr_anyTypeSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "anyTypeSkip");
			XmlSchemaComplexType.NativeFieldInfoPtr_untypedAnyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "untypedAnyType");
			XmlSchemaComplexType.NativeFieldInfoPtr_pvFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "pvFlags");
			XmlSchemaComplexType.NativeMethodInfoPtr_CreateAnyType_Private_Static_XmlSchemaComplexType_XmlSchemaContentProcessing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100665405);
			XmlSchemaComplexType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100665406);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_AnyType_Internal_Static_get_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100665407);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_AnyTypeContentValidator_Internal_Static_get_ContentValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100665408);
			XmlSchemaComplexType.NativeMethodInfoPtr_set_IsMixed_Public_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100665409);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_ContentTypeParticle_Public_get_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100665410);
			XmlSchemaComplexType.NativeMethodInfoPtr_SetContentTypeParticle_Internal_Void_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100665411);
			XmlSchemaComplexType.NativeMethodInfoPtr_SetAttributeWildcard_Internal_Void_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100665412);
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x0004423C File Offset: 0x0004243C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24467, XrefRangeEnd = 24560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref processContents;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_CreateAnyType_Private_Static_XmlSchemaComplexType_XmlSchemaContentProcessing_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr3) : null;
			}
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x0004427C File Offset: 0x0004247C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24570, RefRangeEnd = 24571, XrefRangeStart = 24560, XrefRangeEnd = 24570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaComplexType()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x000442B8 File Offset: 0x000424B8
		public unsafe static XmlSchemaComplexType AnyType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24571, XrefRangeEnd = 24575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_AnyType_Internal_Static_get_XmlSchemaComplexType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr3) : null;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x000442EC File Offset: 0x000424EC
		public unsafe static ContentValidator AnyTypeContentValidator
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24575, XrefRangeEnd = 24580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_AnyTypeContentValidator_Internal_Static_get_ContentValidator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr3) : null;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (set) Token: 0x06000E6F RID: 3695 RVA: 0x00044320 File Offset: 0x00042520
		public unsafe override bool IsMixed
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaComplexType.NativeMethodInfoPtr_set_IsMixed_Public_Virtual_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x0004436C File Offset: 0x0004256C
		public unsafe XmlSchemaParticle ContentTypeParticle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_ContentTypeParticle_Public_get_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
			}
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x000443AC File Offset: 0x000425AC
		[CallerCount(0)]
		public unsafe void SetContentTypeParticle(XmlSchemaParticle value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_SetContentTypeParticle_Internal_Void_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x000443F0 File Offset: 0x000425F0
		[CallerCount(0)]
		public unsafe void SetAttributeWildcard(XmlSchemaAnyAttribute value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_SetAttributeWildcard_Internal_Void_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00006D52 File Offset: 0x00004F52
		public XmlSchemaComplexType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x00044434 File Offset: 0x00042634
		// (set) Token: 0x06000E75 RID: 3701 RVA: 0x00006D5B File Offset: 0x00004F5B
		public unsafe XmlSchemaDerivationMethod block
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_block);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_block)) = value;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x0004445C File Offset: 0x0004265C
		// (set) Token: 0x06000E77 RID: 3703 RVA: 0x00006D76 File Offset: 0x00004F76
		public unsafe XmlSchemaParticle contentTypeParticle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_contentTypeParticle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_contentTypeParticle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x0004448C File Offset: 0x0004268C
		// (set) Token: 0x06000E79 RID: 3705 RVA: 0x00006D95 File Offset: 0x00004F95
		public unsafe XmlSchemaAnyAttribute attributeWildcard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_attributeWildcard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_attributeWildcard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x000444BC File Offset: 0x000426BC
		// (set) Token: 0x06000E7B RID: 3707 RVA: 0x00006DB4 File Offset: 0x00004FB4
		public unsafe static XmlSchemaComplexType anyTypeLax
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaComplexType.NativeFieldInfoPtr_anyTypeLax, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaComplexType.NativeFieldInfoPtr_anyTypeLax, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x000444E4 File Offset: 0x000426E4
		// (set) Token: 0x06000E7D RID: 3709 RVA: 0x00006DC6 File Offset: 0x00004FC6
		public unsafe static XmlSchemaComplexType anyTypeSkip
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaComplexType.NativeFieldInfoPtr_anyTypeSkip, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaComplexType.NativeFieldInfoPtr_anyTypeSkip, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x0004450C File Offset: 0x0004270C
		// (set) Token: 0x06000E7F RID: 3711 RVA: 0x00006DD8 File Offset: 0x00004FD8
		public unsafe static XmlSchemaComplexType untypedAnyType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaComplexType.NativeFieldInfoPtr_untypedAnyType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaComplexType.NativeFieldInfoPtr_untypedAnyType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06000E80 RID: 3712 RVA: 0x00044534 File Offset: 0x00042734
		// (set) Token: 0x06000E81 RID: 3713 RVA: 0x00006DEA File Offset: 0x00004FEA
		public unsafe byte pvFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_pvFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_pvFlags)) = value;
			}
		}

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeFieldInfoPtr_block;

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeFieldInfoPtr_contentTypeParticle;

		// Token: 0x04000A9F RID: 2719
		private static readonly IntPtr NativeFieldInfoPtr_attributeWildcard;

		// Token: 0x04000AA0 RID: 2720
		private static readonly IntPtr NativeFieldInfoPtr_anyTypeLax;

		// Token: 0x04000AA1 RID: 2721
		private static readonly IntPtr NativeFieldInfoPtr_anyTypeSkip;

		// Token: 0x04000AA2 RID: 2722
		private static readonly IntPtr NativeFieldInfoPtr_untypedAnyType;

		// Token: 0x04000AA3 RID: 2723
		private static readonly IntPtr NativeFieldInfoPtr_pvFlags;

		// Token: 0x04000AA4 RID: 2724
		private static readonly IntPtr NativeMethodInfoPtr_CreateAnyType_Private_Static_XmlSchemaComplexType_XmlSchemaContentProcessing_0;

		// Token: 0x04000AA5 RID: 2725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000AA6 RID: 2726
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyType_Internal_Static_get_XmlSchemaComplexType_0;

		// Token: 0x04000AA7 RID: 2727
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyTypeContentValidator_Internal_Static_get_ContentValidator_0;

		// Token: 0x04000AA8 RID: 2728
		private static readonly IntPtr NativeMethodInfoPtr_set_IsMixed_Public_Virtual_set_Void_Boolean_0;

		// Token: 0x04000AA9 RID: 2729
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentTypeParticle_Public_get_XmlSchemaParticle_0;

		// Token: 0x04000AAA RID: 2730
		private static readonly IntPtr NativeMethodInfoPtr_SetContentTypeParticle_Internal_Void_XmlSchemaParticle_0;

		// Token: 0x04000AAB RID: 2731
		private static readonly IntPtr NativeMethodInfoPtr_SetAttributeWildcard_Internal_Void_XmlSchemaAnyAttribute_0;
	}
}
