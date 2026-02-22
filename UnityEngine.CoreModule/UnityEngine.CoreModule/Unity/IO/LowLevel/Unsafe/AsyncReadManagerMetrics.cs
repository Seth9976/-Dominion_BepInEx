using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x0200019A RID: 410
	public static class AsyncReadManagerMetrics
	{
		// Token: 0x06001BE1 RID: 7137 RVA: 0x0000F4D0 File Offset: 0x0000D6D0
		public static bool IsEnabled()
		{
			return AsyncReadManagerMetrics.IsEnabledDelegateField();
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x0000F4DC File Offset: 0x0000D6DC
		public static void ClearMetrics_Internal()
		{
			AsyncReadManagerMetrics.ClearMetrics_InternalDelegateField();
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x0000F4E8 File Offset: 0x0000D6E8
		public static void ClearCompletedMetrics()
		{
			AsyncReadManagerMetrics.ClearMetrics_Internal();
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x00061A18 File Offset: 0x0005FC18
		public static Il2CppReferenceArray<AsyncReadManagerRequestMetric> GetMetrics_Internal(bool clear)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetMetrics_InternalDelegateField(clear);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AsyncReadManagerRequestMetric>>(intPtr2) : null;
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x0000F4F1 File Offset: 0x0000D6F1
		public static void GetMetrics_NoAlloc_Internal(List<AsyncReadManagerRequestMetric> metrics, bool clear)
		{
			AsyncReadManagerMetrics.GetMetrics_NoAlloc_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metrics), clear);
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x00061A40 File Offset: 0x0005FC40
		public static Il2CppReferenceArray<AsyncReadManagerRequestMetric> GetMetrics_Filtered_Internal(AsyncReadManagerMetricsFilters filters, bool clear)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetMetrics_Filtered_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(filters), clear);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AsyncReadManagerRequestMetric>>(intPtr2) : null;
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x0000F504 File Offset: 0x0000D704
		public static void GetMetrics_NoAlloc_Filtered_Internal(List<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters filters, bool clear)
		{
			AsyncReadManagerMetrics.GetMetrics_NoAlloc_Filtered_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metrics), IL2CPP.Il2CppObjectBaseToPtr(filters), clear);
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x00061A70 File Offset: 0x0005FC70
		public static Il2CppReferenceArray<AsyncReadManagerRequestMetric> GetMetrics(AsyncReadManagerMetricsFilters filters, AsyncReadManagerMetrics.Flags flags)
		{
			bool flag = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
			return AsyncReadManagerMetrics.GetMetrics_Filtered_Internal(filters, flag);
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x00061A94 File Offset: 0x0005FC94
		public static void GetMetrics(List<AsyncReadManagerRequestMetric> outMetrics, AsyncReadManagerMetricsFilters filters, AsyncReadManagerMetrics.Flags flags)
		{
			bool flag = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
			AsyncReadManagerMetrics.GetMetrics_NoAlloc_Filtered_Internal(outMetrics, filters, flag);
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x00061AB8 File Offset: 0x0005FCB8
		public static Il2CppReferenceArray<AsyncReadManagerRequestMetric> GetMetrics(AsyncReadManagerMetrics.Flags flags)
		{
			bool flag = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
			return AsyncReadManagerMetrics.GetMetrics_Internal(flag);
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x00061ADC File Offset: 0x0005FCDC
		public static void GetMetrics(List<AsyncReadManagerRequestMetric> outMetrics, AsyncReadManagerMetrics.Flags flags)
		{
			bool flag = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
			AsyncReadManagerMetrics.GetMetrics_NoAlloc_Internal(outMetrics, flag);
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x0000F51D File Offset: 0x0000D71D
		public static void StartCollectingMetrics()
		{
			AsyncReadManagerMetrics.StartCollectingMetricsDelegateField();
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x0000F529 File Offset: 0x0000D729
		public static void StopCollectingMetrics()
		{
			AsyncReadManagerMetrics.StopCollectingMetricsDelegateField();
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x00061B00 File Offset: 0x0005FD00
		public static AsyncReadManagerSummaryMetrics GetSummaryMetrics_Internal(bool clear)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetSummaryMetrics_InternalDelegateField(clear);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr2) : null;
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x00061B28 File Offset: 0x0005FD28
		public static AsyncReadManagerSummaryMetrics GetCurrentSummaryMetrics(AsyncReadManagerMetrics.Flags flags)
		{
			bool flag = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
			return AsyncReadManagerMetrics.GetSummaryMetrics_Internal(flag);
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x00061B4C File Offset: 0x0005FD4C
		public static AsyncReadManagerSummaryMetrics GetSummaryMetricsWithFilters_Internal(AsyncReadManagerMetricsFilters metricsFilters, bool clear)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetSummaryMetricsWithFilters_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metricsFilters), clear);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr2) : null;
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x00061B7C File Offset: 0x0005FD7C
		public static AsyncReadManagerSummaryMetrics GetCurrentSummaryMetrics(AsyncReadManagerMetricsFilters metricsFilters, AsyncReadManagerMetrics.Flags flags)
		{
			bool flag = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
			return AsyncReadManagerMetrics.GetSummaryMetricsWithFilters_Internal(metricsFilters, flag);
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x00061BA0 File Offset: 0x0005FDA0
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics_Internal(Il2CppReferenceArray<AsyncReadManagerRequestMetric> metrics)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetSummaryOfMetrics_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metrics));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr2) : null;
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x00061BCC File Offset: 0x0005FDCC
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(Il2CppReferenceArray<AsyncReadManagerRequestMetric> metrics)
		{
			return AsyncReadManagerMetrics.GetSummaryOfMetrics_Internal(metrics);
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x00061BE4 File Offset: 0x0005FDE4
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics_FromContainer_Internal(List<AsyncReadManagerRequestMetric> metrics)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetSummaryOfMetrics_FromContainer_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metrics));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr2) : null;
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x00061C10 File Offset: 0x0005FE10
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(List<AsyncReadManagerRequestMetric> metrics)
		{
			return AsyncReadManagerMetrics.GetSummaryOfMetrics_FromContainer_Internal(metrics);
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x00061C28 File Offset: 0x0005FE28
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetricsWithFilters_Internal(Il2CppReferenceArray<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters metricsFilters)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metrics), IL2CPP.Il2CppObjectBaseToPtr(metricsFilters));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr2) : null;
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x00061C5C File Offset: 0x0005FE5C
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(Il2CppReferenceArray<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters metricsFilters)
		{
			return AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_Internal(metrics, metricsFilters);
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x00061C78 File Offset: 0x0005FE78
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetricsWithFilters_FromContainer_Internal(List<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters metricsFilters)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metrics), IL2CPP.Il2CppObjectBaseToPtr(metricsFilters));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr2) : null;
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x00061CAC File Offset: 0x0005FEAC
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(List<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters metricsFilters)
		{
			return AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_FromContainer_Internal(metrics, metricsFilters);
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x0000F535 File Offset: 0x0000D735
		public static ulong GetTotalSizeOfNonASRMReadsBytes(bool emptyAfterRead)
		{
			return AsyncReadManagerMetrics.GetTotalSizeOfNonASRMReadsBytesDelegateField(emptyAfterRead);
		}

		// Token: 0x040015C6 RID: 5574
		private static readonly AsyncReadManagerMetrics.IsEnabledDelegate IsEnabledDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.IsEnabledDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::IsEnabled");

		// Token: 0x040015C7 RID: 5575
		private static readonly AsyncReadManagerMetrics.ClearMetrics_InternalDelegate ClearMetrics_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.ClearMetrics_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::ClearMetrics_Internal");

		// Token: 0x040015C8 RID: 5576
		private static readonly AsyncReadManagerMetrics.GetMetrics_InternalDelegate GetMetrics_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetMetrics_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_Internal");

		// Token: 0x040015C9 RID: 5577
		private static readonly AsyncReadManagerMetrics.GetMetrics_NoAlloc_InternalDelegate GetMetrics_NoAlloc_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetMetrics_NoAlloc_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_NoAlloc_Internal");

		// Token: 0x040015CA RID: 5578
		private static readonly AsyncReadManagerMetrics.GetMetrics_Filtered_InternalDelegate GetMetrics_Filtered_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetMetrics_Filtered_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_Filtered_Internal");

		// Token: 0x040015CB RID: 5579
		private static readonly AsyncReadManagerMetrics.GetMetrics_NoAlloc_Filtered_InternalDelegate GetMetrics_NoAlloc_Filtered_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetMetrics_NoAlloc_Filtered_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_NoAlloc_Filtered_Internal");

		// Token: 0x040015CC RID: 5580
		private static readonly AsyncReadManagerMetrics.StartCollectingMetricsDelegate StartCollectingMetricsDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.StartCollectingMetricsDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::StartCollectingMetrics");

		// Token: 0x040015CD RID: 5581
		private static readonly AsyncReadManagerMetrics.StopCollectingMetricsDelegate StopCollectingMetricsDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.StopCollectingMetricsDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::StopCollectingMetrics");

		// Token: 0x040015CE RID: 5582
		private static readonly AsyncReadManagerMetrics.GetSummaryMetrics_InternalDelegate GetSummaryMetrics_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryMetrics_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryMetrics_Internal");

		// Token: 0x040015CF RID: 5583
		private static readonly AsyncReadManagerMetrics.GetSummaryMetricsWithFilters_InternalDelegate GetSummaryMetricsWithFilters_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryMetricsWithFilters_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryMetricsWithFilters_Internal");

		// Token: 0x040015D0 RID: 5584
		private static readonly AsyncReadManagerMetrics.GetSummaryOfMetrics_InternalDelegate GetSummaryOfMetrics_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryOfMetrics_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetrics_Internal");

		// Token: 0x040015D1 RID: 5585
		private static readonly AsyncReadManagerMetrics.GetSummaryOfMetrics_FromContainer_InternalDelegate GetSummaryOfMetrics_FromContainer_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryOfMetrics_FromContainer_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetrics_FromContainer_Internal");

		// Token: 0x040015D2 RID: 5586
		private static readonly AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_InternalDelegate GetSummaryOfMetricsWithFilters_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetricsWithFilters_Internal");

		// Token: 0x040015D3 RID: 5587
		private static readonly AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegate GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetricsWithFilters_FromContainer_Internal");

		// Token: 0x040015D4 RID: 5588
		private static readonly AsyncReadManagerMetrics.GetTotalSizeOfNonASRMReadsBytesDelegate GetTotalSizeOfNonASRMReadsBytesDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetTotalSizeOfNonASRMReadsBytesDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetTotalSizeOfNonASRMReadsBytes");

		// Token: 0x02000A7F RID: 2687
		public enum Flags
		{
			// Token: 0x04001D8E RID: 7566
			None,
			// Token: 0x04001D8F RID: 7567
			ClearOnRead
		}

		// Token: 0x02000A80 RID: 2688
		// (Invoke) Token: 0x06003304 RID: 13060
		private delegate bool IsEnabledDelegate();

		// Token: 0x02000A81 RID: 2689
		// (Invoke) Token: 0x06003306 RID: 13062
		private delegate void ClearMetrics_InternalDelegate();

		// Token: 0x02000A82 RID: 2690
		// (Invoke) Token: 0x06003308 RID: 13064
		private delegate IntPtr GetMetrics_InternalDelegate(bool clear);

		// Token: 0x02000A83 RID: 2691
		// (Invoke) Token: 0x0600330A RID: 13066
		private delegate void GetMetrics_NoAlloc_InternalDelegate(IntPtr metrics, bool clear);

		// Token: 0x02000A84 RID: 2692
		// (Invoke) Token: 0x0600330C RID: 13068
		private delegate IntPtr GetMetrics_Filtered_InternalDelegate(IntPtr filters, bool clear);

		// Token: 0x02000A85 RID: 2693
		// (Invoke) Token: 0x0600330E RID: 13070
		private delegate void GetMetrics_NoAlloc_Filtered_InternalDelegate(IntPtr metrics, IntPtr filters, bool clear);

		// Token: 0x02000A86 RID: 2694
		// (Invoke) Token: 0x06003310 RID: 13072
		private delegate void StartCollectingMetricsDelegate();

		// Token: 0x02000A87 RID: 2695
		// (Invoke) Token: 0x06003312 RID: 13074
		private delegate void StopCollectingMetricsDelegate();

		// Token: 0x02000A88 RID: 2696
		// (Invoke) Token: 0x06003314 RID: 13076
		private delegate IntPtr GetSummaryMetrics_InternalDelegate(bool clear);

		// Token: 0x02000A89 RID: 2697
		// (Invoke) Token: 0x06003316 RID: 13078
		private delegate IntPtr GetSummaryMetricsWithFilters_InternalDelegate(IntPtr metricsFilters, bool clear);

		// Token: 0x02000A8A RID: 2698
		// (Invoke) Token: 0x06003318 RID: 13080
		private delegate IntPtr GetSummaryOfMetrics_InternalDelegate(IntPtr metrics);

		// Token: 0x02000A8B RID: 2699
		// (Invoke) Token: 0x0600331A RID: 13082
		private delegate IntPtr GetSummaryOfMetrics_FromContainer_InternalDelegate(IntPtr metrics);

		// Token: 0x02000A8C RID: 2700
		// (Invoke) Token: 0x0600331C RID: 13084
		private delegate IntPtr GetSummaryOfMetricsWithFilters_InternalDelegate(IntPtr metrics, IntPtr metricsFilters);

		// Token: 0x02000A8D RID: 2701
		// (Invoke) Token: 0x0600331E RID: 13086
		private delegate IntPtr GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegate(IntPtr metrics, IntPtr metricsFilters);

		// Token: 0x02000A8E RID: 2702
		// (Invoke) Token: 0x06003320 RID: 13088
		private delegate ulong GetTotalSizeOfNonASRMReadsBytesDelegate(bool emptyAfterRead);
	}
}
