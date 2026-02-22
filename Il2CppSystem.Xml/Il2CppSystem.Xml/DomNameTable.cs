using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000025 RID: 37
	public class DomNameTable : Object
	{
		// Token: 0x0600031B RID: 795 RVA: 0x00015700 File Offset: 0x00013900
		// Note: this type is marked as 'beforefieldinit'.
		static DomNameTable()
		{
			Il2CppClassPointerStore<DomNameTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "DomNameTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr);
			DomNameTable.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, "entries");
			DomNameTable.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, "count");
			DomNameTable.NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, "mask");
			DomNameTable.NativeFieldInfoPtr_ownerDocument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, "ownerDocument");
			DomNameTable.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, "nameTable");
			DomNameTable.NativeMethodInfoPtr__ctor_Public_Void_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, 100663823);
			DomNameTable.NativeMethodInfoPtr_GetName_Public_XmlName_String_String_String_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, 100663824);
			DomNameTable.NativeMethodInfoPtr_AddName_Public_XmlName_String_String_String_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, 100663825);
			DomNameTable.NativeMethodInfoPtr_Grow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, 100663826);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x000157E4 File Offset: 0x000139E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14693, RefRangeEnd = 14694, XrefRangeStart = 14688, XrefRangeEnd = 14693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DomNameTable(XmlDocument document)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(document);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomNameTable.NativeMethodInfoPtr__ctor_Public_Void_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00015830 File Offset: 0x00013A30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 14700, RefRangeEnd = 14703, XrefRangeStart = 14694, XrefRangeEnd = 14700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomNameTable.NativeMethodInfoPtr_GetName_Public_XmlName_String_String_String_IXmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlName>(intPtr3) : null;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000158B8 File Offset: 0x00013AB8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 14710, RefRangeEnd = 14717, XrefRangeStart = 14703, XrefRangeEnd = 14710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomNameTable.NativeMethodInfoPtr_AddName_Public_XmlName_String_String_String_IXmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlName>(intPtr3) : null;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00015940 File Offset: 0x00013B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14717, XrefRangeEnd = 14722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Grow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomNameTable.NativeMethodInfoPtr_Grow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00003169 File Offset: 0x00001369
		public DomNameTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000321 RID: 801 RVA: 0x00015974 File Offset: 0x00013B74
		// (set) Token: 0x06000322 RID: 802 RVA: 0x00003172 File Offset: 0x00001372
		public unsafe Il2CppReferenceArray<XmlName> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlName>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000323 RID: 803 RVA: 0x000159A4 File Offset: 0x00013BA4
		// (set) Token: 0x06000324 RID: 804 RVA: 0x00003191 File Offset: 0x00001391
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000325 RID: 805 RVA: 0x000159CC File Offset: 0x00013BCC
		// (set) Token: 0x06000326 RID: 806 RVA: 0x000031AC File Offset: 0x000013AC
		public unsafe int mask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_mask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_mask)) = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000327 RID: 807 RVA: 0x000159F4 File Offset: 0x00013BF4
		// (set) Token: 0x06000328 RID: 808 RVA: 0x000031C7 File Offset: 0x000013C7
		public unsafe XmlDocument ownerDocument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_ownerDocument);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_ownerDocument), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00015A24 File Offset: 0x00013C24
		// (set) Token: 0x0600032A RID: 810 RVA: 0x000031E6 File Offset: 0x000013E6
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeFieldInfoPtr_mask;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeFieldInfoPtr_ownerDocument;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlDocument_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_XmlName_String_String_String_IXmlSchemaInfo_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_AddName_Public_XmlName_String_String_String_IXmlSchemaInfo_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_Grow_Private_Void_0;
	}
}
