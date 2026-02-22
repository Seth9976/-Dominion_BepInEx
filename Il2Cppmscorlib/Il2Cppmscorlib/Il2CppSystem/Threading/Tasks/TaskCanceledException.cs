using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002A9 RID: 681
	[Serializable]
	public class TaskCanceledException : OperationCanceledException
	{
		// Token: 0x06002E16 RID: 11798 RVA: 0x000E9884 File Offset: 0x000E7A84
		// Note: this type is marked as 'beforefieldinit'.
		static TaskCanceledException()
		{
			Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskCanceledException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr);
			TaskCanceledException.NativeFieldInfoPtr_m_canceledTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr, "m_canceledTask");
			TaskCanceledException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr, 100670613);
			TaskCanceledException.NativeMethodInfoPtr__ctor_Public_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr, 100670614);
			TaskCanceledException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr, 100670615);
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x000E9904 File Offset: 0x000E7B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336349, XrefRangeEnd = 336353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskCanceledException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCanceledException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x000E9940 File Offset: 0x000E7B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336353, XrefRangeEnd = 336360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskCanceledException(Task task)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCanceledException.NativeMethodInfoPtr__ctor_Public_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E19 RID: 11801 RVA: 0x000E998C File Offset: 0x000E7B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskCanceledException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCanceledException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E1A RID: 11802 RVA: 0x00010169 File Offset: 0x0000E369
		public TaskCanceledException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06002E1B RID: 11803 RVA: 0x000E99F0 File Offset: 0x000E7BF0
		// (set) Token: 0x06002E1C RID: 11804 RVA: 0x00010172 File Offset: 0x0000E372
		public unsafe Task m_canceledTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskCanceledException.NativeFieldInfoPtr_m_canceledTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskCanceledException.NativeFieldInfoPtr_m_canceledTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002809 RID: 10249
		private static readonly IntPtr NativeFieldInfoPtr_m_canceledTask;

		// Token: 0x0400280A RID: 10250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400280B RID: 10251
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Task_0;

		// Token: 0x0400280C RID: 10252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
