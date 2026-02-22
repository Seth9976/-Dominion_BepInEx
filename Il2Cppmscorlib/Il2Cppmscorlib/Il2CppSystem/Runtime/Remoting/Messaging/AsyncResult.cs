using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003E5 RID: 997
	public class AsyncResult : Object
	{
		// Token: 0x06003F21 RID: 16161 RVA: 0x00125EF0 File Offset: 0x001240F0
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncResult()
		{
			Il2CppClassPointerStore<AsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "AsyncResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr);
			AsyncResult.NativeFieldInfoPtr_async_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "async_state");
			AsyncResult.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "handle");
			AsyncResult.NativeFieldInfoPtr_async_delegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "async_delegate");
			AsyncResult.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "data");
			AsyncResult.NativeFieldInfoPtr_object_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "object_data");
			AsyncResult.NativeFieldInfoPtr_sync_completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "sync_completed");
			AsyncResult.NativeFieldInfoPtr_completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "completed");
			AsyncResult.NativeFieldInfoPtr_endinvoke_called = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "endinvoke_called");
			AsyncResult.NativeFieldInfoPtr_async_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "async_callback");
			AsyncResult.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "current");
			AsyncResult.NativeFieldInfoPtr_original = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "original");
			AsyncResult.NativeFieldInfoPtr_add_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "add_time");
			AsyncResult.NativeFieldInfoPtr_call_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "call_message");
			AsyncResult.NativeFieldInfoPtr_message_ctrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "message_ctrl");
			AsyncResult.NativeFieldInfoPtr_reply_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "reply_message");
			AsyncResult.NativeFieldInfoPtr_orig_cb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "orig_cb");
			AsyncResult.NativeFieldInfoPtr_ccb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "ccb");
			AsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672543);
			AsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_WaitCallback_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672544);
			AsyncResult.NativeMethodInfoPtr_WaitCallback_Context_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672545);
			AsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672546);
			AsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672547);
			AsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672548);
			AsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672549);
			AsyncResult.NativeMethodInfoPtr_get_EndInvokeCalled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672550);
			AsyncResult.NativeMethodInfoPtr_set_EndInvokeCalled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672551);
			AsyncResult.NativeMethodInfoPtr_get_AsyncDelegate_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672552);
			AsyncResult.NativeMethodInfoPtr_get_NextSink_Public_Virtual_Final_New_get_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672553);
			AsyncResult.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672554);
			AsyncResult.NativeMethodInfoPtr_GetReplyMessage_Public_Virtual_New_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672555);
			AsyncResult.NativeMethodInfoPtr_SetMessageCtrl_Public_Virtual_New_Void_IMessageCtrl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672556);
			AsyncResult.NativeMethodInfoPtr_SetCompletedSynchronously_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672557);
			AsyncResult.NativeMethodInfoPtr_EndInvoke_Internal_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672558);
			AsyncResult.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672559);
			AsyncResult.NativeMethodInfoPtr_get_CallMessage_Internal_get_MonoMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672560);
			AsyncResult.NativeMethodInfoPtr_set_CallMessage_Internal_set_Void_MonoMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672561);
			AsyncResult.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672562);
			AsyncResult.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672563);
			AsyncResult.NativeMethodInfoPtr_Invoke_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672564);
			AsyncResult.NativeMethodInfoPtr___ctor_b__17_0_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100672566);
		}

		// Token: 0x06003F22 RID: 16162 RVA: 0x00126240 File Offset: 0x00124440
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncResult()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F23 RID: 16163 RVA: 0x0012627C File Offset: 0x0012447C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354254, XrefRangeEnd = 354265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncResult(WaitCallback cb, Object state, bool capture_context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capture_context;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_WaitCallback_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F24 RID: 16164 RVA: 0x001262E8 File Offset: 0x001244E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354265, XrefRangeEnd = 354278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WaitCallback_Context(Object state)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_WaitCallback_Context_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x06003F25 RID: 16165 RVA: 0x00126320 File Offset: 0x00124520
		public unsafe virtual Object AsyncState
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x06003F26 RID: 16166 RVA: 0x0012636C File Offset: 0x0012456C
		public unsafe virtual WaitHandle AsyncWaitHandle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354278, XrefRangeEnd = 354285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_New_get_WaitHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x06003F27 RID: 16167 RVA: 0x001263B8 File Offset: 0x001245B8
		public unsafe virtual bool CompletedSynchronously
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x06003F28 RID: 16168 RVA: 0x00126400 File Offset: 0x00124600
		public unsafe virtual bool IsCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x06003F29 RID: 16169 RVA: 0x00126448 File Offset: 0x00124648
		// (set) Token: 0x06003F2A RID: 16170 RVA: 0x00126484 File Offset: 0x00124684
		public unsafe bool EndInvokeCalled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_get_EndInvokeCalled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_set_EndInvokeCalled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x06003F2B RID: 16171 RVA: 0x001264C4 File Offset: 0x001246C4
		public unsafe virtual Object AsyncDelegate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_get_AsyncDelegate_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x06003F2C RID: 16172 RVA: 0x00126510 File Offset: 0x00124710
		public unsafe virtual IMessageSink NextSink
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_get_NextSink_Public_Virtual_Final_New_get_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
			}
		}

		// Token: 0x06003F2D RID: 16173 RVA: 0x00126550 File Offset: 0x00124750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354285, XrefRangeEnd = 354290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replySink);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06003F2E RID: 16174 RVA: 0x001265C0 File Offset: 0x001247C0
		[CallerCount(0)]
		public unsafe virtual IMessage GetReplyMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_GetReplyMessage_Public_Virtual_New_IMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
		}

		// Token: 0x06003F2F RID: 16175 RVA: 0x0012660C File Offset: 0x0012480C
		[CallerCount(0)]
		public unsafe virtual void SetMessageCtrl(IMessageCtrl mc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_SetMessageCtrl_Public_Virtual_New_Void_IMessageCtrl_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F30 RID: 16176 RVA: 0x0012665C File Offset: 0x0012485C
		[CallerCount(0)]
		public unsafe void SetCompletedSynchronously(bool completed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref completed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_SetCompletedSynchronously_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F31 RID: 16177 RVA: 0x0012669C File Offset: 0x0012489C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354294, RefRangeEnd = 354295, XrefRangeStart = 354290, XrefRangeEnd = 354294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMessage EndInvoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_EndInvoke_Internal_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
		}

		// Token: 0x06003F32 RID: 16178 RVA: 0x001266DC File Offset: 0x001248DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354295, XrefRangeEnd = 354304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_New_IMessage_IMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x06003F33 RID: 16179 RVA: 0x00126738 File Offset: 0x00124938
		// (set) Token: 0x06003F34 RID: 16180 RVA: 0x00126778 File Offset: 0x00124978
		public unsafe MonoMethodMessage CallMessage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_get_CallMessage_Internal_get_MonoMethodMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoMethodMessage>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_set_CallMessage_Internal_set_Void_MonoMethodMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003F35 RID: 16181 RVA: 0x001267BC File Offset: 0x001249BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354304, XrefRangeEnd = 354305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Threading_IThreadPoolWorkItem_ExecuteWorkItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F36 RID: 16182 RVA: 0x001267F0 File Offset: 0x001249F0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Threading_IThreadPoolWorkItem_MarkAborted(ThreadAbortException tae)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tae);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F37 RID: 16183 RVA: 0x00126834 File Offset: 0x00124A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_Invoke_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003F38 RID: 16184 RVA: 0x00126874 File Offset: 0x00124A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354305, XrefRangeEnd = 354313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__17_0(Object <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr___ctor_b__17_0_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F39 RID: 16185 RVA: 0x00017DCD File Offset: 0x00015FCD
		public AsyncResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x06003F3A RID: 16186 RVA: 0x001268B8 File Offset: 0x00124AB8
		// (set) Token: 0x06003F3B RID: 16187 RVA: 0x00017DD6 File Offset: 0x00015FD6
		public unsafe Object async_state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_async_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_async_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x06003F3C RID: 16188 RVA: 0x001268E8 File Offset: 0x00124AE8
		// (set) Token: 0x06003F3D RID: 16189 RVA: 0x00017DF5 File Offset: 0x00015FF5
		public unsafe WaitHandle handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x06003F3E RID: 16190 RVA: 0x00126918 File Offset: 0x00124B18
		// (set) Token: 0x06003F3F RID: 16191 RVA: 0x00017E14 File Offset: 0x00016014
		public unsafe Object async_delegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_async_delegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_async_delegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x06003F40 RID: 16192 RVA: 0x00126948 File Offset: 0x00124B48
		// (set) Token: 0x06003F41 RID: 16193 RVA: 0x00017E33 File Offset: 0x00016033
		public unsafe IntPtr data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_data);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_data)) = value;
			}
		}

		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x06003F42 RID: 16194 RVA: 0x00126970 File Offset: 0x00124B70
		// (set) Token: 0x06003F43 RID: 16195 RVA: 0x00017E4E File Offset: 0x0001604E
		public unsafe Object object_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_object_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_object_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x06003F44 RID: 16196 RVA: 0x001269A0 File Offset: 0x00124BA0
		// (set) Token: 0x06003F45 RID: 16197 RVA: 0x00017E6D File Offset: 0x0001606D
		public unsafe bool sync_completed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_sync_completed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_sync_completed)) = value;
			}
		}

		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x06003F46 RID: 16198 RVA: 0x001269C8 File Offset: 0x00124BC8
		// (set) Token: 0x06003F47 RID: 16199 RVA: 0x00017E88 File Offset: 0x00016088
		public unsafe bool completed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_completed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_completed)) = value;
			}
		}

		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x06003F48 RID: 16200 RVA: 0x001269F0 File Offset: 0x00124BF0
		// (set) Token: 0x06003F49 RID: 16201 RVA: 0x00017EA3 File Offset: 0x000160A3
		public unsafe bool endinvoke_called
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_endinvoke_called);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_endinvoke_called)) = value;
			}
		}

		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x06003F4A RID: 16202 RVA: 0x00126A18 File Offset: 0x00124C18
		// (set) Token: 0x06003F4B RID: 16203 RVA: 0x00017EBE File Offset: 0x000160BE
		public unsafe Object async_callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_async_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_async_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x06003F4C RID: 16204 RVA: 0x00126A48 File Offset: 0x00124C48
		// (set) Token: 0x06003F4D RID: 16205 RVA: 0x00017EDD File Offset: 0x000160DD
		public unsafe ExecutionContext current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x06003F4E RID: 16206 RVA: 0x00126A78 File Offset: 0x00124C78
		// (set) Token: 0x06003F4F RID: 16207 RVA: 0x00017EFC File Offset: 0x000160FC
		public unsafe ExecutionContext original
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_original);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_original), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x06003F50 RID: 16208 RVA: 0x00126AA8 File Offset: 0x00124CA8
		// (set) Token: 0x06003F51 RID: 16209 RVA: 0x00017F1B File Offset: 0x0001611B
		public unsafe long add_time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_add_time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_add_time)) = value;
			}
		}

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x06003F52 RID: 16210 RVA: 0x00126AD0 File Offset: 0x00124CD0
		// (set) Token: 0x06003F53 RID: 16211 RVA: 0x00017F36 File Offset: 0x00016136
		public unsafe MonoMethodMessage call_message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_call_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoMethodMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_call_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x06003F54 RID: 16212 RVA: 0x00126B00 File Offset: 0x00124D00
		// (set) Token: 0x06003F55 RID: 16213 RVA: 0x00017F55 File Offset: 0x00016155
		public unsafe IMessageCtrl message_ctrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_message_ctrl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_message_ctrl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x06003F56 RID: 16214 RVA: 0x00126B30 File Offset: 0x00124D30
		// (set) Token: 0x06003F57 RID: 16215 RVA: 0x00017F74 File Offset: 0x00016174
		public unsafe IMessage reply_message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_reply_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_reply_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x06003F58 RID: 16216 RVA: 0x00126B60 File Offset: 0x00124D60
		// (set) Token: 0x06003F59 RID: 16217 RVA: 0x00017F93 File Offset: 0x00016193
		public unsafe WaitCallback orig_cb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_orig_cb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_orig_cb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x06003F5A RID: 16218 RVA: 0x00126B90 File Offset: 0x00124D90
		// (set) Token: 0x06003F5B RID: 16219 RVA: 0x00017FB2 File Offset: 0x000161B2
		public unsafe static ContextCallback ccb
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AsyncResult.NativeFieldInfoPtr_ccb, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AsyncResult.NativeFieldInfoPtr_ccb, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040033E2 RID: 13282
		private static readonly IntPtr NativeFieldInfoPtr_async_state;

		// Token: 0x040033E3 RID: 13283
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x040033E4 RID: 13284
		private static readonly IntPtr NativeFieldInfoPtr_async_delegate;

		// Token: 0x040033E5 RID: 13285
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040033E6 RID: 13286
		private static readonly IntPtr NativeFieldInfoPtr_object_data;

		// Token: 0x040033E7 RID: 13287
		private static readonly IntPtr NativeFieldInfoPtr_sync_completed;

		// Token: 0x040033E8 RID: 13288
		private static readonly IntPtr NativeFieldInfoPtr_completed;

		// Token: 0x040033E9 RID: 13289
		private static readonly IntPtr NativeFieldInfoPtr_endinvoke_called;

		// Token: 0x040033EA RID: 13290
		private static readonly IntPtr NativeFieldInfoPtr_async_callback;

		// Token: 0x040033EB RID: 13291
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x040033EC RID: 13292
		private static readonly IntPtr NativeFieldInfoPtr_original;

		// Token: 0x040033ED RID: 13293
		private static readonly IntPtr NativeFieldInfoPtr_add_time;

		// Token: 0x040033EE RID: 13294
		private static readonly IntPtr NativeFieldInfoPtr_call_message;

		// Token: 0x040033EF RID: 13295
		private static readonly IntPtr NativeFieldInfoPtr_message_ctrl;

		// Token: 0x040033F0 RID: 13296
		private static readonly IntPtr NativeFieldInfoPtr_reply_message;

		// Token: 0x040033F1 RID: 13297
		private static readonly IntPtr NativeFieldInfoPtr_orig_cb;

		// Token: 0x040033F2 RID: 13298
		private static readonly IntPtr NativeFieldInfoPtr_ccb;

		// Token: 0x040033F3 RID: 13299
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040033F4 RID: 13300
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_WaitCallback_Object_Boolean_0;

		// Token: 0x040033F5 RID: 13301
		private static readonly IntPtr NativeMethodInfoPtr_WaitCallback_Context_Private_Static_Void_Object_0;

		// Token: 0x040033F6 RID: 13302
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncState_Public_Virtual_New_get_Object_0;

		// Token: 0x040033F7 RID: 13303
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_New_get_WaitHandle_0;

		// Token: 0x040033F8 RID: 13304
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040033F9 RID: 13305
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040033FA RID: 13306
		private static readonly IntPtr NativeMethodInfoPtr_get_EndInvokeCalled_Public_get_Boolean_0;

		// Token: 0x040033FB RID: 13307
		private static readonly IntPtr NativeMethodInfoPtr_set_EndInvokeCalled_Public_set_Void_Boolean_0;

		// Token: 0x040033FC RID: 13308
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncDelegate_Public_Virtual_New_get_Object_0;

		// Token: 0x040033FD RID: 13309
		private static readonly IntPtr NativeMethodInfoPtr_get_NextSink_Public_Virtual_Final_New_get_IMessageSink_0;

		// Token: 0x040033FE RID: 13310
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0;

		// Token: 0x040033FF RID: 13311
		private static readonly IntPtr NativeMethodInfoPtr_GetReplyMessage_Public_Virtual_New_IMessage_0;

		// Token: 0x04003400 RID: 13312
		private static readonly IntPtr NativeMethodInfoPtr_SetMessageCtrl_Public_Virtual_New_Void_IMessageCtrl_0;

		// Token: 0x04003401 RID: 13313
		private static readonly IntPtr NativeMethodInfoPtr_SetCompletedSynchronously_Internal_Void_Boolean_0;

		// Token: 0x04003402 RID: 13314
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Internal_IMessage_0;

		// Token: 0x04003403 RID: 13315
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_New_IMessage_IMessage_0;

		// Token: 0x04003404 RID: 13316
		private static readonly IntPtr NativeMethodInfoPtr_get_CallMessage_Internal_get_MonoMethodMessage_0;

		// Token: 0x04003405 RID: 13317
		private static readonly IntPtr NativeMethodInfoPtr_set_CallMessage_Internal_set_Void_MonoMethodMessage_0;

		// Token: 0x04003406 RID: 13318
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0;

		// Token: 0x04003407 RID: 13319
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0;

		// Token: 0x04003408 RID: 13320
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Internal_Object_0;

		// Token: 0x04003409 RID: 13321
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__17_0_Private_Void_Object_0;
	}
}
