using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002A0 RID: 672
	public sealed class CompletionActionInvoker : Object
	{
		// Token: 0x06002DF1 RID: 11761 RVA: 0x000E9148 File Offset: 0x000E7348
		// Note: this type is marked as 'beforefieldinit'.
		static CompletionActionInvoker()
		{
			Il2CppClassPointerStore<CompletionActionInvoker>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "CompletionActionInvoker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompletionActionInvoker>.NativeClassPtr);
			CompletionActionInvoker.NativeFieldInfoPtr_m_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompletionActionInvoker>.NativeClassPtr, "m_action");
			CompletionActionInvoker.NativeFieldInfoPtr_m_completingTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompletionActionInvoker>.NativeClassPtr, "m_completingTask");
			CompletionActionInvoker.NativeMethodInfoPtr__ctor_Internal_Void_ITaskCompletionAction_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompletionActionInvoker>.NativeClassPtr, 100670595);
			CompletionActionInvoker.NativeMethodInfoPtr_ExecuteWorkItem_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompletionActionInvoker>.NativeClassPtr, 100670596);
			CompletionActionInvoker.NativeMethodInfoPtr_MarkAborted_Public_Virtual_Final_New_Void_ThreadAbortException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompletionActionInvoker>.NativeClassPtr, 100670597);
		}

		// Token: 0x06002DF2 RID: 11762 RVA: 0x000E91DC File Offset: 0x000E73DC
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompletionActionInvoker(ITaskCompletionAction action, Task completingTask)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompletionActionInvoker>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(completingTask);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompletionActionInvoker.NativeMethodInfoPtr__ctor_Internal_Void_ITaskCompletionAction_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF3 RID: 11763 RVA: 0x000E923C File Offset: 0x000E743C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336248, XrefRangeEnd = 336253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteWorkItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompletionActionInvoker.NativeMethodInfoPtr_ExecuteWorkItem_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF4 RID: 11764 RVA: 0x000E9270 File Offset: 0x000E7470
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkAborted(ThreadAbortException tae)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tae);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompletionActionInvoker.NativeMethodInfoPtr_MarkAborted_Public_Virtual_Final_New_Void_ThreadAbortException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DF5 RID: 11765 RVA: 0x00010022 File Offset: 0x0000E222
		public CompletionActionInvoker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06002DF6 RID: 11766 RVA: 0x000E92B4 File Offset: 0x000E74B4
		// (set) Token: 0x06002DF7 RID: 11767 RVA: 0x0001002B File Offset: 0x0000E22B
		public unsafe ITaskCompletionAction m_action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompletionActionInvoker.NativeFieldInfoPtr_m_action);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITaskCompletionAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompletionActionInvoker.NativeFieldInfoPtr_m_action), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06002DF8 RID: 11768 RVA: 0x000E92E4 File Offset: 0x000E74E4
		// (set) Token: 0x06002DF9 RID: 11769 RVA: 0x0001004A File Offset: 0x0000E24A
		public unsafe Task m_completingTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompletionActionInvoker.NativeFieldInfoPtr_m_completingTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompletionActionInvoker.NativeFieldInfoPtr_m_completingTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040027D3 RID: 10195
		private static readonly IntPtr NativeFieldInfoPtr_m_action;

		// Token: 0x040027D4 RID: 10196
		private static readonly IntPtr NativeFieldInfoPtr_m_completingTask;

		// Token: 0x040027D5 RID: 10197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ITaskCompletionAction_Task_0;

		// Token: 0x040027D6 RID: 10198
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteWorkItem_Public_Virtual_Final_New_Void_0;

		// Token: 0x040027D7 RID: 10199
		private static readonly IntPtr NativeMethodInfoPtr_MarkAborted_Public_Virtual_Final_New_Void_ThreadAbortException_0;
	}
}
