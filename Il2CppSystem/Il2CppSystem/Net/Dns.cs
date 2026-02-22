using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x02000105 RID: 261
	public static class Dns : Object
	{
		// Token: 0x06000F3E RID: 3902 RVA: 0x0004992C File Offset: 0x00047B2C
		// Note: this type is marked as 'beforefieldinit'.
		static Dns()
		{
			Il2CppClassPointerStore<Dns>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "Dns");
			Dns.NativeMethodInfoPtr_GetHostByName_internal_Private_Static_Boolean_String_byref_String_byref_Il2CppStringArray_byref_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100665422);
			Dns.NativeMethodInfoPtr_GetHostByAddr_internal_Private_Static_Boolean_String_byref_String_byref_Il2CppStringArray_byref_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100665423);
			Dns.NativeMethodInfoPtr_GetHostName_internal_Private_Static_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100665424);
			Dns.NativeMethodInfoPtr_Error_11001_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100665425);
			Dns.NativeMethodInfoPtr_hostent_to_IPHostEntry_Private_Static_IPHostEntry_String_String_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100665426);
			Dns.NativeMethodInfoPtr_GetHostByAddressFromString_Private_Static_IPHostEntry_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100665427);
			Dns.NativeMethodInfoPtr_GetHostEntry_Public_Static_IPHostEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100665428);
			Dns.NativeMethodInfoPtr_GetHostEntry_Public_Static_IPHostEntry_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100665429);
			Dns.NativeMethodInfoPtr_GetHostByName_Public_Static_IPHostEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100665430);
			Dns.NativeMethodInfoPtr_GetHostName_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100665431);
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x00049A1C File Offset: 0x00047C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50148, XrefRangeEnd = 50149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetHostByName_internal(string host, out string h_name, out Il2CppStringArray h_aliases, out Il2CppStringArray h_addr_list, int hint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hint;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostByName_internal_Private_Static_Boolean_String_byref_String_byref_Il2CppStringArray_byref_Il2CppStringArray_Int32_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			h_name = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr6 = intPtr2;
			h_aliases = ((intPtr6 == 0) ? null : new Il2CppStringArray(intPtr6));
			IntPtr intPtr7 = intPtr3;
			h_addr_list = ((intPtr7 == 0) ? null : new Il2CppStringArray(intPtr7));
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x00049ACC File Offset: 0x00047CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50149, XrefRangeEnd = 50150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetHostByAddr_internal(string addr, out string h_name, out Il2CppStringArray h_aliases, out Il2CppStringArray h_addr_list, int hint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(addr);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hint;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostByAddr_internal_Private_Static_Boolean_String_byref_String_byref_Il2CppStringArray_byref_Il2CppStringArray_Int32_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			h_name = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr6 = intPtr2;
			h_aliases = ((intPtr6 == 0) ? null : new Il2CppStringArray(intPtr6));
			IntPtr intPtr7 = intPtr3;
			h_addr_list = ((intPtr7 == 0) ? null : new Il2CppStringArray(intPtr7));
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x00049B7C File Offset: 0x00047D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50150, XrefRangeEnd = 50151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetHostName_internal(out string h_name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostName_internal_Private_Static_Boolean_byref_String_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				h_name = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00049BC8 File Offset: 0x00047DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50151, XrefRangeEnd = 50158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Error_11001(string hostName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hostName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_Error_11001_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x00049C00 File Offset: 0x00047E00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 50188, RefRangeEnd = 50192, XrefRangeStart = 50158, XrefRangeEnd = 50188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, Il2CppStringArray h_aliases, Il2CppStringArray h_addrlist)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(originalHostName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(h_name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(h_aliases);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(h_addrlist);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_hostent_to_IPHostEntry_Private_Static_IPHostEntry_String_String_Il2CppStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr3) : null;
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x00049C7C File Offset: 0x00047E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50192, XrefRangeEnd = 50208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPHostEntry GetHostByAddressFromString(string address, bool parse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostByAddressFromString_Private_Static_IPHostEntry_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr3) : null;
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x00049CD0 File Offset: 0x00047ED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50230, RefRangeEnd = 50231, XrefRangeStart = 50208, XrefRangeEnd = 50230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPHostEntry GetHostEntry(string hostNameOrAddress)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hostNameOrAddress);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostEntry_Public_Static_IPHostEntry_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x00049D14 File Offset: 0x00047F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50231, XrefRangeEnd = 50243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPHostEntry GetHostEntry(IPAddress address)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostEntry_Public_Static_IPHostEntry_IPAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x00049D58 File Offset: 0x00047F58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 50249, RefRangeEnd = 50251, XrefRangeStart = 50243, XrefRangeEnd = 50249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPHostEntry GetHostByName(string hostName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hostName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostByName_Public_Static_IPHostEntry_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x00049D9C File Offset: 0x00047F9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 50252, RefRangeEnd = 50254, XrefRangeStart = 50251, XrefRangeEnd = 50252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetHostName()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostName_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00008041 File Offset: 0x00006241
		public Dns(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BED RID: 3053
		private static readonly IntPtr NativeMethodInfoPtr_GetHostByName_internal_Private_Static_Boolean_String_byref_String_byref_Il2CppStringArray_byref_Il2CppStringArray_Int32_0;

		// Token: 0x04000BEE RID: 3054
		private static readonly IntPtr NativeMethodInfoPtr_GetHostByAddr_internal_Private_Static_Boolean_String_byref_String_byref_Il2CppStringArray_byref_Il2CppStringArray_Int32_0;

		// Token: 0x04000BEF RID: 3055
		private static readonly IntPtr NativeMethodInfoPtr_GetHostName_internal_Private_Static_Boolean_byref_String_0;

		// Token: 0x04000BF0 RID: 3056
		private static readonly IntPtr NativeMethodInfoPtr_Error_11001_Private_Static_Void_String_0;

		// Token: 0x04000BF1 RID: 3057
		private static readonly IntPtr NativeMethodInfoPtr_hostent_to_IPHostEntry_Private_Static_IPHostEntry_String_String_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x04000BF2 RID: 3058
		private static readonly IntPtr NativeMethodInfoPtr_GetHostByAddressFromString_Private_Static_IPHostEntry_String_Boolean_0;

		// Token: 0x04000BF3 RID: 3059
		private static readonly IntPtr NativeMethodInfoPtr_GetHostEntry_Public_Static_IPHostEntry_String_0;

		// Token: 0x04000BF4 RID: 3060
		private static readonly IntPtr NativeMethodInfoPtr_GetHostEntry_Public_Static_IPHostEntry_IPAddress_0;

		// Token: 0x04000BF5 RID: 3061
		private static readonly IntPtr NativeMethodInfoPtr_GetHostByName_Public_Static_IPHostEntry_String_0;

		// Token: 0x04000BF6 RID: 3062
		private static readonly IntPtr NativeMethodInfoPtr_GetHostName_Public_Static_String_0;
	}
}
