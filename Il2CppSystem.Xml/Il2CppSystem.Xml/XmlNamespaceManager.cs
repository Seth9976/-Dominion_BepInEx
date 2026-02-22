using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000063 RID: 99
	public class XmlNamespaceManager : Object
	{
		// Token: 0x060007E9 RID: 2025 RVA: 0x0002B644 File Offset: 0x00029844
		// Note: this type is marked as 'beforefieldinit'.
		static XmlNamespaceManager()
		{
			Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlNamespaceManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr);
			XmlNamespaceManager.NativeFieldInfoPtr_nsdecls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "nsdecls");
			XmlNamespaceManager.NativeFieldInfoPtr_lastDecl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "lastDecl");
			XmlNamespaceManager.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "nameTable");
			XmlNamespaceManager.NativeFieldInfoPtr_scopeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "scopeId");
			XmlNamespaceManager.NativeFieldInfoPtr_hashTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "hashTable");
			XmlNamespaceManager.NativeFieldInfoPtr_useHashtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "useHashtable");
			XmlNamespaceManager.NativeFieldInfoPtr_xml = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "xml");
			XmlNamespaceManager.NativeFieldInfoPtr_xmlNs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "xmlNs");
			XmlNamespaceManager.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100664603);
			XmlNamespaceManager.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100664604);
			XmlNamespaceManager.NativeMethodInfoPtr_get_NameTable_Public_Virtual_New_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100664605);
			XmlNamespaceManager.NativeMethodInfoPtr_get_DefaultNamespace_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100664606);
			XmlNamespaceManager.NativeMethodInfoPtr_PushScope_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100664607);
			XmlNamespaceManager.NativeMethodInfoPtr_PopScope_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100664608);
			XmlNamespaceManager.NativeMethodInfoPtr_AddNamespace_Public_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100664609);
			XmlNamespaceManager.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100664610);
			XmlNamespaceManager.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100664611);
			XmlNamespaceManager.NativeMethodInfoPtr_LookupNamespaceDecl_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100664612);
			XmlNamespaceManager.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100664613);
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0002B7F0 File Offset: 0x000299F0
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNamespaceManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamespaceManager.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0002B82C File Offset: 0x00029A2C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 20899, RefRangeEnd = 20906, XrefRangeStart = 20882, XrefRangeEnd = 20899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNamespaceManager(XmlNameTable nameTable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamespaceManager.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x0002B878 File Offset: 0x00029A78
		public unsafe virtual XmlNameTable NameTable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_get_NameTable_Public_Virtual_New_get_XmlNameTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x0002B8C4 File Offset: 0x00029AC4
		public unsafe virtual string DefaultNamespace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20906, XrefRangeEnd = 20909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_get_DefaultNamespace_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x0002B908 File Offset: 0x00029B08
		[CallerCount(0)]
		public unsafe virtual void PushScope()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_PushScope_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x0002B944 File Offset: 0x00029B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20909, XrefRangeEnd = 20913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool PopScope()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_PopScope_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0002B98C File Offset: 0x00029B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20913, XrefRangeEnd = 20927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddNamespace(string prefix, string uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_AddNamespace_Public_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x0002B9EC File Offset: 0x00029BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20927, XrefRangeEnd = 20945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x0002BA38 File Offset: 0x00029C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20945, XrefRangeEnd = 20946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x0002BA8C File Offset: 0x00029C8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 20949, RefRangeEnd = 20951, XrefRangeStart = 20946, XrefRangeEnd = 20949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LookupNamespaceDecl(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamespaceManager.NativeMethodInfoPtr_LookupNamespaceDecl_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x0002BADC File Offset: 0x00029CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20951, XrefRangeEnd = 20953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string LookupPrefix(string uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x000047EA File Offset: 0x000029EA
		public XmlNamespaceManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x0002BB30 File Offset: 0x00029D30
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x000047F3 File Offset: 0x000029F3
		public unsafe Il2CppReferenceArray<XmlNamespaceManager.NamespaceDeclaration> nsdecls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_nsdecls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlNamespaceManager.NamespaceDeclaration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_nsdecls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x0002BB60 File Offset: 0x00029D60
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x00004812 File Offset: 0x00002A12
		public unsafe int lastDecl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_lastDecl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_lastDecl)) = value;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x0002BB88 File Offset: 0x00029D88
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x0000482D File Offset: 0x00002A2D
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x0002BBB8 File Offset: 0x00029DB8
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x0000484C File Offset: 0x00002A4C
		public unsafe int scopeId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_scopeId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_scopeId)) = value;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x0002BBE0 File Offset: 0x00029DE0
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x00004867 File Offset: 0x00002A67
		public unsafe Dictionary<string, int> hashTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_hashTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_hashTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x0002BC10 File Offset: 0x00029E10
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x00004886 File Offset: 0x00002A86
		public unsafe bool useHashtable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_useHashtable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_useHashtable)) = value;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x0002BC38 File Offset: 0x00029E38
		// (set) Token: 0x06000803 RID: 2051 RVA: 0x000048A1 File Offset: 0x00002AA1
		public unsafe string xml
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_xml);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_xml), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x0002BC60 File Offset: 0x00029E60
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x000048C0 File Offset: 0x00002AC0
		public unsafe string xmlNs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_xmlNs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_xmlNs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeFieldInfoPtr_nsdecls;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeFieldInfoPtr_lastDecl;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeFieldInfoPtr_scopeId;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeFieldInfoPtr_hashTable;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeFieldInfoPtr_useHashtable;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeFieldInfoPtr_xml;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeFieldInfoPtr_xmlNs;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_Virtual_New_get_XmlNameTable_0;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultNamespace_Public_Virtual_New_get_String_0;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeMethodInfoPtr_PushScope_Public_Virtual_New_Void_0;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeMethodInfoPtr_PopScope_Public_Virtual_New_Boolean_0;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeMethodInfoPtr_AddNamespace_Public_Virtual_New_Void_String_String_0;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Virtual_New_String_String_0;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespaceDecl_Private_Int32_String_0;

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeMethodInfoPtr_LookupPrefix_Public_Virtual_New_String_String_0;

		// Token: 0x0200012B RID: 299
		public sealed class NamespaceDeclaration : ValueType
		{
			// Token: 0x06001285 RID: 4741 RVA: 0x0005508C File Offset: 0x0005328C
			// Note: this type is marked as 'beforefieldinit'.
			static NamespaceDeclaration()
			{
				Il2CppClassPointerStore<XmlNamespaceManager.NamespaceDeclaration>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "NamespaceDeclaration");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNamespaceManager.NamespaceDeclaration>.NativeClassPtr);
				XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager.NamespaceDeclaration>.NativeClassPtr, "prefix");
				XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager.NamespaceDeclaration>.NativeClassPtr, "uri");
				XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_scopeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager.NamespaceDeclaration>.NativeClassPtr, "scopeId");
				XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_previousNsIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager.NamespaceDeclaration>.NativeClassPtr, "previousNsIndex");
				XmlNamespaceManager.NamespaceDeclaration.NativeMethodInfoPtr_Set_Public_Void_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager.NamespaceDeclaration>.NativeClassPtr, 100664614);
			}

			// Token: 0x06001286 RID: 4742 RVA: 0x0005511C File Offset: 0x0005331C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20879, RefRangeEnd = 20882, XrefRangeStart = 20879, XrefRangeEnd = 20879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Set(string prefix, string uri, int scopeId, int previousNsIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uri);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scopeId;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousNsIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamespaceManager.NamespaceDeclaration.NativeMethodInfoPtr_Set_Public_Void_String_String_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001287 RID: 4743 RVA: 0x000083BB File Offset: 0x000065BB
			public NamespaceDeclaration(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001288 RID: 4744 RVA: 0x000083C4 File Offset: 0x000065C4
			public NamespaceDeclaration()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNamespaceManager.NamespaceDeclaration>.NativeClassPtr))
			{
			}

			// Token: 0x1700067B RID: 1659
			// (get) Token: 0x06001289 RID: 4745 RVA: 0x00055194 File Offset: 0x00053394
			// (set) Token: 0x0600128A RID: 4746 RVA: 0x000083D6 File Offset: 0x000065D6
			public unsafe string prefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_prefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700067C RID: 1660
			// (get) Token: 0x0600128B RID: 4747 RVA: 0x000551BC File Offset: 0x000533BC
			// (set) Token: 0x0600128C RID: 4748 RVA: 0x000083F5 File Offset: 0x000065F5
			public unsafe string uri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_uri);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_uri), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700067D RID: 1661
			// (get) Token: 0x0600128D RID: 4749 RVA: 0x000551E4 File Offset: 0x000533E4
			// (set) Token: 0x0600128E RID: 4750 RVA: 0x00008414 File Offset: 0x00006614
			public unsafe int scopeId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_scopeId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_scopeId)) = value;
				}
			}

			// Token: 0x1700067E RID: 1662
			// (get) Token: 0x0600128F RID: 4751 RVA: 0x0005520C File Offset: 0x0005340C
			// (set) Token: 0x06001290 RID: 4752 RVA: 0x0000842F File Offset: 0x0000662F
			public unsafe int previousNsIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_previousNsIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_previousNsIndex)) = value;
				}
			}

			// Token: 0x04000E9C RID: 3740
			private static readonly IntPtr NativeFieldInfoPtr_prefix;

			// Token: 0x04000E9D RID: 3741
			private static readonly IntPtr NativeFieldInfoPtr_uri;

			// Token: 0x04000E9E RID: 3742
			private static readonly IntPtr NativeFieldInfoPtr_scopeId;

			// Token: 0x04000E9F RID: 3743
			private static readonly IntPtr NativeFieldInfoPtr_previousNsIndex;

			// Token: 0x04000EA0 RID: 3744
			private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_String_String_Int32_Int32_0;
		}
	}
}
