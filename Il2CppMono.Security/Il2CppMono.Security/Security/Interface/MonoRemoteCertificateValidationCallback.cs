using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x02000023 RID: 35
	public sealed class MonoRemoteCertificateValidationCallback : MulticastDelegate
	{
		// Token: 0x060001B4 RID: 436 RVA: 0x00009E7C File Offset: 0x0000807C
		// Note: this type is marked as 'beforefieldinit'.
		static MonoRemoteCertificateValidationCallback()
		{
			Il2CppClassPointerStore<MonoRemoteCertificateValidationCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Interface", "MonoRemoteCertificateValidationCallback");
			MonoRemoteCertificateValidationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoRemoteCertificateValidationCallback>.NativeClassPtr, 100663529);
			MonoRemoteCertificateValidationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_String_X509Certificate_X509Chain_MonoSslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoRemoteCertificateValidationCallback>.NativeClassPtr, 100663530);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00009ECC File Offset: 0x000080CC
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 9068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoRemoteCertificateValidationCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoRemoteCertificateValidationCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoRemoteCertificateValidationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00009F28 File Offset: 0x00008128
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 10203, RefRangeEnd = 10207, XrefRangeStart = 10203, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Invoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certificate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chain);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sslPolicyErrors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoRemoteCertificateValidationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_String_X509Certificate_X509Chain_MonoSslPolicyErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002BBD File Offset: 0x00000DBD
		public MonoRemoteCertificateValidationCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002BC6 File Offset: 0x00000DC6
		public static implicit operator MonoRemoteCertificateValidationCallback(Func<string, X509Certificate, X509Chain, MonoSslPolicyErrors, bool> A_0)
		{
			return DelegateSupport.ConvertDelegate<MonoRemoteCertificateValidationCallback>(A_0);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002BCE File Offset: 0x00000DCE
		public static MonoRemoteCertificateValidationCallback operator +(MonoRemoteCertificateValidationCallback A_0, MonoRemoteCertificateValidationCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<MonoRemoteCertificateValidationCallback>();
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002BDC File Offset: 0x00000DDC
		public static MonoRemoteCertificateValidationCallback operator -(MonoRemoteCertificateValidationCallback A_0, MonoRemoteCertificateValidationCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<MonoRemoteCertificateValidationCallback>();
			}
			return delegate2;
		}

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_String_X509Certificate_X509Chain_MonoSslPolicyErrors_0;
	}
}
