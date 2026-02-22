using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002B6 RID: 694
	[Serializable]
	public class TaskSchedulerException : Exception
	{
		// Token: 0x06002EBF RID: 11967 RVA: 0x000EC198 File Offset: 0x000EA398
		// Note: this type is marked as 'beforefieldinit'.
		static TaskSchedulerException()
		{
			Il2CppClassPointerStore<TaskSchedulerException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskSchedulerException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskSchedulerException>.NativeClassPtr);
			TaskSchedulerException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskSchedulerException>.NativeClassPtr, 100670704);
			TaskSchedulerException.NativeMethodInfoPtr__ctor_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskSchedulerException>.NativeClassPtr, 100670705);
			TaskSchedulerException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskSchedulerException>.NativeClassPtr, 100670706);
		}

		// Token: 0x06002EC0 RID: 11968 RVA: 0x000EC204 File Offset: 0x000EA404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337163, XrefRangeEnd = 337170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskSchedulerException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskSchedulerException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskSchedulerException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EC1 RID: 11969 RVA: 0x000EC240 File Offset: 0x000EA440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337177, RefRangeEnd = 337178, XrefRangeStart = 337170, XrefRangeEnd = 337177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskSchedulerException(Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskSchedulerException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerException);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskSchedulerException.NativeMethodInfoPtr__ctor_Public_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EC2 RID: 11970 RVA: 0x000EC28C File Offset: 0x000EA48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337178, XrefRangeEnd = 337182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskSchedulerException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskSchedulerException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskSchedulerException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x00010539 File Offset: 0x0000E739
		public TaskSchedulerException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002877 RID: 10359
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002878 RID: 10360
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Exception_0;

		// Token: 0x04002879 RID: 10361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
