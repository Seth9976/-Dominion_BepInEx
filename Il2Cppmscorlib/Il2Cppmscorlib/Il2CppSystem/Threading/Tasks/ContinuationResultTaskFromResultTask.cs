using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002AC RID: 684
	public sealed class ContinuationResultTaskFromResultTask<TAntecedentResult, TResult> : Task<TResult>
	{
		// Token: 0x06002E2E RID: 11822 RVA: 0x000E9EDC File Offset: 0x000E80DC
		// Note: this type is marked as 'beforefieldinit'.
		static ContinuationResultTaskFromResultTask()
		{
			Il2CppClassPointerStore<ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "ContinuationResultTaskFromResultTask`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAntecedentResult>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>>.NativeClassPtr);
			ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>.NativeFieldInfoPtr_m_antecedent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>>.NativeClassPtr, "m_antecedent");
			ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Task_1_TAntecedentResult_Delegate_Object_TaskCreationOptions_InternalTaskOptions_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>>.NativeClassPtr, 100670625);
			ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>.NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>>.NativeClassPtr, 100670626);
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x000E9F98 File Offset: 0x000E8198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336412, XrefRangeEnd = 336442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContinuationResultTaskFromResultTask(Task<TAntecedentResult> antecedent, Delegate function, Object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(antecedent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(function);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Task_1_TAntecedentResult_Delegate_Object_TaskCreationOptions_InternalTaskOptions_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x000EA034 File Offset: 0x000E8234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336442, XrefRangeEnd = 336447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InnerInvoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>.NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x000101E1 File Offset: 0x0000E3E1
		public ContinuationResultTaskFromResultTask(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06002E32 RID: 11826 RVA: 0x000EA068 File Offset: 0x000E8268
		// (set) Token: 0x06002E33 RID: 11827 RVA: 0x000101EA File Offset: 0x0000E3EA
		public unsafe Task<TAntecedentResult> m_antecedent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>.NativeFieldInfoPtr_m_antecedent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<TAntecedentResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>.NativeFieldInfoPtr_m_antecedent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002818 RID: 10264
		private static readonly IntPtr NativeFieldInfoPtr_m_antecedent;

		// Token: 0x04002819 RID: 10265
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Task_1_TAntecedentResult_Delegate_Object_TaskCreationOptions_InternalTaskOptions_byref_StackCrawlMark_0;

		// Token: 0x0400281A RID: 10266
		private static readonly IntPtr NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0;
	}
}
