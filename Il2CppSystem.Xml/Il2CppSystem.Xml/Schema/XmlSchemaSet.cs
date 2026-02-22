using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000F8 RID: 248
	public class XmlSchemaSet : Object
	{
		// Token: 0x06000EF6 RID: 3830 RVA: 0x00046158 File Offset: 0x00044358
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaSet()
		{
			Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr);
			XmlSchemaSet.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "nameTable");
			XmlSchemaSet.NativeFieldInfoPtr_schemas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "schemas");
			XmlSchemaSet.NativeFieldInfoPtr_internalEventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "internalEventHandler");
			XmlSchemaSet.NativeFieldInfoPtr_eventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "eventHandler");
			XmlSchemaSet.NativeFieldInfoPtr_schemaLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "schemaLocations");
			XmlSchemaSet.NativeFieldInfoPtr_chameleonSchemas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "chameleonSchemas");
			XmlSchemaSet.NativeFieldInfoPtr_targetNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "targetNamespaces");
			XmlSchemaSet.NativeFieldInfoPtr_compileAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "compileAll");
			XmlSchemaSet.NativeFieldInfoPtr_cachedCompiledInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "cachedCompiledInfo");
			XmlSchemaSet.NativeFieldInfoPtr_readerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "readerSettings");
			XmlSchemaSet.NativeFieldInfoPtr_compilationSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, "compilationSettings");
			XmlSchemaSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100665469);
			XmlSchemaSet.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100665470);
			XmlSchemaSet.NativeMethodInfoPtr_InternalValidationCallback_Private_Void_Object_ValidationEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr, 100665471);
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x000462A0 File Offset: 0x000444A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24840, XrefRangeEnd = 24845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x000462DC File Offset: 0x000444DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24891, RefRangeEnd = 24893, XrefRangeStart = 24845, XrefRangeEnd = 24891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSet(XmlNameTable nameTable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaSet>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x00046328 File Offset: 0x00044528
		[CallerCount(0)]
		public unsafe void InternalValidationCallback(Object sender, ValidationEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSet.NativeMethodInfoPtr_InternalValidationCallback_Private_Void_Object_ValidationEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x00007103 File Offset: 0x00005303
		public XmlSchemaSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x0004637C File Offset: 0x0004457C
		// (set) Token: 0x06000EFC RID: 3836 RVA: 0x0000710C File Offset: 0x0000530C
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x000463AC File Offset: 0x000445AC
		// (set) Token: 0x06000EFE RID: 3838 RVA: 0x0000712B File Offset: 0x0000532B
		public unsafe SortedList schemas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_schemas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_schemas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06000EFF RID: 3839 RVA: 0x000463DC File Offset: 0x000445DC
		// (set) Token: 0x06000F00 RID: 3840 RVA: 0x0000714A File Offset: 0x0000534A
		public unsafe ValidationEventHandler internalEventHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_internalEventHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_internalEventHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x0004640C File Offset: 0x0004460C
		// (set) Token: 0x06000F02 RID: 3842 RVA: 0x00007169 File Offset: 0x00005369
		public unsafe ValidationEventHandler eventHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_eventHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_eventHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06000F03 RID: 3843 RVA: 0x0004643C File Offset: 0x0004463C
		// (set) Token: 0x06000F04 RID: 3844 RVA: 0x00007188 File Offset: 0x00005388
		public unsafe Hashtable schemaLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_schemaLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_schemaLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06000F05 RID: 3845 RVA: 0x0004646C File Offset: 0x0004466C
		// (set) Token: 0x06000F06 RID: 3846 RVA: 0x000071A7 File Offset: 0x000053A7
		public unsafe Hashtable chameleonSchemas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_chameleonSchemas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_chameleonSchemas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06000F07 RID: 3847 RVA: 0x0004649C File Offset: 0x0004469C
		// (set) Token: 0x06000F08 RID: 3848 RVA: 0x000071C6 File Offset: 0x000053C6
		public unsafe Hashtable targetNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_targetNamespaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_targetNamespaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06000F09 RID: 3849 RVA: 0x000464CC File Offset: 0x000446CC
		// (set) Token: 0x06000F0A RID: 3850 RVA: 0x000071E5 File Offset: 0x000053E5
		public unsafe bool compileAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_compileAll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_compileAll)) = value;
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06000F0B RID: 3851 RVA: 0x000464F4 File Offset: 0x000446F4
		// (set) Token: 0x06000F0C RID: 3852 RVA: 0x00007200 File Offset: 0x00005400
		public unsafe SchemaInfo cachedCompiledInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_cachedCompiledInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_cachedCompiledInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06000F0D RID: 3853 RVA: 0x00046524 File Offset: 0x00044724
		// (set) Token: 0x06000F0E RID: 3854 RVA: 0x0000721F File Offset: 0x0000541F
		public unsafe XmlReaderSettings readerSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_readerSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReaderSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_readerSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06000F0F RID: 3855 RVA: 0x00046554 File Offset: 0x00044754
		// (set) Token: 0x06000F10 RID: 3856 RVA: 0x0000723E File Offset: 0x0000543E
		public unsafe XmlSchemaCompilationSettings compilationSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_compilationSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaCompilationSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSet.NativeFieldInfoPtr_compilationSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x04000B0B RID: 2827
		private static readonly IntPtr NativeFieldInfoPtr_schemas;

		// Token: 0x04000B0C RID: 2828
		private static readonly IntPtr NativeFieldInfoPtr_internalEventHandler;

		// Token: 0x04000B0D RID: 2829
		private static readonly IntPtr NativeFieldInfoPtr_eventHandler;

		// Token: 0x04000B0E RID: 2830
		private static readonly IntPtr NativeFieldInfoPtr_schemaLocations;

		// Token: 0x04000B0F RID: 2831
		private static readonly IntPtr NativeFieldInfoPtr_chameleonSchemas;

		// Token: 0x04000B10 RID: 2832
		private static readonly IntPtr NativeFieldInfoPtr_targetNamespaces;

		// Token: 0x04000B11 RID: 2833
		private static readonly IntPtr NativeFieldInfoPtr_compileAll;

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeFieldInfoPtr_cachedCompiledInfo;

		// Token: 0x04000B13 RID: 2835
		private static readonly IntPtr NativeFieldInfoPtr_readerSettings;

		// Token: 0x04000B14 RID: 2836
		private static readonly IntPtr NativeFieldInfoPtr_compilationSettings;

		// Token: 0x04000B15 RID: 2837
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B16 RID: 2838
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0;

		// Token: 0x04000B17 RID: 2839
		private static readonly IntPtr NativeMethodInfoPtr_InternalValidationCallback_Private_Void_Object_ValidationEventArgs_0;
	}
}
