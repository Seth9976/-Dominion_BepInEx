using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x020003A1 RID: 929
	public class SoapServices : Object
	{
		// Token: 0x06003C88 RID: 15496 RVA: 0x0011CE98 File Offset: 0x0011B098
		// Note: this type is marked as 'beforefieldinit'.
		static SoapServices()
		{
			Il2CppClassPointerStore<SoapServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "SoapServices");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoapServices>.NativeClassPtr);
			SoapServices.NativeFieldInfoPtr__xmlTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, "_xmlTypes");
			SoapServices.NativeFieldInfoPtr__xmlElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, "_xmlElements");
			SoapServices.NativeFieldInfoPtr__soapActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, "_soapActions");
			SoapServices.NativeFieldInfoPtr__soapActionsMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, "_soapActionsMethods");
			SoapServices.NativeFieldInfoPtr__typeInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, "_typeInfos");
			SoapServices.NativeMethodInfoPtr_get_XmlNsForClrTypeWithAssembly_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672225);
			SoapServices.NativeMethodInfoPtr_get_XmlNsForClrTypeWithNs_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672226);
			SoapServices.NativeMethodInfoPtr_get_XmlNsForClrTypeWithNsAndAssembly_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672227);
			SoapServices.NativeMethodInfoPtr_CodeXmlNamespaceForClrTypeNamespace_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672228);
			SoapServices.NativeMethodInfoPtr_GetNameKey_Private_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672229);
			SoapServices.NativeMethodInfoPtr_GetAssemblyName_Private_Static_String_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672230);
			SoapServices.NativeMethodInfoPtr_GetXmlElementForInteropType_Public_Static_Boolean_Type_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672231);
			SoapServices.NativeMethodInfoPtr_GetXmlNamespaceForMethodCall_Public_Static_String_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672232);
			SoapServices.NativeMethodInfoPtr_GetXmlNamespaceForMethodResponse_Public_Static_String_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672233);
			SoapServices.NativeMethodInfoPtr_GetXmlTypeForInteropType_Public_Static_Boolean_Type_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672234);
			SoapServices.NativeMethodInfoPtr_PreLoad_Public_Static_Void_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672235);
			SoapServices.NativeMethodInfoPtr_PreLoad_Public_Static_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672236);
			SoapServices.NativeMethodInfoPtr_RegisterInteropXmlElement_Public_Static_Void_String_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672237);
			SoapServices.NativeMethodInfoPtr_RegisterInteropXmlType_Public_Static_Void_String_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672238);
			SoapServices.NativeMethodInfoPtr_EncodeNs_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672239);
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x06003C89 RID: 15497 RVA: 0x0011D058 File Offset: 0x0011B258
		public unsafe static string XmlNsForClrTypeWithAssembly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351153, XrefRangeEnd = 351155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_get_XmlNsForClrTypeWithAssembly_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06003C8A RID: 15498 RVA: 0x0011D084 File Offset: 0x0011B284
		public unsafe static string XmlNsForClrTypeWithNs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351155, XrefRangeEnd = 351157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_get_XmlNsForClrTypeWithNs_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06003C8B RID: 15499 RVA: 0x0011D0B0 File Offset: 0x0011B2B0
		public unsafe static string XmlNsForClrTypeWithNsAndAssembly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351157, XrefRangeEnd = 351159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_get_XmlNsForClrTypeWithNsAndAssembly_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003C8C RID: 15500 RVA: 0x0011D0DC File Offset: 0x0011B2DC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 351183, RefRangeEnd = 351189, XrefRangeStart = 351159, XrefRangeEnd = 351183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeNamespace);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_CodeXmlNamespaceForClrTypeNamespace_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003C8D RID: 15501 RVA: 0x0011D12C File Offset: 0x0011B32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351189, XrefRangeEnd = 351192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNameKey(string name, string namspace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namspace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_GetNameKey_Private_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003C8E RID: 15502 RVA: 0x0011D17C File Offset: 0x0011B37C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 351200, RefRangeEnd = 351202, XrefRangeStart = 351192, XrefRangeEnd = 351200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAssemblyName(MethodBase mb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_GetAssemblyName_Private_Static_String_MethodBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003C8F RID: 15503 RVA: 0x0011D1B8 File Offset: 0x0011B3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351202, XrefRangeEnd = 351208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetXmlElementForInteropType(Type type, out string xmlElement, out string xmlNamespace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_GetXmlElementForInteropType_Public_Static_Boolean_Type_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			xmlElement = IL2CPP.Il2CppStringToManaged(intPtr);
			xmlNamespace = IL2CPP.Il2CppStringToManaged(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06003C90 RID: 15504 RVA: 0x0011D230 File Offset: 0x0011B430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351208, XrefRangeEnd = 351214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetXmlNamespaceForMethodCall(MethodBase mb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_GetXmlNamespaceForMethodCall_Public_Static_String_MethodBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003C91 RID: 15505 RVA: 0x0011D26C File Offset: 0x0011B46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351214, XrefRangeEnd = 351220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetXmlNamespaceForMethodResponse(MethodBase mb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_GetXmlNamespaceForMethodResponse_Public_Static_String_MethodBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003C92 RID: 15506 RVA: 0x0011D2A8 File Offset: 0x0011B4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351220, XrefRangeEnd = 351226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetXmlTypeForInteropType(Type type, out string xmlType, out string xmlTypeNamespace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_GetXmlTypeForInteropType_Public_Static_Boolean_Type_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			xmlType = IL2CPP.Il2CppStringToManaged(intPtr);
			xmlTypeNamespace = IL2CPP.Il2CppStringToManaged(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06003C93 RID: 15507 RVA: 0x0011D320 File Offset: 0x0011B520
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351231, RefRangeEnd = 351232, XrefRangeStart = 351226, XrefRangeEnd = 351231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PreLoad(Assembly assembly)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assembly);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_PreLoad_Public_Static_Void_Assembly_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003C94 RID: 15508 RVA: 0x0011D358 File Offset: 0x0011B558
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 351292, RefRangeEnd = 351294, XrefRangeStart = 351232, XrefRangeEnd = 351292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PreLoad(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_PreLoad_Public_Static_Void_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003C95 RID: 15509 RVA: 0x0011D390 File Offset: 0x0011B590
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351307, RefRangeEnd = 351308, XrefRangeStart = 351294, XrefRangeEnd = 351307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlElement);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlNamespace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_RegisterInteropXmlElement_Public_Static_Void_String_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C96 RID: 15510 RVA: 0x0011D3EC File Offset: 0x0011B5EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 351321, RefRangeEnd = 351323, XrefRangeStart = 351308, XrefRangeEnd = 351321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlTypeNamespace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_RegisterInteropXmlType_Public_Static_Void_String_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C97 RID: 15511 RVA: 0x0011D448 File Offset: 0x0011B648
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 351339, RefRangeEnd = 351341, XrefRangeStart = 351323, XrefRangeEnd = 351339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncodeNs(string ns)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_EncodeNs_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003C98 RID: 15512 RVA: 0x00016C7F File Offset: 0x00014E7F
		public SoapServices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x06003C99 RID: 15513 RVA: 0x0011D484 File Offset: 0x0011B684
		// (set) Token: 0x06003C9A RID: 15514 RVA: 0x00016C88 File Offset: 0x00014E88
		public unsafe static Hashtable _xmlTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SoapServices.NativeFieldInfoPtr__xmlTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SoapServices.NativeFieldInfoPtr__xmlTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x06003C9B RID: 15515 RVA: 0x0011D4AC File Offset: 0x0011B6AC
		// (set) Token: 0x06003C9C RID: 15516 RVA: 0x00016C9A File Offset: 0x00014E9A
		public unsafe static Hashtable _xmlElements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SoapServices.NativeFieldInfoPtr__xmlElements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SoapServices.NativeFieldInfoPtr__xmlElements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x06003C9D RID: 15517 RVA: 0x0011D4D4 File Offset: 0x0011B6D4
		// (set) Token: 0x06003C9E RID: 15518 RVA: 0x00016CAC File Offset: 0x00014EAC
		public unsafe static Hashtable _soapActions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SoapServices.NativeFieldInfoPtr__soapActions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SoapServices.NativeFieldInfoPtr__soapActions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x06003C9F RID: 15519 RVA: 0x0011D4FC File Offset: 0x0011B6FC
		// (set) Token: 0x06003CA0 RID: 15520 RVA: 0x00016CBE File Offset: 0x00014EBE
		public unsafe static Hashtable _soapActionsMethods
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SoapServices.NativeFieldInfoPtr__soapActionsMethods, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SoapServices.NativeFieldInfoPtr__soapActionsMethods, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x06003CA1 RID: 15521 RVA: 0x0011D524 File Offset: 0x0011B724
		// (set) Token: 0x06003CA2 RID: 15522 RVA: 0x00016CD0 File Offset: 0x00014ED0
		public unsafe static Hashtable _typeInfos
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SoapServices.NativeFieldInfoPtr__typeInfos, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SoapServices.NativeFieldInfoPtr__typeInfos, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003238 RID: 12856
		private static readonly IntPtr NativeFieldInfoPtr__xmlTypes;

		// Token: 0x04003239 RID: 12857
		private static readonly IntPtr NativeFieldInfoPtr__xmlElements;

		// Token: 0x0400323A RID: 12858
		private static readonly IntPtr NativeFieldInfoPtr__soapActions;

		// Token: 0x0400323B RID: 12859
		private static readonly IntPtr NativeFieldInfoPtr__soapActionsMethods;

		// Token: 0x0400323C RID: 12860
		private static readonly IntPtr NativeFieldInfoPtr__typeInfos;

		// Token: 0x0400323D RID: 12861
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlNsForClrTypeWithAssembly_Public_Static_get_String_0;

		// Token: 0x0400323E RID: 12862
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlNsForClrTypeWithNs_Public_Static_get_String_0;

		// Token: 0x0400323F RID: 12863
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlNsForClrTypeWithNsAndAssembly_Public_Static_get_String_0;

		// Token: 0x04003240 RID: 12864
		private static readonly IntPtr NativeMethodInfoPtr_CodeXmlNamespaceForClrTypeNamespace_Public_Static_String_String_String_0;

		// Token: 0x04003241 RID: 12865
		private static readonly IntPtr NativeMethodInfoPtr_GetNameKey_Private_Static_String_String_String_0;

		// Token: 0x04003242 RID: 12866
		private static readonly IntPtr NativeMethodInfoPtr_GetAssemblyName_Private_Static_String_MethodBase_0;

		// Token: 0x04003243 RID: 12867
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlElementForInteropType_Public_Static_Boolean_Type_byref_String_byref_String_0;

		// Token: 0x04003244 RID: 12868
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlNamespaceForMethodCall_Public_Static_String_MethodBase_0;

		// Token: 0x04003245 RID: 12869
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlNamespaceForMethodResponse_Public_Static_String_MethodBase_0;

		// Token: 0x04003246 RID: 12870
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlTypeForInteropType_Public_Static_Boolean_Type_byref_String_byref_String_0;

		// Token: 0x04003247 RID: 12871
		private static readonly IntPtr NativeMethodInfoPtr_PreLoad_Public_Static_Void_Assembly_0;

		// Token: 0x04003248 RID: 12872
		private static readonly IntPtr NativeMethodInfoPtr_PreLoad_Public_Static_Void_Type_0;

		// Token: 0x04003249 RID: 12873
		private static readonly IntPtr NativeMethodInfoPtr_RegisterInteropXmlElement_Public_Static_Void_String_String_Type_0;

		// Token: 0x0400324A RID: 12874
		private static readonly IntPtr NativeMethodInfoPtr_RegisterInteropXmlType_Public_Static_Void_String_String_Type_0;

		// Token: 0x0400324B RID: 12875
		private static readonly IntPtr NativeMethodInfoPtr_EncodeNs_Private_Static_String_String_0;

		// Token: 0x0200062A RID: 1578
		public class TypeInfo : Object
		{
			// Token: 0x06005432 RID: 21554 RVA: 0x00174E30 File Offset: 0x00173030
			// Note: this type is marked as 'beforefieldinit'.
			static TypeInfo()
			{
				Il2CppClassPointerStore<SoapServices.TypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, "TypeInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoapServices.TypeInfo>.NativeClassPtr);
				SoapServices.TypeInfo.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapServices.TypeInfo>.NativeClassPtr, "Attributes");
				SoapServices.TypeInfo.NativeFieldInfoPtr_Elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapServices.TypeInfo>.NativeClassPtr, "Elements");
				SoapServices.TypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices.TypeInfo>.NativeClassPtr, 100672241);
			}

			// Token: 0x06005433 RID: 21555 RVA: 0x00174E98 File Offset: 0x00173098
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TypeInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoapServices.TypeInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.TypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005434 RID: 21556 RVA: 0x00020760 File Offset: 0x0001E960
			public TypeInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001591 RID: 5521
			// (get) Token: 0x06005435 RID: 21557 RVA: 0x00174ED4 File Offset: 0x001730D4
			// (set) Token: 0x06005436 RID: 21558 RVA: 0x00020769 File Offset: 0x0001E969
			public unsafe Hashtable Attributes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapServices.TypeInfo.NativeFieldInfoPtr_Attributes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapServices.TypeInfo.NativeFieldInfoPtr_Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001592 RID: 5522
			// (get) Token: 0x06005437 RID: 21559 RVA: 0x00174F04 File Offset: 0x00173104
			// (set) Token: 0x06005438 RID: 21560 RVA: 0x00020788 File Offset: 0x0001E988
			public unsafe Hashtable Elements
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapServices.TypeInfo.NativeFieldInfoPtr_Elements);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapServices.TypeInfo.NativeFieldInfoPtr_Elements), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040043D9 RID: 17369
			private static readonly IntPtr NativeFieldInfoPtr_Attributes;

			// Token: 0x040043DA RID: 17370
			private static readonly IntPtr NativeFieldInfoPtr_Elements;

			// Token: 0x040043DB RID: 17371
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
