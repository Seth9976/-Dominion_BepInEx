using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200002D RID: 45
	public class XmlDeclaration : XmlLinkedNode
	{
		// Token: 0x06000394 RID: 916 RVA: 0x00017A78 File Offset: 0x00015C78
		// Note: this type is marked as 'beforefieldinit'.
		static XmlDeclaration()
		{
			Il2CppClassPointerStore<XmlDeclaration>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlDeclaration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlDeclaration>.NativeClassPtr);
			XmlDeclaration.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDeclaration>.NativeClassPtr, "version");
			XmlDeclaration.NativeFieldInfoPtr_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDeclaration>.NativeClassPtr, "encoding");
			XmlDeclaration.NativeFieldInfoPtr_standalone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDeclaration>.NativeClassPtr, "standalone");
			XmlDeclaration.NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_String_String_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDeclaration>.NativeClassPtr, 100663904);
			XmlDeclaration.NativeMethodInfoPtr_get_Version_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDeclaration>.NativeClassPtr, 100663905);
			XmlDeclaration.NativeMethodInfoPtr_set_Version_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDeclaration>.NativeClassPtr, 100663906);
			XmlDeclaration.NativeMethodInfoPtr_get_Encoding_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDeclaration>.NativeClassPtr, 100663907);
			XmlDeclaration.NativeMethodInfoPtr_set_Encoding_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDeclaration>.NativeClassPtr, 100663908);
			XmlDeclaration.NativeMethodInfoPtr_get_Standalone_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDeclaration>.NativeClassPtr, 100663909);
			XmlDeclaration.NativeMethodInfoPtr_set_Standalone_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDeclaration>.NativeClassPtr, 100663910);
			XmlDeclaration.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDeclaration>.NativeClassPtr, 100663911);
			XmlDeclaration.NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDeclaration>.NativeClassPtr, 100663912);
			XmlDeclaration.NativeMethodInfoPtr_get_InnerText_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDeclaration>.NativeClassPtr, 100663913);
			XmlDeclaration.NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDeclaration>.NativeClassPtr, 100663914);
			XmlDeclaration.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDeclaration>.NativeClassPtr, 100663915);
			XmlDeclaration.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDeclaration>.NativeClassPtr, 100663916);
			XmlDeclaration.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDeclaration>.NativeClassPtr, 100663917);
			XmlDeclaration.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDeclaration>.NativeClassPtr, 100663918);
			XmlDeclaration.NativeMethodInfoPtr_IsValidXmlVersion_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDeclaration>.NativeClassPtr, 100663919);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00017C24 File Offset: 0x00015E24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14962, RefRangeEnd = 14963, XrefRangeStart = 14951, XrefRangeEnd = 14962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDeclaration(string version, string encoding, string standalone, XmlDocument doc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDeclaration>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(version);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(standalone);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(doc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDeclaration.NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_String_String_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00017CA8 File Offset: 0x00015EA8
		// (set) Token: 0x06000397 RID: 919 RVA: 0x00017CE0 File Offset: 0x00015EE0
		public unsafe string Version
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDeclaration.NativeMethodInfoPtr_get_Version_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDeclaration.NativeMethodInfoPtr_set_Version_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00017D24 File Offset: 0x00015F24
		// (set) Token: 0x06000399 RID: 921 RVA: 0x00017D5C File Offset: 0x00015F5C
		public unsafe string Encoding
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDeclaration.NativeMethodInfoPtr_get_Encoding_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14963, XrefRangeEnd = 14965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDeclaration.NativeMethodInfoPtr_set_Encoding_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00017DA0 File Offset: 0x00015FA0
		// (set) Token: 0x0600039B RID: 923 RVA: 0x00017DD8 File Offset: 0x00015FD8
		public unsafe string Standalone
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDeclaration.NativeMethodInfoPtr_get_Standalone_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14972, RefRangeEnd = 14973, XrefRangeStart = 14965, XrefRangeEnd = 14972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDeclaration.NativeMethodInfoPtr_set_Standalone_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00017E1C File Offset: 0x0001601C
		// (set) Token: 0x0600039D RID: 925 RVA: 0x00017E60 File Offset: 0x00016060
		public unsafe override string Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDeclaration.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDeclaration.NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00017EB0 File Offset: 0x000160B0
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00017EF4 File Offset: 0x000160F4
		public unsafe override string InnerText
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14973, XrefRangeEnd = 14995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDeclaration.NativeMethodInfoPtr_get_InnerText_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14995, XrefRangeEnd = 15008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDeclaration.NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00017F44 File Offset: 0x00016144
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15008, XrefRangeEnd = 15010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDeclaration.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x00017F88 File Offset: 0x00016188
		public unsafe override string LocalName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 15010, RefRangeEnd = 15012, XrefRangeStart = 15010, XrefRangeEnd = 15010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDeclaration.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00017FCC File Offset: 0x000161CC
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDeclaration.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00018014 File Offset: 0x00016214
		[CallerCount(0)]
		public unsafe override XmlNode CloneNode(bool deep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDeclaration.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0001806C File Offset: 0x0001626C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 15015, RefRangeEnd = 15016, XrefRangeStart = 15012, XrefRangeEnd = 15015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValidXmlVersion(string ver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ver);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDeclaration.NativeMethodInfoPtr_IsValidXmlVersion_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00003319 File Offset: 0x00001519
		public XmlDeclaration(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x000180BC File Offset: 0x000162BC
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x00003322 File Offset: 0x00001522
		public unsafe string version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDeclaration.NativeFieldInfoPtr_version);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDeclaration.NativeFieldInfoPtr_version), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x000180E4 File Offset: 0x000162E4
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x00003341 File Offset: 0x00001541
		public unsafe string encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDeclaration.NativeFieldInfoPtr_encoding);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDeclaration.NativeFieldInfoPtr_encoding), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0001810C File Offset: 0x0001630C
		// (set) Token: 0x060003AB RID: 939 RVA: 0x00003360 File Offset: 0x00001560
		public unsafe string standalone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDeclaration.NativeFieldInfoPtr_standalone);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDeclaration.NativeFieldInfoPtr_standalone), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeFieldInfoPtr_encoding;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeFieldInfoPtr_standalone;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_String_String_XmlDocument_0;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_String_0;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Internal_set_Void_String_0;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeMethodInfoPtr_get_Encoding_Public_get_String_0;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeMethodInfoPtr_set_Encoding_Public_set_Void_String_0;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeMethodInfoPtr_get_Standalone_Public_get_String_0;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeMethodInfoPtr_set_Standalone_Public_set_Void_String_0;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeMethodInfoPtr_get_InnerText_Public_Virtual_get_String_0;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr_IsValidXmlVersion_Private_Boolean_String_0;
	}
}
