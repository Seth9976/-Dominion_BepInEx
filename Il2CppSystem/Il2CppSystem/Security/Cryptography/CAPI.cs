using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200007D RID: 125
	public static class CAPI : Object
	{
		// Token: 0x060007F9 RID: 2041 RVA: 0x0002DA74 File Offset: 0x0002BC74
		// Note: this type is marked as 'beforefieldinit'.
		static CAPI()
		{
			Il2CppClassPointerStore<CAPI>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography", "CAPI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CAPI>.NativeClassPtr);
			CAPI.NativeMethodInfoPtr_CryptFindOIDInfoNameFromKey_Public_Static_String_String_OidGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CAPI>.NativeClassPtr, 100664326);
			CAPI.NativeMethodInfoPtr_CryptFindOIDInfoKeyFromName_Public_Static_String_String_OidGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CAPI>.NativeClassPtr, 100664327);
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x0002DACC File Offset: 0x0002BCCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 41496, RefRangeEnd = 41498, XrefRangeStart = 41424, XrefRangeEnd = 41496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CryptFindOIDInfoNameFromKey(string key, OidGroup oidGroup)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oidGroup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CAPI.NativeMethodInfoPtr_CryptFindOIDInfoNameFromKey_Public_Static_String_String_OidGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x0002DB18 File Offset: 0x0002BD18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41567, RefRangeEnd = 41568, XrefRangeStart = 41498, XrefRangeEnd = 41567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CryptFindOIDInfoKeyFromName(string name, OidGroup oidGroup)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oidGroup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CAPI.NativeMethodInfoPtr_CryptFindOIDInfoKeyFromName_Public_Static_String_String_OidGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00005417 File Offset: 0x00003617
		public CAPI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_CryptFindOIDInfoNameFromKey_Public_Static_String_String_OidGroup_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr_CryptFindOIDInfoKeyFromName_Public_Static_String_String_OidGroup_0;
	}
}
