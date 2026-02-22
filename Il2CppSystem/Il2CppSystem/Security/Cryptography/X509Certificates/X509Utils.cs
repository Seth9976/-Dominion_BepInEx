using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x02000087 RID: 135
	public class X509Utils : Object
	{
		// Token: 0x06000811 RID: 2065 RVA: 0x0002E114 File Offset: 0x0002C314
		// Note: this type is marked as 'beforefieldinit'.
		static X509Utils()
		{
			Il2CppClassPointerStore<X509Utils>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509Utils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Utils>.NativeClassPtr);
			X509Utils.NativeMethodInfoPtr_FindOidInfo_Internal_Static_String_UInt32_String_OidGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Utils>.NativeClassPtr, 100664342);
			X509Utils.NativeMethodInfoPtr_FindOidInfoWithFallback_Internal_Static_String_UInt32_String_OidGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Utils>.NativeClassPtr, 100664343);
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x0002E16C File Offset: 0x0002C36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41798, XrefRangeEnd = 41799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FindOidInfo(uint keyType, string keyValue, OidGroup oidGroup)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keyValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oidGroup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Utils.NativeMethodInfoPtr_FindOidInfo_Internal_Static_String_UInt32_String_OidGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x0002E1C4 File Offset: 0x0002C3C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 41802, RefRangeEnd = 41806, XrefRangeStart = 41799, XrefRangeEnd = 41802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FindOidInfoWithFallback(uint key, string value, OidGroup group)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref group;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Utils.NativeMethodInfoPtr_FindOidInfoWithFallback_Internal_Static_String_UInt32_String_OidGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00005467 File Offset: 0x00003667
		public X509Utils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeMethodInfoPtr_FindOidInfo_Internal_Static_String_UInt32_String_OidGroup_0;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeMethodInfoPtr_FindOidInfoWithFallback_Internal_Static_String_UInt32_String_OidGroup_0;
	}
}
