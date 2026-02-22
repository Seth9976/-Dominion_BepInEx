using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.Net;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Net.Security
{
	// Token: 0x02000022 RID: 34
	public sealed class ServerCertValidationCallbackWrapper : MulticastDelegate
	{
		// Token: 0x06000171 RID: 369 RVA: 0x00015ED0 File Offset: 0x000140D0
		// Note: this type is marked as 'beforefieldinit'.
		static ServerCertValidationCallbackWrapper()
		{
			Il2CppClassPointerStore<ServerCertValidationCallbackWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "ServerCertValidationCallbackWrapper");
			ServerCertValidationCallbackWrapper.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerCertValidationCallbackWrapper>.NativeClassPtr, 100663565);
			ServerCertValidationCallbackWrapper.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_ServerCertValidationCallback_X509Certificate_X509Chain_MonoSslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerCertValidationCallbackWrapper>.NativeClassPtr, 100663566);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00015F20 File Offset: 0x00014120
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerCertValidationCallbackWrapper(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerCertValidationCallbackWrapper>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerCertValidationCallbackWrapper.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00015F7C File Offset: 0x0001417C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 10203, RefRangeEnd = 10207, XrefRangeStart = 10203, XrefRangeEnd = 10207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Invoke(ServerCertValidationCallback callback, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certificate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chain);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sslPolicyErrors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerCertValidationCallbackWrapper.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_ServerCertValidationCallback_X509Certificate_X509Chain_MonoSslPolicyErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002804 File Offset: 0x00000A04
		public ServerCertValidationCallbackWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000280D File Offset: 0x00000A0D
		public static implicit operator ServerCertValidationCallbackWrapper(Func<ServerCertValidationCallback, X509Certificate, X509Chain, MonoSslPolicyErrors, bool> A_0)
		{
			return DelegateSupport.ConvertDelegate<ServerCertValidationCallbackWrapper>(A_0);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002815 File Offset: 0x00000A15
		public static ServerCertValidationCallbackWrapper operator +(ServerCertValidationCallbackWrapper A_0, ServerCertValidationCallbackWrapper A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ServerCertValidationCallbackWrapper>();
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002823 File Offset: 0x00000A23
		public static ServerCertValidationCallbackWrapper operator -(ServerCertValidationCallbackWrapper A_0, ServerCertValidationCallbackWrapper A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ServerCertValidationCallbackWrapper>();
			}
			return delegate2;
		}

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_ServerCertValidationCallback_X509Certificate_X509Chain_MonoSslPolicyErrors_0;
	}
}
