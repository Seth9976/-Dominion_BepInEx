using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000D7 RID: 215
	public class Time : Object
	{
		// Token: 0x060012B3 RID: 4787 RVA: 0x00048EC8 File Offset: 0x000470C8
		// Note: this type is marked as 'beforefieldinit'.
		static Time()
		{
			Il2CppClassPointerStore<Time>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Time");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Time>.NativeClassPtr);
			Time.NativeMethodInfoPtr_get_time_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100664566);
			Time.NativeMethodInfoPtr_get_deltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100664567);
			Time.NativeMethodInfoPtr_get_unscaledTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100664568);
			Time.NativeMethodInfoPtr_get_unscaledDeltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100664569);
			Time.NativeMethodInfoPtr_get_fixedDeltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100664570);
			Time.NativeMethodInfoPtr_set_timeScale_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100664571);
			Time.NativeMethodInfoPtr_get_realtimeSinceStartup_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100664572);
			Time.get_timeAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_timeAsDoubleDelegate>("UnityEngine.Time::get_timeAsDouble");
			Time.get_timeSinceLevelLoadDelegateField = IL2CPP.ResolveICall<Time.get_timeSinceLevelLoadDelegate>("UnityEngine.Time::get_timeSinceLevelLoad");
			Time.get_timeSinceLevelLoadAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_timeSinceLevelLoadAsDoubleDelegate>("UnityEngine.Time::get_timeSinceLevelLoadAsDouble");
			Time.get_fixedTimeDelegateField = IL2CPP.ResolveICall<Time.get_fixedTimeDelegate>("UnityEngine.Time::get_fixedTime");
			Time.get_fixedTimeAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_fixedTimeAsDoubleDelegate>("UnityEngine.Time::get_fixedTimeAsDouble");
			Time.get_unscaledTimeAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_unscaledTimeAsDoubleDelegate>("UnityEngine.Time::get_unscaledTimeAsDouble");
			Time.get_fixedUnscaledTimeDelegateField = IL2CPP.ResolveICall<Time.get_fixedUnscaledTimeDelegate>("UnityEngine.Time::get_fixedUnscaledTime");
			Time.get_fixedUnscaledTimeAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_fixedUnscaledTimeAsDoubleDelegate>("UnityEngine.Time::get_fixedUnscaledTimeAsDouble");
			Time.get_fixedUnscaledDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.get_fixedUnscaledDeltaTimeDelegate>("UnityEngine.Time::get_fixedUnscaledDeltaTime");
			Time.set_fixedDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.set_fixedDeltaTimeDelegate>("UnityEngine.Time::set_fixedDeltaTime");
			Time.get_maximumDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.get_maximumDeltaTimeDelegate>("UnityEngine.Time::get_maximumDeltaTime");
			Time.set_maximumDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.set_maximumDeltaTimeDelegate>("UnityEngine.Time::set_maximumDeltaTime");
			Time.get_smoothDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.get_smoothDeltaTimeDelegate>("UnityEngine.Time::get_smoothDeltaTime");
			Time.get_maximumParticleDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.get_maximumParticleDeltaTimeDelegate>("UnityEngine.Time::get_maximumParticleDeltaTime");
			Time.set_maximumParticleDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.set_maximumParticleDeltaTimeDelegate>("UnityEngine.Time::set_maximumParticleDeltaTime");
			Time.get_timeScaleDelegateField = IL2CPP.ResolveICall<Time.get_timeScaleDelegate>("UnityEngine.Time::get_timeScale");
			Time.get_frameCountDelegateField = IL2CPP.ResolveICall<Time.get_frameCountDelegate>("UnityEngine.Time::get_frameCount");
			Time.get_renderedFrameCountDelegateField = IL2CPP.ResolveICall<Time.get_renderedFrameCountDelegate>("UnityEngine.Time::get_renderedFrameCount");
			Time.get_realtimeSinceStartupAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_realtimeSinceStartupAsDoubleDelegate>("UnityEngine.Time::get_realtimeSinceStartupAsDouble");
			Time.get_captureDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.get_captureDeltaTimeDelegate>("UnityEngine.Time::get_captureDeltaTime");
			Time.set_captureDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.set_captureDeltaTimeDelegate>("UnityEngine.Time::set_captureDeltaTime");
			Time.get_inFixedTimeStepDelegateField = IL2CPP.ResolveICall<Time.get_inFixedTimeStepDelegate>("UnityEngine.Time::get_inFixedTimeStep");
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x060012B4 RID: 4788 RVA: 0x000490D0 File Offset: 0x000472D0
		public unsafe static float time
		{
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 76711, RefRangeEnd = 76772, XrefRangeStart = 76709, XrefRangeEnd = 76711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_time_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x060012B5 RID: 4789 RVA: 0x00049100 File Offset: 0x00047300
		public unsafe static float deltaTime
		{
			[CallerCount(46)]
			[CachedScanResults(RefRangeStart = 76774, RefRangeEnd = 76820, XrefRangeStart = 76772, XrefRangeEnd = 76774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_deltaTime_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x060012B6 RID: 4790 RVA: 0x00049130 File Offset: 0x00047330
		public unsafe static float unscaledTime
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 76822, RefRangeEnd = 76837, XrefRangeStart = 76820, XrefRangeEnd = 76822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_unscaledTime_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x060012B7 RID: 4791 RVA: 0x00049160 File Offset: 0x00047360
		public unsafe static float unscaledDeltaTime
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 76839, RefRangeEnd = 76844, XrefRangeStart = 76837, XrefRangeEnd = 76839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_unscaledDeltaTime_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x060012B8 RID: 4792 RVA: 0x00049190 File Offset: 0x00047390
		// (set) Token: 0x060012C5 RID: 4805 RVA: 0x0000B282 File Offset: 0x00009482
		public unsafe static float fixedDeltaTime
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 76846, RefRangeEnd = 76847, XrefRangeStart = 76844, XrefRangeEnd = 76846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_fixedDeltaTime_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Time.set_fixedDeltaTimeDelegateField(value);
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x060012CB RID: 4811 RVA: 0x0000B2CD File Offset: 0x000094CD
		// (set) Token: 0x060012B9 RID: 4793 RVA: 0x000491C0 File Offset: 0x000473C0
		public unsafe static float timeScale
		{
			get
			{
				return Time.get_timeScaleDelegateField();
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 76849, RefRangeEnd = 76852, XrefRangeStart = 76847, XrefRangeEnd = 76849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_set_timeScale_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x000491F4 File Offset: 0x000473F4
		public unsafe static float realtimeSinceStartup
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 76854, RefRangeEnd = 76872, XrefRangeStart = 76852, XrefRangeEnd = 76854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_realtimeSinceStartup_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x0000B20D File Offset: 0x0000940D
		public Time(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x0000B216 File Offset: 0x00009416
		public static double timeAsDouble
		{
			get
			{
				return Time.get_timeAsDoubleDelegateField();
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x060012BD RID: 4797 RVA: 0x0000B222 File Offset: 0x00009422
		public static float timeSinceLevelLoad
		{
			get
			{
				return Time.get_timeSinceLevelLoadDelegateField();
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x060012BE RID: 4798 RVA: 0x0000B22E File Offset: 0x0000942E
		public static double timeSinceLevelLoadAsDouble
		{
			get
			{
				return Time.get_timeSinceLevelLoadAsDoubleDelegateField();
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x060012BF RID: 4799 RVA: 0x0000B23A File Offset: 0x0000943A
		public static float fixedTime
		{
			get
			{
				return Time.get_fixedTimeDelegateField();
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x060012C0 RID: 4800 RVA: 0x0000B246 File Offset: 0x00009446
		public static double fixedTimeAsDouble
		{
			get
			{
				return Time.get_fixedTimeAsDoubleDelegateField();
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x060012C1 RID: 4801 RVA: 0x0000B252 File Offset: 0x00009452
		public static double unscaledTimeAsDouble
		{
			get
			{
				return Time.get_unscaledTimeAsDoubleDelegateField();
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x060012C2 RID: 4802 RVA: 0x0000B25E File Offset: 0x0000945E
		public static float fixedUnscaledTime
		{
			get
			{
				return Time.get_fixedUnscaledTimeDelegateField();
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x060012C3 RID: 4803 RVA: 0x0000B26A File Offset: 0x0000946A
		public static double fixedUnscaledTimeAsDouble
		{
			get
			{
				return Time.get_fixedUnscaledTimeAsDoubleDelegateField();
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x060012C4 RID: 4804 RVA: 0x0000B276 File Offset: 0x00009476
		public static float fixedUnscaledDeltaTime
		{
			get
			{
				return Time.get_fixedUnscaledDeltaTimeDelegateField();
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x060012C6 RID: 4806 RVA: 0x0000B28F File Offset: 0x0000948F
		// (set) Token: 0x060012C7 RID: 4807 RVA: 0x0000B29B File Offset: 0x0000949B
		public static float maximumDeltaTime
		{
			get
			{
				return Time.get_maximumDeltaTimeDelegateField();
			}
			set
			{
				Time.set_maximumDeltaTimeDelegateField(value);
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x060012C8 RID: 4808 RVA: 0x0000B2A8 File Offset: 0x000094A8
		public static float smoothDeltaTime
		{
			get
			{
				return Time.get_smoothDeltaTimeDelegateField();
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x0000B2B4 File Offset: 0x000094B4
		// (set) Token: 0x060012CA RID: 4810 RVA: 0x0000B2C0 File Offset: 0x000094C0
		public static float maximumParticleDeltaTime
		{
			get
			{
				return Time.get_maximumParticleDeltaTimeDelegateField();
			}
			set
			{
				Time.set_maximumParticleDeltaTimeDelegateField(value);
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x060012CC RID: 4812 RVA: 0x0000B2D9 File Offset: 0x000094D9
		public static int frameCount
		{
			get
			{
				return Time.get_frameCountDelegateField();
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x060012CD RID: 4813 RVA: 0x0000B2E5 File Offset: 0x000094E5
		public static int renderedFrameCount
		{
			get
			{
				return Time.get_renderedFrameCountDelegateField();
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x060012CE RID: 4814 RVA: 0x0000B2F1 File Offset: 0x000094F1
		public static double realtimeSinceStartupAsDouble
		{
			get
			{
				return Time.get_realtimeSinceStartupAsDoubleDelegateField();
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x060012CF RID: 4815 RVA: 0x0000B2FD File Offset: 0x000094FD
		// (set) Token: 0x060012D0 RID: 4816 RVA: 0x0000B309 File Offset: 0x00009509
		public static float captureDeltaTime
		{
			get
			{
				return Time.get_captureDeltaTimeDelegateField();
			}
			set
			{
				Time.set_captureDeltaTimeDelegateField(value);
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x060012D1 RID: 4817 RVA: 0x00049224 File Offset: 0x00047424
		// (set) Token: 0x060012D2 RID: 4818 RVA: 0x0000B316 File Offset: 0x00009516
		public static int captureFramerate
		{
			get
			{
				return (Time.captureDeltaTime == 0f) ? 0 : ((int)Mathf.Round(1f / Time.captureDeltaTime));
			}
			set
			{
				Time.captureDeltaTime = ((value == 0) ? 0f : (1f / (float)value));
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x0000B331 File Offset: 0x00009531
		public static bool inFixedTimeStep
		{
			get
			{
				return Time.get_inFixedTimeStepDelegateField();
			}
		}

		// Token: 0x04000DCC RID: 3532
		private static readonly IntPtr NativeMethodInfoPtr_get_time_Public_Static_get_Single_0;

		// Token: 0x04000DCD RID: 3533
		private static readonly IntPtr NativeMethodInfoPtr_get_deltaTime_Public_Static_get_Single_0;

		// Token: 0x04000DCE RID: 3534
		private static readonly IntPtr NativeMethodInfoPtr_get_unscaledTime_Public_Static_get_Single_0;

		// Token: 0x04000DCF RID: 3535
		private static readonly IntPtr NativeMethodInfoPtr_get_unscaledDeltaTime_Public_Static_get_Single_0;

		// Token: 0x04000DD0 RID: 3536
		private static readonly IntPtr NativeMethodInfoPtr_get_fixedDeltaTime_Public_Static_get_Single_0;

		// Token: 0x04000DD1 RID: 3537
		private static readonly IntPtr NativeMethodInfoPtr_set_timeScale_Public_Static_set_Void_Single_0;

		// Token: 0x04000DD2 RID: 3538
		private static readonly IntPtr NativeMethodInfoPtr_get_realtimeSinceStartup_Public_Static_get_Single_0;

		// Token: 0x04000DD3 RID: 3539
		private static readonly Time.get_timeAsDoubleDelegate get_timeAsDoubleDelegateField;

		// Token: 0x04000DD4 RID: 3540
		private static readonly Time.get_timeSinceLevelLoadDelegate get_timeSinceLevelLoadDelegateField;

		// Token: 0x04000DD5 RID: 3541
		private static readonly Time.get_timeSinceLevelLoadAsDoubleDelegate get_timeSinceLevelLoadAsDoubleDelegateField;

		// Token: 0x04000DD6 RID: 3542
		private static readonly Time.get_fixedTimeDelegate get_fixedTimeDelegateField;

		// Token: 0x04000DD7 RID: 3543
		private static readonly Time.get_fixedTimeAsDoubleDelegate get_fixedTimeAsDoubleDelegateField;

		// Token: 0x04000DD8 RID: 3544
		private static readonly Time.get_unscaledTimeAsDoubleDelegate get_unscaledTimeAsDoubleDelegateField;

		// Token: 0x04000DD9 RID: 3545
		private static readonly Time.get_fixedUnscaledTimeDelegate get_fixedUnscaledTimeDelegateField;

		// Token: 0x04000DDA RID: 3546
		private static readonly Time.get_fixedUnscaledTimeAsDoubleDelegate get_fixedUnscaledTimeAsDoubleDelegateField;

		// Token: 0x04000DDB RID: 3547
		private static readonly Time.get_fixedUnscaledDeltaTimeDelegate get_fixedUnscaledDeltaTimeDelegateField;

		// Token: 0x04000DDC RID: 3548
		private static readonly Time.set_fixedDeltaTimeDelegate set_fixedDeltaTimeDelegateField;

		// Token: 0x04000DDD RID: 3549
		private static readonly Time.get_maximumDeltaTimeDelegate get_maximumDeltaTimeDelegateField;

		// Token: 0x04000DDE RID: 3550
		private static readonly Time.set_maximumDeltaTimeDelegate set_maximumDeltaTimeDelegateField;

		// Token: 0x04000DDF RID: 3551
		private static readonly Time.get_smoothDeltaTimeDelegate get_smoothDeltaTimeDelegateField;

		// Token: 0x04000DE0 RID: 3552
		private static readonly Time.get_maximumParticleDeltaTimeDelegate get_maximumParticleDeltaTimeDelegateField;

		// Token: 0x04000DE1 RID: 3553
		private static readonly Time.set_maximumParticleDeltaTimeDelegate set_maximumParticleDeltaTimeDelegateField;

		// Token: 0x04000DE2 RID: 3554
		private static readonly Time.get_timeScaleDelegate get_timeScaleDelegateField;

		// Token: 0x04000DE3 RID: 3555
		private static readonly Time.get_frameCountDelegate get_frameCountDelegateField;

		// Token: 0x04000DE4 RID: 3556
		private static readonly Time.get_renderedFrameCountDelegate get_renderedFrameCountDelegateField;

		// Token: 0x04000DE5 RID: 3557
		private static readonly Time.get_realtimeSinceStartupAsDoubleDelegate get_realtimeSinceStartupAsDoubleDelegateField;

		// Token: 0x04000DE6 RID: 3558
		private static readonly Time.get_captureDeltaTimeDelegate get_captureDeltaTimeDelegateField;

		// Token: 0x04000DE7 RID: 3559
		private static readonly Time.set_captureDeltaTimeDelegate set_captureDeltaTimeDelegateField;

		// Token: 0x04000DE8 RID: 3560
		private static readonly Time.get_inFixedTimeStepDelegate get_inFixedTimeStepDelegateField;

		// Token: 0x02000824 RID: 2084
		// (Invoke) Token: 0x06002DF4 RID: 11764
		private delegate double get_timeAsDoubleDelegate();

		// Token: 0x02000825 RID: 2085
		// (Invoke) Token: 0x06002DF6 RID: 11766
		private delegate float get_timeSinceLevelLoadDelegate();

		// Token: 0x02000826 RID: 2086
		// (Invoke) Token: 0x06002DF8 RID: 11768
		private delegate double get_timeSinceLevelLoadAsDoubleDelegate();

		// Token: 0x02000827 RID: 2087
		// (Invoke) Token: 0x06002DFA RID: 11770
		private delegate float get_fixedTimeDelegate();

		// Token: 0x02000828 RID: 2088
		// (Invoke) Token: 0x06002DFC RID: 11772
		private delegate double get_fixedTimeAsDoubleDelegate();

		// Token: 0x02000829 RID: 2089
		// (Invoke) Token: 0x06002DFE RID: 11774
		private delegate double get_unscaledTimeAsDoubleDelegate();

		// Token: 0x0200082A RID: 2090
		// (Invoke) Token: 0x06002E00 RID: 11776
		private delegate float get_fixedUnscaledTimeDelegate();

		// Token: 0x0200082B RID: 2091
		// (Invoke) Token: 0x06002E02 RID: 11778
		private delegate double get_fixedUnscaledTimeAsDoubleDelegate();

		// Token: 0x0200082C RID: 2092
		// (Invoke) Token: 0x06002E04 RID: 11780
		private delegate float get_fixedUnscaledDeltaTimeDelegate();

		// Token: 0x0200082D RID: 2093
		// (Invoke) Token: 0x06002E06 RID: 11782
		private delegate void set_fixedDeltaTimeDelegate(float value);

		// Token: 0x0200082E RID: 2094
		// (Invoke) Token: 0x06002E08 RID: 11784
		private delegate float get_maximumDeltaTimeDelegate();

		// Token: 0x0200082F RID: 2095
		// (Invoke) Token: 0x06002E0A RID: 11786
		private delegate void set_maximumDeltaTimeDelegate(float value);

		// Token: 0x02000830 RID: 2096
		// (Invoke) Token: 0x06002E0C RID: 11788
		private delegate float get_smoothDeltaTimeDelegate();

		// Token: 0x02000831 RID: 2097
		// (Invoke) Token: 0x06002E0E RID: 11790
		private delegate float get_maximumParticleDeltaTimeDelegate();

		// Token: 0x02000832 RID: 2098
		// (Invoke) Token: 0x06002E10 RID: 11792
		private delegate void set_maximumParticleDeltaTimeDelegate(float value);

		// Token: 0x02000833 RID: 2099
		// (Invoke) Token: 0x06002E12 RID: 11794
		private delegate float get_timeScaleDelegate();

		// Token: 0x02000834 RID: 2100
		// (Invoke) Token: 0x06002E14 RID: 11796
		private delegate int get_frameCountDelegate();

		// Token: 0x02000835 RID: 2101
		// (Invoke) Token: 0x06002E16 RID: 11798
		private delegate int get_renderedFrameCountDelegate();

		// Token: 0x02000836 RID: 2102
		// (Invoke) Token: 0x06002E18 RID: 11800
		private delegate double get_realtimeSinceStartupAsDoubleDelegate();

		// Token: 0x02000837 RID: 2103
		// (Invoke) Token: 0x06002E1A RID: 11802
		private delegate float get_captureDeltaTimeDelegate();

		// Token: 0x02000838 RID: 2104
		// (Invoke) Token: 0x06002E1C RID: 11804
		private delegate void set_captureDeltaTimeDelegate(float value);

		// Token: 0x02000839 RID: 2105
		// (Invoke) Token: 0x06002E1E RID: 11806
		private delegate bool get_inFixedTimeStepDelegate();
	}
}
