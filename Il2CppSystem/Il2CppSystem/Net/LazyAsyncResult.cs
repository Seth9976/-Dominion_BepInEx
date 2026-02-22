using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Net
{
	// Token: 0x020000E4 RID: 228
	public class LazyAsyncResult : Object
	{
		// Token: 0x06000D13 RID: 3347 RVA: 0x00041BC8 File Offset: 0x0003FDC8
		// Note: this type is marked as 'beforefieldinit'.
		static LazyAsyncResult()
		{
			Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "LazyAsyncResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr);
			LazyAsyncResult.NativeFieldInfoPtr_t_ThreadContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "t_ThreadContext");
			LazyAsyncResult.NativeFieldInfoPtr_m_AsyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "m_AsyncObject");
			LazyAsyncResult.NativeFieldInfoPtr_m_AsyncState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "m_AsyncState");
			LazyAsyncResult.NativeFieldInfoPtr_m_AsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "m_AsyncCallback");
			LazyAsyncResult.NativeFieldInfoPtr_m_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "m_Result");
			LazyAsyncResult.NativeFieldInfoPtr_m_IntCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "m_IntCompleted");
			LazyAsyncResult.NativeFieldInfoPtr_m_UserEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "m_UserEvent");
			LazyAsyncResult.NativeFieldInfoPtr_m_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "m_Event");
			LazyAsyncResult.NativeMethodInfoPtr_get_CurrentThreadContext_Private_Static_get_ThreadContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665139);
			LazyAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Object_Object_AsyncCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665140);
			LazyAsyncResult.NativeMethodInfoPtr_get_AsyncObject_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665141);
			LazyAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665142);
			LazyAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665143);
			LazyAsyncResult.NativeMethodInfoPtr_LazilyCreateEvent_Private_Boolean_byref_ManualResetEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665144);
			LazyAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665145);
			LazyAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665146);
			LazyAsyncResult.NativeMethodInfoPtr_get_InternalPeekCompleted_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665147);
			LazyAsyncResult.NativeMethodInfoPtr_ProtectedInvokeCallback_Protected_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665148);
			LazyAsyncResult.NativeMethodInfoPtr_InvokeCallback_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665149);
			LazyAsyncResult.NativeMethodInfoPtr_Complete_Protected_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665150);
			LazyAsyncResult.NativeMethodInfoPtr_WorkerThreadComplete_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665151);
			LazyAsyncResult.NativeMethodInfoPtr_Cleanup_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665152);
			LazyAsyncResult.NativeMethodInfoPtr_InternalWaitForCompletion_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665153);
			LazyAsyncResult.NativeMethodInfoPtr_WaitForCompletion_Private_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100665154);
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x00041DD8 File Offset: 0x0003FFD8
		public unsafe static LazyAsyncResult.ThreadContext CurrentThreadContext
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47559, XrefRangeEnd = 47568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_get_CurrentThreadContext_Private_Static_get_ThreadContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LazyAsyncResult.ThreadContext>(intPtr3) : null;
			}
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x00041E0C File Offset: 0x0004000C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 47573, RefRangeEnd = 47574, XrefRangeStart = 47568, XrefRangeEnd = 47573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LazyAsyncResult(Object myObject, Object myState, AsyncCallback myCallBack)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(myObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(myState);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(myCallBack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Object_Object_AsyncCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x00041E7C File Offset: 0x0004007C
		public unsafe Object AsyncObject
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_get_AsyncObject_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000D17 RID: 3351 RVA: 0x00041EBC File Offset: 0x000400BC
		public unsafe virtual Object AsyncState
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x00041EFC File Offset: 0x000400FC
		public unsafe virtual WaitHandle AsyncWaitHandle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47574, XrefRangeEnd = 47578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00041F3C File Offset: 0x0004013C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 47588, RefRangeEnd = 47590, XrefRangeStart = 47578, XrefRangeEnd = 47588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LazilyCreateEvent(out ManualResetEvent waitHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_LazilyCreateEvent_Private_Boolean_byref_ManualResetEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				waitHandle = ((intPtr4 == 0) ? null : new ManualResetEvent(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000D1A RID: 3354 RVA: 0x00041F9C File Offset: 0x0004019C
		public unsafe virtual bool CompletedSynchronously
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47590, XrefRangeEnd = 47591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000D1B RID: 3355 RVA: 0x00041FD8 File Offset: 0x000401D8
		public unsafe virtual bool IsCompleted
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 47592, RefRangeEnd = 47594, XrefRangeStart = 47591, XrefRangeEnd = 47592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000D1C RID: 3356 RVA: 0x00042014 File Offset: 0x00040214
		public unsafe bool InternalPeekCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_get_InternalPeekCompleted_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x00042050 File Offset: 0x00040250
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 47606, RefRangeEnd = 47607, XrefRangeStart = 47594, XrefRangeEnd = 47606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProtectedInvokeCallback(Object result, IntPtr userToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userToken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_ProtectedInvokeCallback_Protected_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x000420A0 File Offset: 0x000402A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 47609, RefRangeEnd = 47613, XrefRangeStart = 47607, XrefRangeEnd = 47609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeCallback(Object result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_InvokeCallback_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x000420E4 File Offset: 0x000402E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47613, XrefRangeEnd = 47633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Complete(IntPtr userToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userToken;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LazyAsyncResult.NativeMethodInfoPtr_Complete_Protected_Virtual_New_Void_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x00042130 File Offset: 0x00040330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47633, XrefRangeEnd = 47635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WorkerThreadComplete(Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_WorkerThreadComplete_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x00042174 File Offset: 0x00040374
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LazyAsyncResult.NativeMethodInfoPtr_Cleanup_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x000421B0 File Offset: 0x000403B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 47636, RefRangeEnd = 47637, XrefRangeStart = 47635, XrefRangeEnd = 47636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object InternalWaitForCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_InternalWaitForCompletion_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x000421F0 File Offset: 0x000403F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 47652, RefRangeEnd = 47653, XrefRangeStart = 47637, XrefRangeEnd = 47652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object WaitForCompletion(bool snap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_WaitForCompletion_Private_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00007173 File Offset: 0x00005373
		public LazyAsyncResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x0004223C File Offset: 0x0004043C
		// (set) Token: 0x06000D26 RID: 3366 RVA: 0x0000717C File Offset: 0x0000537C
		public unsafe static LazyAsyncResult.ThreadContext t_ThreadContext
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LazyAsyncResult.NativeFieldInfoPtr_t_ThreadContext, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LazyAsyncResult.ThreadContext>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LazyAsyncResult.NativeFieldInfoPtr_t_ThreadContext, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000D27 RID: 3367 RVA: 0x00042264 File Offset: 0x00040464
		// (set) Token: 0x06000D28 RID: 3368 RVA: 0x0000718E File Offset: 0x0000538E
		public unsafe Object m_AsyncObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_AsyncObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_AsyncObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000D29 RID: 3369 RVA: 0x00042294 File Offset: 0x00040494
		// (set) Token: 0x06000D2A RID: 3370 RVA: 0x000071AD File Offset: 0x000053AD
		public unsafe Object m_AsyncState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_AsyncState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_AsyncState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x000422C4 File Offset: 0x000404C4
		// (set) Token: 0x06000D2C RID: 3372 RVA: 0x000071CC File Offset: 0x000053CC
		public unsafe AsyncCallback m_AsyncCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_AsyncCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_AsyncCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x000422F4 File Offset: 0x000404F4
		// (set) Token: 0x06000D2E RID: 3374 RVA: 0x000071EB File Offset: 0x000053EB
		public unsafe Object m_Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_Result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_Result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x00042324 File Offset: 0x00040524
		// (set) Token: 0x06000D30 RID: 3376 RVA: 0x0000720A File Offset: 0x0000540A
		public unsafe int m_IntCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_IntCompleted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_IntCompleted)) = value;
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x0004234C File Offset: 0x0004054C
		// (set) Token: 0x06000D32 RID: 3378 RVA: 0x00007225 File Offset: 0x00005425
		public unsafe bool m_UserEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_UserEvent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_UserEvent)) = value;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000D33 RID: 3379 RVA: 0x00042374 File Offset: 0x00040574
		// (set) Token: 0x06000D34 RID: 3380 RVA: 0x00007240 File Offset: 0x00005440
		public unsafe Object m_Event
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_Event);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_Event), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeFieldInfoPtr_t_ThreadContext;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeFieldInfoPtr_m_AsyncObject;

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeFieldInfoPtr_m_AsyncState;

		// Token: 0x04000A62 RID: 2658
		private static readonly IntPtr NativeFieldInfoPtr_m_AsyncCallback;

		// Token: 0x04000A63 RID: 2659
		private static readonly IntPtr NativeFieldInfoPtr_m_Result;

		// Token: 0x04000A64 RID: 2660
		private static readonly IntPtr NativeFieldInfoPtr_m_IntCompleted;

		// Token: 0x04000A65 RID: 2661
		private static readonly IntPtr NativeFieldInfoPtr_m_UserEvent;

		// Token: 0x04000A66 RID: 2662
		private static readonly IntPtr NativeFieldInfoPtr_m_Event;

		// Token: 0x04000A67 RID: 2663
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentThreadContext_Private_Static_get_ThreadContext_0;

		// Token: 0x04000A68 RID: 2664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_Object_AsyncCallback_0;

		// Token: 0x04000A69 RID: 2665
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncObject_Internal_get_Object_0;

		// Token: 0x04000A6A RID: 2666
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04000A6B RID: 2667
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0;

		// Token: 0x04000A6C RID: 2668
		private static readonly IntPtr NativeMethodInfoPtr_LazilyCreateEvent_Private_Boolean_byref_ManualResetEvent_0;

		// Token: 0x04000A6D RID: 2669
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000A6E RID: 2670
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000A6F RID: 2671
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalPeekCompleted_Internal_get_Boolean_0;

		// Token: 0x04000A70 RID: 2672
		private static readonly IntPtr NativeMethodInfoPtr_ProtectedInvokeCallback_Protected_Void_Object_IntPtr_0;

		// Token: 0x04000A71 RID: 2673
		private static readonly IntPtr NativeMethodInfoPtr_InvokeCallback_Internal_Void_Object_0;

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Protected_Virtual_New_Void_IntPtr_0;

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeMethodInfoPtr_WorkerThreadComplete_Private_Void_Object_0;

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Protected_Virtual_New_Void_0;

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeMethodInfoPtr_InternalWaitForCompletion_Internal_Object_0;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletion_Private_Object_Boolean_0;

		// Token: 0x020001B0 RID: 432
		public class ThreadContext : Object
		{
			// Token: 0x06001882 RID: 6274 RVA: 0x00069690 File Offset: 0x00067890
			// Note: this type is marked as 'beforefieldinit'.
			static ThreadContext()
			{
				Il2CppClassPointerStore<LazyAsyncResult.ThreadContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "ThreadContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LazyAsyncResult.ThreadContext>.NativeClassPtr);
				LazyAsyncResult.ThreadContext.NativeFieldInfoPtr_m_NestedIOCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult.ThreadContext>.NativeClassPtr, "m_NestedIOCount");
				LazyAsyncResult.ThreadContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult.ThreadContext>.NativeClassPtr, 100665155);
			}

			// Token: 0x06001883 RID: 6275 RVA: 0x000696E4 File Offset: 0x000678E4
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ThreadContext()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LazyAsyncResult.ThreadContext>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.ThreadContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001884 RID: 6276 RVA: 0x0000CD4E File Offset: 0x0000AF4E
			public ThreadContext(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007D8 RID: 2008
			// (get) Token: 0x06001885 RID: 6277 RVA: 0x00069720 File Offset: 0x00067920
			// (set) Token: 0x06001886 RID: 6278 RVA: 0x0000CD57 File Offset: 0x0000AF57
			public unsafe int m_NestedIOCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.ThreadContext.NativeFieldInfoPtr_m_NestedIOCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.ThreadContext.NativeFieldInfoPtr_m_NestedIOCount)) = value;
				}
			}

			// Token: 0x04001369 RID: 4969
			private static readonly IntPtr NativeFieldInfoPtr_m_NestedIOCount;

			// Token: 0x0400136A RID: 4970
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
