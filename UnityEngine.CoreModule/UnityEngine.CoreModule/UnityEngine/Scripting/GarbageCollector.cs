using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Scripting
{
	// Token: 0x02000266 RID: 614
	public static class GarbageCollector
	{
		// Token: 0x06001FF7 RID: 8183 RVA: 0x00012762 File Offset: 0x00010962
		public static void add_GCModeChanged(Action<GarbageCollector.Mode> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x0001276F File Offset: 0x0001096F
		public static void remove_GCModeChanged(Action<GarbageCollector.Mode> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06001FF9 RID: 8185 RVA: 0x00067118 File Offset: 0x00065318
		// (set) Token: 0x06001FFA RID: 8186 RVA: 0x0001277C File Offset: 0x0001097C
		public static GarbageCollector.Mode GCMode
		{
			get
			{
				return GarbageCollector.GetMode();
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x00012789 File Offset: 0x00010989
		public static void SetMode(GarbageCollector.Mode mode)
		{
			GarbageCollector.SetModeDelegateField(mode);
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x00012796 File Offset: 0x00010996
		public static GarbageCollector.Mode GetMode()
		{
			return GarbageCollector.GetModeDelegateField();
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06001FFD RID: 8189 RVA: 0x000127A2 File Offset: 0x000109A2
		public static bool isIncremental
		{
			get
			{
				return GarbageCollector.get_isIncrementalDelegateField();
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06001FFE RID: 8190 RVA: 0x000127AE File Offset: 0x000109AE
		// (set) Token: 0x06001FFF RID: 8191 RVA: 0x000127BA File Offset: 0x000109BA
		public static ulong incrementalTimeSliceNanoseconds
		{
			get
			{
				return GarbageCollector.get_incrementalTimeSliceNanosecondsDelegateField();
			}
			set
			{
				GarbageCollector.set_incrementalTimeSliceNanosecondsDelegateField(value);
			}
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x000127C7 File Offset: 0x000109C7
		public static bool CollectIncremental([Optional] ulong nanoseconds)
		{
			return GarbageCollector.CollectIncrementalDelegateField(nanoseconds);
		}

		// Token: 0x04001950 RID: 6480
		private static readonly GarbageCollector.SetModeDelegate SetModeDelegateField = IL2CPP.ResolveICall<GarbageCollector.SetModeDelegate>("UnityEngine.Scripting.GarbageCollector::SetMode");

		// Token: 0x04001951 RID: 6481
		private static readonly GarbageCollector.GetModeDelegate GetModeDelegateField = IL2CPP.ResolveICall<GarbageCollector.GetModeDelegate>("UnityEngine.Scripting.GarbageCollector::GetMode");

		// Token: 0x04001952 RID: 6482
		private static readonly GarbageCollector.get_isIncrementalDelegate get_isIncrementalDelegateField = IL2CPP.ResolveICall<GarbageCollector.get_isIncrementalDelegate>("UnityEngine.Scripting.GarbageCollector::get_isIncremental");

		// Token: 0x04001953 RID: 6483
		private static readonly GarbageCollector.get_incrementalTimeSliceNanosecondsDelegate get_incrementalTimeSliceNanosecondsDelegateField = IL2CPP.ResolveICall<GarbageCollector.get_incrementalTimeSliceNanosecondsDelegate>("UnityEngine.Scripting.GarbageCollector::get_incrementalTimeSliceNanoseconds");

		// Token: 0x04001954 RID: 6484
		private static readonly GarbageCollector.set_incrementalTimeSliceNanosecondsDelegate set_incrementalTimeSliceNanosecondsDelegateField = IL2CPP.ResolveICall<GarbageCollector.set_incrementalTimeSliceNanosecondsDelegate>("UnityEngine.Scripting.GarbageCollector::set_incrementalTimeSliceNanoseconds");

		// Token: 0x04001955 RID: 6485
		private static readonly GarbageCollector.CollectIncrementalDelegate CollectIncrementalDelegateField = IL2CPP.ResolveICall<GarbageCollector.CollectIncrementalDelegate>("UnityEngine.Scripting.GarbageCollector::CollectIncremental");

		// Token: 0x02000C6B RID: 3179
		public enum Mode
		{
			// Token: 0x04001DB2 RID: 7602
			Disabled,
			// Token: 0x04001DB3 RID: 7603
			Enabled,
			// Token: 0x04001DB4 RID: 7604
			Manual
		}

		// Token: 0x02000C6C RID: 3180
		// (Invoke) Token: 0x060036BE RID: 14014
		private delegate void SetModeDelegate(GarbageCollector.Mode mode);

		// Token: 0x02000C6D RID: 3181
		// (Invoke) Token: 0x060036C0 RID: 14016
		private delegate GarbageCollector.Mode GetModeDelegate();

		// Token: 0x02000C6E RID: 3182
		// (Invoke) Token: 0x060036C2 RID: 14018
		private delegate bool get_isIncrementalDelegate();

		// Token: 0x02000C6F RID: 3183
		// (Invoke) Token: 0x060036C4 RID: 14020
		private delegate ulong get_incrementalTimeSliceNanosecondsDelegate();

		// Token: 0x02000C70 RID: 3184
		// (Invoke) Token: 0x060036C6 RID: 14022
		private delegate void set_incrementalTimeSliceNanosecondsDelegate(ulong value);

		// Token: 0x02000C71 RID: 3185
		// (Invoke) Token: 0x060036C8 RID: 14024
		private delegate bool CollectIncrementalDelegate(ulong nanoseconds);
	}
}
