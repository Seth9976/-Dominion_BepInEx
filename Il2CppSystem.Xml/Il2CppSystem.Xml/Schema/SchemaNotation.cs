using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000DF RID: 223
	public sealed class SchemaNotation : Object
	{
		// Token: 0x06000E05 RID: 3589 RVA: 0x00042BDC File Offset: 0x00040DDC
		// Note: this type is marked as 'beforefieldinit'.
		static SchemaNotation()
		{
			Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaNotation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr);
			SchemaNotation.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, "name");
			SchemaNotation.NativeFieldInfoPtr_systemLiteral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, "systemLiteral");
			SchemaNotation.NativeFieldInfoPtr_pubid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, "pubid");
			SchemaNotation.NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, 100665359);
			SchemaNotation.NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, 100665360);
			SchemaNotation.NativeMethodInfoPtr_get_SystemLiteral_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, 100665361);
			SchemaNotation.NativeMethodInfoPtr_set_SystemLiteral_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, 100665362);
			SchemaNotation.NativeMethodInfoPtr_get_Pubid_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, 100665363);
			SchemaNotation.NativeMethodInfoPtr_set_Pubid_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr, 100665364);
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00042CC0 File Offset: 0x00040EC0
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaNotation(XmlQualifiedName name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaNotation>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNotation.NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000E07 RID: 3591 RVA: 0x00042D0C File Offset: 0x00040F0C
		public unsafe XmlQualifiedName Name
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNotation.NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000E08 RID: 3592 RVA: 0x00042D4C File Offset: 0x00040F4C
		// (set) Token: 0x06000E09 RID: 3593 RVA: 0x00042D84 File Offset: 0x00040F84
		public unsafe string SystemLiteral
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNotation.NativeMethodInfoPtr_get_SystemLiteral_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNotation.NativeMethodInfoPtr_set_SystemLiteral_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x00042DC8 File Offset: 0x00040FC8
		// (set) Token: 0x06000E0B RID: 3595 RVA: 0x00042E00 File Offset: 0x00041000
		public unsafe string Pubid
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNotation.NativeMethodInfoPtr_get_Pubid_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNotation.NativeMethodInfoPtr_set_Pubid_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00006A5D File Offset: 0x00004C5D
		public SchemaNotation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x00042E44 File Offset: 0x00041044
		// (set) Token: 0x06000E0E RID: 3598 RVA: 0x00006A66 File Offset: 0x00004C66
		public unsafe XmlQualifiedName name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNotation.NativeFieldInfoPtr_name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNotation.NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000E0F RID: 3599 RVA: 0x00042E74 File Offset: 0x00041074
		// (set) Token: 0x06000E10 RID: 3600 RVA: 0x00006A85 File Offset: 0x00004C85
		public unsafe string systemLiteral
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNotation.NativeFieldInfoPtr_systemLiteral);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNotation.NativeFieldInfoPtr_systemLiteral), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06000E11 RID: 3601 RVA: 0x00042E9C File Offset: 0x0004109C
		// (set) Token: 0x06000E12 RID: 3602 RVA: 0x00006AA4 File Offset: 0x00004CA4
		public unsafe string pubid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNotation.NativeFieldInfoPtr_pubid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNotation.NativeFieldInfoPtr_pubid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000A5D RID: 2653
		private static readonly IntPtr NativeFieldInfoPtr_systemLiteral;

		// Token: 0x04000A5E RID: 2654
		private static readonly IntPtr NativeFieldInfoPtr_pubid;

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_0;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0;

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeMethodInfoPtr_get_SystemLiteral_Internal_get_String_0;

		// Token: 0x04000A62 RID: 2658
		private static readonly IntPtr NativeMethodInfoPtr_set_SystemLiteral_Internal_set_Void_String_0;

		// Token: 0x04000A63 RID: 2659
		private static readonly IntPtr NativeMethodInfoPtr_get_Pubid_Internal_get_String_0;

		// Token: 0x04000A64 RID: 2660
		private static readonly IntPtr NativeMethodInfoPtr_set_Pubid_Internal_set_Void_String_0;
	}
}
