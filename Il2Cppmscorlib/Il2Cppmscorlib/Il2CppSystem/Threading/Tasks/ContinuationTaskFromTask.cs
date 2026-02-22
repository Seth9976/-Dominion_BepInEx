using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002AB RID: 683
	public sealed class ContinuationTaskFromTask : Task
	{
		// Token: 0x06002E28 RID: 11816 RVA: 0x000E9D70 File Offset: 0x000E7F70
		// Note: this type is marked as 'beforefieldinit'.
		static ContinuationTaskFromTask()
		{
			Il2CppClassPointerStore<ContinuationTaskFromTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "ContinuationTaskFromTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinuationTaskFromTask>.NativeClassPtr);
			ContinuationTaskFromTask.NativeFieldInfoPtr_m_antecedent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinuationTaskFromTask>.NativeClassPtr, "m_antecedent");
			ContinuationTaskFromTask.NativeMethodInfoPtr__ctor_Public_Void_Task_Delegate_Object_TaskCreationOptions_InternalTaskOptions_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinuationTaskFromTask>.NativeClassPtr, 100670623);
			ContinuationTaskFromTask.NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinuationTaskFromTask>.NativeClassPtr, 100670624);
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x000E9DDC File Offset: 0x000E7FDC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 336399, RefRangeEnd = 336403, XrefRangeStart = 336393, XrefRangeEnd = 336399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContinuationTaskFromTask(Task antecedent, Delegate action, Object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContinuationTaskFromTask>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(antecedent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinuationTaskFromTask.NativeMethodInfoPtr__ctor_Public_Void_Task_Delegate_Object_TaskCreationOptions_InternalTaskOptions_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x000E9E78 File Offset: 0x000E8078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336403, XrefRangeEnd = 336412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InnerInvoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinuationTaskFromTask.NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x000101B9 File Offset: 0x0000E3B9
		public ContinuationTaskFromTask(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06002E2C RID: 11820 RVA: 0x000E9EAC File Offset: 0x000E80AC
		// (set) Token: 0x06002E2D RID: 11821 RVA: 0x000101C2 File Offset: 0x0000E3C2
		public unsafe Task m_antecedent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinuationTaskFromTask.NativeFieldInfoPtr_m_antecedent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinuationTaskFromTask.NativeFieldInfoPtr_m_antecedent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002815 RID: 10261
		private static readonly IntPtr NativeFieldInfoPtr_m_antecedent;

		// Token: 0x04002816 RID: 10262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Task_Delegate_Object_TaskCreationOptions_InternalTaskOptions_byref_StackCrawlMark_0;

		// Token: 0x04002817 RID: 10263
		private static readonly IntPtr NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0;
	}
}
