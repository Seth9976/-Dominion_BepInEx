using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem
{
	// Token: 0x0200003C RID: 60
	public static class IPv6AddressHelper : Object
	{
		// Token: 0x060003A5 RID: 933 RVA: 0x0001F42C File Offset: 0x0001D62C
		// Note: this type is marked as 'beforefieldinit'.
		static IPv6AddressHelper()
		{
			Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "IPv6AddressHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr);
			IPv6AddressHelper.NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_byref_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100663877);
			IPv6AddressHelper.NativeMethodInfoPtr_CreateCanonicalName_Internal_Static_String_ptr_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100663878);
			IPv6AddressHelper.NativeMethodInfoPtr_FindCompressionRange_Private_Static_KeyValuePair_2_Int32_Int32_ptr_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100663879);
			IPv6AddressHelper.NativeMethodInfoPtr_ShouldHaveIpv4Embedded_Private_Static_Boolean_ptr_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100663880);
			IPv6AddressHelper.NativeMethodInfoPtr_InternalIsValid_Private_Static_Boolean_ptr_Char_Int32_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100663881);
			IPv6AddressHelper.NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100663882);
			IPv6AddressHelper.NativeMethodInfoPtr_IsValidStrict_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100663883);
			IPv6AddressHelper.NativeMethodInfoPtr_Parse_Internal_Static_Boolean_String_ptr_UInt16_Int32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100663884);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0001F4FC File Offset: 0x0001D6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36961, XrefRangeEnd = 36968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isLoopback;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(scopeId);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IPv6AddressHelper.NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_byref_Boolean_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			scopeId = IL2CPP.Il2CppStringToManaged(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0001F578 File Offset: 0x0001D778
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37008, RefRangeEnd = 37009, XrefRangeStart = 36968, XrefRangeEnd = 37008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CreateCanonicalName(ushort* numbers)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = numbers;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressHelper.NativeMethodInfoPtr_CreateCanonicalName_Internal_Static_String_ptr_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0001F5B0 File Offset: 0x0001D7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37009, XrefRangeEnd = 37014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static KeyValuePair<int, int> FindCompressionRange(ushort* numbers)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = numbers;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressHelper.NativeMethodInfoPtr_FindCompressionRange_Private_Static_KeyValuePair_2_Int32_Int32_ptr_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new KeyValuePair<int, int>(intPtr);
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0001F5E8 File Offset: 0x0001D7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37014, XrefRangeEnd = 37015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldHaveIpv4Embedded(ushort* numbers)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = numbers;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressHelper.NativeMethodInfoPtr_ShouldHaveIpv4Embedded_Private_Static_Boolean_ptr_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0001F624 File Offset: 0x0001D824
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 37028, RefRangeEnd = 37030, XrefRangeStart = 37015, XrefRangeEnd = 37028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref validateStrictAddress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressHelper.NativeMethodInfoPtr_InternalIsValid_Private_Static_Boolean_ptr_Char_Int32_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0001F68C File Offset: 0x0001D88C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37031, RefRangeEnd = 37032, XrefRangeStart = 37030, XrefRangeEnd = 37031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid(char* name, int start, ref int end)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressHelper.NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0001F6E4 File Offset: 0x0001D8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37032, XrefRangeEnd = 37033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidStrict(char* name, int start, ref int end)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressHelper.NativeMethodInfoPtr_IsValidStrict_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0001F73C File Offset: 0x0001D93C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37064, RefRangeEnd = 37065, XrefRangeStart = 37033, XrefRangeEnd = 37064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Parse(string address, ushort* numbers, int start, ref string scopeId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = numbers;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(scopeId);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IPv6AddressHelper.NativeMethodInfoPtr_Parse_Internal_Static_Boolean_String_ptr_UInt16_Int32_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			scopeId = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000341D File Offset: 0x0000161D
		public IPv6AddressHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_byref_Boolean_byref_String_0;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeMethodInfoPtr_CreateCanonicalName_Internal_Static_String_ptr_UInt16_0;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr_FindCompressionRange_Private_Static_KeyValuePair_2_Int32_Int32_ptr_UInt16_0;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr_ShouldHaveIpv4Embedded_Private_Static_Boolean_ptr_UInt16_0;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeMethodInfoPtr_InternalIsValid_Private_Static_Boolean_ptr_Char_Int32_byref_Int32_Boolean_0;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_0;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr_IsValidStrict_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_0;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Internal_Static_Boolean_String_ptr_UInt16_Int32_byref_String_0;
	}
}
