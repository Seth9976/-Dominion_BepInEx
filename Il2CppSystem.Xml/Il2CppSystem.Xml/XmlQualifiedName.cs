using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000065 RID: 101
	[Serializable]
	public class XmlQualifiedName : Object
	{
		// Token: 0x06000806 RID: 2054 RVA: 0x0002BC88 File Offset: 0x00029E88
		// Note: this type is marked as 'beforefieldinit'.
		static XmlQualifiedName()
		{
			Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlQualifiedName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr);
			XmlQualifiedName.NativeFieldInfoPtr_hashCodeDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, "hashCodeDelegate");
			XmlQualifiedName.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, "name");
			XmlQualifiedName.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, "ns");
			XmlQualifiedName.NativeFieldInfoPtr_hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, "hash");
			XmlQualifiedName.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, "Empty");
			XmlQualifiedName.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100664615);
			XmlQualifiedName.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100664616);
			XmlQualifiedName.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100664617);
			XmlQualifiedName.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100664618);
			XmlQualifiedName.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100664619);
			XmlQualifiedName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100664620);
			XmlQualifiedName.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100664621);
			XmlQualifiedName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100664622);
			XmlQualifiedName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100664623);
			XmlQualifiedName.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_XmlQualifiedName_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100664624);
			XmlQualifiedName.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_XmlQualifiedName_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100664625);
			XmlQualifiedName.NativeMethodInfoPtr_GetHashCodeDelegate_Private_Static_HashCodeOfStringDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100664626);
			XmlQualifiedName.NativeMethodInfoPtr_IsRandomizedHashingDisabled_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100664627);
			XmlQualifiedName.NativeMethodInfoPtr_GetHashCodeOfString_Private_Static_Int32_String_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100664628);
			XmlQualifiedName.NativeMethodInfoPtr_Parse_Internal_Static_XmlQualifiedName_String_IXmlNamespaceResolver_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100664629);
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x0002BE48 File Offset: 0x0002A048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20954, XrefRangeEnd = 20961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlQualifiedName()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x0002BE84 File Offset: 0x0002A084
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 20967, RefRangeEnd = 20969, XrefRangeStart = 20961, XrefRangeEnd = 20967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlQualifiedName(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x0002BED0 File Offset: 0x0002A0D0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 20973, RefRangeEnd = 20986, XrefRangeStart = 20969, XrefRangeEnd = 20973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlQualifiedName(string name, string ns)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x0002BF30 File Offset: 0x0002A130
		public unsafe string Namespace
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x0002BF68 File Offset: 0x0002A168
		public unsafe string Name
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x0002BFA0 File Offset: 0x0002A1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20986, XrefRangeEnd = 21024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlQualifiedName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x0002BFE8 File Offset: 0x0002A1E8
		public unsafe bool IsEmpty
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21024, RefRangeEnd = 21032, XrefRangeStart = 21024, XrefRangeEnd = 21024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x0002C024 File Offset: 0x0002A224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21032, XrefRangeEnd = 21033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlQualifiedName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x0002C068 File Offset: 0x0002A268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21033, XrefRangeEnd = 21043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlQualifiedName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x0002C0C0 File Offset: 0x0002A2C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21043, XrefRangeEnd = 21045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(XmlQualifiedName a, XmlQualifiedName b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_XmlQualifiedName_XmlQualifiedName_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x0002C114 File Offset: 0x0002A314
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21050, RefRangeEnd = 21051, XrefRangeStart = 21045, XrefRangeEnd = 21050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(XmlQualifiedName a, XmlQualifiedName b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_XmlQualifiedName_XmlQualifiedName_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x0002C168 File Offset: 0x0002A368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21051, XrefRangeEnd = 21071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlQualifiedName.HashCodeOfStringDelegate GetHashCodeDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr_GetHashCodeDelegate_Private_Static_HashCodeOfStringDelegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName.HashCodeOfStringDelegate>(intPtr3) : null;
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x0002C19C File Offset: 0x0002A39C
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsRandomizedHashingDisabled()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr_IsRandomizedHashingDisabled_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x0002C1CC File Offset: 0x0002A3CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21072, RefRangeEnd = 21073, XrefRangeStart = 21071, XrefRangeEnd = 21072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHashCodeOfString(string s, int length, long additionalEntropy)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalEntropy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr_GetHashCodeOfString_Private_Static_Int32_String_Int32_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x0002C22C File Offset: 0x0002A42C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 21089, RefRangeEnd = 21092, XrefRangeStart = 21073, XrefRangeEnd = 21089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, out string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr_Parse_Internal_Static_XmlQualifiedName_String_IXmlNamespaceResolver_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			prefix = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr4) : null;
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x000048DF File Offset: 0x00002ADF
		public XmlQualifiedName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x0002C2A0 File Offset: 0x0002A4A0
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x000048E8 File Offset: 0x00002AE8
		public unsafe static XmlQualifiedName.HashCodeOfStringDelegate hashCodeDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlQualifiedName.NativeFieldInfoPtr_hashCodeDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName.HashCodeOfStringDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlQualifiedName.NativeFieldInfoPtr_hashCodeDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x0002C2C8 File Offset: 0x0002A4C8
		// (set) Token: 0x0600081A RID: 2074 RVA: 0x000048FA File Offset: 0x00002AFA
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlQualifiedName.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlQualifiedName.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x0002C2F0 File Offset: 0x0002A4F0
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x00004919 File Offset: 0x00002B19
		public unsafe string ns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlQualifiedName.NativeFieldInfoPtr_ns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlQualifiedName.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x0002C318 File Offset: 0x0002A518
		// (set) Token: 0x0600081E RID: 2078 RVA: 0x00004938 File Offset: 0x00002B38
		public unsafe int hash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlQualifiedName.NativeFieldInfoPtr_hash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlQualifiedName.NativeFieldInfoPtr_hash)) = value;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x0002C340 File Offset: 0x0002A540
		// (set) Token: 0x06000820 RID: 2080 RVA: 0x00004953 File Offset: 0x00002B53
		public unsafe static XmlQualifiedName Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlQualifiedName.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlQualifiedName.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeFieldInfoPtr_hashCodeDelegate;

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeFieldInfoPtr_ns;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeFieldInfoPtr_hash;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_XmlQualifiedName_XmlQualifiedName_0;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_XmlQualifiedName_XmlQualifiedName_0;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCodeDelegate_Private_Static_HashCodeOfStringDelegate_0;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeMethodInfoPtr_IsRandomizedHashingDisabled_Private_Static_Boolean_0;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCodeOfString_Private_Static_Int32_String_Int32_Int64_0;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Internal_Static_XmlQualifiedName_String_IXmlNamespaceResolver_byref_String_0;

		// Token: 0x0200012C RID: 300
		public sealed class HashCodeOfStringDelegate : MulticastDelegate
		{
			// Token: 0x06001291 RID: 4753 RVA: 0x0000844A File Offset: 0x0000664A
			// Note: this type is marked as 'beforefieldinit'.
			static HashCodeOfStringDelegate()
			{
				Il2CppClassPointerStore<XmlQualifiedName.HashCodeOfStringDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, "HashCodeOfStringDelegate");
				XmlQualifiedName.HashCodeOfStringDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName.HashCodeOfStringDelegate>.NativeClassPtr, 100664631);
				XmlQualifiedName.HashCodeOfStringDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_String_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName.HashCodeOfStringDelegate>.NativeClassPtr, 100664632);
			}

			// Token: 0x06001292 RID: 4754 RVA: 0x00055234 File Offset: 0x00053434
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HashCodeOfStringDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlQualifiedName.HashCodeOfStringDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.HashCodeOfStringDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001293 RID: 4755 RVA: 0x00055290 File Offset: 0x00053490
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20953, RefRangeEnd = 20954, XrefRangeStart = 20953, XrefRangeEnd = 20953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Invoke(string s, int sLen, long additionalEntropy)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sLen;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalEntropy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.HashCodeOfStringDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_String_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001294 RID: 4756 RVA: 0x00008488 File Offset: 0x00006688
			public HashCodeOfStringDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001295 RID: 4757 RVA: 0x00008491 File Offset: 0x00006691
			public static implicit operator XmlQualifiedName.HashCodeOfStringDelegate(Func<string, int, long, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<XmlQualifiedName.HashCodeOfStringDelegate>(A_0);
			}

			// Token: 0x06001296 RID: 4758 RVA: 0x00008499 File Offset: 0x00006699
			public static XmlQualifiedName.HashCodeOfStringDelegate operator +(XmlQualifiedName.HashCodeOfStringDelegate A_0, XmlQualifiedName.HashCodeOfStringDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<XmlQualifiedName.HashCodeOfStringDelegate>();
			}

			// Token: 0x06001297 RID: 4759 RVA: 0x000084A7 File Offset: 0x000066A7
			public static XmlQualifiedName.HashCodeOfStringDelegate operator -(XmlQualifiedName.HashCodeOfStringDelegate A_0, XmlQualifiedName.HashCodeOfStringDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<XmlQualifiedName.HashCodeOfStringDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04000EA1 RID: 3745
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000EA2 RID: 3746
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_String_Int32_Int64_0;
		}
	}
}
