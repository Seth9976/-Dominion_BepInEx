using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x0200009F RID: 159
	public sealed class X509SubjectKeyIdentifierExtension : X509Extension
	{
		// Token: 0x06000961 RID: 2401 RVA: 0x00032B1C File Offset: 0x00030D1C
		// Note: this type is marked as 'beforefieldinit'.
		static X509SubjectKeyIdentifierExtension()
		{
			Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509SubjectKeyIdentifierExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr);
			X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr_oid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, "oid");
			X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr_friendlyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, "friendlyName");
			X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__subjectKeyIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, "_subjectKeyIdentifier");
			X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__ski = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, "_ski");
			X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, "_status");
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664506);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664507);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664508);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664509);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_PublicKey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664510);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_PublicKey_X509SubjectKeyIdentifierHashAlgorithm_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664511);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_get_SubjectKeyIdentifier_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664512);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664513);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_FromHexChar_Internal_Static_Byte_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664514);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_FromHexChars_Internal_Static_Byte_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664515);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_FromHex_Internal_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664516);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664517);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664518);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664519);
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00032CC8 File Offset: 0x00030EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43056, XrefRangeEnd = 43065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509SubjectKeyIdentifierExtension()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00032D04 File Offset: 0x00030F04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43075, RefRangeEnd = 43076, XrefRangeStart = 43065, XrefRangeEnd = 43075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509SubjectKeyIdentifierExtension(AsnEncodedData encodedSubjectKeyIdentifier, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encodedSubjectKeyIdentifier);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00032D60 File Offset: 0x00030F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43076, XrefRangeEnd = 43104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509SubjectKeyIdentifierExtension(Il2CppStructArray<byte> subjectKeyIdentifier, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(subjectKeyIdentifier);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00032DBC File Offset: 0x00030FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43104, XrefRangeEnd = 43141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509SubjectKeyIdentifierExtension(string subjectKeyIdentifier, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(subjectKeyIdentifier);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00032E18 File Offset: 0x00031018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43141, XrefRangeEnd = 43142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509SubjectKeyIdentifierExtension(PublicKey key, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_PublicKey_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00032E74 File Offset: 0x00031074
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43203, RefRangeEnd = 43204, XrefRangeStart = 43142, XrefRangeEnd = 43203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509SubjectKeyIdentifierExtension(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref algorithm;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_PublicKey_X509SubjectKeyIdentifierHashAlgorithm_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x00032EDC File Offset: 0x000310DC
		public unsafe string SubjectKeyIdentifier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43204, XrefRangeEnd = 43205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_get_SubjectKeyIdentifier_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00032F14 File Offset: 0x00031114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43205, XrefRangeEnd = 43219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asnEncodedData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00032F58 File Offset: 0x00031158
		[CallerCount(0)]
		public unsafe static byte FromHexChar(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_FromHexChar_Internal_Static_Byte_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00032F98 File Offset: 0x00031198
		[CallerCount(0)]
		public unsafe static byte FromHexChars(char c1, char c2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_FromHexChars_Internal_Static_Byte_Char_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00032FE4 File Offset: 0x000311E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43219, XrefRangeEnd = 43230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> FromHex(string hex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_FromHex_Internal_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00033028 File Offset: 0x00031228
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 43237, RefRangeEnd = 43239, XrefRangeStart = 43230, XrefRangeEnd = 43237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsnDecodeStatus Decode(Il2CppStructArray<byte> extension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extension);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00033078 File Offset: 0x00031278
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43244, RefRangeEnd = 43247, XrefRangeStart = 43239, XrefRangeEnd = 43244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> Encode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x000330B8 File Offset: 0x000312B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43247, XrefRangeEnd = 43268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00005D2A File Offset: 0x00003F2A
		public X509SubjectKeyIdentifierExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x000330FC File Offset: 0x000312FC
		// (set) Token: 0x06000972 RID: 2418 RVA: 0x00005D33 File Offset: 0x00003F33
		public unsafe static string oid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr_oid, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr_oid, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x0003311C File Offset: 0x0003131C
		// (set) Token: 0x06000974 RID: 2420 RVA: 0x00005D45 File Offset: 0x00003F45
		public unsafe static string friendlyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr_friendlyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr_friendlyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x0003313C File Offset: 0x0003133C
		// (set) Token: 0x06000976 RID: 2422 RVA: 0x00005D57 File Offset: 0x00003F57
		public unsafe Il2CppStructArray<byte> _subjectKeyIdentifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__subjectKeyIdentifier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__subjectKeyIdentifier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x0003316C File Offset: 0x0003136C
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x00005D76 File Offset: 0x00003F76
		public unsafe string _ski
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__ski);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__ski), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x00033194 File Offset: 0x00031394
		// (set) Token: 0x0600097A RID: 2426 RVA: 0x00005D95 File Offset: 0x00003F95
		public unsafe AsnDecodeStatus _status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__status)) = value;
			}
		}

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeFieldInfoPtr_oid;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeFieldInfoPtr_friendlyName;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeFieldInfoPtr__subjectKeyIdentifier;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeFieldInfoPtr__ski;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeFieldInfoPtr__status;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Boolean_0;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PublicKey_Boolean_0;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PublicKey_X509SubjectKeyIdentifierHashAlgorithm_Boolean_0;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeMethodInfoPtr_get_SubjectKeyIdentifier_Public_get_String_0;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeMethodInfoPtr_FromHexChar_Internal_Static_Byte_Char_0;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeMethodInfoPtr_FromHexChars_Internal_Static_Byte_Char_Char_0;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeMethodInfoPtr_FromHex_Internal_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0;
	}
}
