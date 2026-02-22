using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002AD RID: 685
	public class TaskContinuation : Object
	{
		// Token: 0x06002E34 RID: 11828 RVA: 0x000EA098 File Offset: 0x000E8298
		// Note: this type is marked as 'beforefieldinit'.
		static TaskContinuation()
		{
			Il2CppClassPointerStore<TaskContinuation>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskContinuation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskContinuation>.NativeClassPtr);
			TaskContinuation.NativeMethodInfoPtr_Run_Internal_Abstract_Virtual_New_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskContinuation>.NativeClassPtr, 100670627);
			TaskContinuation.NativeMethodInfoPtr_InlineIfPossibleOrElseQueue_Protected_Static_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskContinuation>.NativeClassPtr, 100670628);
			TaskContinuation.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskContinuation>.NativeClassPtr, 100670629);
		}

		// Token: 0x06002E35 RID: 11829 RVA: 0x000EA104 File Offset: 0x000E8304
		[CallerCount(0)]
		public unsafe virtual void Run(Task completedTask, bool bCanInlineContinuationTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(completedTask);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCanInlineContinuationTask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskContinuation.NativeMethodInfoPtr_Run_Internal_Abstract_Virtual_New_Void_Task_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E36 RID: 11830 RVA: 0x000EA160 File Offset: 0x000E8360
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 336455, RefRangeEnd = 336456, XrefRangeStart = 336447, XrefRangeEnd = 336455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InlineIfPossibleOrElseQueue(Task task, bool needsProtection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needsProtection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskContinuation.NativeMethodInfoPtr_InlineIfPossibleOrElseQueue_Protected_Static_Void_Task_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x000EA1A4 File Offset: 0x000E83A4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskContinuation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskContinuation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskContinuation.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x00010209 File Offset: 0x0000E409
		public TaskContinuation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400281B RID: 10267
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Abstract_Virtual_New_Void_Task_Boolean_0;

		// Token: 0x0400281C RID: 10268
		private static readonly IntPtr NativeMethodInfoPtr_InlineIfPossibleOrElseQueue_Protected_Static_Void_Task_Boolean_0;

		// Token: 0x0400281D RID: 10269
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
