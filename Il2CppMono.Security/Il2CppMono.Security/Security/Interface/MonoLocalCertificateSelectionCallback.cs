using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x02000024 RID: 36
	public sealed class MonoLocalCertificateSelectionCallback : MulticastDelegate
	{
		// Token: 0x060001BB RID: 443 RVA: 0x00009FA8 File Offset: 0x000081A8
		// Note: this type is marked as 'beforefieldinit'.
		static MonoLocalCertificateSelectionCallback()
		{
			Il2CppClassPointerStore<MonoLocalCertificateSelectionCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Interface", "MonoLocalCertificateSelectionCallback");
			MonoLocalCertificateSelectionCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoLocalCertificateSelectionCallback>.NativeClassPtr, 100663531);
			MonoLocalCertificateSelectionCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoLocalCertificateSelectionCallback>.NativeClassPtr, 100663532);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00009FF8 File Offset: 0x000081F8
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoLocalCertificateSelectionCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoLocalCertificateSelectionCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoLocalCertificateSelectionCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000A054 File Offset: 0x00008254
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 10207, RefRangeEnd = 10209, XrefRangeStart = 10207, XrefRangeEnd = 10207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, Il2CppStringArray acceptableIssuers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localCertificates);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteCertificate);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(acceptableIssuers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoLocalCertificateSelectionCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002BED File Offset: 0x00000DED
		public MonoLocalCertificateSelectionCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002BF6 File Offset: 0x00000DF6
		public static implicit operator MonoLocalCertificateSelectionCallback(Func<string, X509CertificateCollection, X509Certificate, Il2CppStringArray, X509Certificate> A_0)
		{
			return DelegateSupport.ConvertDelegate<MonoLocalCertificateSelectionCallback>(A_0);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002BFE File Offset: 0x00000DFE
		public static MonoLocalCertificateSelectionCallback operator +(MonoLocalCertificateSelectionCallback A_0, MonoLocalCertificateSelectionCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<MonoLocalCertificateSelectionCallback>();
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002C0C File Offset: 0x00000E0C
		public static MonoLocalCertificateSelectionCallback operator -(MonoLocalCertificateSelectionCallback A_0, MonoLocalCertificateSelectionCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<MonoLocalCertificateSelectionCallback>();
			}
			return delegate2;
		}

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0;
	}
}
