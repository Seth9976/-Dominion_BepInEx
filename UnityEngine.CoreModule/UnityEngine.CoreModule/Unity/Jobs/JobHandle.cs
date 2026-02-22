using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Jobs
{
	// Token: 0x0200000C RID: 12
	[StructLayout(2)]
	public struct JobHandle
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00018038 File Offset: 0x00016238
		// Note: this type is marked as 'beforefieldinit'.
		static JobHandle()
		{
			Il2CppClassPointerStore<JobHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs", "JobHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobHandle>.NativeClassPtr);
			JobHandle.NativeFieldInfoPtr_jobGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, "jobGroup");
			JobHandle.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, "version");
			JobHandle.NativeMethodInfoPtr_ScheduleBatchedJobs_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663312);
			JobHandle.ScheduleBatchedJobsAndCompleteDelegateField = IL2CPP.ResolveICall<JobHandle.ScheduleBatchedJobsAndCompleteDelegate>("Unity.Jobs.JobHandle::ScheduleBatchedJobsAndComplete");
			JobHandle.ScheduleBatchedJobsAndIsCompletedDelegateField = IL2CPP.ResolveICall<JobHandle.ScheduleBatchedJobsAndIsCompletedDelegate>("Unity.Jobs.JobHandle::ScheduleBatchedJobsAndIsCompleted");
			JobHandle.ScheduleBatchedJobsAndCompleteAllDelegateField = IL2CPP.ResolveICall<JobHandle.ScheduleBatchedJobsAndCompleteAllDelegate>("Unity.Jobs.JobHandle::ScheduleBatchedJobsAndCompleteAll");
			JobHandle.CombineDependenciesInternal2_InjectedDelegateField = IL2CPP.ResolveICall<JobHandle.CombineDependenciesInternal2_InjectedDelegate>("Unity.Jobs.JobHandle::CombineDependenciesInternal2_Injected");
			JobHandle.CombineDependenciesInternal3_InjectedDelegateField = IL2CPP.ResolveICall<JobHandle.CombineDependenciesInternal3_InjectedDelegate>("Unity.Jobs.JobHandle::CombineDependenciesInternal3_Injected");
			JobHandle.CombineDependenciesInternalPtr_InjectedDelegateField = IL2CPP.ResolveICall<JobHandle.CombineDependenciesInternalPtr_InjectedDelegate>("Unity.Jobs.JobHandle::CombineDependenciesInternalPtr_Injected");
			JobHandle.CheckFenceIsDependencyOrDidSyncFence_InjectedDelegateField = IL2CPP.ResolveICall<JobHandle.CheckFenceIsDependencyOrDidSyncFence_InjectedDelegate>("Unity.Jobs.JobHandle::CheckFenceIsDependencyOrDidSyncFence_Injected");
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00018110 File Offset: 0x00016310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58989, XrefRangeEnd = 58991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScheduleBatchedJobs()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_ScheduleBatchedJobs_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002331 File Offset: 0x00000531
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00018138 File Offset: 0x00016338
		public void Complete()
		{
			bool flag = this.jobGroup == IntPtr.Zero;
			if (!flag)
			{
				JobHandle.ScheduleBatchedJobsAndComplete(ref this);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00018164 File Offset: 0x00016364
		public unsafe static void CompleteAll(ref JobHandle job0, ref JobHandle job1)
		{
			JobHandle* ptr;
			checked
			{
				ptr = stackalloc JobHandle[unchecked((UIntPtr)2) * (UIntPtr)sizeof(JobHandle)];
				*ptr = job0;
			}
			ptr[1] = job1;
			JobHandle.ScheduleBatchedJobsAndCompleteAll((void*)ptr, 2);
			job0 = default(JobHandle);
			job1 = default(JobHandle);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000181B4 File Offset: 0x000163B4
		public unsafe static void CompleteAll(ref JobHandle job0, ref JobHandle job1, ref JobHandle job2)
		{
			JobHandle* ptr;
			checked
			{
				ptr = stackalloc JobHandle[unchecked((UIntPtr)3) * (UIntPtr)sizeof(JobHandle)];
				*ptr = job0;
			}
			ptr[1] = job1;
			ptr[2] = job2;
			JobHandle.ScheduleBatchedJobsAndCompleteAll((void*)ptr, 3);
			job0 = default(JobHandle);
			job1 = default(JobHandle);
			job2 = default(JobHandle);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002343 File Offset: 0x00000543
		public static void CompleteAll(Unity.Collections.NativeArray<JobHandle> jobs)
		{
			JobHandle.ScheduleBatchedJobsAndCompleteAll(jobs.GetUnsafeReadOnlyPtr<JobHandle>(), jobs.Length);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00018220 File Offset: 0x00016420
		public bool IsCompleted
		{
			get
			{
				return JobHandle.ScheduleBatchedJobsAndIsCompleted(ref this);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002359 File Offset: 0x00000559
		public static void ScheduleBatchedJobsAndComplete(ref JobHandle job)
		{
			JobHandle.ScheduleBatchedJobsAndCompleteDelegateField(ref job);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002366 File Offset: 0x00000566
		public static bool ScheduleBatchedJobsAndIsCompleted(ref JobHandle job)
		{
			return JobHandle.ScheduleBatchedJobsAndIsCompletedDelegateField(ref job);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002373 File Offset: 0x00000573
		public unsafe static void ScheduleBatchedJobsAndCompleteAll(void* jobs, int count)
		{
			JobHandle.ScheduleBatchedJobsAndCompleteAllDelegateField(jobs, count);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00018238 File Offset: 0x00016438
		public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1)
		{
			return JobHandle.CombineDependenciesInternal2(ref job0, ref job1);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00018254 File Offset: 0x00016454
		public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1, JobHandle job2)
		{
			return JobHandle.CombineDependenciesInternal3(ref job0, ref job1, ref job2);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00018274 File Offset: 0x00016474
		public static JobHandle CombineDependencies(Unity.Collections.NativeArray<JobHandle> jobs)
		{
			return JobHandle.CombineDependenciesInternalPtr(jobs.GetUnsafeReadOnlyPtr<JobHandle>(), jobs.Length);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00018298 File Offset: 0x00016498
		public static JobHandle CombineDependenciesInternal2(ref JobHandle job0, ref JobHandle job1)
		{
			JobHandle jobHandle;
			JobHandle.CombineDependenciesInternal2_Injected(ref job0, ref job1, out jobHandle);
			return jobHandle;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000182B0 File Offset: 0x000164B0
		public static JobHandle CombineDependenciesInternal3(ref JobHandle job0, ref JobHandle job1, ref JobHandle job2)
		{
			JobHandle jobHandle;
			JobHandle.CombineDependenciesInternal3_Injected(ref job0, ref job1, ref job2, out jobHandle);
			return jobHandle;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000182C8 File Offset: 0x000164C8
		public unsafe static JobHandle CombineDependenciesInternalPtr(void* jobs, int count)
		{
			JobHandle jobHandle;
			JobHandle.CombineDependenciesInternalPtr_Injected(jobs, count, out jobHandle);
			return jobHandle;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002381 File Offset: 0x00000581
		public static bool CheckFenceIsDependencyOrDidSyncFence(JobHandle jobHandle, JobHandle dependsOn)
		{
			return JobHandle.CheckFenceIsDependencyOrDidSyncFence_Injected(ref jobHandle, ref dependsOn);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000238C File Offset: 0x0000058C
		public static void CombineDependenciesInternal2_Injected(ref JobHandle job0, ref JobHandle job1, out JobHandle ret)
		{
			JobHandle.CombineDependenciesInternal2_InjectedDelegateField(ref job0, ref job1, out ret);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000239B File Offset: 0x0000059B
		public static void CombineDependenciesInternal3_Injected(ref JobHandle job0, ref JobHandle job1, ref JobHandle job2, out JobHandle ret)
		{
			JobHandle.CombineDependenciesInternal3_InjectedDelegateField(ref job0, ref job1, ref job2, out ret);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000023AB File Offset: 0x000005AB
		public unsafe static void CombineDependenciesInternalPtr_Injected(void* jobs, int count, out JobHandle ret)
		{
			JobHandle.CombineDependenciesInternalPtr_InjectedDelegateField(jobs, count, out ret);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000023BA File Offset: 0x000005BA
		public static bool CheckFenceIsDependencyOrDidSyncFence_Injected(ref JobHandle jobHandle, ref JobHandle dependsOn)
		{
			return JobHandle.CheckFenceIsDependencyOrDidSyncFence_InjectedDelegateField(ref jobHandle, ref dependsOn);
		}

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_jobGroup;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleBatchedJobs_Public_Static_Void_0;

		// Token: 0x0400004A RID: 74
		[FieldOffset(0)]
		public IntPtr jobGroup;

		// Token: 0x0400004B RID: 75
		[FieldOffset(8)]
		public int version;

		// Token: 0x0400004C RID: 76
		private static readonly JobHandle.ScheduleBatchedJobsAndCompleteDelegate ScheduleBatchedJobsAndCompleteDelegateField;

		// Token: 0x0400004D RID: 77
		private static readonly JobHandle.ScheduleBatchedJobsAndIsCompletedDelegate ScheduleBatchedJobsAndIsCompletedDelegateField;

		// Token: 0x0400004E RID: 78
		private static readonly JobHandle.ScheduleBatchedJobsAndCompleteAllDelegate ScheduleBatchedJobsAndCompleteAllDelegateField;

		// Token: 0x0400004F RID: 79
		private static readonly JobHandle.CombineDependenciesInternal2_InjectedDelegate CombineDependenciesInternal2_InjectedDelegateField;

		// Token: 0x04000050 RID: 80
		private static readonly JobHandle.CombineDependenciesInternal3_InjectedDelegate CombineDependenciesInternal3_InjectedDelegateField;

		// Token: 0x04000051 RID: 81
		private static readonly JobHandle.CombineDependenciesInternalPtr_InjectedDelegate CombineDependenciesInternalPtr_InjectedDelegateField;

		// Token: 0x04000052 RID: 82
		private static readonly JobHandle.CheckFenceIsDependencyOrDidSyncFence_InjectedDelegate CheckFenceIsDependencyOrDidSyncFence_InjectedDelegateField;

		// Token: 0x020002F3 RID: 755
		// (Invoke) Token: 0x06002398 RID: 9112
		private delegate void ScheduleBatchedJobsAndCompleteDelegate(IntPtr job);

		// Token: 0x020002F4 RID: 756
		// (Invoke) Token: 0x0600239A RID: 9114
		private delegate bool ScheduleBatchedJobsAndIsCompletedDelegate(IntPtr job);

		// Token: 0x020002F5 RID: 757
		// (Invoke) Token: 0x0600239C RID: 9116
		private delegate void ScheduleBatchedJobsAndCompleteAllDelegate(IntPtr jobs, int count);

		// Token: 0x020002F6 RID: 758
		// (Invoke) Token: 0x0600239E RID: 9118
		private delegate void CombineDependenciesInternal2_InjectedDelegate(IntPtr job0, IntPtr job1, [Out] IntPtr ret);

		// Token: 0x020002F7 RID: 759
		// (Invoke) Token: 0x060023A0 RID: 9120
		private delegate void CombineDependenciesInternal3_InjectedDelegate(IntPtr job0, IntPtr job1, IntPtr job2, [Out] IntPtr ret);

		// Token: 0x020002F8 RID: 760
		// (Invoke) Token: 0x060023A2 RID: 9122
		private delegate void CombineDependenciesInternalPtr_InjectedDelegate(IntPtr jobs, int count, [Out] IntPtr ret);

		// Token: 0x020002F9 RID: 761
		// (Invoke) Token: 0x060023A4 RID: 9124
		private delegate bool CheckFenceIsDependencyOrDidSyncFence_InjectedDelegate(IntPtr jobHandle, IntPtr dependsOn);
	}
}
