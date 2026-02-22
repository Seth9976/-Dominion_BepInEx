using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Net;
using Il2CppSystem.Net.Sockets;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppMono.Net.Security
{
	// Token: 0x02000027 RID: 39
	public class MonoTlsStream : Object
	{
		// Token: 0x06000225 RID: 549 RVA: 0x00018EAC File Offset: 0x000170AC
		// Note: this type is marked as 'beforefieldinit'.
		static MonoTlsStream()
		{
			Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "MonoTlsStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr);
			MonoTlsStream.NativeFieldInfoPtr_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, "provider");
			MonoTlsStream.NativeFieldInfoPtr_networkStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, "networkStream");
			MonoTlsStream.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, "request");
			MonoTlsStream.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, "settings");
			MonoTlsStream.NativeFieldInfoPtr_sslStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, "sslStream");
			MonoTlsStream.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, "status");
			MonoTlsStream.NativeFieldInfoPtr__CertificateValidationFailed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, "<CertificateValidationFailed>k__BackingField");
			MonoTlsStream.NativeMethodInfoPtr_get_Request_Internal_get_HttpWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, 100663660);
			MonoTlsStream.NativeMethodInfoPtr_get_ExceptionStatus_Internal_get_WebExceptionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, 100663661);
			MonoTlsStream.NativeMethodInfoPtr_get_CertificateValidationFailed_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, 100663662);
			MonoTlsStream.NativeMethodInfoPtr_set_CertificateValidationFailed_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, 100663663);
			MonoTlsStream.NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_NetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, 100663664);
			MonoTlsStream.NativeMethodInfoPtr_CreateStream_Internal_Task_1_Stream_WebConnectionTunnel_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, 100663665);
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00018FE0 File Offset: 0x000171E0
		public unsafe HttpWebRequest Request
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsStream.NativeMethodInfoPtr_get_Request_Internal_get_HttpWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00019020 File Offset: 0x00017220
		public unsafe WebExceptionStatus ExceptionStatus
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsStream.NativeMethodInfoPtr_get_ExceptionStatus_Internal_get_WebExceptionStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000228 RID: 552 RVA: 0x0001905C File Offset: 0x0001725C
		// (set) Token: 0x06000229 RID: 553 RVA: 0x00019098 File Offset: 0x00017298
		public unsafe bool CertificateValidationFailed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsStream.NativeMethodInfoPtr_get_CertificateValidationFailed_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsStream.NativeMethodInfoPtr_set_CertificateValidationFailed_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000190D8 File Offset: 0x000172D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34297, RefRangeEnd = 34298, XrefRangeStart = 34290, XrefRangeEnd = 34297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoTlsStream(HttpWebRequest request, NetworkStream networkStream)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsStream.NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_NetworkStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00019138 File Offset: 0x00017338
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34310, RefRangeEnd = 34311, XrefRangeStart = 34298, XrefRangeEnd = 34310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Stream> CreateStream(WebConnectionTunnel tunnel, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tunnel);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsStream.NativeMethodInfoPtr_CreateStream_Internal_Task_1_Stream_WebConnectionTunnel_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Stream>>(intPtr3) : null;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002CAB File Offset: 0x00000EAB
		public MonoTlsStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600022D RID: 557 RVA: 0x000191A0 File Offset: 0x000173A0
		// (set) Token: 0x0600022E RID: 558 RVA: 0x00002CB4 File Offset: 0x00000EB4
		public unsafe MonoTlsProvider provider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_provider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_provider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600022F RID: 559 RVA: 0x000191D0 File Offset: 0x000173D0
		// (set) Token: 0x06000230 RID: 560 RVA: 0x00002CD3 File Offset: 0x00000ED3
		public unsafe NetworkStream networkStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_networkStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_networkStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000231 RID: 561 RVA: 0x00019200 File Offset: 0x00017400
		// (set) Token: 0x06000232 RID: 562 RVA: 0x00002CF2 File Offset: 0x00000EF2
		public unsafe HttpWebRequest request
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_request);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00019230 File Offset: 0x00017430
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00002D11 File Offset: 0x00000F11
		public unsafe MonoTlsSettings settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00019260 File Offset: 0x00017460
		// (set) Token: 0x06000236 RID: 566 RVA: 0x00002D30 File Offset: 0x00000F30
		public unsafe IMonoSslStream sslStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_sslStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMonoSslStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_sslStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00019290 File Offset: 0x00017490
		// (set) Token: 0x06000238 RID: 568 RVA: 0x00002D4F File Offset: 0x00000F4F
		public unsafe WebExceptionStatus status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_status)) = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000239 RID: 569 RVA: 0x000192B8 File Offset: 0x000174B8
		// (set) Token: 0x0600023A RID: 570 RVA: 0x00002D6A File Offset: 0x00000F6A
		public unsafe bool _CertificateValidationFailed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr__CertificateValidationFailed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr__CertificateValidationFailed_k__BackingField)) = value;
			}
		}

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeFieldInfoPtr_provider;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeFieldInfoPtr_networkStream;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeFieldInfoPtr_request;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeFieldInfoPtr_settings;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeFieldInfoPtr_sslStream;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeFieldInfoPtr__CertificateValidationFailed_k__BackingField;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_get_Request_Internal_get_HttpWebRequest_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_get_ExceptionStatus_Internal_get_WebExceptionStatus_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_get_CertificateValidationFailed_Internal_get_Boolean_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_set_CertificateValidationFailed_Internal_set_Void_Boolean_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_NetworkStream_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_CreateStream_Internal_Task_1_Stream_WebConnectionTunnel_CancellationToken_0;

		// Token: 0x02000185 RID: 389
		[ObfuscatedName("Mono.Net.Security.MonoTlsStream+<CreateStream>d__17")]
		public sealed class _CreateStream_d__17 : ValueType
		{
			// Token: 0x060016F4 RID: 5876 RVA: 0x0006409C File Offset: 0x0006229C
			// Note: this type is marked as 'beforefieldinit'.
			static _CreateStream_d__17()
			{
				Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, "<CreateStream>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__17>.NativeClassPtr);
				MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__17>.NativeClassPtr, "<>1__state");
				MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__17>.NativeClassPtr, "<>t__builder");
				MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__17>.NativeClassPtr, "<>4__this");
				MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr__socket_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__17>.NativeClassPtr, "<socket>5__1");
				MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr_tunnel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__17>.NativeClassPtr, "tunnel");
				MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__17>.NativeClassPtr, "cancellationToken");
				MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__17>.NativeClassPtr, "<>u__1");
				MonoTlsStream._CreateStream_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__17>.NativeClassPtr, 100663666);
				MonoTlsStream._CreateStream_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__17>.NativeClassPtr, 100663667);
			}

			// Token: 0x060016F5 RID: 5877 RVA: 0x0006417C File Offset: 0x0006237C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34234, XrefRangeEnd = 34287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsStream._CreateStream_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016F6 RID: 5878 RVA: 0x000641B4 File Offset: 0x000623B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34287, XrefRangeEnd = 34290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsStream._CreateStream_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060016F7 RID: 5879 RVA: 0x0000C172 File Offset: 0x0000A372
			public _CreateStream_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060016F8 RID: 5880 RVA: 0x0000C17B File Offset: 0x0000A37B
			public _CreateStream_d__17()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__17>.NativeClassPtr))
			{
			}

			// Token: 0x17000767 RID: 1895
			// (get) Token: 0x060016F9 RID: 5881 RVA: 0x000641FC File Offset: 0x000623FC
			// (set) Token: 0x060016FA RID: 5882 RVA: 0x0000C18D File Offset: 0x0000A38D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000768 RID: 1896
			// (get) Token: 0x060016FB RID: 5883 RVA: 0x00064224 File Offset: 0x00062424
			// (set) Token: 0x060016FC RID: 5884 RVA: 0x0000C1A8 File Offset: 0x0000A3A8
			public AsyncTaskMethodBuilder<Stream> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Stream>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Stream>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Stream>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000769 RID: 1897
			// (get) Token: 0x060016FD RID: 5885 RVA: 0x00064254 File Offset: 0x00062454
			// (set) Token: 0x060016FE RID: 5886 RVA: 0x0000C1D6 File Offset: 0x0000A3D6
			public unsafe MonoTlsStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700076A RID: 1898
			// (get) Token: 0x060016FF RID: 5887 RVA: 0x00064284 File Offset: 0x00062484
			// (set) Token: 0x06001700 RID: 5888 RVA: 0x0000C1F5 File Offset: 0x0000A3F5
			public unsafe Socket _socket_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr__socket_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr__socket_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700076B RID: 1899
			// (get) Token: 0x06001701 RID: 5889 RVA: 0x000642B4 File Offset: 0x000624B4
			// (set) Token: 0x06001702 RID: 5890 RVA: 0x0000C214 File Offset: 0x0000A414
			public unsafe WebConnectionTunnel tunnel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr_tunnel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebConnectionTunnel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr_tunnel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700076C RID: 1900
			// (get) Token: 0x06001703 RID: 5891 RVA: 0x000642E4 File Offset: 0x000624E4
			// (set) Token: 0x06001704 RID: 5892 RVA: 0x0000C233 File Offset: 0x0000A433
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700076D RID: 1901
			// (get) Token: 0x06001705 RID: 5893 RVA: 0x00064314 File Offset: 0x00062514
			// (set) Token: 0x06001706 RID: 5894 RVA: 0x0000C261 File Offset: 0x0000A461
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400121F RID: 4639
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001220 RID: 4640
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001221 RID: 4641
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001222 RID: 4642
			private static readonly IntPtr NativeFieldInfoPtr__socket_5__1;

			// Token: 0x04001223 RID: 4643
			private static readonly IntPtr NativeFieldInfoPtr_tunnel;

			// Token: 0x04001224 RID: 4644
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001225 RID: 4645
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001226 RID: 4646
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001227 RID: 4647
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
