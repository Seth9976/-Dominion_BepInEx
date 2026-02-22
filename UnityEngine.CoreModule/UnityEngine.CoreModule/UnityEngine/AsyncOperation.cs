using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200009D RID: 157
	public class AsyncOperation : YieldInstruction
	{
		// Token: 0x06000FAA RID: 4010 RVA: 0x00040FC0 File Offset: 0x0003F1C0
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncOperation()
		{
			Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AsyncOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr);
			AsyncOperation.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, "m_Ptr");
			AsyncOperation.NativeFieldInfoPtr_m_completeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, "m_completeCallback");
			AsyncOperation.NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100664305);
			AsyncOperation.NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100664306);
			AsyncOperation.NativeMethodInfoPtr_get_progress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100664307);
			AsyncOperation.NativeMethodInfoPtr_set_allowSceneActivation_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100664308);
			AsyncOperation.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100664309);
			AsyncOperation.NativeMethodInfoPtr_InvokeCompletionEvent_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100664310);
			AsyncOperation.NativeMethodInfoPtr_add_completed_Public_add_Void_Action_1_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100664311);
			AsyncOperation.NativeMethodInfoPtr_remove_completed_Public_rem_Void_Action_1_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100664312);
			AsyncOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100664313);
			AsyncOperation.get_priorityDelegateField = IL2CPP.ResolveICall<AsyncOperation.get_priorityDelegate>("UnityEngine.AsyncOperation::get_priority");
			AsyncOperation.set_priorityDelegateField = IL2CPP.ResolveICall<AsyncOperation.set_priorityDelegate>("UnityEngine.AsyncOperation::set_priority");
			AsyncOperation.get_allowSceneActivationDelegateField = IL2CPP.ResolveICall<AsyncOperation.get_allowSceneActivationDelegate>("UnityEngine.AsyncOperation::get_allowSceneActivation");
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x000410FC File Offset: 0x0003F2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68170, XrefRangeEnd = 68172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalDestroy(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x00041130 File Offset: 0x0003F330
		public unsafe bool isDone
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 68174, RefRangeEnd = 68177, XrefRangeStart = 68172, XrefRangeEnd = 68174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000FAD RID: 4013 RVA: 0x0004116C File Offset: 0x0003F36C
		public unsafe float progress
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 68179, RefRangeEnd = 68180, XrefRangeStart = 68177, XrefRangeEnd = 68179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_get_progress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x00009CE3 File Offset: 0x00007EE3
		// (set) Token: 0x06000FAE RID: 4014 RVA: 0x000411A8 File Offset: 0x0003F3A8
		public unsafe bool allowSceneActivation
		{
			get
			{
				return AsyncOperation.get_allowSceneActivationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 68182, RefRangeEnd = 68184, XrefRangeStart = 68180, XrefRangeEnd = 68182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_set_allowSceneActivation_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x000411E8 File Offset: 0x0003F3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68184, XrefRangeEnd = 68189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncOperation.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x00041224 File Offset: 0x0003F424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68189, XrefRangeEnd = 68192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeCompletionEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_InvokeCompletionEvent_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00041258 File Offset: 0x0003F458
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 68198, RefRangeEnd = 68201, XrefRangeStart = 68192, XrefRangeEnd = 68198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_completed(Action<AsyncOperation> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_add_completed_Public_add_Void_Action_1_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x0004129C File Offset: 0x0003F49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68201, XrefRangeEnd = 68204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_completed(Action<AsyncOperation> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_remove_completed_Public_rem_Void_Action_1_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x000412E0 File Offset: 0x0003F4E0
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x00009C7B File Offset: 0x00007E7B
		public AsyncOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x0004131C File Offset: 0x0003F51C
		// (set) Token: 0x06000FB6 RID: 4022 RVA: 0x00009C84 File Offset: 0x00007E84
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperation.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperation.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000FB7 RID: 4023 RVA: 0x00041344 File Offset: 0x0003F544
		// (set) Token: 0x06000FB8 RID: 4024 RVA: 0x00009C9F File Offset: 0x00007E9F
		public unsafe Action<AsyncOperation> m_completeCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperation.NativeFieldInfoPtr_m_completeCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperation.NativeFieldInfoPtr_m_completeCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000FB9 RID: 4025 RVA: 0x00009CBE File Offset: 0x00007EBE
		// (set) Token: 0x06000FBA RID: 4026 RVA: 0x00009CD0 File Offset: 0x00007ED0
		public int priority
		{
			get
			{
				return AsyncOperation.get_priorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AsyncOperation.set_priorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000BFB RID: 3067
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000BFC RID: 3068
		private static readonly IntPtr NativeFieldInfoPtr_m_completeCallback;

		// Token: 0x04000BFD RID: 3069
		private static readonly IntPtr NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0;

		// Token: 0x04000BFE RID: 3070
		private static readonly IntPtr NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0;

		// Token: 0x04000BFF RID: 3071
		private static readonly IntPtr NativeMethodInfoPtr_get_progress_Public_get_Single_0;

		// Token: 0x04000C00 RID: 3072
		private static readonly IntPtr NativeMethodInfoPtr_set_allowSceneActivation_Public_set_Void_Boolean_0;

		// Token: 0x04000C01 RID: 3073
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000C02 RID: 3074
		private static readonly IntPtr NativeMethodInfoPtr_InvokeCompletionEvent_Internal_Void_0;

		// Token: 0x04000C03 RID: 3075
		private static readonly IntPtr NativeMethodInfoPtr_add_completed_Public_add_Void_Action_1_AsyncOperation_0;

		// Token: 0x04000C04 RID: 3076
		private static readonly IntPtr NativeMethodInfoPtr_remove_completed_Public_rem_Void_Action_1_AsyncOperation_0;

		// Token: 0x04000C05 RID: 3077
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C06 RID: 3078
		private static readonly AsyncOperation.get_priorityDelegate get_priorityDelegateField;

		// Token: 0x04000C07 RID: 3079
		private static readonly AsyncOperation.set_priorityDelegate set_priorityDelegateField;

		// Token: 0x04000C08 RID: 3080
		private static readonly AsyncOperation.get_allowSceneActivationDelegate get_allowSceneActivationDelegateField;

		// Token: 0x0200076A RID: 1898
		// (Invoke) Token: 0x06002C92 RID: 11410
		private delegate int get_priorityDelegate(IntPtr @this);

		// Token: 0x0200076B RID: 1899
		// (Invoke) Token: 0x06002C94 RID: 11412
		private delegate void set_priorityDelegate(IntPtr @this, int value);

		// Token: 0x0200076C RID: 1900
		// (Invoke) Token: 0x06002C96 RID: 11414
		private delegate bool get_allowSceneActivationDelegate(IntPtr @this);
	}
}
