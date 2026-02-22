using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Security.Cryptography.X509Certificates;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Net
{
	// Token: 0x020000FC RID: 252
	public class ServerCertValidationCallback : Object
	{
		// Token: 0x06000EDC RID: 3804 RVA: 0x00048328 File Offset: 0x00046528
		// Note: this type is marked as 'beforefieldinit'.
		static ServerCertValidationCallback()
		{
			Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ServerCertValidationCallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr);
			ServerCertValidationCallback.NativeFieldInfoPtr_m_ValidationCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr, "m_ValidationCallback");
			ServerCertValidationCallback.NativeFieldInfoPtr_m_Context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr, "m_Context");
			ServerCertValidationCallback.NativeMethodInfoPtr__ctor_Internal_Void_RemoteCertificateValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr, 100665372);
			ServerCertValidationCallback.NativeMethodInfoPtr_Callback_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr, 100665373);
			ServerCertValidationCallback.NativeMethodInfoPtr_Invoke_Internal_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr, 100665374);
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x000483BC File Offset: 0x000465BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49537, RefRangeEnd = 49538, XrefRangeStart = 49532, XrefRangeEnd = 49537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerCertValidationCallback(RemoteCertificateValidationCallback validationCallback)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(validationCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerCertValidationCallback.NativeMethodInfoPtr__ctor_Internal_Void_RemoteCertificateValidationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x00048408 File Offset: 0x00046608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49538, XrefRangeEnd = 49541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Callback(Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerCertValidationCallback.NativeMethodInfoPtr_Callback_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x0004844C File Offset: 0x0004664C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 49556, RefRangeEnd = 49558, XrefRangeStart = 49541, XrefRangeEnd = 49556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Invoke(Object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certificate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chain);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sslPolicyErrors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerCertValidationCallback.NativeMethodInfoPtr_Invoke_Internal_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x00007DFC File Offset: 0x00005FFC
		public ServerCertValidationCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000EE1 RID: 3809 RVA: 0x000484CC File Offset: 0x000466CC
		// (set) Token: 0x06000EE2 RID: 3810 RVA: 0x00007E05 File Offset: 0x00006005
		public unsafe RemoteCertificateValidationCallback m_ValidationCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.NativeFieldInfoPtr_m_ValidationCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RemoteCertificateValidationCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.NativeFieldInfoPtr_m_ValidationCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000EE3 RID: 3811 RVA: 0x000484FC File Offset: 0x000466FC
		// (set) Token: 0x06000EE4 RID: 3812 RVA: 0x00007E24 File Offset: 0x00006024
		public unsafe ExecutionContext m_Context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.NativeFieldInfoPtr_m_Context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.NativeFieldInfoPtr_m_Context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BAB RID: 2987
		private static readonly IntPtr NativeFieldInfoPtr_m_ValidationCallback;

		// Token: 0x04000BAC RID: 2988
		private static readonly IntPtr NativeFieldInfoPtr_m_Context;

		// Token: 0x04000BAD RID: 2989
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_RemoteCertificateValidationCallback_0;

		// Token: 0x04000BAE RID: 2990
		private static readonly IntPtr NativeMethodInfoPtr_Callback_Internal_Void_Object_0;

		// Token: 0x04000BAF RID: 2991
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Internal_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0;

		// Token: 0x020001BD RID: 445
		public class CallbackContext : Object
		{
			// Token: 0x060018DE RID: 6366 RVA: 0x0006A5A8 File Offset: 0x000687A8
			// Note: this type is marked as 'beforefieldinit'.
			static CallbackContext()
			{
				Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr, "CallbackContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr);
				ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr, "request");
				ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_certificate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr, "certificate");
				ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_chain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr, "chain");
				ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_sslPolicyErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr, "sslPolicyErrors");
				ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr, "result");
				ServerCertValidationCallback.CallbackContext.NativeMethodInfoPtr__ctor_Internal_Void_Object_X509Certificate_X509Chain_SslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr, 100665375);
			}

			// Token: 0x060018DF RID: 6367 RVA: 0x0006A64C File Offset: 0x0006884C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49531, RefRangeEnd = 49532, XrefRangeStart = 49530, XrefRangeEnd = 49531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CallbackContext(Object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chain);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sslPolicyErrors;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerCertValidationCallback.CallbackContext.NativeMethodInfoPtr__ctor_Internal_Void_Object_X509Certificate_X509Chain_SslPolicyErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018E0 RID: 6368 RVA: 0x0000D0A8 File Offset: 0x0000B2A8
			public CallbackContext(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007EF RID: 2031
			// (get) Token: 0x060018E1 RID: 6369 RVA: 0x0006A6CC File Offset: 0x000688CC
			// (set) Token: 0x060018E2 RID: 6370 RVA: 0x0000D0B1 File Offset: 0x0000B2B1
			public unsafe Object request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007F0 RID: 2032
			// (get) Token: 0x060018E3 RID: 6371 RVA: 0x0006A6FC File Offset: 0x000688FC
			// (set) Token: 0x060018E4 RID: 6372 RVA: 0x0000D0D0 File Offset: 0x0000B2D0
			public unsafe X509Certificate certificate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_certificate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_certificate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007F1 RID: 2033
			// (get) Token: 0x060018E5 RID: 6373 RVA: 0x0006A72C File Offset: 0x0006892C
			// (set) Token: 0x060018E6 RID: 6374 RVA: 0x0000D0EF File Offset: 0x0000B2EF
			public unsafe X509Chain chain
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_chain);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Chain>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_chain), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007F2 RID: 2034
			// (get) Token: 0x060018E7 RID: 6375 RVA: 0x0006A75C File Offset: 0x0006895C
			// (set) Token: 0x060018E8 RID: 6376 RVA: 0x0000D10E File Offset: 0x0000B30E
			public unsafe SslPolicyErrors sslPolicyErrors
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_sslPolicyErrors);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_sslPolicyErrors)) = value;
				}
			}

			// Token: 0x170007F3 RID: 2035
			// (get) Token: 0x060018E9 RID: 6377 RVA: 0x0006A784 File Offset: 0x00068984
			// (set) Token: 0x060018EA RID: 6378 RVA: 0x0000D129 File Offset: 0x0000B329
			public unsafe bool result
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_result);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_result)) = value;
				}
			}

			// Token: 0x0400139B RID: 5019
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x0400139C RID: 5020
			private static readonly IntPtr NativeFieldInfoPtr_certificate;

			// Token: 0x0400139D RID: 5021
			private static readonly IntPtr NativeFieldInfoPtr_chain;

			// Token: 0x0400139E RID: 5022
			private static readonly IntPtr NativeFieldInfoPtr_sslPolicyErrors;

			// Token: 0x0400139F RID: 5023
			private static readonly IntPtr NativeFieldInfoPtr_result;

			// Token: 0x040013A0 RID: 5024
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_X509Certificate_X509Chain_SslPolicyErrors_0;
		}
	}
}
