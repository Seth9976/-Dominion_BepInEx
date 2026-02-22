using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppSystem.Net.Security
{
	// Token: 0x02000135 RID: 309
	public sealed class RemoteCertificateValidationCallback : MulticastDelegate
	{
		// Token: 0x060014A6 RID: 5286 RVA: 0x0005E44C File Offset: 0x0005C64C
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteCertificateValidationCallback()
		{
			Il2CppClassPointerStore<RemoteCertificateValidationCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Security", "RemoteCertificateValidationCallback");
			RemoteCertificateValidationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteCertificateValidationCallback>.NativeClassPtr, 100666196);
			RemoteCertificateValidationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteCertificateValidationCallback>.NativeClassPtr, 100666197);
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x0005E49C File Offset: 0x0005C69C
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemoteCertificateValidationCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteCertificateValidationCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteCertificateValidationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x0005E4F8 File Offset: 0x0005C6F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 10203, RefRangeEnd = 10207, XrefRangeStart = 10203, XrefRangeEnd = 10207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Invoke(Object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certificate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chain);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sslPolicyErrors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteCertificateValidationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x0000A6E7 File Offset: 0x000088E7
		public RemoteCertificateValidationCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x0000A6F0 File Offset: 0x000088F0
		public static implicit operator RemoteCertificateValidationCallback(Func<Object, X509Certificate, X509Chain, SslPolicyErrors, bool> A_0)
		{
			return DelegateSupport.ConvertDelegate<RemoteCertificateValidationCallback>(A_0);
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x0000A6F8 File Offset: 0x000088F8
		public static RemoteCertificateValidationCallback operator +(RemoteCertificateValidationCallback A_0, RemoteCertificateValidationCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<RemoteCertificateValidationCallback>();
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x0000A706 File Offset: 0x00008906
		public static RemoteCertificateValidationCallback operator -(RemoteCertificateValidationCallback A_0, RemoteCertificateValidationCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<RemoteCertificateValidationCallback>();
			}
			return delegate2;
		}

		// Token: 0x040010B2 RID: 4274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040010B3 RID: 4275
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0;
	}
}
