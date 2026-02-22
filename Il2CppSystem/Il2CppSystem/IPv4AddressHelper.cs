using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200003B RID: 59
	public static class IPv4AddressHelper : Object
	{
		// Token: 0x0600039C RID: 924 RVA: 0x0001F070 File Offset: 0x0001D270
		// Note: this type is marked as 'beforefieldinit'.
		static IPv4AddressHelper()
		{
			Il2CppClassPointerStore<IPv4AddressHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "IPv4AddressHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPv4AddressHelper>.NativeClassPtr);
			IPv4AddressHelper.NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv4AddressHelper>.NativeClassPtr, 100663870);
			IPv4AddressHelper.NativeMethodInfoPtr_ParseHostNumber_Internal_Static_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv4AddressHelper>.NativeClassPtr, 100663871);
			IPv4AddressHelper.NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv4AddressHelper>.NativeClassPtr, 100663872);
			IPv4AddressHelper.NativeMethodInfoPtr_IsValidCanonical_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv4AddressHelper>.NativeClassPtr, 100663873);
			IPv4AddressHelper.NativeMethodInfoPtr_ParseNonCanonical_Internal_Static_Int64_ptr_Char_Int32_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv4AddressHelper>.NativeClassPtr, 100663874);
			IPv4AddressHelper.NativeMethodInfoPtr_Parse_Private_Static_Boolean_String_ptr_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv4AddressHelper>.NativeClassPtr, 100663875);
			IPv4AddressHelper.NativeMethodInfoPtr_ParseCanonical_Private_Static_Boolean_String_ptr_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv4AddressHelper>.NativeClassPtr, 100663876);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0001F12C File Offset: 0x0001D32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36912, XrefRangeEnd = 36941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ParseCanonicalName(string str, int start, int end, ref bool isLoopback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isLoopback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv4AddressHelper.NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_Int32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0001F194 File Offset: 0x0001D394
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36942, RefRangeEnd = 36943, XrefRangeStart = 36941, XrefRangeEnd = 36942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParseHostNumber(string str, int start, int end)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv4AddressHelper.NativeMethodInfoPtr_ParseHostNumber_Internal_Static_Int32_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0001F1F4 File Offset: 0x0001D3F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36944, RefRangeEnd = 36946, XrefRangeStart = 36943, XrefRangeEnd = 36944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowIPv6;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notImplicitFile;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unknownScheme;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv4AddressHelper.NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_Boolean_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0001F278 File Offset: 0x0001D478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36946, XrefRangeEnd = 36948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidCanonical(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowIPv6;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notImplicitFile;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv4AddressHelper.NativeMethodInfoPtr_IsValidCanonical_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0001F2EC File Offset: 0x0001D4EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 36954, RefRangeEnd = 36958, XrefRangeStart = 36948, XrefRangeEnd = 36954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ParseNonCanonical(char* name, int start, ref int end, bool notImplicitFile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notImplicitFile;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv4AddressHelper.NativeMethodInfoPtr_ParseNonCanonical_Internal_Static_Int64_ptr_Char_Int32_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0001F354 File Offset: 0x0001D554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36958, XrefRangeEnd = 36960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Parse(string name, byte* numbers, int start, int end)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = numbers;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv4AddressHelper.NativeMethodInfoPtr_Parse_Private_Static_Boolean_String_ptr_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0001F3C0 File Offset: 0x0001D5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36960, XrefRangeEnd = 36961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseCanonical(string name, byte* numbers, int start, int end)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = numbers;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv4AddressHelper.NativeMethodInfoPtr_ParseCanonical_Private_Static_Boolean_String_ptr_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00003414 File Offset: 0x00001614
		public IPv4AddressHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_Int32_byref_Boolean_0;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeMethodInfoPtr_ParseHostNumber_Internal_Static_Int32_String_Int32_Int32_0;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_Boolean_Boolean_Boolean_0;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeMethodInfoPtr_IsValidCanonical_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_Boolean_Boolean_0;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr_ParseNonCanonical_Internal_Static_Int64_ptr_Char_Int32_byref_Int32_Boolean_0;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Private_Static_Boolean_String_ptr_Byte_Int32_Int32_0;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeMethodInfoPtr_ParseCanonical_Private_Static_Boolean_String_ptr_Byte_Int32_Int32_0;
	}
}
