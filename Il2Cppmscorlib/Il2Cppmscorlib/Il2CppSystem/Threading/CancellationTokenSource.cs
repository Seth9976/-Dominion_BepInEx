using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000258 RID: 600
	public class CancellationTokenSource : Object
	{
		// Token: 0x060029A2 RID: 10658 RVA: 0x000D82C8 File Offset: 0x000D64C8
		// Note: this type is marked as 'beforefieldinit'.
		static CancellationTokenSource()
		{
			Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "CancellationTokenSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr);
			CancellationTokenSource.NativeFieldInfoPtr__staticSource_Set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "_staticSource_Set");
			CancellationTokenSource.NativeFieldInfoPtr__staticSource_NotCancelable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "_staticSource_NotCancelable");
			CancellationTokenSource.NativeFieldInfoPtr_s_nLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "s_nLists");
			CancellationTokenSource.NativeFieldInfoPtr_m_kernelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "m_kernelEvent");
			CancellationTokenSource.NativeFieldInfoPtr_m_registeredCallbacksLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "m_registeredCallbacksLists");
			CancellationTokenSource.NativeFieldInfoPtr_m_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "m_state");
			CancellationTokenSource.NativeFieldInfoPtr_m_threadIDExecutingCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "m_threadIDExecutingCallbacks");
			CancellationTokenSource.NativeFieldInfoPtr_m_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "m_disposed");
			CancellationTokenSource.NativeFieldInfoPtr_m_linkingRegistrations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "m_linkingRegistrations");
			CancellationTokenSource.NativeFieldInfoPtr_s_LinkedTokenCancelDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "s_LinkedTokenCancelDelegate");
			CancellationTokenSource.NativeFieldInfoPtr_m_executingCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "m_executingCallback");
			CancellationTokenSource.NativeFieldInfoPtr_m_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "m_timer");
			CancellationTokenSource.NativeFieldInfoPtr_s_timerCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "s_timerCallback");
			CancellationTokenSource.NativeMethodInfoPtr_LinkedTokenCancelDelegate_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669945);
			CancellationTokenSource.NativeMethodInfoPtr_get_IsCancellationRequested_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669946);
			CancellationTokenSource.NativeMethodInfoPtr_get_IsCancellationCompleted_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669947);
			CancellationTokenSource.NativeMethodInfoPtr_get_IsDisposed_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669948);
			CancellationTokenSource.NativeMethodInfoPtr_set_ThreadIDExecutingCallbacks_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669949);
			CancellationTokenSource.NativeMethodInfoPtr_get_ThreadIDExecutingCallbacks_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669950);
			CancellationTokenSource.NativeMethodInfoPtr_get_Token_Public_get_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669951);
			CancellationTokenSource.NativeMethodInfoPtr_get_CanBeCanceled_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669952);
			CancellationTokenSource.NativeMethodInfoPtr_get_ExecutingCallback_Internal_get_CancellationCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669953);
			CancellationTokenSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669954);
			CancellationTokenSource.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669955);
			CancellationTokenSource.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669956);
			CancellationTokenSource.NativeMethodInfoPtr_Cancel_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669957);
			CancellationTokenSource.NativeMethodInfoPtr_CancelAfter_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669958);
			CancellationTokenSource.NativeMethodInfoPtr_TimerCallbackLogic_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669959);
			CancellationTokenSource.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669960);
			CancellationTokenSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669961);
			CancellationTokenSource.NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669962);
			CancellationTokenSource.NativeMethodInfoPtr_ThrowObjectDisposedException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669963);
			CancellationTokenSource.NativeMethodInfoPtr_InternalGetStaticSource_Internal_Static_CancellationTokenSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669964);
			CancellationTokenSource.NativeMethodInfoPtr_InternalRegister_Internal_CancellationTokenRegistration_Action_1_Object_Object_SynchronizationContext_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669965);
			CancellationTokenSource.NativeMethodInfoPtr_NotifyCancellation_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669966);
			CancellationTokenSource.NativeMethodInfoPtr_ExecuteCallbackHandlers_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669967);
			CancellationTokenSource.NativeMethodInfoPtr_CancellationCallbackCoreWork_OnSyncContext_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669968);
			CancellationTokenSource.NativeMethodInfoPtr_CancellationCallbackCoreWork_Private_Void_CancellationCallbackCoreWorkArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669969);
			CancellationTokenSource.NativeMethodInfoPtr_CreateLinkedTokenSource_Public_Static_CancellationTokenSource_CancellationToken_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669970);
			CancellationTokenSource.NativeMethodInfoPtr_CreateLinkedTokenSource_Public_Static_CancellationTokenSource_Il2CppReferenceArray_1_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669971);
			CancellationTokenSource.NativeMethodInfoPtr_WaitForCallbackToComplete_Internal_Void_CancellationCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100669972);
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x000D862C File Offset: 0x000D682C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330223, XrefRangeEnd = 330231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LinkedTokenCancelDelegate(Object source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_LinkedTokenCancelDelegate_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x060029A4 RID: 10660 RVA: 0x000D8664 File Offset: 0x000D6864
		public unsafe bool IsCancellationRequested
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 330232, RefRangeEnd = 330241, XrefRangeStart = 330231, XrefRangeEnd = 330232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_get_IsCancellationRequested_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x060029A5 RID: 10661 RVA: 0x000D86A0 File Offset: 0x000D68A0
		public unsafe bool IsCancellationCompleted
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330241, XrefRangeEnd = 330242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_get_IsCancellationCompleted_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x060029A6 RID: 10662 RVA: 0x000D86DC File Offset: 0x000D68DC
		public unsafe bool IsDisposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_get_IsDisposed_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x060029A8 RID: 10664 RVA: 0x000D8758 File Offset: 0x000D6958
		// (set) Token: 0x060029A7 RID: 10663 RVA: 0x000D8718 File Offset: 0x000D6918
		public unsafe int ThreadIDExecutingCallbacks
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330243, XrefRangeEnd = 330244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_get_ThreadIDExecutingCallbacks_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330242, XrefRangeEnd = 330243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_set_ThreadIDExecutingCallbacks_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x060029A9 RID: 10665 RVA: 0x000D8794 File Offset: 0x000D6994
		public unsafe CancellationToken Token
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 330245, RefRangeEnd = 330251, XrefRangeStart = 330244, XrefRangeEnd = 330245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_get_Token_Public_get_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CancellationToken(intPtr);
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x060029AA RID: 10666 RVA: 0x000D87CC File Offset: 0x000D69CC
		public unsafe bool CanBeCanceled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330251, XrefRangeEnd = 330252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_get_CanBeCanceled_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x060029AB RID: 10667 RVA: 0x000D8808 File Offset: 0x000D6A08
		public unsafe CancellationCallbackInfo ExecutingCallback
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330252, XrefRangeEnd = 330253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_get_ExecutingCallback_Internal_get_CancellationCallbackInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CancellationCallbackInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060029AC RID: 10668 RVA: 0x000D8848 File Offset: 0x000D6A48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 330256, RefRangeEnd = 330259, XrefRangeStart = 330253, XrefRangeEnd = 330256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationTokenSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x000D8884 File Offset: 0x000D6A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330259, XrefRangeEnd = 330262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationTokenSource(bool set)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref set;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x000D88CC File Offset: 0x000D6ACC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 330267, RefRangeEnd = 330275, XrefRangeStart = 330262, XrefRangeEnd = 330267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x000D8900 File Offset: 0x000D6B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330275, XrefRangeEnd = 330280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel(bool throwOnFirstException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref throwOnFirstException;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_Cancel_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x000D8940 File Offset: 0x000D6B40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 330297, RefRangeEnd = 330298, XrefRangeStart = 330280, XrefRangeEnd = 330297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelAfter(int millisecondsDelay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsDelay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_CancelAfter_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x000D8980 File Offset: 0x000D6B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330298, XrefRangeEnd = 330303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TimerCallbackLogic(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_TimerCallbackLogic_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x000D89B8 File Offset: 0x000D6BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330303, XrefRangeEnd = 330307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x000D89EC File Offset: 0x000D6BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330307, XrefRangeEnd = 330315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CancellationTokenSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x000D8A38 File Offset: 0x000D6C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330315, XrefRangeEnd = 330316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x000D8A6C File Offset: 0x000D6C6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 330323, RefRangeEnd = 330326, XrefRangeStart = 330316, XrefRangeEnd = 330323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowObjectDisposedException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_ThrowObjectDisposedException_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x000D8A94 File Offset: 0x000D6C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330326, XrefRangeEnd = 330330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CancellationTokenSource InternalGetStaticSource(bool set)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref set;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_InternalGetStaticSource_Internal_Static_CancellationTokenSource_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr3) : null;
			}
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x000D8AD4 File Offset: 0x000D6CD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 330372, RefRangeEnd = 330373, XrefRangeStart = 330330, XrefRangeEnd = 330372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationTokenRegistration InternalRegister(Action<Object> callback, Object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stateForCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetSyncContext);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_InternalRegister_Internal_CancellationTokenRegistration_Action_1_Object_Object_SynchronizationContext_ExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CancellationTokenRegistration(intPtr);
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x000D8B54 File Offset: 0x000D6D54
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 330386, RefRangeEnd = 330390, XrefRangeStart = 330373, XrefRangeEnd = 330386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyCancellation(bool throwOnFirstException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref throwOnFirstException;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_NotifyCancellation_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x000D8B94 File Offset: 0x000D6D94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 330442, RefRangeEnd = 330443, XrefRangeStart = 330390, XrefRangeEnd = 330442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteCallbackHandlers(bool throwOnFirstException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref throwOnFirstException;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_ExecuteCallbackHandlers_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x000D8BD4 File Offset: 0x000D6DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330443, XrefRangeEnd = 330447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancellationCallbackCoreWork_OnSyncContext(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_CancellationCallbackCoreWork_OnSyncContext_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x000D8C18 File Offset: 0x000D6E18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 330464, RefRangeEnd = 330466, XrefRangeStart = 330447, XrefRangeEnd = 330464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_CancellationCallbackCoreWork_Private_Void_CancellationCallbackCoreWorkArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x000D8C60 File Offset: 0x000D6E60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 330488, RefRangeEnd = 330489, XrefRangeStart = 330466, XrefRangeEnd = 330488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token1));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token2));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_CreateLinkedTokenSource_Public_Static_CancellationTokenSource_CancellationToken_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr3) : null;
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x000D8CC0 File Offset: 0x000D6EC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 330504, RefRangeEnd = 330505, XrefRangeStart = 330489, XrefRangeEnd = 330504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CancellationTokenSource CreateLinkedTokenSource([Optional] Il2CppReferenceArray<CancellationToken> tokens)
		{
			if (tokens == null)
			{
				tokens = new Il2CppStructArray<CancellationToken>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_CreateLinkedTokenSource_Public_Static_CancellationTokenSource_Il2CppReferenceArray_1_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr3) : null;
			}
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x000D8D14 File Offset: 0x000D6F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330505, XrefRangeEnd = 330508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callbackInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_WaitForCallbackToComplete_Internal_Void_CancellationCallbackInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x0000E7BD File Offset: 0x0000C9BD
		public static CancellationTokenSource CreateLinkedTokenSource(params CancellationToken[] tokens)
		{
			return CancellationTokenSource.CreateLinkedTokenSource(new Il2CppReferenceArray<CancellationToken>(tokens));
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x0000E7CA File Offset: 0x0000C9CA
		public CancellationTokenSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x060029C1 RID: 10689 RVA: 0x000D8D58 File Offset: 0x000D6F58
		// (set) Token: 0x060029C2 RID: 10690 RVA: 0x0000E7D3 File Offset: 0x0000C9D3
		public unsafe static CancellationTokenSource _staticSource_Set
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CancellationTokenSource.NativeFieldInfoPtr__staticSource_Set, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationTokenSource.NativeFieldInfoPtr__staticSource_Set, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x060029C3 RID: 10691 RVA: 0x000D8D80 File Offset: 0x000D6F80
		// (set) Token: 0x060029C4 RID: 10692 RVA: 0x0000E7E5 File Offset: 0x0000C9E5
		public unsafe static CancellationTokenSource _staticSource_NotCancelable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CancellationTokenSource.NativeFieldInfoPtr__staticSource_NotCancelable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationTokenSource.NativeFieldInfoPtr__staticSource_NotCancelable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x060029C5 RID: 10693 RVA: 0x000D8DA8 File Offset: 0x000D6FA8
		// (set) Token: 0x060029C6 RID: 10694 RVA: 0x0000E7F7 File Offset: 0x0000C9F7
		public unsafe static int s_nLists
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CancellationTokenSource.NativeFieldInfoPtr_s_nLists, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationTokenSource.NativeFieldInfoPtr_s_nLists, (void*)(&value));
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x060029C7 RID: 10695 RVA: 0x000D8DC4 File Offset: 0x000D6FC4
		// (set) Token: 0x060029C8 RID: 10696 RVA: 0x0000E805 File Offset: 0x0000CA05
		public unsafe ManualResetEvent m_kernelEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_kernelEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_kernelEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x060029C9 RID: 10697 RVA: 0x000D8DF4 File Offset: 0x000D6FF4
		// (set) Token: 0x060029CA RID: 10698 RVA: 0x0000E824 File Offset: 0x0000CA24
		public unsafe Il2CppReferenceArray<SparselyPopulatedArray<CancellationCallbackInfo>> m_registeredCallbacksLists
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_registeredCallbacksLists);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SparselyPopulatedArray<CancellationCallbackInfo>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_registeredCallbacksLists), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x060029CB RID: 10699 RVA: 0x000D8E24 File Offset: 0x000D7024
		// (set) Token: 0x060029CC RID: 10700 RVA: 0x0000E843 File Offset: 0x0000CA43
		public unsafe int m_state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_state)) = value;
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x060029CD RID: 10701 RVA: 0x000D8E4C File Offset: 0x000D704C
		// (set) Token: 0x060029CE RID: 10702 RVA: 0x0000E85E File Offset: 0x0000CA5E
		public unsafe int m_threadIDExecutingCallbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_threadIDExecutingCallbacks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_threadIDExecutingCallbacks)) = value;
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x060029CF RID: 10703 RVA: 0x000D8E74 File Offset: 0x000D7074
		// (set) Token: 0x060029D0 RID: 10704 RVA: 0x0000E879 File Offset: 0x0000CA79
		public unsafe bool m_disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_disposed)) = value;
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x060029D1 RID: 10705 RVA: 0x000D8E9C File Offset: 0x000D709C
		// (set) Token: 0x060029D2 RID: 10706 RVA: 0x0000E894 File Offset: 0x0000CA94
		public unsafe Il2CppReferenceArray<CancellationTokenRegistration> m_linkingRegistrations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_linkingRegistrations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CancellationTokenRegistration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_linkingRegistrations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x060029D3 RID: 10707 RVA: 0x000D8ECC File Offset: 0x000D70CC
		// (set) Token: 0x060029D4 RID: 10708 RVA: 0x0000E8B3 File Offset: 0x0000CAB3
		public unsafe static Action<Object> s_LinkedTokenCancelDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CancellationTokenSource.NativeFieldInfoPtr_s_LinkedTokenCancelDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationTokenSource.NativeFieldInfoPtr_s_LinkedTokenCancelDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x060029D5 RID: 10709 RVA: 0x000D8EF4 File Offset: 0x000D70F4
		// (set) Token: 0x060029D6 RID: 10710 RVA: 0x0000E8C5 File Offset: 0x0000CAC5
		public unsafe CancellationCallbackInfo m_executingCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_executingCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationCallbackInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_executingCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x060029D7 RID: 10711 RVA: 0x000D8F24 File Offset: 0x000D7124
		// (set) Token: 0x060029D8 RID: 10712 RVA: 0x0000E8E4 File Offset: 0x0000CAE4
		public unsafe Timer m_timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_timer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Timer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr_m_timer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x060029D9 RID: 10713 RVA: 0x000D8F54 File Offset: 0x000D7154
		// (set) Token: 0x060029DA RID: 10714 RVA: 0x0000E903 File Offset: 0x0000CB03
		public unsafe static TimerCallback s_timerCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CancellationTokenSource.NativeFieldInfoPtr_s_timerCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationTokenSource.NativeFieldInfoPtr_s_timerCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040024A8 RID: 9384
		private static readonly IntPtr NativeFieldInfoPtr__staticSource_Set;

		// Token: 0x040024A9 RID: 9385
		private static readonly IntPtr NativeFieldInfoPtr__staticSource_NotCancelable;

		// Token: 0x040024AA RID: 9386
		private static readonly IntPtr NativeFieldInfoPtr_s_nLists;

		// Token: 0x040024AB RID: 9387
		private static readonly IntPtr NativeFieldInfoPtr_m_kernelEvent;

		// Token: 0x040024AC RID: 9388
		private static readonly IntPtr NativeFieldInfoPtr_m_registeredCallbacksLists;

		// Token: 0x040024AD RID: 9389
		private static readonly IntPtr NativeFieldInfoPtr_m_state;

		// Token: 0x040024AE RID: 9390
		private static readonly IntPtr NativeFieldInfoPtr_m_threadIDExecutingCallbacks;

		// Token: 0x040024AF RID: 9391
		private static readonly IntPtr NativeFieldInfoPtr_m_disposed;

		// Token: 0x040024B0 RID: 9392
		private static readonly IntPtr NativeFieldInfoPtr_m_linkingRegistrations;

		// Token: 0x040024B1 RID: 9393
		private static readonly IntPtr NativeFieldInfoPtr_s_LinkedTokenCancelDelegate;

		// Token: 0x040024B2 RID: 9394
		private static readonly IntPtr NativeFieldInfoPtr_m_executingCallback;

		// Token: 0x040024B3 RID: 9395
		private static readonly IntPtr NativeFieldInfoPtr_m_timer;

		// Token: 0x040024B4 RID: 9396
		private static readonly IntPtr NativeFieldInfoPtr_s_timerCallback;

		// Token: 0x040024B5 RID: 9397
		private static readonly IntPtr NativeMethodInfoPtr_LinkedTokenCancelDelegate_Private_Static_Void_Object_0;

		// Token: 0x040024B6 RID: 9398
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCancellationRequested_Public_get_Boolean_0;

		// Token: 0x040024B7 RID: 9399
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCancellationCompleted_Internal_get_Boolean_0;

		// Token: 0x040024B8 RID: 9400
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDisposed_Internal_get_Boolean_0;

		// Token: 0x040024B9 RID: 9401
		private static readonly IntPtr NativeMethodInfoPtr_set_ThreadIDExecutingCallbacks_Internal_set_Void_Int32_0;

		// Token: 0x040024BA RID: 9402
		private static readonly IntPtr NativeMethodInfoPtr_get_ThreadIDExecutingCallbacks_Internal_get_Int32_0;

		// Token: 0x040024BB RID: 9403
		private static readonly IntPtr NativeMethodInfoPtr_get_Token_Public_get_CancellationToken_0;

		// Token: 0x040024BC RID: 9404
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeCanceled_Internal_get_Boolean_0;

		// Token: 0x040024BD RID: 9405
		private static readonly IntPtr NativeMethodInfoPtr_get_ExecutingCallback_Internal_get_CancellationCallbackInfo_0;

		// Token: 0x040024BE RID: 9406
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040024BF RID: 9407
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Boolean_0;

		// Token: 0x040024C0 RID: 9408
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		// Token: 0x040024C1 RID: 9409
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_Boolean_0;

		// Token: 0x040024C2 RID: 9410
		private static readonly IntPtr NativeMethodInfoPtr_CancelAfter_Public_Void_Int32_0;

		// Token: 0x040024C3 RID: 9411
		private static readonly IntPtr NativeMethodInfoPtr_TimerCallbackLogic_Private_Static_Void_Object_0;

		// Token: 0x040024C4 RID: 9412
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040024C5 RID: 9413
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x040024C6 RID: 9414
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_0;

		// Token: 0x040024C7 RID: 9415
		private static readonly IntPtr NativeMethodInfoPtr_ThrowObjectDisposedException_Private_Static_Void_0;

		// Token: 0x040024C8 RID: 9416
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetStaticSource_Internal_Static_CancellationTokenSource_Boolean_0;

		// Token: 0x040024C9 RID: 9417
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegister_Internal_CancellationTokenRegistration_Action_1_Object_Object_SynchronizationContext_ExecutionContext_0;

		// Token: 0x040024CA RID: 9418
		private static readonly IntPtr NativeMethodInfoPtr_NotifyCancellation_Private_Void_Boolean_0;

		// Token: 0x040024CB RID: 9419
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteCallbackHandlers_Private_Void_Boolean_0;

		// Token: 0x040024CC RID: 9420
		private static readonly IntPtr NativeMethodInfoPtr_CancellationCallbackCoreWork_OnSyncContext_Private_Void_Object_0;

		// Token: 0x040024CD RID: 9421
		private static readonly IntPtr NativeMethodInfoPtr_CancellationCallbackCoreWork_Private_Void_CancellationCallbackCoreWorkArguments_0;

		// Token: 0x040024CE RID: 9422
		private static readonly IntPtr NativeMethodInfoPtr_CreateLinkedTokenSource_Public_Static_CancellationTokenSource_CancellationToken_CancellationToken_0;

		// Token: 0x040024CF RID: 9423
		private static readonly IntPtr NativeMethodInfoPtr_CreateLinkedTokenSource_Public_Static_CancellationTokenSource_Il2CppReferenceArray_1_CancellationToken_0;

		// Token: 0x040024D0 RID: 9424
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCallbackToComplete_Internal_Void_CancellationCallbackInfo_0;
	}
}
