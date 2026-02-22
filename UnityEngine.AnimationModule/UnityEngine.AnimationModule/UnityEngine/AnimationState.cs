using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	public sealed class AnimationState : TrackedReference
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00006144 File Offset: 0x00004344
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationState()
		{
			Il2CppClassPointerStore<AnimationState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimationState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationState>.NativeClassPtr);
			AnimationState.get_enabledDelegateField = IL2CPP.ResolveICall<AnimationState.get_enabledDelegate>("UnityEngine.AnimationState::get_enabled");
			AnimationState.set_enabledDelegateField = IL2CPP.ResolveICall<AnimationState.set_enabledDelegate>("UnityEngine.AnimationState::set_enabled");
			AnimationState.get_weightDelegateField = IL2CPP.ResolveICall<AnimationState.get_weightDelegate>("UnityEngine.AnimationState::get_weight");
			AnimationState.set_weightDelegateField = IL2CPP.ResolveICall<AnimationState.set_weightDelegate>("UnityEngine.AnimationState::set_weight");
			AnimationState.get_wrapModeDelegateField = IL2CPP.ResolveICall<AnimationState.get_wrapModeDelegate>("UnityEngine.AnimationState::get_wrapMode");
			AnimationState.set_wrapModeDelegateField = IL2CPP.ResolveICall<AnimationState.set_wrapModeDelegate>("UnityEngine.AnimationState::set_wrapMode");
			AnimationState.get_timeDelegateField = IL2CPP.ResolveICall<AnimationState.get_timeDelegate>("UnityEngine.AnimationState::get_time");
			AnimationState.set_timeDelegateField = IL2CPP.ResolveICall<AnimationState.set_timeDelegate>("UnityEngine.AnimationState::set_time");
			AnimationState.get_normalizedTimeDelegateField = IL2CPP.ResolveICall<AnimationState.get_normalizedTimeDelegate>("UnityEngine.AnimationState::get_normalizedTime");
			AnimationState.set_normalizedTimeDelegateField = IL2CPP.ResolveICall<AnimationState.set_normalizedTimeDelegate>("UnityEngine.AnimationState::set_normalizedTime");
			AnimationState.get_speedDelegateField = IL2CPP.ResolveICall<AnimationState.get_speedDelegate>("UnityEngine.AnimationState::get_speed");
			AnimationState.set_speedDelegateField = IL2CPP.ResolveICall<AnimationState.set_speedDelegate>("UnityEngine.AnimationState::set_speed");
			AnimationState.get_normalizedSpeedDelegateField = IL2CPP.ResolveICall<AnimationState.get_normalizedSpeedDelegate>("UnityEngine.AnimationState::get_normalizedSpeed");
			AnimationState.set_normalizedSpeedDelegateField = IL2CPP.ResolveICall<AnimationState.set_normalizedSpeedDelegate>("UnityEngine.AnimationState::set_normalizedSpeed");
			AnimationState.get_lengthDelegateField = IL2CPP.ResolveICall<AnimationState.get_lengthDelegate>("UnityEngine.AnimationState::get_length");
			AnimationState.get_layerDelegateField = IL2CPP.ResolveICall<AnimationState.get_layerDelegate>("UnityEngine.AnimationState::get_layer");
			AnimationState.set_layerDelegateField = IL2CPP.ResolveICall<AnimationState.set_layerDelegate>("UnityEngine.AnimationState::set_layer");
			AnimationState.get_clipDelegateField = IL2CPP.ResolveICall<AnimationState.get_clipDelegate>("UnityEngine.AnimationState::get_clip");
			AnimationState.get_nameDelegateField = IL2CPP.ResolveICall<AnimationState.get_nameDelegate>("UnityEngine.AnimationState::get_name");
			AnimationState.set_nameDelegateField = IL2CPP.ResolveICall<AnimationState.set_nameDelegate>("UnityEngine.AnimationState::set_name");
			AnimationState.get_blendModeDelegateField = IL2CPP.ResolveICall<AnimationState.get_blendModeDelegate>("UnityEngine.AnimationState::get_blendMode");
			AnimationState.set_blendModeDelegateField = IL2CPP.ResolveICall<AnimationState.set_blendModeDelegate>("UnityEngine.AnimationState::set_blendMode");
			AnimationState.AddMixingTransformDelegateField = IL2CPP.ResolveICall<AnimationState.AddMixingTransformDelegate>("UnityEngine.AnimationState::AddMixingTransform");
			AnimationState.RemoveMixingTransformDelegateField = IL2CPP.ResolveICall<AnimationState.RemoveMixingTransformDelegate>("UnityEngine.AnimationState::RemoveMixingTransform");
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002087 File Offset: 0x00000287
		public AnimationState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002090 File Offset: 0x00000290
		// (set) Token: 0x06000017 RID: 23 RVA: 0x000020A2 File Offset: 0x000002A2
		public bool enabled
		{
			get
			{
				return AnimationState.get_enabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_enabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000020B5 File Offset: 0x000002B5
		// (set) Token: 0x06000019 RID: 25 RVA: 0x000020C7 File Offset: 0x000002C7
		public float weight
		{
			get
			{
				return AnimationState.get_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000020DA File Offset: 0x000002DA
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000020EC File Offset: 0x000002EC
		public WrapMode wrapMode
		{
			get
			{
				return AnimationState.get_wrapModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_wrapModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000020FF File Offset: 0x000002FF
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002111 File Offset: 0x00000311
		public float time
		{
			get
			{
				return AnimationState.get_timeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_timeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002124 File Offset: 0x00000324
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002136 File Offset: 0x00000336
		public float normalizedTime
		{
			get
			{
				return AnimationState.get_normalizedTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_normalizedTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002149 File Offset: 0x00000349
		// (set) Token: 0x06000021 RID: 33 RVA: 0x0000215B File Offset: 0x0000035B
		public float speed
		{
			get
			{
				return AnimationState.get_speedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_speedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000022 RID: 34 RVA: 0x0000216E File Offset: 0x0000036E
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002180 File Offset: 0x00000380
		public float normalizedSpeed
		{
			get
			{
				return AnimationState.get_normalizedSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_normalizedSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002193 File Offset: 0x00000393
		public float length
		{
			get
			{
				return AnimationState.get_lengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000021A5 File Offset: 0x000003A5
		// (set) Token: 0x06000026 RID: 38 RVA: 0x000021B7 File Offset: 0x000003B7
		public int layer
		{
			get
			{
				return AnimationState.get_layerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_layerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000062DC File Offset: 0x000044DC
		public AnimationClip clip
		{
			get
			{
				IntPtr intPtr = AnimationState.get_clipDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00006308 File Offset: 0x00004508
		// (set) Token: 0x06000029 RID: 41 RVA: 0x000021CA File Offset: 0x000003CA
		public string name
		{
			get
			{
				IntPtr intPtr = AnimationState.get_nameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				AnimationState.set_nameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000021E2 File Offset: 0x000003E2
		// (set) Token: 0x0600002B RID: 43 RVA: 0x000021F4 File Offset: 0x000003F4
		public AnimationBlendMode blendMode
		{
			get
			{
				return AnimationState.get_blendModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_blendModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002207 File Offset: 0x00000407
		public void AddMixingTransform(Transform mix)
		{
			this.AddMixingTransform(mix, true);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002213 File Offset: 0x00000413
		public void AddMixingTransform(Transform mix, bool recursive)
		{
			AnimationState.AddMixingTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mix), recursive);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000222C File Offset: 0x0000042C
		public void RemoveMixingTransform(Transform mix)
		{
			AnimationState.RemoveMixingTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mix));
		}

		// Token: 0x04000014 RID: 20
		private static readonly AnimationState.get_enabledDelegate get_enabledDelegateField;

		// Token: 0x04000015 RID: 21
		private static readonly AnimationState.set_enabledDelegate set_enabledDelegateField;

		// Token: 0x04000016 RID: 22
		private static readonly AnimationState.get_weightDelegate get_weightDelegateField;

		// Token: 0x04000017 RID: 23
		private static readonly AnimationState.set_weightDelegate set_weightDelegateField;

		// Token: 0x04000018 RID: 24
		private static readonly AnimationState.get_wrapModeDelegate get_wrapModeDelegateField;

		// Token: 0x04000019 RID: 25
		private static readonly AnimationState.set_wrapModeDelegate set_wrapModeDelegateField;

		// Token: 0x0400001A RID: 26
		private static readonly AnimationState.get_timeDelegate get_timeDelegateField;

		// Token: 0x0400001B RID: 27
		private static readonly AnimationState.set_timeDelegate set_timeDelegateField;

		// Token: 0x0400001C RID: 28
		private static readonly AnimationState.get_normalizedTimeDelegate get_normalizedTimeDelegateField;

		// Token: 0x0400001D RID: 29
		private static readonly AnimationState.set_normalizedTimeDelegate set_normalizedTimeDelegateField;

		// Token: 0x0400001E RID: 30
		private static readonly AnimationState.get_speedDelegate get_speedDelegateField;

		// Token: 0x0400001F RID: 31
		private static readonly AnimationState.set_speedDelegate set_speedDelegateField;

		// Token: 0x04000020 RID: 32
		private static readonly AnimationState.get_normalizedSpeedDelegate get_normalizedSpeedDelegateField;

		// Token: 0x04000021 RID: 33
		private static readonly AnimationState.set_normalizedSpeedDelegate set_normalizedSpeedDelegateField;

		// Token: 0x04000022 RID: 34
		private static readonly AnimationState.get_lengthDelegate get_lengthDelegateField;

		// Token: 0x04000023 RID: 35
		private static readonly AnimationState.get_layerDelegate get_layerDelegateField;

		// Token: 0x04000024 RID: 36
		private static readonly AnimationState.set_layerDelegate set_layerDelegateField;

		// Token: 0x04000025 RID: 37
		private static readonly AnimationState.get_clipDelegate get_clipDelegateField;

		// Token: 0x04000026 RID: 38
		private static readonly AnimationState.get_nameDelegate get_nameDelegateField;

		// Token: 0x04000027 RID: 39
		private static readonly AnimationState.set_nameDelegate set_nameDelegateField;

		// Token: 0x04000028 RID: 40
		private static readonly AnimationState.get_blendModeDelegate get_blendModeDelegateField;

		// Token: 0x04000029 RID: 41
		private static readonly AnimationState.set_blendModeDelegate set_blendModeDelegateField;

		// Token: 0x0400002A RID: 42
		private static readonly AnimationState.AddMixingTransformDelegate AddMixingTransformDelegateField;

		// Token: 0x0400002B RID: 43
		private static readonly AnimationState.RemoveMixingTransformDelegate RemoveMixingTransformDelegateField;

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x0600055D RID: 1373
		private delegate bool get_enabledDelegate(IntPtr @this);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x0600055F RID: 1375
		private delegate void set_enabledDelegate(IntPtr @this, bool value);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x06000561 RID: 1377
		private delegate float get_weightDelegate(IntPtr @this);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x06000563 RID: 1379
		private delegate void set_weightDelegate(IntPtr @this, float value);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x06000565 RID: 1381
		private delegate WrapMode get_wrapModeDelegate(IntPtr @this);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x06000567 RID: 1383
		private delegate void set_wrapModeDelegate(IntPtr @this, WrapMode value);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x06000569 RID: 1385
		private delegate float get_timeDelegate(IntPtr @this);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x0600056B RID: 1387
		private delegate void set_timeDelegate(IntPtr @this, float value);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x0600056D RID: 1389
		private delegate float get_normalizedTimeDelegate(IntPtr @this);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x0600056F RID: 1391
		private delegate void set_normalizedTimeDelegate(IntPtr @this, float value);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x06000571 RID: 1393
		private delegate float get_speedDelegate(IntPtr @this);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x06000573 RID: 1395
		private delegate void set_speedDelegate(IntPtr @this, float value);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x06000575 RID: 1397
		private delegate float get_normalizedSpeedDelegate(IntPtr @this);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x06000577 RID: 1399
		private delegate void set_normalizedSpeedDelegate(IntPtr @this, float value);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x06000579 RID: 1401
		private delegate float get_lengthDelegate(IntPtr @this);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x0600057B RID: 1403
		private delegate int get_layerDelegate(IntPtr @this);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x0600057D RID: 1405
		private delegate void set_layerDelegate(IntPtr @this, int value);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x0600057F RID: 1407
		private delegate IntPtr get_clipDelegate(IntPtr @this);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x06000581 RID: 1409
		private delegate IntPtr get_nameDelegate(IntPtr @this);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x06000583 RID: 1411
		private delegate void set_nameDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x06000585 RID: 1413
		private delegate AnimationBlendMode get_blendModeDelegate(IntPtr @this);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x06000587 RID: 1415
		private delegate void set_blendModeDelegate(IntPtr @this, AnimationBlendMode value);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x06000589 RID: 1417
		private delegate void AddMixingTransformDelegate(IntPtr @this, IntPtr mix, bool recursive);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x0600058B RID: 1419
		private delegate void RemoveMixingTransformDelegate(IntPtr @this, IntPtr mix);
	}
}
