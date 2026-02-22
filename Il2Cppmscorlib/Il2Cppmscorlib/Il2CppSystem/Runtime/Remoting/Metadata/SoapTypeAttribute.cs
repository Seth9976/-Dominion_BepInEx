using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Metadata
{
	// Token: 0x020003DD RID: 989
	public sealed class SoapTypeAttribute : SoapAttribute
	{
		// Token: 0x06003EC7 RID: 16071 RVA: 0x00124CB4 File Offset: 0x00122EB4
		// Note: this type is marked as 'beforefieldinit'.
		static SoapTypeAttribute()
		{
			Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Metadata", "SoapTypeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr);
			SoapTypeAttribute.NativeFieldInfoPtr__useAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, "_useAttribute");
			SoapTypeAttribute.NativeFieldInfoPtr__xmlElementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, "_xmlElementName");
			SoapTypeAttribute.NativeFieldInfoPtr__xmlNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, "_xmlNamespace");
			SoapTypeAttribute.NativeFieldInfoPtr__xmlTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, "_xmlTypeName");
			SoapTypeAttribute.NativeFieldInfoPtr__xmlTypeNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, "_xmlTypeNamespace");
			SoapTypeAttribute.NativeFieldInfoPtr__isType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, "_isType");
			SoapTypeAttribute.NativeFieldInfoPtr__isElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, "_isElement");
			SoapTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100672502);
			SoapTypeAttribute.NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100672503);
			SoapTypeAttribute.NativeMethodInfoPtr_get_XmlElementName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100672504);
			SoapTypeAttribute.NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100672505);
			SoapTypeAttribute.NativeMethodInfoPtr_get_XmlTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100672506);
			SoapTypeAttribute.NativeMethodInfoPtr_get_XmlTypeNamespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100672507);
			SoapTypeAttribute.NativeMethodInfoPtr_get_IsInteropXmlElement_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100672508);
			SoapTypeAttribute.NativeMethodInfoPtr_get_IsInteropXmlType_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100672509);
			SoapTypeAttribute.NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100672510);
		}

		// Token: 0x06003EC8 RID: 16072 RVA: 0x00124E24 File Offset: 0x00123024
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoapTypeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x06003EC9 RID: 16073 RVA: 0x00124E60 File Offset: 0x00123060
		public unsafe override bool UseAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x06003ECA RID: 16074 RVA: 0x00124E9C File Offset: 0x0012309C
		public unsafe string XmlElementName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr_get_XmlElementName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x06003ECB RID: 16075 RVA: 0x00124ED4 File Offset: 0x001230D4
		public unsafe override string XmlNamespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x06003ECC RID: 16076 RVA: 0x00124F0C File Offset: 0x0012310C
		public unsafe string XmlTypeName
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr_get_XmlTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x06003ECD RID: 16077 RVA: 0x00124F44 File Offset: 0x00123144
		public unsafe string XmlTypeNamespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr_get_XmlTypeNamespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x06003ECE RID: 16078 RVA: 0x00124F7C File Offset: 0x0012317C
		public unsafe bool IsInteropXmlElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr_get_IsInteropXmlElement_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x06003ECF RID: 16079 RVA: 0x00124FB8 File Offset: 0x001231B8
		public unsafe bool IsInteropXmlType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr_get_IsInteropXmlType_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003ED0 RID: 16080 RVA: 0x00124FF4 File Offset: 0x001231F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354006, XrefRangeEnd = 354021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetReflectionObject(Object reflectionObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reflectionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003ED1 RID: 16081 RVA: 0x00017B43 File Offset: 0x00015D43
		public SoapTypeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x06003ED2 RID: 16082 RVA: 0x00125038 File Offset: 0x00123238
		// (set) Token: 0x06003ED3 RID: 16083 RVA: 0x00017B4C File Offset: 0x00015D4C
		public new unsafe bool _useAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__useAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__useAttribute)) = value;
			}
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x06003ED4 RID: 16084 RVA: 0x00125060 File Offset: 0x00123260
		// (set) Token: 0x06003ED5 RID: 16085 RVA: 0x00017B67 File Offset: 0x00015D67
		public unsafe string _xmlElementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__xmlElementName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__xmlElementName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x06003ED6 RID: 16086 RVA: 0x00125088 File Offset: 0x00123288
		// (set) Token: 0x06003ED7 RID: 16087 RVA: 0x00017B86 File Offset: 0x00015D86
		public unsafe string _xmlNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__xmlNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__xmlNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x06003ED8 RID: 16088 RVA: 0x001250B0 File Offset: 0x001232B0
		// (set) Token: 0x06003ED9 RID: 16089 RVA: 0x00017BA5 File Offset: 0x00015DA5
		public unsafe string _xmlTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__xmlTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__xmlTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x06003EDA RID: 16090 RVA: 0x001250D8 File Offset: 0x001232D8
		// (set) Token: 0x06003EDB RID: 16091 RVA: 0x00017BC4 File Offset: 0x00015DC4
		public unsafe string _xmlTypeNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__xmlTypeNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__xmlTypeNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x06003EDC RID: 16092 RVA: 0x00125100 File Offset: 0x00123300
		// (set) Token: 0x06003EDD RID: 16093 RVA: 0x00017BE3 File Offset: 0x00015DE3
		public unsafe bool _isType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__isType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__isType)) = value;
			}
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x06003EDE RID: 16094 RVA: 0x00125128 File Offset: 0x00123328
		// (set) Token: 0x06003EDF RID: 16095 RVA: 0x00017BFE File Offset: 0x00015DFE
		public unsafe bool _isElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__isElement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__isElement)) = value;
			}
		}

		// Token: 0x040033A7 RID: 13223
		private static readonly IntPtr NativeFieldInfoPtr__useAttribute;

		// Token: 0x040033A8 RID: 13224
		private static readonly IntPtr NativeFieldInfoPtr__xmlElementName;

		// Token: 0x040033A9 RID: 13225
		private static readonly IntPtr NativeFieldInfoPtr__xmlNamespace;

		// Token: 0x040033AA RID: 13226
		private static readonly IntPtr NativeFieldInfoPtr__xmlTypeName;

		// Token: 0x040033AB RID: 13227
		private static readonly IntPtr NativeFieldInfoPtr__xmlTypeNamespace;

		// Token: 0x040033AC RID: 13228
		private static readonly IntPtr NativeFieldInfoPtr__isType;

		// Token: 0x040033AD RID: 13229
		private static readonly IntPtr NativeFieldInfoPtr__isElement;

		// Token: 0x040033AE RID: 13230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040033AF RID: 13231
		private static readonly IntPtr NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_get_Boolean_0;

		// Token: 0x040033B0 RID: 13232
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlElementName_Public_get_String_0;

		// Token: 0x040033B1 RID: 13233
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_get_String_0;

		// Token: 0x040033B2 RID: 13234
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlTypeName_Public_get_String_0;

		// Token: 0x040033B3 RID: 13235
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlTypeNamespace_Public_get_String_0;

		// Token: 0x040033B4 RID: 13236
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInteropXmlElement_Internal_get_Boolean_0;

		// Token: 0x040033B5 RID: 13237
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInteropXmlType_Internal_get_Boolean_0;

		// Token: 0x040033B6 RID: 13238
		private static readonly IntPtr NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0;
	}
}
