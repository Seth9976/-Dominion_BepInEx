using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200003A RID: 58
	public class DomainNameHelper : Object
	{
		// Token: 0x0600038F RID: 911 RVA: 0x0001EB14 File Offset: 0x0001CD14
		// Note: this type is marked as 'beforefieldinit'.
		static DomainNameHelper()
		{
			Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "DomainNameHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr);
			DomainNameHelper.NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100663859);
			DomainNameHelper.NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100663860);
			DomainNameHelper.NativeMethodInfoPtr_IsValidByIri_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100663861);
			DomainNameHelper.NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100663862);
			DomainNameHelper.NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100663863);
			DomainNameHelper.NativeMethodInfoPtr_IsIdnAce_Private_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100663864);
			DomainNameHelper.NativeMethodInfoPtr_IsIdnAce_Private_Static_Boolean_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100663865);
			DomainNameHelper.NativeMethodInfoPtr_UnicodeEquivalent_Internal_Static_String_String_ptr_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100663866);
			DomainNameHelper.NativeMethodInfoPtr_UnicodeEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100663867);
			DomainNameHelper.NativeMethodInfoPtr_IsASCIILetterOrDigit_Private_Static_Boolean_Char_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100663868);
			DomainNameHelper.NativeMethodInfoPtr_IsValidDomainLabelCharacter_Private_Static_Boolean_Char_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100663869);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0001EC20 File Offset: 0x0001CE20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36840, RefRangeEnd = 36841, XrefRangeStart = 36823, XrefRangeEnd = 36840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ParseCanonicalName(string str, int start, int end, ref bool loopback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &loopback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_Int32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0001EC88 File Offset: 0x0001CE88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36842, RefRangeEnd = 36843, XrefRangeStart = 36841, XrefRangeEnd = 36842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &returnedEnd;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &notCanonical;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notImplicitFile;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_byref_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0001ECFC File Offset: 0x0001CEFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36846, RefRangeEnd = 36847, XrefRangeStart = 36843, XrefRangeEnd = 36846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidByIri(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &returnedEnd;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &notCanonical;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notImplicitFile;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_IsValidByIri_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_byref_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0001ED70 File Offset: 0x0001CF70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36849, RefRangeEnd = 36850, XrefRangeStart = 36847, XrefRangeEnd = 36849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = hostname;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &allAscii;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &atLeastOneValidIdn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0001EDE0 File Offset: 0x0001CFE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36863, RefRangeEnd = 36865, XrefRangeStart = 36850, XrefRangeEnd = 36863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = hostname;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &allAscii;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(bidiStrippedHost);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			bidiStrippedHost = IL2CPP.Il2CppStringToManaged(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0001EE64 File Offset: 0x0001D064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36865, XrefRangeEnd = 36869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsIdnAce(string input, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_IsIdnAce_Private_Static_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0001EEB4 File Offset: 0x0001D0B4
		[CallerCount(0)]
		public unsafe static bool IsIdnAce(char* input, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_IsIdnAce_Private_Static_Boolean_ptr_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0001EF00 File Offset: 0x0001D100
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36874, RefRangeEnd = 36875, XrefRangeStart = 36869, XrefRangeEnd = 36874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UnicodeEquivalent(string idnHost, char* hostname, int start, int end)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(idnHost);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = hostname;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_UnicodeEquivalent_Internal_Static_String_String_ptr_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0001EF68 File Offset: 0x0001D168
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 36908, RefRangeEnd = 36911, XrefRangeStart = 36875, XrefRangeEnd = 36908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UnicodeEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = hostname;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &allAscii;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &atLeastOneValidIdn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_UnicodeEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0001EFD8 File Offset: 0x0001D1D8
		[CallerCount(0)]
		public unsafe static bool IsASCIILetterOrDigit(char character, ref bool notCanonical)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref character;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &notCanonical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_IsASCIILetterOrDigit_Private_Static_Boolean_Char_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0001F024 File Offset: 0x0001D224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36911, RefRangeEnd = 36912, XrefRangeStart = 36911, XrefRangeEnd = 36911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidDomainLabelCharacter(char character, ref bool notCanonical)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref character;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &notCanonical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_IsValidDomainLabelCharacter_Private_Static_Boolean_Char_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000340B File Offset: 0x0000160B
		public DomainNameHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_Int32_byref_Boolean_0;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_byref_Boolean_Boolean_0;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_IsValidByIri_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_byref_Boolean_Boolean_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_Boolean_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_String_0;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_IsIdnAce_Private_Static_Boolean_String_Int32_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr_IsIdnAce_Private_Static_Boolean_ptr_Char_Int32_0;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeMethodInfoPtr_UnicodeEquivalent_Internal_Static_String_String_ptr_Char_Int32_Int32_0;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeMethodInfoPtr_UnicodeEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_Boolean_0;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeMethodInfoPtr_IsASCIILetterOrDigit_Private_Static_Boolean_Char_byref_Boolean_0;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeMethodInfoPtr_IsValidDomainLabelCharacter_Private_Static_Boolean_Char_byref_Boolean_0;
	}
}
