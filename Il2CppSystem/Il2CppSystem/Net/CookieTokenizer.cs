using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000EB RID: 235
	public class CookieTokenizer : Object
	{
		// Token: 0x06000DAC RID: 3500 RVA: 0x00043B20 File Offset: 0x00041D20
		// Note: this type is marked as 'beforefieldinit'.
		static CookieTokenizer()
		{
			Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "CookieTokenizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr);
			CookieTokenizer.NativeFieldInfoPtr_m_eofCookie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_eofCookie");
			CookieTokenizer.NativeFieldInfoPtr_m_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_index");
			CookieTokenizer.NativeFieldInfoPtr_m_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_length");
			CookieTokenizer.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_name");
			CookieTokenizer.NativeFieldInfoPtr_m_quoted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_quoted");
			CookieTokenizer.NativeFieldInfoPtr_m_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_start");
			CookieTokenizer.NativeFieldInfoPtr_m_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_token");
			CookieTokenizer.NativeFieldInfoPtr_m_tokenLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_tokenLength");
			CookieTokenizer.NativeFieldInfoPtr_m_tokenStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_tokenStream");
			CookieTokenizer.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_value");
			CookieTokenizer.NativeFieldInfoPtr_RecognizedAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "RecognizedAttributes");
			CookieTokenizer.NativeFieldInfoPtr_RecognizedServerAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "RecognizedServerAttributes");
			CookieTokenizer.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665217);
			CookieTokenizer.NativeMethodInfoPtr_get_EndOfCookie_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665218);
			CookieTokenizer.NativeMethodInfoPtr_set_EndOfCookie_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665219);
			CookieTokenizer.NativeMethodInfoPtr_get_Eof_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665220);
			CookieTokenizer.NativeMethodInfoPtr_get_Name_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665221);
			CookieTokenizer.NativeMethodInfoPtr_set_Name_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665222);
			CookieTokenizer.NativeMethodInfoPtr_get_Quoted_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665223);
			CookieTokenizer.NativeMethodInfoPtr_set_Quoted_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665224);
			CookieTokenizer.NativeMethodInfoPtr_get_Token_Internal_get_CookieToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665225);
			CookieTokenizer.NativeMethodInfoPtr_set_Token_Internal_set_Void_CookieToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665226);
			CookieTokenizer.NativeMethodInfoPtr_get_Value_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665227);
			CookieTokenizer.NativeMethodInfoPtr_set_Value_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665228);
			CookieTokenizer.NativeMethodInfoPtr_Extract_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665229);
			CookieTokenizer.NativeMethodInfoPtr_FindNext_Internal_CookieToken_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665230);
			CookieTokenizer.NativeMethodInfoPtr_Next_Internal_CookieToken_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665231);
			CookieTokenizer.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665232);
			CookieTokenizer.NativeMethodInfoPtr_TokenFromName_Internal_CookieToken_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100665233);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00043D94 File Offset: 0x00041F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48095, XrefRangeEnd = 48096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookieTokenizer(string tokenStream)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tokenStream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000DAE RID: 3502 RVA: 0x00043DE0 File Offset: 0x00041FE0
		// (set) Token: 0x06000DAF RID: 3503 RVA: 0x00043E1C File Offset: 0x0004201C
		public unsafe bool EndOfCookie
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_get_EndOfCookie_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_set_EndOfCookie_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000DB0 RID: 3504 RVA: 0x00043E5C File Offset: 0x0004205C
		public unsafe bool Eof
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_get_Eof_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x00043E98 File Offset: 0x00042098
		// (set) Token: 0x06000DB2 RID: 3506 RVA: 0x00043ED0 File Offset: 0x000420D0
		public unsafe string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_get_Name_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_set_Name_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x00043F14 File Offset: 0x00042114
		// (set) Token: 0x06000DB4 RID: 3508 RVA: 0x00043F50 File Offset: 0x00042150
		public unsafe bool Quoted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_get_Quoted_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_set_Quoted_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000DB5 RID: 3509 RVA: 0x00043F90 File Offset: 0x00042190
		// (set) Token: 0x06000DB6 RID: 3510 RVA: 0x00043FCC File Offset: 0x000421CC
		public unsafe CookieToken Token
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_get_Token_Internal_get_CookieToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_set_Token_Internal_set_Void_CookieToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x0004400C File Offset: 0x0004220C
		// (set) Token: 0x06000DB8 RID: 3512 RVA: 0x00044044 File Offset: 0x00042244
		public unsafe string Value
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_get_Value_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_set_Value_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00044088 File Offset: 0x00042288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48096, XrefRangeEnd = 48100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Extract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_Extract_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x000440C0 File Offset: 0x000422C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48116, RefRangeEnd = 48117, XrefRangeStart = 48100, XrefRangeEnd = 48116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookieToken FindNext(bool ignoreComma, bool ignoreEquals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ignoreComma;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreEquals;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_FindNext_Internal_CookieToken_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00044118 File Offset: 0x00042318
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48125, RefRangeEnd = 48126, XrefRangeStart = 48117, XrefRangeEnd = 48125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookieToken Next(bool first, bool parseResponseCookies)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref first;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parseResponseCookies;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_Next_Internal_CookieToken_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00044170 File Offset: 0x00042370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48126, XrefRangeEnd = 48129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x000441A4 File Offset: 0x000423A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48129, XrefRangeEnd = 48151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookieToken TokenFromName(bool parseResponseCookies)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref parseResponseCookies;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_TokenFromName_Internal_CookieToken_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x000075BF File Offset: 0x000057BF
		public CookieTokenizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000DBF RID: 3519 RVA: 0x000441F0 File Offset: 0x000423F0
		// (set) Token: 0x06000DC0 RID: 3520 RVA: 0x000075C8 File Offset: 0x000057C8
		public unsafe bool m_eofCookie
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_eofCookie);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_eofCookie)) = value;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x00044218 File Offset: 0x00042418
		// (set) Token: 0x06000DC2 RID: 3522 RVA: 0x000075E3 File Offset: 0x000057E3
		public unsafe int m_index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_index)) = value;
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x00044240 File Offset: 0x00042440
		// (set) Token: 0x06000DC4 RID: 3524 RVA: 0x000075FE File Offset: 0x000057FE
		public unsafe int m_length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_length)) = value;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x00044268 File Offset: 0x00042468
		// (set) Token: 0x06000DC6 RID: 3526 RVA: 0x00007619 File Offset: 0x00005819
		public unsafe string m_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x00044290 File Offset: 0x00042490
		// (set) Token: 0x06000DC8 RID: 3528 RVA: 0x00007638 File Offset: 0x00005838
		public unsafe bool m_quoted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_quoted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_quoted)) = value;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x000442B8 File Offset: 0x000424B8
		// (set) Token: 0x06000DCA RID: 3530 RVA: 0x00007653 File Offset: 0x00005853
		public unsafe int m_start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_start)) = value;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x000442E0 File Offset: 0x000424E0
		// (set) Token: 0x06000DCC RID: 3532 RVA: 0x0000766E File Offset: 0x0000586E
		public unsafe CookieToken m_token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_token);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_token)) = value;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x00044308 File Offset: 0x00042508
		// (set) Token: 0x06000DCE RID: 3534 RVA: 0x00007689 File Offset: 0x00005889
		public unsafe int m_tokenLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_tokenLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_tokenLength)) = value;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x00044330 File Offset: 0x00042530
		// (set) Token: 0x06000DD0 RID: 3536 RVA: 0x000076A4 File Offset: 0x000058A4
		public unsafe string m_tokenStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_tokenStream);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_tokenStream), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x00044358 File Offset: 0x00042558
		// (set) Token: 0x06000DD2 RID: 3538 RVA: 0x000076C3 File Offset: 0x000058C3
		public unsafe string m_value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x00044380 File Offset: 0x00042580
		// (set) Token: 0x06000DD4 RID: 3540 RVA: 0x000076E2 File Offset: 0x000058E2
		public unsafe static Il2CppReferenceArray<CookieTokenizer.RecognizedAttribute> RecognizedAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CookieTokenizer.NativeFieldInfoPtr_RecognizedAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CookieTokenizer.RecognizedAttribute>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CookieTokenizer.NativeFieldInfoPtr_RecognizedAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x000443A8 File Offset: 0x000425A8
		// (set) Token: 0x06000DD6 RID: 3542 RVA: 0x000076F4 File Offset: 0x000058F4
		public unsafe static Il2CppReferenceArray<CookieTokenizer.RecognizedAttribute> RecognizedServerAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CookieTokenizer.NativeFieldInfoPtr_RecognizedServerAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CookieTokenizer.RecognizedAttribute>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CookieTokenizer.NativeFieldInfoPtr_RecognizedServerAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AE0 RID: 2784
		private static readonly IntPtr NativeFieldInfoPtr_m_eofCookie;

		// Token: 0x04000AE1 RID: 2785
		private static readonly IntPtr NativeFieldInfoPtr_m_index;

		// Token: 0x04000AE2 RID: 2786
		private static readonly IntPtr NativeFieldInfoPtr_m_length;

		// Token: 0x04000AE3 RID: 2787
		private static readonly IntPtr NativeFieldInfoPtr_m_name;

		// Token: 0x04000AE4 RID: 2788
		private static readonly IntPtr NativeFieldInfoPtr_m_quoted;

		// Token: 0x04000AE5 RID: 2789
		private static readonly IntPtr NativeFieldInfoPtr_m_start;

		// Token: 0x04000AE6 RID: 2790
		private static readonly IntPtr NativeFieldInfoPtr_m_token;

		// Token: 0x04000AE7 RID: 2791
		private static readonly IntPtr NativeFieldInfoPtr_m_tokenLength;

		// Token: 0x04000AE8 RID: 2792
		private static readonly IntPtr NativeFieldInfoPtr_m_tokenStream;

		// Token: 0x04000AE9 RID: 2793
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x04000AEA RID: 2794
		private static readonly IntPtr NativeFieldInfoPtr_RecognizedAttributes;

		// Token: 0x04000AEB RID: 2795
		private static readonly IntPtr NativeFieldInfoPtr_RecognizedServerAttributes;

		// Token: 0x04000AEC RID: 2796
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x04000AED RID: 2797
		private static readonly IntPtr NativeMethodInfoPtr_get_EndOfCookie_Internal_get_Boolean_0;

		// Token: 0x04000AEE RID: 2798
		private static readonly IntPtr NativeMethodInfoPtr_set_EndOfCookie_Internal_set_Void_Boolean_0;

		// Token: 0x04000AEF RID: 2799
		private static readonly IntPtr NativeMethodInfoPtr_get_Eof_Internal_get_Boolean_0;

		// Token: 0x04000AF0 RID: 2800
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Internal_get_String_0;

		// Token: 0x04000AF1 RID: 2801
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Internal_set_Void_String_0;

		// Token: 0x04000AF2 RID: 2802
		private static readonly IntPtr NativeMethodInfoPtr_get_Quoted_Internal_get_Boolean_0;

		// Token: 0x04000AF3 RID: 2803
		private static readonly IntPtr NativeMethodInfoPtr_set_Quoted_Internal_set_Void_Boolean_0;

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeMethodInfoPtr_get_Token_Internal_get_CookieToken_0;

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeMethodInfoPtr_set_Token_Internal_set_Void_CookieToken_0;

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Internal_get_String_0;

		// Token: 0x04000AF7 RID: 2807
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Internal_set_Void_String_0;

		// Token: 0x04000AF8 RID: 2808
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Internal_String_0;

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeMethodInfoPtr_FindNext_Internal_CookieToken_Boolean_Boolean_0;

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeMethodInfoPtr_Next_Internal_CookieToken_Boolean_Boolean_0;

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeMethodInfoPtr_TokenFromName_Internal_CookieToken_Boolean_0;

		// Token: 0x020001B7 RID: 439
		public sealed class RecognizedAttribute : ValueType
		{
			// Token: 0x060018B8 RID: 6328 RVA: 0x00069F38 File Offset: 0x00068138
			// Note: this type is marked as 'beforefieldinit'.
			static RecognizedAttribute()
			{
				Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "RecognizedAttribute");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr);
				CookieTokenizer.RecognizedAttribute.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr, "m_name");
				CookieTokenizer.RecognizedAttribute.NativeFieldInfoPtr_m_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr, "m_token");
				CookieTokenizer.RecognizedAttribute.NativeMethodInfoPtr__ctor_Internal_Void_String_CookieToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr, 100665235);
				CookieTokenizer.RecognizedAttribute.NativeMethodInfoPtr_get_Token_Internal_get_CookieToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr, 100665236);
				CookieTokenizer.RecognizedAttribute.NativeMethodInfoPtr_IsEqualTo_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr, 100665237);
			}

			// Token: 0x060018B9 RID: 6329 RVA: 0x00069FC8 File Offset: 0x000681C8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 11679, RefRangeEnd = 11680, XrefRangeStart = 11679, XrefRangeEnd = 11680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RecognizedAttribute(string name, CookieToken token)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.RecognizedAttribute.NativeMethodInfoPtr__ctor_Internal_Void_String_CookieToken_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007E7 RID: 2023
			// (get) Token: 0x060018BA RID: 6330 RVA: 0x0006A028 File Offset: 0x00068228
			public unsafe CookieToken Token
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.RecognizedAttribute.NativeMethodInfoPtr_get_Token_Internal_get_CookieToken_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060018BB RID: 6331 RVA: 0x0006A06C File Offset: 0x0006826C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 48093, RefRangeEnd = 48095, XrefRangeStart = 48092, XrefRangeEnd = 48093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsEqualTo(string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.RecognizedAttribute.NativeMethodInfoPtr_IsEqualTo_Internal_Boolean_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060018BC RID: 6332 RVA: 0x0000CF67 File Offset: 0x0000B167
			public RecognizedAttribute(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060018BD RID: 6333 RVA: 0x0000CF70 File Offset: 0x0000B170
			public RecognizedAttribute()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr))
			{
			}

			// Token: 0x170007E5 RID: 2021
			// (get) Token: 0x060018BE RID: 6334 RVA: 0x0006A0C0 File Offset: 0x000682C0
			// (set) Token: 0x060018BF RID: 6335 RVA: 0x0000CF82 File Offset: 0x0000B182
			public unsafe string m_name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.RecognizedAttribute.NativeFieldInfoPtr_m_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.RecognizedAttribute.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170007E6 RID: 2022
			// (get) Token: 0x060018C0 RID: 6336 RVA: 0x0006A0E8 File Offset: 0x000682E8
			// (set) Token: 0x060018C1 RID: 6337 RVA: 0x0000CFA1 File Offset: 0x0000B1A1
			public unsafe CookieToken m_token
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.RecognizedAttribute.NativeFieldInfoPtr_m_token);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.RecognizedAttribute.NativeFieldInfoPtr_m_token)) = value;
				}
			}

			// Token: 0x04001383 RID: 4995
			private static readonly IntPtr NativeFieldInfoPtr_m_name;

			// Token: 0x04001384 RID: 4996
			private static readonly IntPtr NativeFieldInfoPtr_m_token;

			// Token: 0x04001385 RID: 4997
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_CookieToken_0;

			// Token: 0x04001386 RID: 4998
			private static readonly IntPtr NativeMethodInfoPtr_get_Token_Internal_get_CookieToken_0;

			// Token: 0x04001387 RID: 4999
			private static readonly IntPtr NativeMethodInfoPtr_IsEqualTo_Internal_Boolean_String_0;
		}
	}
}
