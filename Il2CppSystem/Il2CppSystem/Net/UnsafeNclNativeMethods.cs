using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security;

namespace Il2CppSystem.Net
{
	// Token: 0x020000FA RID: 250
	public static class UnsafeNclNativeMethods : Object
	{
		// Token: 0x06000ED6 RID: 3798 RVA: 0x00007D7E File Offset: 0x00005F7E
		// Note: this type is marked as 'beforefieldinit'.
		static UnsafeNclNativeMethods()
		{
			Il2CppClassPointerStore<UnsafeNclNativeMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "UnsafeNclNativeMethods");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeNclNativeMethods>.NativeClassPtr);
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00007DA3 File Offset: 0x00005FA3
		public UnsafeNclNativeMethods(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x020001BB RID: 443
		public static class HttpApi : Object
		{
			// Token: 0x060018D6 RID: 6358 RVA: 0x0000D050 File Offset: 0x0000B250
			// Note: this type is marked as 'beforefieldinit'.
			static HttpApi()
			{
				Il2CppClassPointerStore<UnsafeNclNativeMethods.HttpApi>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeNclNativeMethods>.NativeClassPtr, "HttpApi");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeNclNativeMethods.HttpApi>.NativeClassPtr);
				UnsafeNclNativeMethods.HttpApi.NativeFieldInfoPtr_m_Strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNclNativeMethods.HttpApi>.NativeClassPtr, "m_Strings");
			}

			// Token: 0x060018D7 RID: 6359 RVA: 0x0000D084 File Offset: 0x0000B284
			public HttpApi(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007EE RID: 2030
			// (get) Token: 0x060018D8 RID: 6360 RVA: 0x0006A4AC File Offset: 0x000686AC
			// (set) Token: 0x060018D9 RID: 6361 RVA: 0x0000D08D File Offset: 0x0000B28D
			public unsafe static Il2CppStringArray m_Strings
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UnsafeNclNativeMethods.HttpApi.NativeFieldInfoPtr_m_Strings, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UnsafeNclNativeMethods.HttpApi.NativeFieldInfoPtr_m_Strings, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001398 RID: 5016
			private static readonly IntPtr NativeFieldInfoPtr_m_Strings;

			// Token: 0x0200021F RID: 543
			public static class HTTP_REQUEST_HEADER_ID : Object
			{
				// Token: 0x06001CDA RID: 7386 RVA: 0x00074500 File Offset: 0x00072700
				// Note: this type is marked as 'beforefieldinit'.
				static HTTP_REQUEST_HEADER_ID()
				{
					Il2CppClassPointerStore<UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeNclNativeMethods.HttpApi>.NativeClassPtr, "HTTP_REQUEST_HEADER_ID");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID>.NativeClassPtr);
					UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID.NativeFieldInfoPtr_m_Strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID>.NativeClassPtr, "m_Strings");
					UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID.NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID>.NativeClassPtr, 100665368);
				}

				// Token: 0x06001CDB RID: 7387 RVA: 0x00074554 File Offset: 0x00072754
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 49505, RefRangeEnd = 49506, XrefRangeStart = 49501, XrefRangeEnd = 49505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string ToString(int position)
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref position;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID.NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x06001CDC RID: 7388 RVA: 0x000106A2 File Offset: 0x0000E8A2
				public HTTP_REQUEST_HEADER_ID(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000923 RID: 2339
				// (get) Token: 0x06001CDD RID: 7389 RVA: 0x0007458C File Offset: 0x0007278C
				// (set) Token: 0x06001CDE RID: 7390 RVA: 0x000106AB File Offset: 0x0000E8AB
				public unsafe static Il2CppStringArray m_Strings
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID.NativeFieldInfoPtr_m_Strings, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID.NativeFieldInfoPtr_m_Strings, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040015B7 RID: 5559
				private static readonly IntPtr NativeFieldInfoPtr_m_Strings;

				// Token: 0x040015B8 RID: 5560
				private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0;
			}
		}

		// Token: 0x020001BC RID: 444
		public static class SecureStringHelper : Object
		{
			// Token: 0x060018DA RID: 6362 RVA: 0x0006A4D4 File Offset: 0x000686D4
			// Note: this type is marked as 'beforefieldinit'.
			static SecureStringHelper()
			{
				Il2CppClassPointerStore<UnsafeNclNativeMethods.SecureStringHelper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeNclNativeMethods>.NativeClassPtr, "SecureStringHelper");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeNclNativeMethods.SecureStringHelper>.NativeClassPtr);
				UnsafeNclNativeMethods.SecureStringHelper.NativeMethodInfoPtr_CreateString_Internal_Static_String_SecureString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNclNativeMethods.SecureStringHelper>.NativeClassPtr, 100665370);
				UnsafeNclNativeMethods.SecureStringHelper.NativeMethodInfoPtr_CreateSecureString_Internal_Static_SecureString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNclNativeMethods.SecureStringHelper>.NativeClassPtr, 100665371);
			}

			// Token: 0x060018DB RID: 6363 RVA: 0x0006A528 File Offset: 0x00068728
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 49519, RefRangeEnd = 49522, XrefRangeStart = 49506, XrefRangeEnd = 49519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string CreateString(SecureString secureString)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(secureString);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNclNativeMethods.SecureStringHelper.NativeMethodInfoPtr_CreateString_Internal_Static_String_SecureString_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060018DC RID: 6364 RVA: 0x0006A564 File Offset: 0x00068764
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 49527, RefRangeEnd = 49530, XrefRangeStart = 49522, XrefRangeEnd = 49527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static SecureString CreateSecureString(string plainString)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(plainString);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNclNativeMethods.SecureStringHelper.NativeMethodInfoPtr_CreateSecureString_Internal_Static_SecureString_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecureString>(intPtr3) : null;
				}
			}

			// Token: 0x060018DD RID: 6365 RVA: 0x0000D09F File Offset: 0x0000B29F
			public SecureStringHelper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001399 RID: 5017
			private static readonly IntPtr NativeMethodInfoPtr_CreateString_Internal_Static_String_SecureString_0;

			// Token: 0x0400139A RID: 5018
			private static readonly IntPtr NativeMethodInfoPtr_CreateSecureString_Internal_Static_SecureString_String_0;
		}
	}
}
