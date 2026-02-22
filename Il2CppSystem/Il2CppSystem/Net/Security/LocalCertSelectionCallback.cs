using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppSystem.Net.Security
{
	// Token: 0x02000137 RID: 311
	public sealed class LocalCertSelectionCallback : MulticastDelegate
	{
		// Token: 0x060014AD RID: 5293 RVA: 0x0005E578 File Offset: 0x0005C778
		// Note: this type is marked as 'beforefieldinit'.
		static LocalCertSelectionCallback()
		{
			Il2CppClassPointerStore<LocalCertSelectionCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Security", "LocalCertSelectionCallback");
			LocalCertSelectionCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalCertSelectionCallback>.NativeClassPtr, 100666198);
			LocalCertSelectionCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalCertSelectionCallback>.NativeClassPtr, 100666199);
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x0005E5C8 File Offset: 0x0005C7C8
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalCertSelectionCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalCertSelectionCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalCertSelectionCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x0005E624 File Offset: 0x0005C824
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 10207, RefRangeEnd = 10209, XrefRangeStart = 10207, XrefRangeEnd = 10209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalCertSelectionCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x0000A717 File Offset: 0x00008917
		public LocalCertSelectionCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x0000A720 File Offset: 0x00008920
		public static implicit operator LocalCertSelectionCallback(Func<string, X509CertificateCollection, X509Certificate, Il2CppStringArray, X509Certificate> A_0)
		{
			return DelegateSupport.ConvertDelegate<LocalCertSelectionCallback>(A_0);
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x0000A728 File Offset: 0x00008928
		public static LocalCertSelectionCallback operator +(LocalCertSelectionCallback A_0, LocalCertSelectionCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<LocalCertSelectionCallback>();
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x0000A736 File Offset: 0x00008936
		public static LocalCertSelectionCallback operator -(LocalCertSelectionCallback A_0, LocalCertSelectionCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<LocalCertSelectionCallback>();
			}
			return delegate2;
		}

		// Token: 0x040010B9 RID: 4281
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040010BA RID: 4282
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0;
	}
}
