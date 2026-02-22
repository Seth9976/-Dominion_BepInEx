using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x0200009C RID: 156
	public static class X509Helper2 : Object
	{
		// Token: 0x0600093C RID: 2364 RVA: 0x00032318 File Offset: 0x00030518
		// Note: this type is marked as 'beforefieldinit'.
		static X509Helper2()
		{
			Il2CppClassPointerStore<X509Helper2>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509Helper2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr);
			X509Helper2.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr, 100664488);
			X509Helper2.NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509CertificateImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr, 100664489);
			X509Helper2.NativeMethodInfoPtr_Import_Internal_Static_X509Certificate2Impl_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr, 100664490);
			X509Helper2.NativeMethodInfoPtr_CreateChainImpl_Internal_Static_X509ChainImpl_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr, 100664491);
			X509Helper2.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_X509ChainImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr, 100664492);
			X509Helper2.NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509ChainImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr, 100664493);
			X509Helper2.NativeMethodInfoPtr_GetInvalidChainContextException_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr, 100664494);
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x000323D4 File Offset: 0x000305D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42851, RefRangeEnd = 42852, XrefRangeStart = 42846, XrefRangeEnd = 42851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper2.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x000323FC File Offset: 0x000305FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42852, XrefRangeEnd = 42853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowIfContextInvalid(X509CertificateImpl impl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper2.NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509CertificateImpl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00032434 File Offset: 0x00030634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42853, XrefRangeEnd = 42857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509Certificate2Impl Import(Il2CppStructArray<byte> rawData, string password, X509KeyStorageFlags keyStorageFlags, bool disableProvider = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyStorageFlags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref disableProvider;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper2.NativeMethodInfoPtr_Import_Internal_Static_X509Certificate2Impl_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2Impl>(intPtr3) : null;
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x000324A8 File Offset: 0x000306A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42857, XrefRangeEnd = 42874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509ChainImpl CreateChainImpl(bool useMachineContext)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useMachineContext;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper2.NativeMethodInfoPtr_CreateChainImpl_Internal_Static_X509ChainImpl_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ChainImpl>(intPtr3) : null;
			}
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x000324E8 File Offset: 0x000306E8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 42874, RefRangeEnd = 42880, XrefRangeStart = 42874, XrefRangeEnd = 42874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid(X509ChainImpl impl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper2.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_X509ChainImpl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0003252C File Offset: 0x0003072C
		[CallerCount(0)]
		public unsafe static void ThrowIfContextInvalid(X509ChainImpl impl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper2.NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509ChainImpl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00032564 File Offset: 0x00030764
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 42887, RefRangeEnd = 42889, XrefRangeStart = 42880, XrefRangeEnd = 42887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetInvalidChainContextException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper2.NativeMethodInfoPtr_GetInvalidChainContextException_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00005C69 File Offset: 0x00003E69
		public X509Helper2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509CertificateImpl_0;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeMethodInfoPtr_Import_Internal_Static_X509Certificate2Impl_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_Boolean_0;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeMethodInfoPtr_CreateChainImpl_Internal_Static_X509ChainImpl_Boolean_0;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_X509ChainImpl_0;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509ChainImpl_0;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeMethodInfoPtr_GetInvalidChainContextException_Internal_Static_Exception_0;

		// Token: 0x02000195 RID: 405
		public class MyNativeHelper : Object
		{
			// Token: 0x06001758 RID: 5976 RVA: 0x0000C584 File Offset: 0x0000A784
			// Note: this type is marked as 'beforefieldinit'.
			static MyNativeHelper()
			{
				Il2CppClassPointerStore<X509Helper2.MyNativeHelper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr, "MyNativeHelper");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Helper2.MyNativeHelper>.NativeClassPtr);
				X509Helper2.MyNativeHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper2.MyNativeHelper>.NativeClassPtr, 100664495);
			}

			// Token: 0x06001759 RID: 5977 RVA: 0x0006519C File Offset: 0x0006339C
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MyNativeHelper()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Helper2.MyNativeHelper>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper2.MyNativeHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600175A RID: 5978 RVA: 0x0000C5B8 File Offset: 0x0000A7B8
			public MyNativeHelper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040012AB RID: 4779
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
