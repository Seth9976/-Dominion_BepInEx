using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200007F RID: 127
	public class AsnEncodedData : Object
	{
		// Token: 0x060007FD RID: 2045 RVA: 0x0002DB64 File Offset: 0x0002BD64
		// Note: this type is marked as 'beforefieldinit'.
		static AsnEncodedData()
		{
			Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography", "AsnEncodedData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr);
			AsnEncodedData.NativeFieldInfoPtr__oid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, "_oid");
			AsnEncodedData.NativeFieldInfoPtr__raw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, "_raw");
			AsnEncodedData.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664328);
			AsnEncodedData.NativeMethodInfoPtr__ctor_Public_Void_Oid_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664329);
			AsnEncodedData.NativeMethodInfoPtr_set_Oid_Public_set_Void_Oid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664330);
			AsnEncodedData.NativeMethodInfoPtr_get_RawData_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664331);
			AsnEncodedData.NativeMethodInfoPtr_set_RawData_Public_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664332);
			AsnEncodedData.NativeMethodInfoPtr_CopyFrom_Public_Virtual_New_Void_AsnEncodedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664333);
			AsnEncodedData.NativeMethodInfoPtr_ToString_Internal_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664334);
			AsnEncodedData.NativeMethodInfoPtr_Default_Internal_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664335);
			AsnEncodedData.NativeMethodInfoPtr_BasicConstraintsExtension_Internal_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664336);
			AsnEncodedData.NativeMethodInfoPtr_EnhancedKeyUsageExtension_Internal_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664337);
			AsnEncodedData.NativeMethodInfoPtr_KeyUsageExtension_Internal_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664338);
			AsnEncodedData.NativeMethodInfoPtr_SubjectKeyIdentifierExtension_Internal_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664339);
			AsnEncodedData.NativeMethodInfoPtr_SubjectAltName_Internal_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664340);
			AsnEncodedData.NativeMethodInfoPtr_NetscapeCertType_Internal_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100664341);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x0002DCD4 File Offset: 0x0002BED4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsnEncodedData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x0002DD10 File Offset: 0x0002BF10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 41578, RefRangeEnd = 41580, XrefRangeStart = 41568, XrefRangeEnd = 41578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsnEncodedData(Oid oid, Il2CppStructArray<byte> rawData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rawData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr__ctor_Public_Void_Oid_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000265 RID: 613
		// (set) Token: 0x06000800 RID: 2048 RVA: 0x0002DD70 File Offset: 0x0002BF70
		public unsafe Oid Oid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41580, XrefRangeEnd = 41584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_set_Oid_Public_set_Void_Oid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x0002DDB4 File Offset: 0x0002BFB4
		// (set) Token: 0x06000802 RID: 2050 RVA: 0x0002DDF4 File Offset: 0x0002BFF4
		public unsafe Il2CppStructArray<byte> RawData
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_get_RawData_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 41588, RefRangeEnd = 41597, XrefRangeStart = 41584, XrefRangeEnd = 41588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_set_RawData_Public_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x0002DE38 File Offset: 0x0002C038
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41612, RefRangeEnd = 41613, XrefRangeStart = 41597, XrefRangeEnd = 41612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyFrom(AsnEncodedData asnEncodedData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asnEncodedData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsnEncodedData.NativeMethodInfoPtr_CopyFrom_Public_Virtual_New_Void_AsnEncodedData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x0002DE88 File Offset: 0x0002C088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41613, XrefRangeEnd = 41652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToString(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsnEncodedData.NativeMethodInfoPtr_ToString_Internal_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x0002DED8 File Offset: 0x0002C0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41652, XrefRangeEnd = 41667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Default(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_Default_Internal_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x0002DF1C File Offset: 0x0002C11C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41673, RefRangeEnd = 41674, XrefRangeStart = 41667, XrefRangeEnd = 41673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string BasicConstraintsExtension(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_BasicConstraintsExtension_Internal_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x0002DF60 File Offset: 0x0002C160
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41680, RefRangeEnd = 41681, XrefRangeStart = 41674, XrefRangeEnd = 41680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string EnhancedKeyUsageExtension(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_EnhancedKeyUsageExtension_Internal_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x0002DFA4 File Offset: 0x0002C1A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41687, RefRangeEnd = 41688, XrefRangeStart = 41681, XrefRangeEnd = 41687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string KeyUsageExtension(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_KeyUsageExtension_Internal_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x0002DFE8 File Offset: 0x0002C1E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41694, RefRangeEnd = 41695, XrefRangeStart = 41688, XrefRangeEnd = 41694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string SubjectKeyIdentifierExtension(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_SubjectKeyIdentifierExtension_Internal_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x0002E02C File Offset: 0x0002C22C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41736, RefRangeEnd = 41737, XrefRangeStart = 41695, XrefRangeEnd = 41736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string SubjectAltName(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_SubjectAltName_Internal_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x0002E070 File Offset: 0x0002C270
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41797, RefRangeEnd = 41798, XrefRangeStart = 41737, XrefRangeEnd = 41797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string NetscapeCertType(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_NetscapeCertType_Internal_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00005420 File Offset: 0x00003620
		public AsnEncodedData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x0002E0B4 File Offset: 0x0002C2B4
		// (set) Token: 0x0600080E RID: 2062 RVA: 0x00005429 File Offset: 0x00003629
		public unsafe Oid _oid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsnEncodedData.NativeFieldInfoPtr__oid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Oid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsnEncodedData.NativeFieldInfoPtr__oid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x0002E0E4 File Offset: 0x0002C2E4
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x00005448 File Offset: 0x00003648
		public unsafe Il2CppStructArray<byte> _raw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsnEncodedData.NativeFieldInfoPtr__raw);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsnEncodedData.NativeFieldInfoPtr__raw), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeFieldInfoPtr__oid;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeFieldInfoPtr__raw;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Oid_Il2CppStructArray_1_Byte_0;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr_set_Oid_Public_set_Void_Oid_0;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr_get_RawData_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr_set_RawData_Public_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Virtual_New_Void_AsnEncodedData_0;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Virtual_New_String_Boolean_0;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeMethodInfoPtr_Default_Internal_String_Boolean_0;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeMethodInfoPtr_BasicConstraintsExtension_Internal_String_Boolean_0;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeMethodInfoPtr_EnhancedKeyUsageExtension_Internal_String_Boolean_0;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeMethodInfoPtr_KeyUsageExtension_Internal_String_Boolean_0;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeMethodInfoPtr_SubjectKeyIdentifierExtension_Internal_String_Boolean_0;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeMethodInfoPtr_SubjectAltName_Internal_String_Boolean_0;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeMethodInfoPtr_NetscapeCertType_Internal_String_Boolean_0;
	}
}
