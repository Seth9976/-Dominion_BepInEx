using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Profiling
{
	// Token: 0x02000253 RID: 595
	public sealed class Recorder
	{
		// Token: 0x06001FBF RID: 8127 RVA: 0x00012490 File Offset: 0x00010690
		public override void Finalize()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x0001249D File Offset: 0x0001069D
		public static Recorder Get(string samplerName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x000124AA File Offset: 0x000106AA
		public static IntPtr GetInternal(string samplerName)
		{
			return Recorder.GetInternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(samplerName));
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x000124BC File Offset: 0x000106BC
		public bool isValid
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x000124C9 File Offset: 0x000106C9
		public static void DisposeNative(IntPtr ptr)
		{
			Recorder.DisposeNativeDelegateField(ptr);
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001FC4 RID: 8132 RVA: 0x00066E78 File Offset: 0x00065078
		// (set) Token: 0x06001FC5 RID: 8133 RVA: 0x00066E9C File Offset: 0x0006509C
		public bool enabled
		{
			get
			{
				return this.isValid && this.IsEnabled();
			}
			set
			{
				bool isValid = this.isValid;
				if (isValid)
				{
					this.SetEnabled(value);
				}
			}
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x000124D6 File Offset: 0x000106D6
		public bool IsEnabled()
		{
			return Recorder.IsEnabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x000124E8 File Offset: 0x000106E8
		public void SetEnabled(bool enabled)
		{
			Recorder.SetEnabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), enabled);
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x00066EBC File Offset: 0x000650BC
		public long elapsedNanoseconds
		{
			get
			{
				return this.isValid ? this.GetElapsedNanoseconds() : 0L;
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001FC9 RID: 8137 RVA: 0x00066EE0 File Offset: 0x000650E0
		public long gpuElapsedNanoseconds
		{
			get
			{
				return this.isValid ? this.GetGpuElapsedNanoseconds() : 0L;
			}
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x000124FB File Offset: 0x000106FB
		public long GetElapsedNanoseconds()
		{
			return Recorder.GetElapsedNanosecondsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x0001250D File Offset: 0x0001070D
		public long GetGpuElapsedNanoseconds()
		{
			return Recorder.GetGpuElapsedNanosecondsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001FCC RID: 8140 RVA: 0x00066F04 File Offset: 0x00065104
		public int sampleBlockCount
		{
			get
			{
				return this.isValid ? this.GetSampleBlockCount() : 0;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x00066F28 File Offset: 0x00065128
		public int gpuSampleBlockCount
		{
			get
			{
				return this.isValid ? this.GetGpuSampleBlockCount() : 0;
			}
		}

		// Token: 0x06001FCE RID: 8142 RVA: 0x0001251F File Offset: 0x0001071F
		public int GetSampleBlockCount()
		{
			return Recorder.GetSampleBlockCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x00012531 File Offset: 0x00010731
		public int GetGpuSampleBlockCount()
		{
			return Recorder.GetGpuSampleBlockCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x00012543 File Offset: 0x00010743
		public void FilterToCurrentThread()
		{
			Recorder.FilterToCurrentThreadDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001FD1 RID: 8145 RVA: 0x00012555 File Offset: 0x00010755
		public void CollectFromAllThreads()
		{
			Recorder.CollectFromAllThreadsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0400192B RID: 6443
		private static readonly Recorder.GetInternalDelegate GetInternalDelegateField = IL2CPP.ResolveICall<Recorder.GetInternalDelegate>("UnityEngine.Profiling.Recorder::GetInternal");

		// Token: 0x0400192C RID: 6444
		private static readonly Recorder.DisposeNativeDelegate DisposeNativeDelegateField = IL2CPP.ResolveICall<Recorder.DisposeNativeDelegate>("UnityEngine.Profiling.Recorder::DisposeNative");

		// Token: 0x0400192D RID: 6445
		private static readonly Recorder.IsEnabledDelegate IsEnabledDelegateField = IL2CPP.ResolveICall<Recorder.IsEnabledDelegate>("UnityEngine.Profiling.Recorder::IsEnabled");

		// Token: 0x0400192E RID: 6446
		private static readonly Recorder.SetEnabledDelegate SetEnabledDelegateField = IL2CPP.ResolveICall<Recorder.SetEnabledDelegate>("UnityEngine.Profiling.Recorder::SetEnabled");

		// Token: 0x0400192F RID: 6447
		private static readonly Recorder.GetElapsedNanosecondsDelegate GetElapsedNanosecondsDelegateField = IL2CPP.ResolveICall<Recorder.GetElapsedNanosecondsDelegate>("UnityEngine.Profiling.Recorder::GetElapsedNanoseconds");

		// Token: 0x04001930 RID: 6448
		private static readonly Recorder.GetGpuElapsedNanosecondsDelegate GetGpuElapsedNanosecondsDelegateField = IL2CPP.ResolveICall<Recorder.GetGpuElapsedNanosecondsDelegate>("UnityEngine.Profiling.Recorder::GetGpuElapsedNanoseconds");

		// Token: 0x04001931 RID: 6449
		private static readonly Recorder.GetSampleBlockCountDelegate GetSampleBlockCountDelegateField = IL2CPP.ResolveICall<Recorder.GetSampleBlockCountDelegate>("UnityEngine.Profiling.Recorder::GetSampleBlockCount");

		// Token: 0x04001932 RID: 6450
		private static readonly Recorder.GetGpuSampleBlockCountDelegate GetGpuSampleBlockCountDelegateField = IL2CPP.ResolveICall<Recorder.GetGpuSampleBlockCountDelegate>("UnityEngine.Profiling.Recorder::GetGpuSampleBlockCount");

		// Token: 0x04001933 RID: 6451
		private static readonly Recorder.FilterToCurrentThreadDelegate FilterToCurrentThreadDelegateField = IL2CPP.ResolveICall<Recorder.FilterToCurrentThreadDelegate>("UnityEngine.Profiling.Recorder::FilterToCurrentThread");

		// Token: 0x04001934 RID: 6452
		private static readonly Recorder.CollectFromAllThreadsDelegate CollectFromAllThreadsDelegateField = IL2CPP.ResolveICall<Recorder.CollectFromAllThreadsDelegate>("UnityEngine.Profiling.Recorder::CollectFromAllThreads");

		// Token: 0x02000C57 RID: 3159
		// (Invoke) Token: 0x06003696 RID: 13974
		private delegate IntPtr GetInternalDelegate(IntPtr samplerName);

		// Token: 0x02000C58 RID: 3160
		// (Invoke) Token: 0x06003698 RID: 13976
		private delegate void DisposeNativeDelegate(IntPtr ptr);

		// Token: 0x02000C59 RID: 3161
		// (Invoke) Token: 0x0600369A RID: 13978
		private delegate bool IsEnabledDelegate(IntPtr @this);

		// Token: 0x02000C5A RID: 3162
		// (Invoke) Token: 0x0600369C RID: 13980
		private delegate void SetEnabledDelegate(IntPtr @this, bool enabled);

		// Token: 0x02000C5B RID: 3163
		// (Invoke) Token: 0x0600369E RID: 13982
		private delegate long GetElapsedNanosecondsDelegate(IntPtr @this);

		// Token: 0x02000C5C RID: 3164
		// (Invoke) Token: 0x060036A0 RID: 13984
		private delegate long GetGpuElapsedNanosecondsDelegate(IntPtr @this);

		// Token: 0x02000C5D RID: 3165
		// (Invoke) Token: 0x060036A2 RID: 13986
		private delegate int GetSampleBlockCountDelegate(IntPtr @this);

		// Token: 0x02000C5E RID: 3166
		// (Invoke) Token: 0x060036A4 RID: 13988
		private delegate int GetGpuSampleBlockCountDelegate(IntPtr @this);

		// Token: 0x02000C5F RID: 3167
		// (Invoke) Token: 0x060036A6 RID: 13990
		private delegate void FilterToCurrentThreadDelegate(IntPtr @this);

		// Token: 0x02000C60 RID: 3168
		// (Invoke) Token: 0x060036A8 RID: 13992
		private delegate void CollectFromAllThreadsDelegate(IntPtr @this);
	}
}
