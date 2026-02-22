using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000130 RID: 304
	public sealed class SocketAsyncResult : IOAsyncResult
	{
		// Token: 0x06001467 RID: 5223 RVA: 0x0005D8F0 File Offset: 0x0005BAF0
		// Note: this type is marked as 'beforefieldinit'.
		static SocketAsyncResult()
		{
			Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "SocketAsyncResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr);
			SocketAsyncResult.NativeFieldInfoPtr_socket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "socket");
			SocketAsyncResult.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "operation");
			SocketAsyncResult.NativeFieldInfoPtr_DelayedException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "DelayedException");
			SocketAsyncResult.NativeFieldInfoPtr_EndPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "EndPoint");
			SocketAsyncResult.NativeFieldInfoPtr_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "Buffer");
			SocketAsyncResult.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "Offset");
			SocketAsyncResult.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "Size");
			SocketAsyncResult.NativeFieldInfoPtr_SockFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "SockFlags");
			SocketAsyncResult.NativeFieldInfoPtr_AcceptSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "AcceptSocket");
			SocketAsyncResult.NativeFieldInfoPtr_Addresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "Addresses");
			SocketAsyncResult.NativeFieldInfoPtr_Port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "Port");
			SocketAsyncResult.NativeFieldInfoPtr_Buffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "Buffers");
			SocketAsyncResult.NativeFieldInfoPtr_ReuseSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "ReuseSocket");
			SocketAsyncResult.NativeFieldInfoPtr_CurrentAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "CurrentAddress");
			SocketAsyncResult.NativeFieldInfoPtr_AcceptedSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "AcceptedSocket");
			SocketAsyncResult.NativeFieldInfoPtr_Total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "Total");
			SocketAsyncResult.NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "error");
			SocketAsyncResult.NativeFieldInfoPtr_EndCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "EndCalled");
			SocketAsyncResult.NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100666172);
			SocketAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_Socket_AsyncCallback_Object_SocketOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100666173);
			SocketAsyncResult.NativeMethodInfoPtr_get_ErrorCode_Public_get_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100666174);
			SocketAsyncResult.NativeMethodInfoPtr_CheckIfThrowDelayedException_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100666175);
			SocketAsyncResult.NativeMethodInfoPtr_CompleteDisposed_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100666176);
			SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100666177);
			SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100666178);
			SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100666179);
			SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Exception_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100666180);
			SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100666181);
			SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100666182);
			SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Socket_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100666183);
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x0005DB78 File Offset: 0x0005BD78
		public unsafe IntPtr Handle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57171, XrefRangeEnd = 57172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x0005DBB4 File Offset: 0x0005BDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57172, XrefRangeEnd = 57173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketAsyncResult(Socket socket, AsyncCallback callback, Object state, SocketOperation operation)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(socket);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref operation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_Socket_AsyncCallback_Object_SocketOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x0005DC34 File Offset: 0x0005BE34
		public unsafe SocketError ErrorCode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57173, XrefRangeEnd = 57175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_get_ErrorCode_Public_get_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x0005DC70 File Offset: 0x0005BE70
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 57175, RefRangeEnd = 57185, XrefRangeStart = 57175, XrefRangeEnd = 57175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckIfThrowDelayedException()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_CheckIfThrowDelayedException_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x0005DCA4 File Offset: 0x0005BEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57185, XrefRangeEnd = 57186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CompleteDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_CompleteDisposed_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x0005DCD8 File Offset: 0x0005BED8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 57208, RefRangeEnd = 57219, XrefRangeStart = 57186, XrefRangeEnd = 57208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x0005DD0C File Offset: 0x0005BF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57219, XrefRangeEnd = 57220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(bool synch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref synch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x0005DD4C File Offset: 0x0005BF4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 57221, RefRangeEnd = 57225, XrefRangeStart = 57220, XrefRangeEnd = 57221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(int total)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref total;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x0005DD8C File Offset: 0x0005BF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57225, XrefRangeEnd = 57226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(Exception e, bool synch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref synch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Exception_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x0005DDDC File Offset: 0x0005BFDC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 57227, RefRangeEnd = 57232, XrefRangeStart = 57226, XrefRangeEnd = 57227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x0005DE20 File Offset: 0x0005C020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57233, RefRangeEnd = 57234, XrefRangeStart = 57232, XrefRangeEnd = 57233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(Socket s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x0005DE64 File Offset: 0x0005C064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57234, XrefRangeEnd = 57235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(Socket s, int total)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref total;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Socket_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x0000A453 File Offset: 0x00008653
		public SocketAsyncResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x0005DEB4 File Offset: 0x0005C0B4
		// (set) Token: 0x06001476 RID: 5238 RVA: 0x0000A45C File Offset: 0x0000865C
		public unsafe Socket socket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_socket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_socket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06001477 RID: 5239 RVA: 0x0005DEE4 File Offset: 0x0005C0E4
		// (set) Token: 0x06001478 RID: 5240 RVA: 0x0000A47B File Offset: 0x0000867B
		public unsafe SocketOperation operation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_operation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_operation)) = value;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001479 RID: 5241 RVA: 0x0005DF0C File Offset: 0x0005C10C
		// (set) Token: 0x0600147A RID: 5242 RVA: 0x0000A496 File Offset: 0x00008696
		public unsafe Exception DelayedException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_DelayedException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_DelayedException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x0600147B RID: 5243 RVA: 0x0005DF3C File Offset: 0x0005C13C
		// (set) Token: 0x0600147C RID: 5244 RVA: 0x0000A4B5 File Offset: 0x000086B5
		public unsafe EndPoint EndPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_EndPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EndPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_EndPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x0600147D RID: 5245 RVA: 0x0005DF6C File Offset: 0x0005C16C
		// (set) Token: 0x0600147E RID: 5246 RVA: 0x0000A4D4 File Offset: 0x000086D4
		public unsafe Il2CppStructArray<byte> Buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x0600147F RID: 5247 RVA: 0x0005DF9C File Offset: 0x0005C19C
		// (set) Token: 0x06001480 RID: 5248 RVA: 0x0000A4F3 File Offset: 0x000086F3
		public unsafe int Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Offset)) = value;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x0005DFC4 File Offset: 0x0005C1C4
		// (set) Token: 0x06001482 RID: 5250 RVA: 0x0000A50E File Offset: 0x0000870E
		public unsafe int Size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Size)) = value;
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x0005DFEC File Offset: 0x0005C1EC
		// (set) Token: 0x06001484 RID: 5252 RVA: 0x0000A529 File Offset: 0x00008729
		public unsafe SocketFlags SockFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_SockFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_SockFlags)) = value;
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x0005E014 File Offset: 0x0005C214
		// (set) Token: 0x06001486 RID: 5254 RVA: 0x0000A544 File Offset: 0x00008744
		public unsafe Socket AcceptSocket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_AcceptSocket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_AcceptSocket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x0005E044 File Offset: 0x0005C244
		// (set) Token: 0x06001488 RID: 5256 RVA: 0x0000A563 File Offset: 0x00008763
		public unsafe Il2CppReferenceArray<IPAddress> Addresses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Addresses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Addresses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06001489 RID: 5257 RVA: 0x0005E074 File Offset: 0x0005C274
		// (set) Token: 0x0600148A RID: 5258 RVA: 0x0000A582 File Offset: 0x00008782
		public unsafe int Port
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Port);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Port)) = value;
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x0600148B RID: 5259 RVA: 0x0005E09C File Offset: 0x0005C29C
		// (set) Token: 0x0600148C RID: 5260 RVA: 0x0000A59D File Offset: 0x0000879D
		public unsafe IList<ArraySegment<byte>> Buffers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Buffers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<ArraySegment<byte>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Buffers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x0005E0CC File Offset: 0x0005C2CC
		// (set) Token: 0x0600148E RID: 5262 RVA: 0x0000A5BC File Offset: 0x000087BC
		public unsafe bool ReuseSocket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_ReuseSocket);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_ReuseSocket)) = value;
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x0600148F RID: 5263 RVA: 0x0005E0F4 File Offset: 0x0005C2F4
		// (set) Token: 0x06001490 RID: 5264 RVA: 0x0000A5D7 File Offset: 0x000087D7
		public unsafe int CurrentAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_CurrentAddress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_CurrentAddress)) = value;
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06001491 RID: 5265 RVA: 0x0005E11C File Offset: 0x0005C31C
		// (set) Token: 0x06001492 RID: 5266 RVA: 0x0000A5F2 File Offset: 0x000087F2
		public unsafe Socket AcceptedSocket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_AcceptedSocket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_AcceptedSocket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x0005E14C File Offset: 0x0005C34C
		// (set) Token: 0x06001494 RID: 5268 RVA: 0x0000A611 File Offset: 0x00008811
		public unsafe int Total
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Total);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Total)) = value;
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x0005E174 File Offset: 0x0005C374
		// (set) Token: 0x06001496 RID: 5270 RVA: 0x0000A62C File Offset: 0x0000882C
		public unsafe int error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_error);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_error)) = value;
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x0005E19C File Offset: 0x0005C39C
		// (set) Token: 0x06001498 RID: 5272 RVA: 0x0000A647 File Offset: 0x00008847
		public unsafe int EndCalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_EndCalled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_EndCalled)) = value;
			}
		}

		// Token: 0x0400107C RID: 4220
		private static readonly IntPtr NativeFieldInfoPtr_socket;

		// Token: 0x0400107D RID: 4221
		private static readonly IntPtr NativeFieldInfoPtr_operation;

		// Token: 0x0400107E RID: 4222
		private static readonly IntPtr NativeFieldInfoPtr_DelayedException;

		// Token: 0x0400107F RID: 4223
		private static readonly IntPtr NativeFieldInfoPtr_EndPoint;

		// Token: 0x04001080 RID: 4224
		private static readonly IntPtr NativeFieldInfoPtr_Buffer;

		// Token: 0x04001081 RID: 4225
		private static readonly IntPtr NativeFieldInfoPtr_Offset;

		// Token: 0x04001082 RID: 4226
		private static readonly IntPtr NativeFieldInfoPtr_Size;

		// Token: 0x04001083 RID: 4227
		private static readonly IntPtr NativeFieldInfoPtr_SockFlags;

		// Token: 0x04001084 RID: 4228
		private static readonly IntPtr NativeFieldInfoPtr_AcceptSocket;

		// Token: 0x04001085 RID: 4229
		private static readonly IntPtr NativeFieldInfoPtr_Addresses;

		// Token: 0x04001086 RID: 4230
		private static readonly IntPtr NativeFieldInfoPtr_Port;

		// Token: 0x04001087 RID: 4231
		private static readonly IntPtr NativeFieldInfoPtr_Buffers;

		// Token: 0x04001088 RID: 4232
		private static readonly IntPtr NativeFieldInfoPtr_ReuseSocket;

		// Token: 0x04001089 RID: 4233
		private static readonly IntPtr NativeFieldInfoPtr_CurrentAddress;

		// Token: 0x0400108A RID: 4234
		private static readonly IntPtr NativeFieldInfoPtr_AcceptedSocket;

		// Token: 0x0400108B RID: 4235
		private static readonly IntPtr NativeFieldInfoPtr_Total;

		// Token: 0x0400108C RID: 4236
		private static readonly IntPtr NativeFieldInfoPtr_error;

		// Token: 0x0400108D RID: 4237
		private static readonly IntPtr NativeFieldInfoPtr_EndCalled;

		// Token: 0x0400108E RID: 4238
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0;

		// Token: 0x0400108F RID: 4239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Socket_AsyncCallback_Object_SocketOperation_0;

		// Token: 0x04001090 RID: 4240
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorCode_Public_get_SocketError_0;

		// Token: 0x04001091 RID: 4241
		private static readonly IntPtr NativeMethodInfoPtr_CheckIfThrowDelayedException_Public_Void_0;

		// Token: 0x04001092 RID: 4242
		private static readonly IntPtr NativeMethodInfoPtr_CompleteDisposed_Internal_Virtual_Void_0;

		// Token: 0x04001093 RID: 4243
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_0;

		// Token: 0x04001094 RID: 4244
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_Boolean_0;

		// Token: 0x04001095 RID: 4245
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_Int32_0;

		// Token: 0x04001096 RID: 4246
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_Exception_Boolean_0;

		// Token: 0x04001097 RID: 4247
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_Exception_0;

		// Token: 0x04001098 RID: 4248
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_Socket_0;

		// Token: 0x04001099 RID: 4249
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_Socket_Int32_0;

		// Token: 0x020001F0 RID: 496
		[ObfuscatedName("System.Net.Sockets.SocketAsyncResult+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001C0A RID: 7178 RVA: 0x00072170 File Offset: 0x00070370
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SocketAsyncResult.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketAsyncResult.__c>.NativeClassPtr);
				SocketAsyncResult.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult.__c>.NativeClassPtr, "<>9");
				SocketAsyncResult.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult.__c>.NativeClassPtr, "<>9__27_0");
				SocketAsyncResult.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult.__c>.NativeClassPtr, 100666185);
				SocketAsyncResult.__c.NativeMethodInfoPtr__Complete_b__27_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult.__c>.NativeClassPtr, 100666186);
			}

			// Token: 0x06001C0B RID: 7179 RVA: 0x000721EC File Offset: 0x000703EC
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketAsyncResult.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C0C RID: 7180 RVA: 0x00072228 File Offset: 0x00070428
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57166, XrefRangeEnd = 57171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Complete_b__27_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.__c.NativeMethodInfoPtr__Complete_b__27_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C0D RID: 7181 RVA: 0x0000FAC6 File Offset: 0x0000DCC6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000910 RID: 2320
			// (get) Token: 0x06001C0E RID: 7182 RVA: 0x0007226C File Offset: 0x0007046C
			// (set) Token: 0x06001C0F RID: 7183 RVA: 0x0000FACF File Offset: 0x0000DCCF
			public unsafe static SocketAsyncResult.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SocketAsyncResult.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SocketAsyncResult.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SocketAsyncResult.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000911 RID: 2321
			// (get) Token: 0x06001C10 RID: 7184 RVA: 0x00072294 File Offset: 0x00070494
			// (set) Token: 0x06001C11 RID: 7185 RVA: 0x0000FAE1 File Offset: 0x0000DCE1
			public unsafe static WaitCallback __9__27_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SocketAsyncResult.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SocketAsyncResult.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001552 RID: 5458
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001553 RID: 5459
			private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

			// Token: 0x04001554 RID: 5460
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001555 RID: 5461
			private static readonly IntPtr NativeMethodInfoPtr__Complete_b__27_0_Internal_Void_Object_0;
		}
	}
}
