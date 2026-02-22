using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.Remoting.Messaging;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200026E RID: 622
	[Serializable]
	public sealed class ExecutionContext : Object
	{
		// Token: 0x06002ABD RID: 10941 RVA: 0x000DC394 File Offset: 0x000DA594
		// Note: this type is marked as 'beforefieldinit'.
		static ExecutionContext()
		{
			Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ExecutionContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr);
			ExecutionContext.NativeFieldInfoPtr__syncContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "_syncContext");
			ExecutionContext.NativeFieldInfoPtr__syncContextNoFlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "_syncContextNoFlow");
			ExecutionContext.NativeFieldInfoPtr__logicalCallContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "_logicalCallContext");
			ExecutionContext.NativeFieldInfoPtr__illogicalCallContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "_illogicalCallContext");
			ExecutionContext.NativeFieldInfoPtr__flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "_flags");
			ExecutionContext.NativeFieldInfoPtr__localValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "_localValues");
			ExecutionContext.NativeFieldInfoPtr__localChangeNotifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "_localChangeNotifications");
			ExecutionContext.NativeFieldInfoPtr_s_dummyDefaultEC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "s_dummyDefaultEC");
			ExecutionContext.NativeMethodInfoPtr_get_isNewCapture_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670079);
			ExecutionContext.NativeMethodInfoPtr_set_isNewCapture_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670080);
			ExecutionContext.NativeMethodInfoPtr_get_isFlowSuppressed_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670081);
			ExecutionContext.NativeMethodInfoPtr_set_isFlowSuppressed_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670082);
			ExecutionContext.NativeMethodInfoPtr_get_PreAllocatedDefault_Internal_Static_get_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670083);
			ExecutionContext.NativeMethodInfoPtr_get_IsPreAllocatedDefault_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670084);
			ExecutionContext.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670085);
			ExecutionContext.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670086);
			ExecutionContext.NativeMethodInfoPtr_GetLocalValue_Internal_Static_Object_IAsyncLocal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670087);
			ExecutionContext.NativeMethodInfoPtr_SetLocalValue_Internal_Static_Void_IAsyncLocal_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670088);
			ExecutionContext.NativeMethodInfoPtr_OnAsyncLocalContextChanged_Internal_Static_Void_ExecutionContext_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670089);
			ExecutionContext.NativeMethodInfoPtr_get_LogicalCallContext_Internal_get_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670090);
			ExecutionContext.NativeMethodInfoPtr_set_LogicalCallContext_Internal_set_Void_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670091);
			ExecutionContext.NativeMethodInfoPtr_get_IllogicalCallContext_Internal_get_IllogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670092);
			ExecutionContext.NativeMethodInfoPtr_set_IllogicalCallContext_Internal_set_Void_IllogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670093);
			ExecutionContext.NativeMethodInfoPtr_get_SynchronizationContext_Internal_get_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670094);
			ExecutionContext.NativeMethodInfoPtr_set_SynchronizationContext_Internal_set_Void_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670095);
			ExecutionContext.NativeMethodInfoPtr_get_SynchronizationContextNoFlow_Internal_get_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670096);
			ExecutionContext.NativeMethodInfoPtr_set_SynchronizationContextNoFlow_Internal_set_Void_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670097);
			ExecutionContext.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670098);
			ExecutionContext.NativeMethodInfoPtr_Run_Public_Static_Void_ExecutionContext_ContextCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670099);
			ExecutionContext.NativeMethodInfoPtr_Run_Internal_Static_Void_ExecutionContext_ContextCallback_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670100);
			ExecutionContext.NativeMethodInfoPtr_RunInternal_Internal_Static_Void_ExecutionContext_ContextCallback_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670101);
			ExecutionContext.NativeMethodInfoPtr_EstablishCopyOnWriteScope_Internal_Static_Void_byref_ExecutionContextSwitcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670102);
			ExecutionContext.NativeMethodInfoPtr_EstablishCopyOnWriteScope_Private_Static_Void_Thread_Boolean_byref_ExecutionContextSwitcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670103);
			ExecutionContext.NativeMethodInfoPtr_SetExecutionContext_Internal_Static_ExecutionContextSwitcher_ExecutionContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670104);
			ExecutionContext.NativeMethodInfoPtr_CreateCopy_Public_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670105);
			ExecutionContext.NativeMethodInfoPtr_CreateMutableCopy_Internal_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670106);
			ExecutionContext.NativeMethodInfoPtr_IsFlowSuppressed_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670107);
			ExecutionContext.NativeMethodInfoPtr_Capture_Public_Static_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670108);
			ExecutionContext.NativeMethodInfoPtr_FastCapture_Internal_Static_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670109);
			ExecutionContext.NativeMethodInfoPtr_Capture_Internal_Static_ExecutionContext_byref_StackCrawlMark_CaptureOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670110);
			ExecutionContext.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670111);
			ExecutionContext.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670112);
			ExecutionContext.NativeMethodInfoPtr_IsDefaultFTContext_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670113);
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06002ABE RID: 10942 RVA: 0x000DC720 File Offset: 0x000DA920
		// (set) Token: 0x06002ABF RID: 10943 RVA: 0x000DC75C File Offset: 0x000DA95C
		public unsafe bool isNewCapture
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_get_isNewCapture_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_set_isNewCapture_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06002AC0 RID: 10944 RVA: 0x000DC79C File Offset: 0x000DA99C
		// (set) Token: 0x06002AC1 RID: 10945 RVA: 0x000DC7D8 File Offset: 0x000DA9D8
		public unsafe bool isFlowSuppressed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_get_isFlowSuppressed_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_set_isFlowSuppressed_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06002AC2 RID: 10946 RVA: 0x000DC818 File Offset: 0x000DAA18
		public unsafe static ExecutionContext PreAllocatedDefault
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331320, XrefRangeEnd = 331324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_get_PreAllocatedDefault_Internal_Static_get_ExecutionContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06002AC3 RID: 10947 RVA: 0x000DC84C File Offset: 0x000DAA4C
		public unsafe bool IsPreAllocatedDefault
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 331324, RefRangeEnd = 331328, XrefRangeStart = 331324, XrefRangeEnd = 331324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_get_IsPreAllocatedDefault_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AC4 RID: 10948 RVA: 0x000DC888 File Offset: 0x000DAA88
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecutionContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AC5 RID: 10949 RVA: 0x000DC8C4 File Offset: 0x000DAAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331328, XrefRangeEnd = 331329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecutionContext(bool isPreAllocatedDefault)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isPreAllocatedDefault;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AC6 RID: 10950 RVA: 0x000DC90C File Offset: 0x000DAB0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 331332, RefRangeEnd = 331333, XrefRangeStart = 331329, XrefRangeEnd = 331332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetLocalValue(IAsyncLocal local)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(local);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_GetLocalValue_Internal_Static_Object_IAsyncLocal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x000DC950 File Offset: 0x000DAB50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 331368, RefRangeEnd = 331369, XrefRangeStart = 331333, XrefRangeEnd = 331368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLocalValue(IAsyncLocal local, Object newValue, bool needChangeNotifications)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(local);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needChangeNotifications;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_SetLocalValue_Internal_Static_Void_IAsyncLocal_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AC8 RID: 10952 RVA: 0x000DC9A8 File Offset: 0x000DABA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 331410, RefRangeEnd = 331413, XrefRangeStart = 331369, XrefRangeEnd = 331410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(previous);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(current);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_OnAsyncLocalContextChanged_Internal_Static_Void_ExecutionContext_ExecutionContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06002AC9 RID: 10953 RVA: 0x000DC9F0 File Offset: 0x000DABF0
		// (set) Token: 0x06002ACA RID: 10954 RVA: 0x000DCA30 File Offset: 0x000DAC30
		public unsafe LogicalCallContext LogicalCallContext
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 331417, RefRangeEnd = 331422, XrefRangeStart = 331413, XrefRangeEnd = 331417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_get_LogicalCallContext_Internal_get_LogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_set_LogicalCallContext_Internal_set_Void_LogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06002ACB RID: 10955 RVA: 0x000DCA74 File Offset: 0x000DAC74
		// (set) Token: 0x06002ACC RID: 10956 RVA: 0x000DCAB4 File Offset: 0x000DACB4
		public unsafe IllogicalCallContext IllogicalCallContext
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331422, XrefRangeEnd = 331426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_get_IllogicalCallContext_Internal_get_IllogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IllogicalCallContext>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_set_IllogicalCallContext_Internal_set_Void_IllogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06002ACD RID: 10957 RVA: 0x000DCAF8 File Offset: 0x000DACF8
		// (set) Token: 0x06002ACE RID: 10958 RVA: 0x000DCB38 File Offset: 0x000DAD38
		public unsafe SynchronizationContext SynchronizationContext
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_get_SynchronizationContext_Internal_get_SynchronizationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_set_SynchronizationContext_Internal_set_Void_SynchronizationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06002ACF RID: 10959 RVA: 0x000DCB7C File Offset: 0x000DAD7C
		// (set) Token: 0x06002AD0 RID: 10960 RVA: 0x000DCBBC File Offset: 0x000DADBC
		public unsafe SynchronizationContext SynchronizationContextNoFlow
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_get_SynchronizationContextNoFlow_Internal_get_SynchronizationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_set_SynchronizationContextNoFlow_Internal_set_Void_SynchronizationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x000DCC00 File Offset: 0x000DAE00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 331426, RefRangeEnd = 331429, XrefRangeStart = 331426, XrefRangeEnd = 331426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x000DCC34 File Offset: 0x000DAE34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 331437, RefRangeEnd = 331441, XrefRangeStart = 331429, XrefRangeEnd = 331437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Run(ExecutionContext executionContext, ContextCallback callback, Object state)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_Run_Public_Static_Void_ExecutionContext_ContextCallback_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x000DCC90 File Offset: 0x000DAE90
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 331445, RefRangeEnd = 331452, XrefRangeStart = 331441, XrefRangeEnd = 331445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Run(ExecutionContext executionContext, ContextCallback callback, Object state, bool preserveSyncCtx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveSyncCtx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_Run_Internal_Static_Void_ExecutionContext_ContextCallback_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AD4 RID: 10964 RVA: 0x000DCCF8 File Offset: 0x000DAEF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 331481, RefRangeEnd = 331483, XrefRangeStart = 331452, XrefRangeEnd = 331481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state, bool preserveSyncCtx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveSyncCtx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_RunInternal_Internal_Static_Void_ExecutionContext_ContextCallback_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AD5 RID: 10965 RVA: 0x000DCD60 File Offset: 0x000DAF60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 331490, RefRangeEnd = 331493, XrefRangeStart = 331483, XrefRangeEnd = 331490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EstablishCopyOnWriteScope(ref ExecutionContextSwitcher ecsw)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(ecsw);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_EstablishCopyOnWriteScope_Internal_Static_Void_byref_ExecutionContextSwitcher_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x000DCD98 File Offset: 0x000DAF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331493, XrefRangeEnd = 331496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ref ExecutionContextSwitcher ecsw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentThread);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref knownNullWindowsIdentity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(ecsw);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_EstablishCopyOnWriteScope_Private_Static_Void_Thread_Boolean_byref_ExecutionContextSwitcher_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x000DCDF0 File Offset: 0x000DAFF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 331509, RefRangeEnd = 331510, XrefRangeStart = 331496, XrefRangeEnd = 331509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveSyncCtx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_SetExecutionContext_Internal_Static_ExecutionContextSwitcher_ExecutionContext_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ExecutionContextSwitcher(intPtr);
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x000DCE3C File Offset: 0x000DB03C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 331522, RefRangeEnd = 331525, XrefRangeStart = 331510, XrefRangeEnd = 331522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecutionContext CreateCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_CreateCopy_Public_ExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x000DCE7C File Offset: 0x000DB07C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 331541, RefRangeEnd = 331542, XrefRangeStart = 331525, XrefRangeEnd = 331541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecutionContext CreateMutableCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_CreateMutableCopy_Internal_ExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x000DCEBC File Offset: 0x000DB0BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 331545, RefRangeEnd = 331547, XrefRangeStart = 331542, XrefRangeEnd = 331545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsFlowSuppressed()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_IsFlowSuppressed_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002ADB RID: 10971 RVA: 0x000DCEEC File Offset: 0x000DB0EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 331551, RefRangeEnd = 331552, XrefRangeStart = 331547, XrefRangeEnd = 331551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ExecutionContext Capture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_Capture_Public_Static_ExecutionContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
		}

		// Token: 0x06002ADC RID: 10972 RVA: 0x000DCF20 File Offset: 0x000DB120
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 331556, RefRangeEnd = 331558, XrefRangeStart = 331552, XrefRangeEnd = 331556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ExecutionContext FastCapture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_FastCapture_Internal_Static_ExecutionContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x000DCF54 File Offset: 0x000DB154
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 331562, RefRangeEnd = 331573, XrefRangeStart = 331558, XrefRangeEnd = 331562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ExecutionContext Capture(ref StackCrawlMark stackMark, ExecutionContext.CaptureOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &stackMark;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_Capture_Internal_Static_ExecutionContext_byref_StackCrawlMark_CaptureOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x000DCFA4 File Offset: 0x000DB1A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331573, XrefRangeEnd = 331582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x000DD000 File Offset: 0x000DB200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331582, XrefRangeEnd = 331594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecutionContext(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x000DD064 File Offset: 0x000DB264
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 331596, RefRangeEnd = 331597, XrefRangeStart = 331594, XrefRangeEnd = 331596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDefaultFTContext(bool ignoreSyncCtx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ignoreSyncCtx;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_IsDefaultFTContext_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x0000EEEB File Offset: 0x0000D0EB
		public ExecutionContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06002AE2 RID: 10978 RVA: 0x000DD0B0 File Offset: 0x000DB2B0
		// (set) Token: 0x06002AE3 RID: 10979 RVA: 0x0000EEF4 File Offset: 0x0000D0F4
		public unsafe SynchronizationContext _syncContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__syncContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__syncContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06002AE4 RID: 10980 RVA: 0x000DD0E0 File Offset: 0x000DB2E0
		// (set) Token: 0x06002AE5 RID: 10981 RVA: 0x0000EF13 File Offset: 0x0000D113
		public unsafe SynchronizationContext _syncContextNoFlow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__syncContextNoFlow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__syncContextNoFlow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06002AE6 RID: 10982 RVA: 0x000DD110 File Offset: 0x000DB310
		// (set) Token: 0x06002AE7 RID: 10983 RVA: 0x0000EF32 File Offset: 0x0000D132
		public unsafe LogicalCallContext _logicalCallContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__logicalCallContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__logicalCallContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06002AE8 RID: 10984 RVA: 0x000DD140 File Offset: 0x000DB340
		// (set) Token: 0x06002AE9 RID: 10985 RVA: 0x0000EF51 File Offset: 0x0000D151
		public unsafe IllogicalCallContext _illogicalCallContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__illogicalCallContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IllogicalCallContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__illogicalCallContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06002AEA RID: 10986 RVA: 0x000DD170 File Offset: 0x000DB370
		// (set) Token: 0x06002AEB RID: 10987 RVA: 0x0000EF70 File Offset: 0x0000D170
		public unsafe ExecutionContext.Flags _flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__flags)) = value;
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06002AEC RID: 10988 RVA: 0x000DD198 File Offset: 0x000DB398
		// (set) Token: 0x06002AED RID: 10989 RVA: 0x0000EF8B File Offset: 0x0000D18B
		public unsafe Dictionary<IAsyncLocal, Object> _localValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__localValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<IAsyncLocal, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__localValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06002AEE RID: 10990 RVA: 0x000DD1C8 File Offset: 0x000DB3C8
		// (set) Token: 0x06002AEF RID: 10991 RVA: 0x0000EFAA File Offset: 0x0000D1AA
		public unsafe List<IAsyncLocal> _localChangeNotifications
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__localChangeNotifications);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IAsyncLocal>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__localChangeNotifications), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06002AF0 RID: 10992 RVA: 0x000DD1F8 File Offset: 0x000DB3F8
		// (set) Token: 0x06002AF1 RID: 10993 RVA: 0x0000EFC9 File Offset: 0x0000D1C9
		public unsafe static ExecutionContext s_dummyDefaultEC
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecutionContext.NativeFieldInfoPtr_s_dummyDefaultEC, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecutionContext.NativeFieldInfoPtr_s_dummyDefaultEC, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002562 RID: 9570
		private static readonly IntPtr NativeFieldInfoPtr__syncContext;

		// Token: 0x04002563 RID: 9571
		private static readonly IntPtr NativeFieldInfoPtr__syncContextNoFlow;

		// Token: 0x04002564 RID: 9572
		private static readonly IntPtr NativeFieldInfoPtr__logicalCallContext;

		// Token: 0x04002565 RID: 9573
		private static readonly IntPtr NativeFieldInfoPtr__illogicalCallContext;

		// Token: 0x04002566 RID: 9574
		private static readonly IntPtr NativeFieldInfoPtr__flags;

		// Token: 0x04002567 RID: 9575
		private static readonly IntPtr NativeFieldInfoPtr__localValues;

		// Token: 0x04002568 RID: 9576
		private static readonly IntPtr NativeFieldInfoPtr__localChangeNotifications;

		// Token: 0x04002569 RID: 9577
		private static readonly IntPtr NativeFieldInfoPtr_s_dummyDefaultEC;

		// Token: 0x0400256A RID: 9578
		private static readonly IntPtr NativeMethodInfoPtr_get_isNewCapture_Internal_get_Boolean_0;

		// Token: 0x0400256B RID: 9579
		private static readonly IntPtr NativeMethodInfoPtr_set_isNewCapture_Internal_set_Void_Boolean_0;

		// Token: 0x0400256C RID: 9580
		private static readonly IntPtr NativeMethodInfoPtr_get_isFlowSuppressed_Internal_get_Boolean_0;

		// Token: 0x0400256D RID: 9581
		private static readonly IntPtr NativeMethodInfoPtr_set_isFlowSuppressed_Internal_set_Void_Boolean_0;

		// Token: 0x0400256E RID: 9582
		private static readonly IntPtr NativeMethodInfoPtr_get_PreAllocatedDefault_Internal_Static_get_ExecutionContext_0;

		// Token: 0x0400256F RID: 9583
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPreAllocatedDefault_Internal_get_Boolean_0;

		// Token: 0x04002570 RID: 9584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002571 RID: 9585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x04002572 RID: 9586
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalValue_Internal_Static_Object_IAsyncLocal_0;

		// Token: 0x04002573 RID: 9587
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalValue_Internal_Static_Void_IAsyncLocal_Object_Boolean_0;

		// Token: 0x04002574 RID: 9588
		private static readonly IntPtr NativeMethodInfoPtr_OnAsyncLocalContextChanged_Internal_Static_Void_ExecutionContext_ExecutionContext_0;

		// Token: 0x04002575 RID: 9589
		private static readonly IntPtr NativeMethodInfoPtr_get_LogicalCallContext_Internal_get_LogicalCallContext_0;

		// Token: 0x04002576 RID: 9590
		private static readonly IntPtr NativeMethodInfoPtr_set_LogicalCallContext_Internal_set_Void_LogicalCallContext_0;

		// Token: 0x04002577 RID: 9591
		private static readonly IntPtr NativeMethodInfoPtr_get_IllogicalCallContext_Internal_get_IllogicalCallContext_0;

		// Token: 0x04002578 RID: 9592
		private static readonly IntPtr NativeMethodInfoPtr_set_IllogicalCallContext_Internal_set_Void_IllogicalCallContext_0;

		// Token: 0x04002579 RID: 9593
		private static readonly IntPtr NativeMethodInfoPtr_get_SynchronizationContext_Internal_get_SynchronizationContext_0;

		// Token: 0x0400257A RID: 9594
		private static readonly IntPtr NativeMethodInfoPtr_set_SynchronizationContext_Internal_set_Void_SynchronizationContext_0;

		// Token: 0x0400257B RID: 9595
		private static readonly IntPtr NativeMethodInfoPtr_get_SynchronizationContextNoFlow_Internal_get_SynchronizationContext_0;

		// Token: 0x0400257C RID: 9596
		private static readonly IntPtr NativeMethodInfoPtr_set_SynchronizationContextNoFlow_Internal_set_Void_SynchronizationContext_0;

		// Token: 0x0400257D RID: 9597
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400257E RID: 9598
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Static_Void_ExecutionContext_ContextCallback_Object_0;

		// Token: 0x0400257F RID: 9599
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Static_Void_ExecutionContext_ContextCallback_Object_Boolean_0;

		// Token: 0x04002580 RID: 9600
		private static readonly IntPtr NativeMethodInfoPtr_RunInternal_Internal_Static_Void_ExecutionContext_ContextCallback_Object_Boolean_0;

		// Token: 0x04002581 RID: 9601
		private static readonly IntPtr NativeMethodInfoPtr_EstablishCopyOnWriteScope_Internal_Static_Void_byref_ExecutionContextSwitcher_0;

		// Token: 0x04002582 RID: 9602
		private static readonly IntPtr NativeMethodInfoPtr_EstablishCopyOnWriteScope_Private_Static_Void_Thread_Boolean_byref_ExecutionContextSwitcher_0;

		// Token: 0x04002583 RID: 9603
		private static readonly IntPtr NativeMethodInfoPtr_SetExecutionContext_Internal_Static_ExecutionContextSwitcher_ExecutionContext_Boolean_0;

		// Token: 0x04002584 RID: 9604
		private static readonly IntPtr NativeMethodInfoPtr_CreateCopy_Public_ExecutionContext_0;

		// Token: 0x04002585 RID: 9605
		private static readonly IntPtr NativeMethodInfoPtr_CreateMutableCopy_Internal_ExecutionContext_0;

		// Token: 0x04002586 RID: 9606
		private static readonly IntPtr NativeMethodInfoPtr_IsFlowSuppressed_Public_Static_Boolean_0;

		// Token: 0x04002587 RID: 9607
		private static readonly IntPtr NativeMethodInfoPtr_Capture_Public_Static_ExecutionContext_0;

		// Token: 0x04002588 RID: 9608
		private static readonly IntPtr NativeMethodInfoPtr_FastCapture_Internal_Static_ExecutionContext_0;

		// Token: 0x04002589 RID: 9609
		private static readonly IntPtr NativeMethodInfoPtr_Capture_Internal_Static_ExecutionContext_byref_StackCrawlMark_CaptureOptions_0;

		// Token: 0x0400258A RID: 9610
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400258B RID: 9611
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400258C RID: 9612
		private static readonly IntPtr NativeMethodInfoPtr_IsDefaultFTContext_Internal_Boolean_Boolean_0;

		// Token: 0x020005EA RID: 1514
		public enum Flags
		{
			// Token: 0x040042BF RID: 17087
			None,
			// Token: 0x040042C0 RID: 17088
			IsNewCapture,
			// Token: 0x040042C1 RID: 17089
			IsFlowSuppressed,
			// Token: 0x040042C2 RID: 17090
			IsPreAllocatedDefault = 4
		}

		// Token: 0x020005EB RID: 1515
		public sealed class Reader : ValueType
		{
			// Token: 0x06005257 RID: 21079 RVA: 0x0016F360 File Offset: 0x0016D560
			// Note: this type is marked as 'beforefieldinit'.
			static Reader()
			{
				Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "Reader");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr);
				ExecutionContext.Reader.NativeFieldInfoPtr_m_ec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, "m_ec");
				ExecutionContext.Reader.NativeMethodInfoPtr__ctor_Public_Void_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100670115);
				ExecutionContext.Reader.NativeMethodInfoPtr_DangerousGetRawExecutionContext_Public_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100670116);
				ExecutionContext.Reader.NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100670117);
				ExecutionContext.Reader.NativeMethodInfoPtr_IsDefaultFTContext_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100670118);
				ExecutionContext.Reader.NativeMethodInfoPtr_get_IsFlowSuppressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100670119);
				ExecutionContext.Reader.NativeMethodInfoPtr_get_SynchronizationContext_Public_get_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100670120);
				ExecutionContext.Reader.NativeMethodInfoPtr_get_SynchronizationContextNoFlow_Public_get_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100670121);
				ExecutionContext.Reader.NativeMethodInfoPtr_get_LogicalCallContext_Public_get_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100670122);
				ExecutionContext.Reader.NativeMethodInfoPtr_GetLocalValue_Public_Object_IAsyncLocal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100670123);
				ExecutionContext.Reader.NativeMethodInfoPtr_HasSameLocalValues_Public_Boolean_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100670124);
			}

			// Token: 0x06005258 RID: 21080 RVA: 0x0016F468 File Offset: 0x0016D668
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Reader(ExecutionContext ec)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ec);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr__ctor_Public_Void_ExecutionContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005259 RID: 21081 RVA: 0x0016F4B8 File Offset: 0x0016D6B8
			[CallerCount(0)]
			public unsafe ExecutionContext DangerousGetRawExecutionContext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr_DangerousGetRawExecutionContext_Public_ExecutionContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
			}

			// Token: 0x1700150A RID: 5386
			// (get) Token: 0x0600525A RID: 21082 RVA: 0x0016F4FC File Offset: 0x0016D6FC
			public unsafe bool IsNull
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 305860, RefRangeEnd = 305866, XrefRangeStart = 305860, XrefRangeEnd = 305866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600525B RID: 21083 RVA: 0x0016F540 File Offset: 0x0016D740
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 331307, RefRangeEnd = 331308, XrefRangeStart = 331305, XrefRangeEnd = 331307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsDefaultFTContext(bool ignoreSyncCtx)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref ignoreSyncCtx;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr_IsDefaultFTContext_Public_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700150B RID: 5387
			// (get) Token: 0x0600525C RID: 21084 RVA: 0x0016F590 File Offset: 0x0016D790
			public unsafe bool IsFlowSuppressed
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr_get_IsFlowSuppressed_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700150C RID: 5388
			// (get) Token: 0x0600525D RID: 21085 RVA: 0x0016F5D4 File Offset: 0x0016D7D4
			public unsafe SynchronizationContext SynchronizationContext
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 331308, RefRangeEnd = 331310, XrefRangeStart = 331308, XrefRangeEnd = 331308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr_get_SynchronizationContext_Public_get_SynchronizationContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
				}
			}

			// Token: 0x1700150D RID: 5389
			// (get) Token: 0x0600525E RID: 21086 RVA: 0x0016F618 File Offset: 0x0016D818
			public unsafe SynchronizationContext SynchronizationContextNoFlow
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 331310, RefRangeEnd = 331313, XrefRangeStart = 331310, XrefRangeEnd = 331310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr_get_SynchronizationContextNoFlow_Public_get_SynchronizationContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
				}
			}

			// Token: 0x1700150E RID: 5390
			// (get) Token: 0x0600525F RID: 21087 RVA: 0x0016F65C File Offset: 0x0016D85C
			public unsafe LogicalCallContext.Reader LogicalCallContext
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 331313, RefRangeEnd = 331314, XrefRangeStart = 331313, XrefRangeEnd = 331313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr_get_LogicalCallContext_Public_get_Reader_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new LogicalCallContext.Reader(intPtr);
				}
			}

			// Token: 0x06005260 RID: 21088 RVA: 0x0016F698 File Offset: 0x0016D898
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 331317, RefRangeEnd = 331318, XrefRangeStart = 331314, XrefRangeEnd = 331317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object GetLocalValue(IAsyncLocal local)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(local);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr_GetLocalValue_Public_Object_IAsyncLocal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005261 RID: 21089 RVA: 0x0016F6F0 File Offset: 0x0016D8F0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 331319, RefRangeEnd = 331320, XrefRangeStart = 331318, XrefRangeEnd = 331319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool HasSameLocalValues(ExecutionContext other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr_HasSameLocalValues_Public_Boolean_ExecutionContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005262 RID: 21090 RVA: 0x0001F740 File Offset: 0x0001D940
			public Reader(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005263 RID: 21091 RVA: 0x0001F749 File Offset: 0x0001D949
			public Reader()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr))
			{
			}

			// Token: 0x17001509 RID: 5385
			// (get) Token: 0x06005264 RID: 21092 RVA: 0x0016F744 File Offset: 0x0016D944
			// (set) Token: 0x06005265 RID: 21093 RVA: 0x0001F75B File Offset: 0x0001D95B
			public unsafe ExecutionContext m_ec
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.Reader.NativeFieldInfoPtr_m_ec);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.Reader.NativeFieldInfoPtr_m_ec), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040042C3 RID: 17091
			private static readonly IntPtr NativeFieldInfoPtr_m_ec;

			// Token: 0x040042C4 RID: 17092
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ExecutionContext_0;

			// Token: 0x040042C5 RID: 17093
			private static readonly IntPtr NativeMethodInfoPtr_DangerousGetRawExecutionContext_Public_ExecutionContext_0;

			// Token: 0x040042C6 RID: 17094
			private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0;

			// Token: 0x040042C7 RID: 17095
			private static readonly IntPtr NativeMethodInfoPtr_IsDefaultFTContext_Public_Boolean_Boolean_0;

			// Token: 0x040042C8 RID: 17096
			private static readonly IntPtr NativeMethodInfoPtr_get_IsFlowSuppressed_Public_get_Boolean_0;

			// Token: 0x040042C9 RID: 17097
			private static readonly IntPtr NativeMethodInfoPtr_get_SynchronizationContext_Public_get_SynchronizationContext_0;

			// Token: 0x040042CA RID: 17098
			private static readonly IntPtr NativeMethodInfoPtr_get_SynchronizationContextNoFlow_Public_get_SynchronizationContext_0;

			// Token: 0x040042CB RID: 17099
			private static readonly IntPtr NativeMethodInfoPtr_get_LogicalCallContext_Public_get_Reader_0;

			// Token: 0x040042CC RID: 17100
			private static readonly IntPtr NativeMethodInfoPtr_GetLocalValue_Public_Object_IAsyncLocal_0;

			// Token: 0x040042CD RID: 17101
			private static readonly IntPtr NativeMethodInfoPtr_HasSameLocalValues_Public_Boolean_ExecutionContext_0;
		}

		// Token: 0x020005EC RID: 1516
		[Flags]
		public enum CaptureOptions
		{
			// Token: 0x040042CF RID: 17103
			None = 0,
			// Token: 0x040042D0 RID: 17104
			IgnoreSyncCtx = 1,
			// Token: 0x040042D1 RID: 17105
			OptimizeDefaultCase = 2
		}
	}
}
