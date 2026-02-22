using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200025A RID: 602
	public class CancellationCallbackInfo : Object
	{
		// Token: 0x060029E3 RID: 10723 RVA: 0x000D90A0 File Offset: 0x000D72A0
		// Note: this type is marked as 'beforefieldinit'.
		static CancellationCallbackInfo()
		{
			Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "CancellationCallbackInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr);
			CancellationCallbackInfo.NativeFieldInfoPtr_Callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, "Callback");
			CancellationCallbackInfo.NativeFieldInfoPtr_StateForCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, "StateForCallback");
			CancellationCallbackInfo.NativeFieldInfoPtr_TargetSyncContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, "TargetSyncContext");
			CancellationCallbackInfo.NativeFieldInfoPtr_TargetExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, "TargetExecutionContext");
			CancellationCallbackInfo.NativeFieldInfoPtr_CancellationTokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, "CancellationTokenSource");
			CancellationCallbackInfo.NativeFieldInfoPtr_s_executionContextCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, "s_executionContextCallback");
			CancellationCallbackInfo.NativeMethodInfoPtr__ctor_Internal_Void_Action_1_Object_Object_SynchronizationContext_ExecutionContext_CancellationTokenSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, 100669975);
			CancellationCallbackInfo.NativeMethodInfoPtr_ExecuteCallback_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, 100669976);
			CancellationCallbackInfo.NativeMethodInfoPtr_ExecutionContextCallback_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, 100669977);
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x000D9184 File Offset: 0x000D7384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationCallbackInfo(Action<Object> callback, Object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stateForCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetSyncContext);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetExecutionContext);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cancellationTokenSource);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationCallbackInfo.NativeMethodInfoPtr__ctor_Internal_Void_Action_1_Object_Object_SynchronizationContext_ExecutionContext_CancellationTokenSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x000D921C File Offset: 0x000D741C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330508, XrefRangeEnd = 330527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteCallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationCallbackInfo.NativeMethodInfoPtr_ExecuteCallback_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029E6 RID: 10726 RVA: 0x000D9250 File Offset: 0x000D7450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330527, XrefRangeEnd = 330533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecutionContextCallback(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationCallbackInfo.NativeMethodInfoPtr_ExecutionContextCallback_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x0000E96A File Offset: 0x0000CB6A
		public CancellationCallbackInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x060029E8 RID: 10728 RVA: 0x000D9288 File Offset: 0x000D7488
		// (set) Token: 0x060029E9 RID: 10729 RVA: 0x0000E973 File Offset: 0x0000CB73
		public unsafe Action<Object> Callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_Callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_Callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x060029EA RID: 10730 RVA: 0x000D92B8 File Offset: 0x000D74B8
		// (set) Token: 0x060029EB RID: 10731 RVA: 0x0000E992 File Offset: 0x0000CB92
		public unsafe Object StateForCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_StateForCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_StateForCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x060029EC RID: 10732 RVA: 0x000D92E8 File Offset: 0x000D74E8
		// (set) Token: 0x060029ED RID: 10733 RVA: 0x0000E9B1 File Offset: 0x0000CBB1
		public unsafe SynchronizationContext TargetSyncContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_TargetSyncContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_TargetSyncContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x060029EE RID: 10734 RVA: 0x000D9318 File Offset: 0x000D7518
		// (set) Token: 0x060029EF RID: 10735 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
		public unsafe ExecutionContext TargetExecutionContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_TargetExecutionContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_TargetExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x060029F0 RID: 10736 RVA: 0x000D9348 File Offset: 0x000D7548
		// (set) Token: 0x060029F1 RID: 10737 RVA: 0x0000E9EF File Offset: 0x0000CBEF
		public unsafe CancellationTokenSource CancellationTokenSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_CancellationTokenSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_CancellationTokenSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x060029F2 RID: 10738 RVA: 0x000D9378 File Offset: 0x000D7578
		// (set) Token: 0x060029F3 RID: 10739 RVA: 0x0000EA0E File Offset: 0x0000CC0E
		public unsafe static ContextCallback s_executionContextCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CancellationCallbackInfo.NativeFieldInfoPtr_s_executionContextCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationCallbackInfo.NativeFieldInfoPtr_s_executionContextCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040024D4 RID: 9428
		private static readonly IntPtr NativeFieldInfoPtr_Callback;

		// Token: 0x040024D5 RID: 9429
		private static readonly IntPtr NativeFieldInfoPtr_StateForCallback;

		// Token: 0x040024D6 RID: 9430
		private static readonly IntPtr NativeFieldInfoPtr_TargetSyncContext;

		// Token: 0x040024D7 RID: 9431
		private static readonly IntPtr NativeFieldInfoPtr_TargetExecutionContext;

		// Token: 0x040024D8 RID: 9432
		private static readonly IntPtr NativeFieldInfoPtr_CancellationTokenSource;

		// Token: 0x040024D9 RID: 9433
		private static readonly IntPtr NativeFieldInfoPtr_s_executionContextCallback;

		// Token: 0x040024DA RID: 9434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Action_1_Object_Object_SynchronizationContext_ExecutionContext_CancellationTokenSource_0;

		// Token: 0x040024DB RID: 9435
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteCallback_Internal_Void_0;

		// Token: 0x040024DC RID: 9436
		private static readonly IntPtr NativeMethodInfoPtr_ExecutionContextCallback_Private_Static_Void_Object_0;
	}
}
