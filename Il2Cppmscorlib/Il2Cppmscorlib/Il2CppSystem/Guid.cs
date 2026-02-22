using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppSystem
{
	// Token: 0x020000B5 RID: 181
	[Serializable]
	[StructLayout(2)]
	public struct Guid
	{
		// Token: 0x06000CB5 RID: 3253 RVA: 0x0005B744 File Offset: 0x00059944
		// Note: this type is marked as 'beforefieldinit'.
		static Guid()
		{
			Il2CppClassPointerStore<Guid>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Guid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Guid>.NativeClassPtr);
			Guid.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "Empty");
			Guid.NativeFieldInfoPtr__a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_a");
			Guid.NativeFieldInfoPtr__b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_b");
			Guid.NativeFieldInfoPtr__c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_c");
			Guid.NativeFieldInfoPtr__d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_d");
			Guid.NativeFieldInfoPtr__e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_e");
			Guid.NativeFieldInfoPtr__f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_f");
			Guid.NativeFieldInfoPtr__g = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_g");
			Guid.NativeFieldInfoPtr__h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_h");
			Guid.NativeFieldInfoPtr__i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_i");
			Guid.NativeFieldInfoPtr__j = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_j");
			Guid.NativeFieldInfoPtr__k = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_k");
			Guid.NativeFieldInfoPtr__rngAccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_rngAccess");
			Guid.NativeFieldInfoPtr__rng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_rng");
			Guid.NativeFieldInfoPtr__fastRng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_fastRng");
			Guid.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665411);
			Guid.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt16_UInt16_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665412);
			Guid.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665413);
			Guid.NativeMethodInfoPtr_Parse_Public_Static_Guid_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665414);
			Guid.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665415);
			Guid.NativeMethodInfoPtr_TryParseGuid_Private_Static_Boolean_String_GuidStyles_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665416);
			Guid.NativeMethodInfoPtr_TryParseGuidWithHexPrefix_Private_Static_Boolean_String_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665417);
			Guid.NativeMethodInfoPtr_TryParseGuidWithNoStyle_Private_Static_Boolean_String_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665418);
			Guid.NativeMethodInfoPtr_TryParseGuidWithDashes_Private_Static_Boolean_String_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665419);
			Guid.NativeMethodInfoPtr_StringToShort_Private_Static_Boolean_String_Int32_Int32_byref_Int16_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665420);
			Guid.NativeMethodInfoPtr_StringToShort_Private_Static_Boolean_String_ptr_Int32_Int32_Int32_byref_Int16_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665421);
			Guid.NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_String_Int32_Int32_byref_Int32_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665422);
			Guid.NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_String_byref_Int32_Int32_Int32_byref_Int32_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665423);
			Guid.NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_String_ptr_Int32_Int32_Int32_byref_Int32_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665424);
			Guid.NativeMethodInfoPtr_StringToLong_Private_Static_Boolean_String_byref_Int32_Int32_byref_Int64_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665425);
			Guid.NativeMethodInfoPtr_StringToLong_Private_Static_Boolean_String_ptr_Int32_Int32_byref_Int64_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665426);
			Guid.NativeMethodInfoPtr_EatAllWhitespace_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665427);
			Guid.NativeMethodInfoPtr_IsHexPrefix_Private_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665428);
			Guid.NativeMethodInfoPtr_ToByteArray_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665429);
			Guid.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665430);
			Guid.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665431);
			Guid.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665432);
			Guid.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665433);
			Guid.NativeMethodInfoPtr_GetResult_Private_Int32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665434);
			Guid.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665435);
			Guid.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665436);
			Guid.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Guid_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665437);
			Guid.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Guid_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665438);
			Guid.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665439);
			Guid.NativeMethodInfoPtr_HexToChar_Private_Static_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665440);
			Guid.NativeMethodInfoPtr_HexsToChars_Private_Static_Int32_ptr_Char_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665441);
			Guid.NativeMethodInfoPtr_HexsToChars_Private_Static_Int32_ptr_Char_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665442);
			Guid.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665443);
			Guid.NativeMethodInfoPtr_NewGuid_Public_Static_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665444);
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x0005BB48 File Offset: 0x00059D48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 285751, RefRangeEnd = 285754, XrefRangeStart = 285751, XrefRangeEnd = 285751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Guid(Il2CppStructArray<byte> b)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x0005BB80 File Offset: 0x00059D80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285754, RefRangeEnd = 285755, XrefRangeStart = 285754, XrefRangeEnd = 285754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Guid(uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref e;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref g;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref j;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref k;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt16_UInt16_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x0005BC44 File Offset: 0x00059E44
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 285761, RefRangeEnd = 285774, XrefRangeStart = 285755, XrefRangeEnd = 285761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Guid(string g)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(g);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr__ctor_Public_Void_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x0005BC7C File Offset: 0x00059E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285774, XrefRangeEnd = 285779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Guid Parse(string input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_Parse_Public_Static_Guid_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x0005BCC0 File Offset: 0x00059EC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285787, RefRangeEnd = 285788, XrefRangeStart = 285779, XrefRangeEnd = 285787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string input, out Guid result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x0005BD10 File Offset: 0x00059F10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 285794, RefRangeEnd = 285797, XrefRangeStart = 285788, XrefRangeEnd = 285794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseGuid(string g, Guid.GuidStyles flags, ref Guid.GuidResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(g);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_TryParseGuid_Private_Static_Boolean_String_GuidStyles_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x0005BD74 File Offset: 0x00059F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285797, XrefRangeEnd = 285858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseGuidWithHexPrefix(string guidString, ref Guid.GuidResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guidString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_TryParseGuidWithHexPrefix_Private_Static_Boolean_String_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x0005BDC8 File Offset: 0x00059FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285858, XrefRangeEnd = 285873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseGuidWithNoStyle(string guidString, ref Guid.GuidResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guidString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_TryParseGuidWithNoStyle_Private_Static_Boolean_String_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x0005BE1C File Offset: 0x0005A01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285873, XrefRangeEnd = 285882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseGuidWithDashes(string guidString, ref Guid.GuidResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guidString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_TryParseGuidWithDashes_Private_Static_Boolean_String_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x0005BE70 File Offset: 0x0005A070
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285889, RefRangeEnd = 285891, XrefRangeStart = 285882, XrefRangeEnd = 285889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StringToShort(string str, int requiredLength, int flags, out short result, ref Guid.GuidResult parseResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiredLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parseResult);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_StringToShort_Private_Static_Boolean_String_Int32_Int32_byref_Int16_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x0005BEF0 File Offset: 0x0005A0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285891, XrefRangeEnd = 285895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StringToShort(string str, int* parsePos, int requiredLength, int flags, out short result, ref Guid.GuidResult parseResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = parsePos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiredLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parseResult);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_StringToShort_Private_Static_Boolean_String_ptr_Int32_Int32_Int32_byref_Int16_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x0005BF80 File Offset: 0x0005A180
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285899, RefRangeEnd = 285900, XrefRangeStart = 285895, XrefRangeEnd = 285899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StringToInt(string str, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiredLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parseResult);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_String_Int32_Int32_byref_Int32_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x0005C000 File Offset: 0x0005A200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285900, XrefRangeEnd = 285904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StringToInt(string str, ref int parsePos, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &parsePos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiredLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parseResult);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_String_byref_Int32_Int32_Int32_byref_Int32_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x0005C090 File Offset: 0x0005A290
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 285908, RefRangeEnd = 285912, XrefRangeStart = 285904, XrefRangeEnd = 285908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StringToInt(string str, int* parsePos, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = parsePos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiredLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parseResult);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_String_ptr_Int32_Int32_Int32_byref_Int32_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x0005C120 File Offset: 0x0005A320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285912, XrefRangeEnd = 285916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StringToLong(string str, ref int parsePos, int flags, out long result, ref Guid.GuidResult parseResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &parsePos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parseResult);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_StringToLong_Private_Static_Boolean_String_byref_Int32_Int32_byref_Int64_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x0005C1A0 File Offset: 0x0005A3A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285917, RefRangeEnd = 285918, XrefRangeStart = 285916, XrefRangeEnd = 285917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StringToLong(string str, int* parsePos, int flags, out long result, ref Guid.GuidResult parseResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = parsePos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parseResult);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_StringToLong_Private_Static_Boolean_String_ptr_Int32_Int32_byref_Int64_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x0005C220 File Offset: 0x0005A420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285918, XrefRangeEnd = 285928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EatAllWhitespace(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_EatAllWhitespace_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x0005C25C File Offset: 0x0005A45C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 285938, RefRangeEnd = 285942, XrefRangeStart = 285928, XrefRangeEnd = 285938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsHexPrefix(string str, int i)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_IsHexPrefix_Private_Static_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x0005C2AC File Offset: 0x0005A4AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285945, RefRangeEnd = 285947, XrefRangeStart = 285942, XrefRangeEnd = 285945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ToByteArray()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_ToByteArray_Public_Il2CppStructArray_1_Byte_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x0005C2E0 File Offset: 0x0005A4E0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 285950, RefRangeEnd = 285961, XrefRangeStart = 285947, XrefRangeEnd = 285950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x0005C30C File Offset: 0x0005A50C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x0005C33C File Offset: 0x0005A53C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285964, RefRangeEnd = 285965, XrefRangeStart = 285961, XrefRangeEnd = 285964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x0005C380 File Offset: 0x0005A580
		[CallerCount(0)]
		public unsafe bool Equals(Guid g)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref g;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Guid_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x0005C3C0 File Offset: 0x0005A5C0
		[CallerCount(0)]
		public unsafe int GetResult(uint me, uint them)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref me;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref them;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_GetResult_Private_Int32_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x0005C40C File Offset: 0x0005A60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285965, XrefRangeEnd = 285968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x0005C450 File Offset: 0x0005A650
		[CallerCount(0)]
		public unsafe int CompareTo(Guid value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Guid_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x0005C490 File Offset: 0x0005A690
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 285968, RefRangeEnd = 285988, XrefRangeStart = 285968, XrefRangeEnd = 285968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Guid a, Guid b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Guid_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x0005C4DC File Offset: 0x0005A6DC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 285991, RefRangeEnd = 285997, XrefRangeStart = 285988, XrefRangeEnd = 285991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Guid a, Guid b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Guid_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x0005C528 File Offset: 0x0005A728
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 285998, RefRangeEnd = 286004, XrefRangeStart = 285997, XrefRangeEnd = 285998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_ToString_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x0005C564 File Offset: 0x0005A764
		[CallerCount(0)]
		public unsafe static char HexToChar(int a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_HexToChar_Private_Static_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x0005C5A4 File Offset: 0x0005A7A4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 286008, RefRangeEnd = 286020, XrefRangeStart = 286004, XrefRangeEnd = 286008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int HexsToChars(char* guidChars, int offset, int a, int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = guidChars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_HexsToChars_Private_Static_Int32_ptr_Char_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x0005C60C File Offset: 0x0005A80C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 286025, RefRangeEnd = 286030, XrefRangeStart = 286020, XrefRangeEnd = 286025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int HexsToChars(char* guidChars, int offset, int a, int b, bool hex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = guidChars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_HexsToChars_Private_Static_Int32_ptr_Char_Int32_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x0005C680 File Offset: 0x0005A880
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286076, RefRangeEnd = 286078, XrefRangeStart = 286030, XrefRangeEnd = 286076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x0005C6D0 File Offset: 0x0005A8D0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 286099, RefRangeEnd = 286107, XrefRangeStart = 286078, XrefRangeEnd = 286099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Guid NewGuid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_NewGuid_Public_Static_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x0000560D File Offset: 0x0000380D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Guid>.NativeClassPtr, ref this));
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x0005C700 File Offset: 0x0005A900
		// (set) Token: 0x06000CDA RID: 3290 RVA: 0x0000561F File Offset: 0x0000381F
		public unsafe static Guid Empty
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(Guid.NativeFieldInfoPtr_Empty, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Guid.NativeFieldInfoPtr_Empty, (void*)(&value));
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x0005C71C File Offset: 0x0005A91C
		// (set) Token: 0x06000CDC RID: 3292 RVA: 0x0000562D File Offset: 0x0000382D
		public unsafe static Object _rngAccess
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Guid.NativeFieldInfoPtr__rngAccess, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Guid.NativeFieldInfoPtr__rngAccess, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x0005C744 File Offset: 0x0005A944
		// (set) Token: 0x06000CDE RID: 3294 RVA: 0x0000563F File Offset: 0x0000383F
		public unsafe static RandomNumberGenerator _rng
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Guid.NativeFieldInfoPtr__rng, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Guid.NativeFieldInfoPtr__rng, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x0005C76C File Offset: 0x0005A96C
		// (set) Token: 0x06000CE0 RID: 3296 RVA: 0x00005651 File Offset: 0x00003851
		public unsafe static RandomNumberGenerator _fastRng
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Guid.NativeFieldInfoPtr__fastRng, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Guid.NativeFieldInfoPtr__fastRng, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeFieldInfoPtr__a;

		// Token: 0x04000ACD RID: 2765
		private static readonly IntPtr NativeFieldInfoPtr__b;

		// Token: 0x04000ACE RID: 2766
		private static readonly IntPtr NativeFieldInfoPtr__c;

		// Token: 0x04000ACF RID: 2767
		private static readonly IntPtr NativeFieldInfoPtr__d;

		// Token: 0x04000AD0 RID: 2768
		private static readonly IntPtr NativeFieldInfoPtr__e;

		// Token: 0x04000AD1 RID: 2769
		private static readonly IntPtr NativeFieldInfoPtr__f;

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeFieldInfoPtr__g;

		// Token: 0x04000AD3 RID: 2771
		private static readonly IntPtr NativeFieldInfoPtr__h;

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeFieldInfoPtr__i;

		// Token: 0x04000AD5 RID: 2773
		private static readonly IntPtr NativeFieldInfoPtr__j;

		// Token: 0x04000AD6 RID: 2774
		private static readonly IntPtr NativeFieldInfoPtr__k;

		// Token: 0x04000AD7 RID: 2775
		private static readonly IntPtr NativeFieldInfoPtr__rngAccess;

		// Token: 0x04000AD8 RID: 2776
		private static readonly IntPtr NativeFieldInfoPtr__rng;

		// Token: 0x04000AD9 RID: 2777
		private static readonly IntPtr NativeFieldInfoPtr__fastRng;

		// Token: 0x04000ADA RID: 2778
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000ADB RID: 2779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt16_UInt16_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_0;

		// Token: 0x04000ADC RID: 2780
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000ADD RID: 2781
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Guid_String_0;

		// Token: 0x04000ADE RID: 2782
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Guid_0;

		// Token: 0x04000ADF RID: 2783
		private static readonly IntPtr NativeMethodInfoPtr_TryParseGuid_Private_Static_Boolean_String_GuidStyles_byref_GuidResult_0;

		// Token: 0x04000AE0 RID: 2784
		private static readonly IntPtr NativeMethodInfoPtr_TryParseGuidWithHexPrefix_Private_Static_Boolean_String_byref_GuidResult_0;

		// Token: 0x04000AE1 RID: 2785
		private static readonly IntPtr NativeMethodInfoPtr_TryParseGuidWithNoStyle_Private_Static_Boolean_String_byref_GuidResult_0;

		// Token: 0x04000AE2 RID: 2786
		private static readonly IntPtr NativeMethodInfoPtr_TryParseGuidWithDashes_Private_Static_Boolean_String_byref_GuidResult_0;

		// Token: 0x04000AE3 RID: 2787
		private static readonly IntPtr NativeMethodInfoPtr_StringToShort_Private_Static_Boolean_String_Int32_Int32_byref_Int16_byref_GuidResult_0;

		// Token: 0x04000AE4 RID: 2788
		private static readonly IntPtr NativeMethodInfoPtr_StringToShort_Private_Static_Boolean_String_ptr_Int32_Int32_Int32_byref_Int16_byref_GuidResult_0;

		// Token: 0x04000AE5 RID: 2789
		private static readonly IntPtr NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_String_Int32_Int32_byref_Int32_byref_GuidResult_0;

		// Token: 0x04000AE6 RID: 2790
		private static readonly IntPtr NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_String_byref_Int32_Int32_Int32_byref_Int32_byref_GuidResult_0;

		// Token: 0x04000AE7 RID: 2791
		private static readonly IntPtr NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_String_ptr_Int32_Int32_Int32_byref_Int32_byref_GuidResult_0;

		// Token: 0x04000AE8 RID: 2792
		private static readonly IntPtr NativeMethodInfoPtr_StringToLong_Private_Static_Boolean_String_byref_Int32_Int32_byref_Int64_byref_GuidResult_0;

		// Token: 0x04000AE9 RID: 2793
		private static readonly IntPtr NativeMethodInfoPtr_StringToLong_Private_Static_Boolean_String_ptr_Int32_Int32_byref_Int64_byref_GuidResult_0;

		// Token: 0x04000AEA RID: 2794
		private static readonly IntPtr NativeMethodInfoPtr_EatAllWhitespace_Private_Static_String_String_0;

		// Token: 0x04000AEB RID: 2795
		private static readonly IntPtr NativeMethodInfoPtr_IsHexPrefix_Private_Static_Boolean_String_Int32_0;

		// Token: 0x04000AEC RID: 2796
		private static readonly IntPtr NativeMethodInfoPtr_ToByteArray_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000AED RID: 2797
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000AEE RID: 2798
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000AEF RID: 2799
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000AF0 RID: 2800
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Guid_0;

		// Token: 0x04000AF1 RID: 2801
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Private_Int32_UInt32_UInt32_0;

		// Token: 0x04000AF2 RID: 2802
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000AF3 RID: 2803
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Guid_0;

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Guid_Guid_0;

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Guid_Guid_0;

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x04000AF7 RID: 2807
		private static readonly IntPtr NativeMethodInfoPtr_HexToChar_Private_Static_Char_Int32_0;

		// Token: 0x04000AF8 RID: 2808
		private static readonly IntPtr NativeMethodInfoPtr_HexsToChars_Private_Static_Int32_ptr_Char_Int32_Int32_Int32_0;

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeMethodInfoPtr_HexsToChars_Private_Static_Int32_ptr_Char_Int32_Int32_Int32_Boolean_0;

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeMethodInfoPtr_NewGuid_Public_Static_Guid_0;

		// Token: 0x04000AFC RID: 2812
		[FieldOffset(0)]
		public int _a;

		// Token: 0x04000AFD RID: 2813
		[FieldOffset(4)]
		public short _b;

		// Token: 0x04000AFE RID: 2814
		[FieldOffset(6)]
		public short _c;

		// Token: 0x04000AFF RID: 2815
		[FieldOffset(8)]
		public byte _d;

		// Token: 0x04000B00 RID: 2816
		[FieldOffset(9)]
		public byte _e;

		// Token: 0x04000B01 RID: 2817
		[FieldOffset(10)]
		public byte _f;

		// Token: 0x04000B02 RID: 2818
		[FieldOffset(11)]
		public byte _g;

		// Token: 0x04000B03 RID: 2819
		[FieldOffset(12)]
		public byte _h;

		// Token: 0x04000B04 RID: 2820
		[FieldOffset(13)]
		public byte _i;

		// Token: 0x04000B05 RID: 2821
		[FieldOffset(14)]
		public byte _j;

		// Token: 0x04000B06 RID: 2822
		[FieldOffset(15)]
		public byte _k;

		// Token: 0x02000597 RID: 1431
		[Flags]
		public enum GuidStyles
		{
			// Token: 0x04004008 RID: 16392
			None = 0,
			// Token: 0x04004009 RID: 16393
			AllowParenthesis = 1,
			// Token: 0x0400400A RID: 16394
			AllowBraces = 2,
			// Token: 0x0400400B RID: 16395
			AllowDashes = 4,
			// Token: 0x0400400C RID: 16396
			AllowHexPrefix = 8,
			// Token: 0x0400400D RID: 16397
			RequireParenthesis = 16,
			// Token: 0x0400400E RID: 16398
			RequireBraces = 32,
			// Token: 0x0400400F RID: 16399
			RequireDashes = 64,
			// Token: 0x04004010 RID: 16400
			RequireHexPrefix = 128,
			// Token: 0x04004011 RID: 16401
			HexFormat = 160,
			// Token: 0x04004012 RID: 16402
			NumberFormat = 0,
			// Token: 0x04004013 RID: 16403
			DigitFormat = 64,
			// Token: 0x04004014 RID: 16404
			BraceFormat = 96,
			// Token: 0x04004015 RID: 16405
			ParenthesisFormat = 80,
			// Token: 0x04004016 RID: 16406
			Any = 15
		}

		// Token: 0x02000598 RID: 1432
		public enum GuidParseThrowStyle
		{
			// Token: 0x04004018 RID: 16408
			None,
			// Token: 0x04004019 RID: 16409
			All,
			// Token: 0x0400401A RID: 16410
			AllButOverflow
		}

		// Token: 0x02000599 RID: 1433
		public enum ParseFailureKind
		{
			// Token: 0x0400401C RID: 16412
			None,
			// Token: 0x0400401D RID: 16413
			ArgumentNull,
			// Token: 0x0400401E RID: 16414
			Format,
			// Token: 0x0400401F RID: 16415
			FormatWithParameter,
			// Token: 0x04004020 RID: 16416
			NativeException,
			// Token: 0x04004021 RID: 16417
			FormatWithInnerException
		}

		// Token: 0x0200059A RID: 1434
		public sealed class GuidResult : ValueType
		{
			// Token: 0x06004F0D RID: 20237 RVA: 0x00163E38 File Offset: 0x00162038
			// Note: this type is marked as 'beforefieldinit'.
			static GuidResult()
			{
				Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Guid>.NativeClassPtr, "GuidResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr);
				Guid.GuidResult.NativeFieldInfoPtr_parsedGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, "parsedGuid");
				Guid.GuidResult.NativeFieldInfoPtr_throwStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, "throwStyle");
				Guid.GuidResult.NativeFieldInfoPtr_m_failure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, "m_failure");
				Guid.GuidResult.NativeFieldInfoPtr_m_failureMessageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, "m_failureMessageID");
				Guid.GuidResult.NativeFieldInfoPtr_m_failureMessageFormatArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, "m_failureMessageFormatArgument");
				Guid.GuidResult.NativeFieldInfoPtr_m_failureArgumentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, "m_failureArgumentName");
				Guid.GuidResult.NativeFieldInfoPtr_m_innerException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, "m_innerException");
				Guid.GuidResult.NativeMethodInfoPtr_Init_Internal_Void_GuidParseThrowStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, 100665446);
				Guid.GuidResult.NativeMethodInfoPtr_SetFailure_Internal_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, 100665447);
				Guid.GuidResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, 100665448);
				Guid.GuidResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, 100665449);
				Guid.GuidResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, 100665450);
				Guid.GuidResult.NativeMethodInfoPtr_GetGuidParseException_Internal_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, 100665451);
			}

			// Token: 0x06004F0E RID: 20238 RVA: 0x00163F68 File Offset: 0x00162168
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 285734, RefRangeEnd = 285737, XrefRangeStart = 285730, XrefRangeEnd = 285734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(Guid.GuidParseThrowStyle canThrow)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref canThrow;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.GuidResult.NativeMethodInfoPtr_Init_Internal_Void_GuidParseThrowStyle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F0F RID: 20239 RVA: 0x00163FAC File Offset: 0x001621AC
			[CallerCount(0)]
			public unsafe void SetFailure(Exception nativeException)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nativeException);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.GuidResult.NativeMethodInfoPtr_SetFailure_Internal_Void_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F10 RID: 20240 RVA: 0x00163FF4 File Offset: 0x001621F4
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 285737, RefRangeEnd = 285742, XrefRangeStart = 285737, XrefRangeEnd = 285737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetFailure(Guid.ParseFailureKind failure, string failureMessageID)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref failure;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failureMessageID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.GuidResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F11 RID: 20241 RVA: 0x0016404C File Offset: 0x0016224C
			[CallerCount(0)]
			public unsafe void SetFailure(Guid.ParseFailureKind failure, string failureMessageID, Object failureMessageFormatArgument)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref failure;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failureMessageID);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(failureMessageFormatArgument);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.GuidResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F12 RID: 20242 RVA: 0x001640B4 File Offset: 0x001622B4
			[CallerCount(0)]
			public unsafe void SetFailure(Guid.ParseFailureKind failure, string failureMessageID, Object failureMessageFormatArgument, string failureArgumentName, Exception innerException)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref failure;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failureMessageID);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(failureMessageFormatArgument);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failureArgumentName);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.GuidResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_String_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F13 RID: 20243 RVA: 0x00164144 File Offset: 0x00162344
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285742, XrefRangeEnd = 285751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Exception GetGuidParseException()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.GuidResult.NativeMethodInfoPtr_GetGuidParseException_Internal_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}

			// Token: 0x06004F14 RID: 20244 RVA: 0x0001DEBB File Offset: 0x0001C0BB
			public GuidResult(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004F15 RID: 20245 RVA: 0x0001DEC4 File Offset: 0x0001C0C4
			public GuidResult()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr))
			{
			}

			// Token: 0x17001414 RID: 5140
			// (get) Token: 0x06004F16 RID: 20246 RVA: 0x00164188 File Offset: 0x00162388
			// (set) Token: 0x06004F17 RID: 20247 RVA: 0x0001DED6 File Offset: 0x0001C0D6
			public unsafe Guid parsedGuid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_parsedGuid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_parsedGuid)) = value;
				}
			}

			// Token: 0x17001415 RID: 5141
			// (get) Token: 0x06004F18 RID: 20248 RVA: 0x001641B0 File Offset: 0x001623B0
			// (set) Token: 0x06004F19 RID: 20249 RVA: 0x0001DEF1 File Offset: 0x0001C0F1
			public unsafe Guid.GuidParseThrowStyle throwStyle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_throwStyle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_throwStyle)) = value;
				}
			}

			// Token: 0x17001416 RID: 5142
			// (get) Token: 0x06004F1A RID: 20250 RVA: 0x001641D8 File Offset: 0x001623D8
			// (set) Token: 0x06004F1B RID: 20251 RVA: 0x0001DF0C File Offset: 0x0001C10C
			public unsafe Guid.ParseFailureKind m_failure
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_m_failure);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_m_failure)) = value;
				}
			}

			// Token: 0x17001417 RID: 5143
			// (get) Token: 0x06004F1C RID: 20252 RVA: 0x00164200 File Offset: 0x00162400
			// (set) Token: 0x06004F1D RID: 20253 RVA: 0x0001DF27 File Offset: 0x0001C127
			public unsafe string m_failureMessageID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_m_failureMessageID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_m_failureMessageID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001418 RID: 5144
			// (get) Token: 0x06004F1E RID: 20254 RVA: 0x00164228 File Offset: 0x00162428
			// (set) Token: 0x06004F1F RID: 20255 RVA: 0x0001DF46 File Offset: 0x0001C146
			public unsafe Object m_failureMessageFormatArgument
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_m_failureMessageFormatArgument);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_m_failureMessageFormatArgument), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001419 RID: 5145
			// (get) Token: 0x06004F20 RID: 20256 RVA: 0x00164258 File Offset: 0x00162458
			// (set) Token: 0x06004F21 RID: 20257 RVA: 0x0001DF65 File Offset: 0x0001C165
			public unsafe string m_failureArgumentName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_m_failureArgumentName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_m_failureArgumentName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700141A RID: 5146
			// (get) Token: 0x06004F22 RID: 20258 RVA: 0x00164280 File Offset: 0x00162480
			// (set) Token: 0x06004F23 RID: 20259 RVA: 0x0001DF84 File Offset: 0x0001C184
			public unsafe Exception m_innerException
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_m_innerException);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr_m_innerException), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004022 RID: 16418
			private static readonly IntPtr NativeFieldInfoPtr_parsedGuid;

			// Token: 0x04004023 RID: 16419
			private static readonly IntPtr NativeFieldInfoPtr_throwStyle;

			// Token: 0x04004024 RID: 16420
			private static readonly IntPtr NativeFieldInfoPtr_m_failure;

			// Token: 0x04004025 RID: 16421
			private static readonly IntPtr NativeFieldInfoPtr_m_failureMessageID;

			// Token: 0x04004026 RID: 16422
			private static readonly IntPtr NativeFieldInfoPtr_m_failureMessageFormatArgument;

			// Token: 0x04004027 RID: 16423
			private static readonly IntPtr NativeFieldInfoPtr_m_failureArgumentName;

			// Token: 0x04004028 RID: 16424
			private static readonly IntPtr NativeFieldInfoPtr_m_innerException;

			// Token: 0x04004029 RID: 16425
			private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_GuidParseThrowStyle_0;

			// Token: 0x0400402A RID: 16426
			private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_Exception_0;

			// Token: 0x0400402B RID: 16427
			private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0;

			// Token: 0x0400402C RID: 16428
			private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0;

			// Token: 0x0400402D RID: 16429
			private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_String_Exception_0;

			// Token: 0x0400402E RID: 16430
			private static readonly IntPtr NativeMethodInfoPtr_GetGuidParseException_Internal_Exception_0;
		}
	}
}
