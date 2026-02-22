using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Jobs.LowLevel.Unsafe
{
	// Token: 0x02000195 RID: 405
	public static class JobsUtility
	{
		// Token: 0x06001BCB RID: 7115 RVA: 0x0000F3C5 File Offset: 0x0000D5C5
		public unsafe static void PatchBufferMinMaxRanges(IntPtr bufferRangePatchData, void* jobdata, int startIndex, int rangeSize)
		{
			JobsUtility.PatchBufferMinMaxRangesDelegateField(bufferRangePatchData, jobdata, startIndex, rangeSize);
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x0000F3D5 File Offset: 0x0000D5D5
		public static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, Object managedJobFunction0, Object managedJobFunction1, Object managedJobFunction2)
		{
			return JobsUtility.CreateJobReflectionDataDelegateField(IL2CPP.Il2CppObjectBaseToPtr(wrapperJobType), IL2CPP.Il2CppObjectBaseToPtr(userJobType), IL2CPP.Il2CppObjectBaseToPtr(managedJobFunction0), IL2CPP.Il2CppObjectBaseToPtr(managedJobFunction1), IL2CPP.Il2CppObjectBaseToPtr(managedJobFunction2));
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x0006184C File Offset: 0x0005FA4C
		public static IntPtr CreateJobReflectionData(Type type, JobType jobType, Object managedJobFunction0, [Optional] Object managedJobFunction1, [Optional] Object managedJobFunction2)
		{
			return JobsUtility.CreateJobReflectionData(type, type, managedJobFunction0, managedJobFunction1, managedJobFunction2);
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x0006186C File Offset: 0x0005FA6C
		public static IntPtr CreateJobReflectionData(Type type, Object managedJobFunction0, [Optional] Object managedJobFunction1, [Optional] Object managedJobFunction2)
		{
			return JobsUtility.CreateJobReflectionData(type, type, managedJobFunction0, managedJobFunction1, managedJobFunction2);
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x00061888 File Offset: 0x0005FA88
		public static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, JobType jobType, Object managedJobFunction0)
		{
			return JobsUtility.CreateJobReflectionData(wrapperJobType, userJobType, managedJobFunction0, null, null);
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x000618A4 File Offset: 0x0005FAA4
		public static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, Object managedJobFunction0)
		{
			return JobsUtility.CreateJobReflectionData(wrapperJobType, userJobType, managedJobFunction0, null, null);
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x0000F400 File Offset: 0x0000D600
		public static bool IsExecutingJob
		{
			get
			{
				return JobsUtility.get_IsExecutingJobDelegateField();
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x0000F40C File Offset: 0x0000D60C
		// (set) Token: 0x06001BD3 RID: 7123 RVA: 0x0000F418 File Offset: 0x0000D618
		public static bool JobDebuggerEnabled
		{
			get
			{
				return JobsUtility.get_JobDebuggerEnabledDelegateField();
			}
			set
			{
				JobsUtility.set_JobDebuggerEnabledDelegateField(value);
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001BD4 RID: 7124 RVA: 0x0000F425 File Offset: 0x0000D625
		// (set) Token: 0x06001BD5 RID: 7125 RVA: 0x0000F431 File Offset: 0x0000D631
		public static bool JobCompilerEnabled
		{
			get
			{
				return JobsUtility.get_JobCompilerEnabledDelegateField();
			}
			set
			{
				JobsUtility.set_JobCompilerEnabledDelegateField(value);
			}
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x0000F43E File Offset: 0x0000D63E
		public static int GetJobQueueWorkerThreadCount()
		{
			return JobsUtility.GetJobQueueWorkerThreadCountDelegateField();
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x0000F44A File Offset: 0x0000D64A
		public static void SetJobQueueMaximumActiveThreadCount(int count)
		{
			JobsUtility.SetJobQueueMaximumActiveThreadCountDelegateField(count);
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001BD8 RID: 7128 RVA: 0x0000F457 File Offset: 0x0000D657
		public static int JobWorkerMaximumCount
		{
			get
			{
				return JobsUtility.get_JobWorkerMaximumCountDelegateField();
			}
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x0000F463 File Offset: 0x0000D663
		public static void ResetJobWorkerCount()
		{
			JobsUtility.ResetJobWorkerCountDelegateField();
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001BDA RID: 7130 RVA: 0x000618C0 File Offset: 0x0005FAC0
		// (set) Token: 0x06001BDB RID: 7131 RVA: 0x000618D8 File Offset: 0x0005FAD8
		public static int JobWorkerCount
		{
			get
			{
				return JobsUtility.GetJobQueueWorkerThreadCount();
			}
			set
			{
				bool flag = value < 0 || value > JobsUtility.JobWorkerMaximumCount;
				if (flag)
				{
					throw new ArgumentOutOfRangeException("JobWorkerCount", String.Format("Invalid JobWorkerCount {0} must be in the range 0 -> {1}", value, JobsUtility.JobWorkerMaximumCount));
				}
				JobsUtility.SetJobQueueMaximumActiveThreadCount(value);
			}
		}

		// Token: 0x040015A8 RID: 5544
		public const int MaxJobThreadCount = 128;

		// Token: 0x040015A9 RID: 5545
		public const int CacheLineSize = 64;

		// Token: 0x040015AA RID: 5546
		private static readonly JobsUtility.PatchBufferMinMaxRangesDelegate PatchBufferMinMaxRangesDelegateField = IL2CPP.ResolveICall<JobsUtility.PatchBufferMinMaxRangesDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::PatchBufferMinMaxRanges");

		// Token: 0x040015AB RID: 5547
		private static readonly JobsUtility.CreateJobReflectionDataDelegate CreateJobReflectionDataDelegateField = IL2CPP.ResolveICall<JobsUtility.CreateJobReflectionDataDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::CreateJobReflectionData");

		// Token: 0x040015AC RID: 5548
		private static readonly JobsUtility.get_IsExecutingJobDelegate get_IsExecutingJobDelegateField = IL2CPP.ResolveICall<JobsUtility.get_IsExecutingJobDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_IsExecutingJob");

		// Token: 0x040015AD RID: 5549
		private static readonly JobsUtility.get_JobDebuggerEnabledDelegate get_JobDebuggerEnabledDelegateField = IL2CPP.ResolveICall<JobsUtility.get_JobDebuggerEnabledDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_JobDebuggerEnabled");

		// Token: 0x040015AE RID: 5550
		private static readonly JobsUtility.set_JobDebuggerEnabledDelegate set_JobDebuggerEnabledDelegateField = IL2CPP.ResolveICall<JobsUtility.set_JobDebuggerEnabledDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::set_JobDebuggerEnabled");

		// Token: 0x040015AF RID: 5551
		private static readonly JobsUtility.get_JobCompilerEnabledDelegate get_JobCompilerEnabledDelegateField = IL2CPP.ResolveICall<JobsUtility.get_JobCompilerEnabledDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_JobCompilerEnabled");

		// Token: 0x040015B0 RID: 5552
		private static readonly JobsUtility.set_JobCompilerEnabledDelegate set_JobCompilerEnabledDelegateField = IL2CPP.ResolveICall<JobsUtility.set_JobCompilerEnabledDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::set_JobCompilerEnabled");

		// Token: 0x040015B1 RID: 5553
		private static readonly JobsUtility.GetJobQueueWorkerThreadCountDelegate GetJobQueueWorkerThreadCountDelegateField = IL2CPP.ResolveICall<JobsUtility.GetJobQueueWorkerThreadCountDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::GetJobQueueWorkerThreadCount");

		// Token: 0x040015B2 RID: 5554
		private static readonly JobsUtility.SetJobQueueMaximumActiveThreadCountDelegate SetJobQueueMaximumActiveThreadCountDelegateField = IL2CPP.ResolveICall<JobsUtility.SetJobQueueMaximumActiveThreadCountDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::SetJobQueueMaximumActiveThreadCount");

		// Token: 0x040015B3 RID: 5555
		private static readonly JobsUtility.get_JobWorkerMaximumCountDelegate get_JobWorkerMaximumCountDelegateField = IL2CPP.ResolveICall<JobsUtility.get_JobWorkerMaximumCountDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_JobWorkerMaximumCount");

		// Token: 0x040015B4 RID: 5556
		private static readonly JobsUtility.ResetJobWorkerCountDelegate ResetJobWorkerCountDelegateField = IL2CPP.ResolveICall<JobsUtility.ResetJobWorkerCountDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::ResetJobWorkerCount");

		// Token: 0x02000A71 RID: 2673
		// (Invoke) Token: 0x060032E8 RID: 13032
		private delegate void PatchBufferMinMaxRangesDelegate(IntPtr bufferRangePatchData, IntPtr jobdata, int startIndex, int rangeSize);

		// Token: 0x02000A72 RID: 2674
		// (Invoke) Token: 0x060032EA RID: 13034
		private delegate IntPtr CreateJobReflectionDataDelegate(IntPtr wrapperJobType, IntPtr userJobType, IntPtr managedJobFunction0, IntPtr managedJobFunction1, IntPtr managedJobFunction2);

		// Token: 0x02000A73 RID: 2675
		// (Invoke) Token: 0x060032EC RID: 13036
		private delegate bool get_IsExecutingJobDelegate();

		// Token: 0x02000A74 RID: 2676
		// (Invoke) Token: 0x060032EE RID: 13038
		private delegate bool get_JobDebuggerEnabledDelegate();

		// Token: 0x02000A75 RID: 2677
		// (Invoke) Token: 0x060032F0 RID: 13040
		private delegate void set_JobDebuggerEnabledDelegate(bool value);

		// Token: 0x02000A76 RID: 2678
		// (Invoke) Token: 0x060032F2 RID: 13042
		private delegate bool get_JobCompilerEnabledDelegate();

		// Token: 0x02000A77 RID: 2679
		// (Invoke) Token: 0x060032F4 RID: 13044
		private delegate void set_JobCompilerEnabledDelegate(bool value);

		// Token: 0x02000A78 RID: 2680
		// (Invoke) Token: 0x060032F6 RID: 13046
		private delegate int GetJobQueueWorkerThreadCountDelegate();

		// Token: 0x02000A79 RID: 2681
		// (Invoke) Token: 0x060032F8 RID: 13048
		private delegate void SetJobQueueMaximumActiveThreadCountDelegate(int count);

		// Token: 0x02000A7A RID: 2682
		// (Invoke) Token: 0x060032FA RID: 13050
		private delegate int get_JobWorkerMaximumCountDelegate();

		// Token: 0x02000A7B RID: 2683
		// (Invoke) Token: 0x060032FC RID: 13052
		private delegate void ResetJobWorkerCountDelegate();
	}
}
