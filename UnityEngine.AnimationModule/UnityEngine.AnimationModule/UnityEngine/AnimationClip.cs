using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000007 RID: 7
	public sealed class AnimationClip : Motion
	{
		// Token: 0x0600005E RID: 94 RVA: 0x00006810 File Offset: 0x00004A10
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationClip()
		{
			Il2CppClassPointerStore<AnimationClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimationClip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationClip>.NativeClassPtr);
			AnimationClip.Internal_CreateAnimationClipDelegateField = IL2CPP.ResolveICall<AnimationClip.Internal_CreateAnimationClipDelegate>("UnityEngine.AnimationClip::Internal_CreateAnimationClip");
			AnimationClip.SampleAnimationDelegateField = IL2CPP.ResolveICall<AnimationClip.SampleAnimationDelegate>("UnityEngine.AnimationClip::SampleAnimation");
			AnimationClip.get_lengthDelegateField = IL2CPP.ResolveICall<AnimationClip.get_lengthDelegate>("UnityEngine.AnimationClip::get_length");
			AnimationClip.get_startTimeDelegateField = IL2CPP.ResolveICall<AnimationClip.get_startTimeDelegate>("UnityEngine.AnimationClip::get_startTime");
			AnimationClip.get_stopTimeDelegateField = IL2CPP.ResolveICall<AnimationClip.get_stopTimeDelegate>("UnityEngine.AnimationClip::get_stopTime");
			AnimationClip.get_frameRateDelegateField = IL2CPP.ResolveICall<AnimationClip.get_frameRateDelegate>("UnityEngine.AnimationClip::get_frameRate");
			AnimationClip.set_frameRateDelegateField = IL2CPP.ResolveICall<AnimationClip.set_frameRateDelegate>("UnityEngine.AnimationClip::set_frameRate");
			AnimationClip.SetCurveDelegateField = IL2CPP.ResolveICall<AnimationClip.SetCurveDelegate>("UnityEngine.AnimationClip::SetCurve");
			AnimationClip.EnsureQuaternionContinuityDelegateField = IL2CPP.ResolveICall<AnimationClip.EnsureQuaternionContinuityDelegate>("UnityEngine.AnimationClip::EnsureQuaternionContinuity");
			AnimationClip.ClearCurvesDelegateField = IL2CPP.ResolveICall<AnimationClip.ClearCurvesDelegate>("UnityEngine.AnimationClip::ClearCurves");
			AnimationClip.get_wrapModeDelegateField = IL2CPP.ResolveICall<AnimationClip.get_wrapModeDelegate>("UnityEngine.AnimationClip::get_wrapMode");
			AnimationClip.set_wrapModeDelegateField = IL2CPP.ResolveICall<AnimationClip.set_wrapModeDelegate>("UnityEngine.AnimationClip::set_wrapMode");
			AnimationClip.get_legacyDelegateField = IL2CPP.ResolveICall<AnimationClip.get_legacyDelegate>("UnityEngine.AnimationClip::get_legacy");
			AnimationClip.set_legacyDelegateField = IL2CPP.ResolveICall<AnimationClip.set_legacyDelegate>("UnityEngine.AnimationClip::set_legacy");
			AnimationClip.get_humanMotionDelegateField = IL2CPP.ResolveICall<AnimationClip.get_humanMotionDelegate>("UnityEngine.AnimationClip::get_humanMotion");
			AnimationClip.get_emptyDelegateField = IL2CPP.ResolveICall<AnimationClip.get_emptyDelegate>("UnityEngine.AnimationClip::get_empty");
			AnimationClip.get_hasGenericRootTransformDelegateField = IL2CPP.ResolveICall<AnimationClip.get_hasGenericRootTransformDelegate>("UnityEngine.AnimationClip::get_hasGenericRootTransform");
			AnimationClip.get_hasMotionFloatCurvesDelegateField = IL2CPP.ResolveICall<AnimationClip.get_hasMotionFloatCurvesDelegate>("UnityEngine.AnimationClip::get_hasMotionFloatCurves");
			AnimationClip.get_hasMotionCurvesDelegateField = IL2CPP.ResolveICall<AnimationClip.get_hasMotionCurvesDelegate>("UnityEngine.AnimationClip::get_hasMotionCurves");
			AnimationClip.get_hasRootCurvesDelegateField = IL2CPP.ResolveICall<AnimationClip.get_hasRootCurvesDelegate>("UnityEngine.AnimationClip::get_hasRootCurves");
			AnimationClip.get_hasRootMotionDelegateField = IL2CPP.ResolveICall<AnimationClip.get_hasRootMotionDelegate>("UnityEngine.AnimationClip::get_hasRootMotion");
			AnimationClip.AddEventInternalDelegateField = IL2CPP.ResolveICall<AnimationClip.AddEventInternalDelegate>("UnityEngine.AnimationClip::AddEventInternal");
			AnimationClip.SetEventsInternalDelegateField = IL2CPP.ResolveICall<AnimationClip.SetEventsInternalDelegate>("UnityEngine.AnimationClip::SetEventsInternal");
			AnimationClip.GetEventsInternalDelegateField = IL2CPP.ResolveICall<AnimationClip.GetEventsInternalDelegate>("UnityEngine.AnimationClip::GetEventsInternal");
			AnimationClip.get_localBounds_InjectedDelegateField = IL2CPP.ResolveICall<AnimationClip.get_localBounds_InjectedDelegate>("UnityEngine.AnimationClip::get_localBounds_Injected");
			AnimationClip.set_localBounds_InjectedDelegateField = IL2CPP.ResolveICall<AnimationClip.set_localBounds_InjectedDelegate>("UnityEngine.AnimationClip::set_localBounds_Injected");
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000023D6 File Offset: 0x000005D6
		public AnimationClip(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000023DF File Offset: 0x000005DF
		public static void Internal_CreateAnimationClip(AnimationClip self)
		{
			AnimationClip.Internal_CreateAnimationClipDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000023F1 File Offset: 0x000005F1
		public void SampleAnimation(GameObject go, float time)
		{
			AnimationClip.SampleAnimation(go, this, time, this.wrapMode);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002403 File Offset: 0x00000603
		public static void SampleAnimation(GameObject go, AnimationClip clip, float inTime, WrapMode wrapMode)
		{
			AnimationClip.SampleAnimationDelegateField(IL2CPP.Il2CppObjectBaseToPtr(go), IL2CPP.Il2CppObjectBaseToPtr(clip), inTime, wrapMode);
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0000241D File Offset: 0x0000061D
		public float length
		{
			get
			{
				return AnimationClip.get_lengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0000242F File Offset: 0x0000062F
		public float startTime
		{
			get
			{
				return AnimationClip.get_startTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002441 File Offset: 0x00000641
		public float stopTime
		{
			get
			{
				return AnimationClip.get_stopTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00002453 File Offset: 0x00000653
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00002465 File Offset: 0x00000665
		public float frameRate
		{
			get
			{
				return AnimationClip.get_frameRateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationClip.set_frameRateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002478 File Offset: 0x00000678
		public void SetCurve(string relativePath, Type type, string propertyName, AnimationCurve curve)
		{
			AnimationClip.SetCurveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(relativePath), IL2CPP.Il2CppObjectBaseToPtr(type), IL2CPP.ManagedStringToIl2Cpp(propertyName), IL2CPP.Il2CppObjectBaseToPtr(curve));
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000024A3 File Offset: 0x000006A3
		public void EnsureQuaternionContinuity()
		{
			AnimationClip.EnsureQuaternionContinuityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000024B5 File Offset: 0x000006B5
		public void ClearCurves()
		{
			AnimationClip.ClearCurvesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600006B RID: 107 RVA: 0x000024C7 File Offset: 0x000006C7
		// (set) Token: 0x0600006C RID: 108 RVA: 0x000024D9 File Offset: 0x000006D9
		public WrapMode wrapMode
		{
			get
			{
				return AnimationClip.get_wrapModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationClip.set_wrapModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600006D RID: 109 RVA: 0x000069C8 File Offset: 0x00004BC8
		// (set) Token: 0x0600006E RID: 110 RVA: 0x000024EC File Offset: 0x000006EC
		public Bounds localBounds
		{
			get
			{
				Bounds bounds;
				this.get_localBounds_Injected(out bounds);
				return bounds;
			}
			set
			{
				this.set_localBounds_Injected(ref value);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000024F6 File Offset: 0x000006F6
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00002508 File Offset: 0x00000708
		public new bool legacy
		{
			get
			{
				return AnimationClip.get_legacyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationClip.set_legacyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000071 RID: 113 RVA: 0x0000251B File Offset: 0x0000071B
		public bool humanMotion
		{
			get
			{
				return AnimationClip.get_humanMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0000252D File Offset: 0x0000072D
		public bool empty
		{
			get
			{
				return AnimationClip.get_emptyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000073 RID: 115 RVA: 0x0000253F File Offset: 0x0000073F
		public bool hasGenericRootTransform
		{
			get
			{
				return AnimationClip.get_hasGenericRootTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00002551 File Offset: 0x00000751
		public bool hasMotionFloatCurves
		{
			get
			{
				return AnimationClip.get_hasMotionFloatCurvesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00002563 File Offset: 0x00000763
		public bool hasMotionCurves
		{
			get
			{
				return AnimationClip.get_hasMotionCurvesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002575 File Offset: 0x00000775
		public bool hasRootCurves
		{
			get
			{
				return AnimationClip.get_hasRootCurvesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002587 File Offset: 0x00000787
		public bool hasRootMotion
		{
			get
			{
				return AnimationClip.get_hasRootMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000069E0 File Offset: 0x00004BE0
		public void AddEvent(AnimationEvent evt)
		{
			bool flag = evt == null;
			if (flag)
			{
				throw new ArgumentNullException("evt");
			}
			this.AddEventInternal(evt);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002599 File Offset: 0x00000799
		public void AddEventInternal(Object evt)
		{
			AnimationClip.AddEventInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(evt));
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00006A0C File Offset: 0x00004C0C
		// (set) Token: 0x0600007B RID: 123 RVA: 0x000025B1 File Offset: 0x000007B1
		public Il2CppReferenceArray<AnimationEvent> events
		{
			get
			{
				return this.GetEventsInternal().Cast<Il2CppReferenceArray<AnimationEvent>>();
			}
			set
			{
				this.SetEventsInternal(value);
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000025BC File Offset: 0x000007BC
		public void SetEventsInternal(Array value)
		{
			AnimationClip.SetEventsInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00006A2C File Offset: 0x00004C2C
		public Array GetEventsInternal()
		{
			IntPtr intPtr = AnimationClip.GetEventsInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Array>(intPtr2) : null;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000025D4 File Offset: 0x000007D4
		public void get_localBounds_Injected(out Bounds ret)
		{
			AnimationClip.get_localBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000025E7 File Offset: 0x000007E7
		public void set_localBounds_Injected(ref Bounds value)
		{
			AnimationClip.set_localBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000038 RID: 56
		private static readonly AnimationClip.Internal_CreateAnimationClipDelegate Internal_CreateAnimationClipDelegateField;

		// Token: 0x04000039 RID: 57
		private static readonly AnimationClip.SampleAnimationDelegate SampleAnimationDelegateField;

		// Token: 0x0400003A RID: 58
		private static readonly AnimationClip.get_lengthDelegate get_lengthDelegateField;

		// Token: 0x0400003B RID: 59
		private static readonly AnimationClip.get_startTimeDelegate get_startTimeDelegateField;

		// Token: 0x0400003C RID: 60
		private static readonly AnimationClip.get_stopTimeDelegate get_stopTimeDelegateField;

		// Token: 0x0400003D RID: 61
		private static readonly AnimationClip.get_frameRateDelegate get_frameRateDelegateField;

		// Token: 0x0400003E RID: 62
		private static readonly AnimationClip.set_frameRateDelegate set_frameRateDelegateField;

		// Token: 0x0400003F RID: 63
		private static readonly AnimationClip.SetCurveDelegate SetCurveDelegateField;

		// Token: 0x04000040 RID: 64
		private static readonly AnimationClip.EnsureQuaternionContinuityDelegate EnsureQuaternionContinuityDelegateField;

		// Token: 0x04000041 RID: 65
		private static readonly AnimationClip.ClearCurvesDelegate ClearCurvesDelegateField;

		// Token: 0x04000042 RID: 66
		private static readonly AnimationClip.get_wrapModeDelegate get_wrapModeDelegateField;

		// Token: 0x04000043 RID: 67
		private static readonly AnimationClip.set_wrapModeDelegate set_wrapModeDelegateField;

		// Token: 0x04000044 RID: 68
		private static readonly AnimationClip.get_legacyDelegate get_legacyDelegateField;

		// Token: 0x04000045 RID: 69
		private static readonly AnimationClip.set_legacyDelegate set_legacyDelegateField;

		// Token: 0x04000046 RID: 70
		private static readonly AnimationClip.get_humanMotionDelegate get_humanMotionDelegateField;

		// Token: 0x04000047 RID: 71
		private static readonly AnimationClip.get_emptyDelegate get_emptyDelegateField;

		// Token: 0x04000048 RID: 72
		private static readonly AnimationClip.get_hasGenericRootTransformDelegate get_hasGenericRootTransformDelegateField;

		// Token: 0x04000049 RID: 73
		private static readonly AnimationClip.get_hasMotionFloatCurvesDelegate get_hasMotionFloatCurvesDelegateField;

		// Token: 0x0400004A RID: 74
		private static readonly AnimationClip.get_hasMotionCurvesDelegate get_hasMotionCurvesDelegateField;

		// Token: 0x0400004B RID: 75
		private static readonly AnimationClip.get_hasRootCurvesDelegate get_hasRootCurvesDelegateField;

		// Token: 0x0400004C RID: 76
		private static readonly AnimationClip.get_hasRootMotionDelegate get_hasRootMotionDelegateField;

		// Token: 0x0400004D RID: 77
		private static readonly AnimationClip.AddEventInternalDelegate AddEventInternalDelegateField;

		// Token: 0x0400004E RID: 78
		private static readonly AnimationClip.SetEventsInternalDelegate SetEventsInternalDelegateField;

		// Token: 0x0400004F RID: 79
		private static readonly AnimationClip.GetEventsInternalDelegate GetEventsInternalDelegateField;

		// Token: 0x04000050 RID: 80
		private static readonly AnimationClip.get_localBounds_InjectedDelegate get_localBounds_InjectedDelegateField;

		// Token: 0x04000051 RID: 81
		private static readonly AnimationClip.set_localBounds_InjectedDelegate set_localBounds_InjectedDelegateField;

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x0600058D RID: 1421
		private delegate void Internal_CreateAnimationClipDelegate(IntPtr self);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x0600058F RID: 1423
		private delegate void SampleAnimationDelegate(IntPtr go, IntPtr clip, float inTime, WrapMode wrapMode);

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x06000591 RID: 1425
		private delegate float get_lengthDelegate(IntPtr @this);

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x06000593 RID: 1427
		private delegate float get_startTimeDelegate(IntPtr @this);

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x06000595 RID: 1429
		private delegate float get_stopTimeDelegate(IntPtr @this);

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x06000597 RID: 1431
		private delegate float get_frameRateDelegate(IntPtr @this);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x06000599 RID: 1433
		private delegate void set_frameRateDelegate(IntPtr @this, float value);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x0600059B RID: 1435
		private delegate void SetCurveDelegate(IntPtr @this, IntPtr relativePath, IntPtr type, IntPtr propertyName, IntPtr curve);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x0600059D RID: 1437
		private delegate void EnsureQuaternionContinuityDelegate(IntPtr @this);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x0600059F RID: 1439
		private delegate void ClearCurvesDelegate(IntPtr @this);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x060005A1 RID: 1441
		private delegate WrapMode get_wrapModeDelegate(IntPtr @this);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x060005A3 RID: 1443
		private delegate void set_wrapModeDelegate(IntPtr @this, WrapMode value);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x060005A5 RID: 1445
		private delegate bool get_legacyDelegate(IntPtr @this);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x060005A7 RID: 1447
		private delegate void set_legacyDelegate(IntPtr @this, bool value);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x060005A9 RID: 1449
		private delegate bool get_humanMotionDelegate(IntPtr @this);

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x060005AB RID: 1451
		private delegate bool get_emptyDelegate(IntPtr @this);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x060005AD RID: 1453
		private delegate bool get_hasGenericRootTransformDelegate(IntPtr @this);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x060005AF RID: 1455
		private delegate bool get_hasMotionFloatCurvesDelegate(IntPtr @this);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x060005B1 RID: 1457
		private delegate bool get_hasMotionCurvesDelegate(IntPtr @this);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x060005B3 RID: 1459
		private delegate bool get_hasRootCurvesDelegate(IntPtr @this);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x060005B5 RID: 1461
		private delegate bool get_hasRootMotionDelegate(IntPtr @this);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x060005B7 RID: 1463
		private delegate void AddEventInternalDelegate(IntPtr @this, IntPtr evt);

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x060005B9 RID: 1465
		private delegate void SetEventsInternalDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x060005BB RID: 1467
		private delegate IntPtr GetEventsInternalDelegate(IntPtr @this);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x060005BD RID: 1469
		private delegate void get_localBounds_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x060005BF RID: 1471
		private delegate void set_localBounds_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
