using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations
{
	// Token: 0x0200001F RID: 31
	[StructLayout(2)]
	public struct AnimationStream
	{
		// Token: 0x06000332 RID: 818 RVA: 0x0000AF48 File Offset: 0x00009148
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationStream()
		{
			Il2CppClassPointerStore<AnimationStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr);
			AnimationStream.NativeFieldInfoPtr_m_AnimatorBindingsVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "m_AnimatorBindingsVersion");
			AnimationStream.NativeFieldInfoPtr_constant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "constant");
			AnimationStream.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "input");
			AnimationStream.NativeFieldInfoPtr_output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "output");
			AnimationStream.NativeFieldInfoPtr_workspace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "workspace");
			AnimationStream.NativeFieldInfoPtr_inputStreamAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "inputStreamAccessor");
			AnimationStream.NativeFieldInfoPtr_animationHandleBinder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "animationHandleBinder");
			AnimationStream.CopyAnimationStreamMotionInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.CopyAnimationStreamMotionInternal_InjectedDelegate>("UnityEngine.Animations.AnimationStream::CopyAnimationStreamMotionInternal_Injected");
			AnimationStream.GetDeltaTime_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.GetDeltaTime_InjectedDelegate>("UnityEngine.Animations.AnimationStream::GetDeltaTime_Injected");
			AnimationStream.GetIsHumanStream_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.GetIsHumanStream_InjectedDelegate>("UnityEngine.Animations.AnimationStream::GetIsHumanStream_Injected");
			AnimationStream.GetVelocity_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.GetVelocity_InjectedDelegate>("UnityEngine.Animations.AnimationStream::GetVelocity_Injected");
			AnimationStream.SetVelocity_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.SetVelocity_InjectedDelegate>("UnityEngine.Animations.AnimationStream::SetVelocity_Injected");
			AnimationStream.GetAngularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.GetAngularVelocity_InjectedDelegate>("UnityEngine.Animations.AnimationStream::GetAngularVelocity_Injected");
			AnimationStream.SetAngularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.SetAngularVelocity_InjectedDelegate>("UnityEngine.Animations.AnimationStream::SetAngularVelocity_Injected");
			AnimationStream.GetRootMotionPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.GetRootMotionPosition_InjectedDelegate>("UnityEngine.Animations.AnimationStream::GetRootMotionPosition_Injected");
			AnimationStream.GetRootMotionRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.GetRootMotionRotation_InjectedDelegate>("UnityEngine.Animations.AnimationStream::GetRootMotionRotation_Injected");
			AnimationStream.GetInputStreamCount_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.GetInputStreamCount_InjectedDelegate>("UnityEngine.Animations.AnimationStream::GetInputStreamCount_Injected");
			AnimationStream.InternalGetInputStream_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.InternalGetInputStream_InjectedDelegate>("UnityEngine.Animations.AnimationStream::InternalGetInputStream_Injected");
			AnimationStream.InternalGetInputWeight_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.InternalGetInputWeight_InjectedDelegate>("UnityEngine.Animations.AnimationStream::InternalGetInputWeight_Injected");
			AnimationStream.GetHumanStream_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.GetHumanStream_InjectedDelegate>("UnityEngine.Animations.AnimationStream::GetHumanStream_Injected");
			AnimationStream.InternalReadSceneTransforms_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.InternalReadSceneTransforms_InjectedDelegate>("UnityEngine.Animations.AnimationStream::InternalReadSceneTransforms_Injected");
			AnimationStream.InternalWriteSceneTransforms_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.InternalWriteSceneTransforms_InjectedDelegate>("UnityEngine.Animations.AnimationStream::InternalWriteSceneTransforms_Injected");
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00003E92 File Offset: 0x00002092
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, ref this));
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0000B0E8 File Offset: 0x000092E8
		public uint animatorBindingsVersion
		{
			get
			{
				return this.m_AnimatorBindingsVersion;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000335 RID: 821 RVA: 0x0000B100 File Offset: 0x00009300
		public bool isValid
		{
			get
			{
				return this.m_AnimatorBindingsVersion >= 2U && this.constant != IntPtr.Zero && this.input != IntPtr.Zero && this.output != IntPtr.Zero && this.workspace != IntPtr.Zero && this.animationHandleBinder != IntPtr.Zero;
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000B178 File Offset: 0x00009378
		public void CheckIsValid()
		{
			bool flag = !this.isValid;
			if (flag)
			{
				throw new InvalidOperationException("The AnimationStream is invalid.");
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000337 RID: 823 RVA: 0x0000B1A0 File Offset: 0x000093A0
		public float deltaTime
		{
			get
			{
				this.CheckIsValid();
				return this.GetDeltaTime();
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0000B1C0 File Offset: 0x000093C0
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00003EA4 File Offset: 0x000020A4
		public Vector3 velocity
		{
			get
			{
				this.CheckIsValid();
				return this.GetVelocity();
			}
			set
			{
				this.CheckIsValid();
				this.SetVelocity(value);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0000B1E0 File Offset: 0x000093E0
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00003EB6 File Offset: 0x000020B6
		public Vector3 angularVelocity
		{
			get
			{
				this.CheckIsValid();
				return this.GetAngularVelocity();
			}
			set
			{
				this.CheckIsValid();
				this.SetAngularVelocity(value);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600033C RID: 828 RVA: 0x0000B200 File Offset: 0x00009400
		public Vector3 rootMotionPosition
		{
			get
			{
				this.CheckIsValid();
				return this.GetRootMotionPosition();
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600033D RID: 829 RVA: 0x0000B220 File Offset: 0x00009420
		public Quaternion rootMotionRotation
		{
			get
			{
				this.CheckIsValid();
				return this.GetRootMotionRotation();
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0000B240 File Offset: 0x00009440
		public bool isHumanStream
		{
			get
			{
				this.CheckIsValid();
				return this.GetIsHumanStream();
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000B260 File Offset: 0x00009460
		public AnimationHumanStream AsHuman()
		{
			this.CheckIsValid();
			bool flag = !this.GetIsHumanStream();
			if (flag)
			{
				throw new InvalidOperationException("Cannot create an AnimationHumanStream for a generic rig.");
			}
			return this.GetHumanStream();
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0000B298 File Offset: 0x00009498
		public int inputStreamCount
		{
			get
			{
				this.CheckIsValid();
				return this.GetInputStreamCount();
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000B2B8 File Offset: 0x000094B8
		public AnimationStream GetInputStream(int index)
		{
			this.CheckIsValid();
			return this.InternalGetInputStream(index);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000B2D8 File Offset: 0x000094D8
		public float GetInputWeight(int index)
		{
			this.CheckIsValid();
			return this.InternalGetInputWeight(index);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00003EC8 File Offset: 0x000020C8
		public void CopyAnimationStreamMotion(AnimationStream animationStream)
		{
			this.CheckIsValid();
			animationStream.CheckIsValid();
			this.CopyAnimationStreamMotionInternal(animationStream);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00003EE2 File Offset: 0x000020E2
		public void ReadSceneTransforms()
		{
			this.CheckIsValid();
			this.InternalReadSceneTransforms();
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00003EF3 File Offset: 0x000020F3
		public void WriteSceneTransforms()
		{
			this.CheckIsValid();
			this.InternalWriteSceneTransforms();
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00003F04 File Offset: 0x00002104
		public void CopyAnimationStreamMotionInternal(AnimationStream animationStream)
		{
			AnimationStream.CopyAnimationStreamMotionInternal_Injected(ref this, ref animationStream);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00003F0E File Offset: 0x0000210E
		public float GetDeltaTime()
		{
			return AnimationStream.GetDeltaTime_Injected(ref this);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00003F16 File Offset: 0x00002116
		public bool GetIsHumanStream()
		{
			return AnimationStream.GetIsHumanStream_Injected(ref this);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000B2F8 File Offset: 0x000094F8
		public Vector3 GetVelocity()
		{
			Vector3 vector;
			AnimationStream.GetVelocity_Injected(ref this, out vector);
			return vector;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00003F1E File Offset: 0x0000211E
		public void SetVelocity(Vector3 velocity)
		{
			AnimationStream.SetVelocity_Injected(ref this, ref velocity);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000B310 File Offset: 0x00009510
		public Vector3 GetAngularVelocity()
		{
			Vector3 vector;
			AnimationStream.GetAngularVelocity_Injected(ref this, out vector);
			return vector;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00003F28 File Offset: 0x00002128
		public void SetAngularVelocity(Vector3 velocity)
		{
			AnimationStream.SetAngularVelocity_Injected(ref this, ref velocity);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000B328 File Offset: 0x00009528
		public Vector3 GetRootMotionPosition()
		{
			Vector3 vector;
			AnimationStream.GetRootMotionPosition_Injected(ref this, out vector);
			return vector;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000B340 File Offset: 0x00009540
		public Quaternion GetRootMotionRotation()
		{
			Quaternion quaternion;
			AnimationStream.GetRootMotionRotation_Injected(ref this, out quaternion);
			return quaternion;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00003F32 File Offset: 0x00002132
		public int GetInputStreamCount()
		{
			return AnimationStream.GetInputStreamCount_Injected(ref this);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000B358 File Offset: 0x00009558
		public AnimationStream InternalGetInputStream(int index)
		{
			AnimationStream animationStream;
			AnimationStream.InternalGetInputStream_Injected(ref this, index, out animationStream);
			return animationStream;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00003F3A File Offset: 0x0000213A
		public float InternalGetInputWeight(int index)
		{
			return AnimationStream.InternalGetInputWeight_Injected(ref this, index);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000B370 File Offset: 0x00009570
		public AnimationHumanStream GetHumanStream()
		{
			AnimationHumanStream animationHumanStream;
			AnimationStream.GetHumanStream_Injected(ref this, out animationHumanStream);
			return animationHumanStream;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00003F43 File Offset: 0x00002143
		public void InternalReadSceneTransforms()
		{
			AnimationStream.InternalReadSceneTransforms_Injected(ref this);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00003F4B File Offset: 0x0000214B
		public void InternalWriteSceneTransforms()
		{
			AnimationStream.InternalWriteSceneTransforms_Injected(ref this);
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00003F53 File Offset: 0x00002153
		public static void CopyAnimationStreamMotionInternal_Injected(ref AnimationStream _unity_self, ref AnimationStream animationStream)
		{
			AnimationStream.CopyAnimationStreamMotionInternal_InjectedDelegateField(ref _unity_self, ref animationStream);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00003F61 File Offset: 0x00002161
		public static float GetDeltaTime_Injected(ref AnimationStream _unity_self)
		{
			return AnimationStream.GetDeltaTime_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00003F6E File Offset: 0x0000216E
		public static bool GetIsHumanStream_Injected(ref AnimationStream _unity_self)
		{
			return AnimationStream.GetIsHumanStream_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00003F7B File Offset: 0x0000217B
		public static void GetVelocity_Injected(ref AnimationStream _unity_self, out Vector3 ret)
		{
			AnimationStream.GetVelocity_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00003F89 File Offset: 0x00002189
		public static void SetVelocity_Injected(ref AnimationStream _unity_self, ref Vector3 velocity)
		{
			AnimationStream.SetVelocity_InjectedDelegateField(ref _unity_self, ref velocity);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00003F97 File Offset: 0x00002197
		public static void GetAngularVelocity_Injected(ref AnimationStream _unity_self, out Vector3 ret)
		{
			AnimationStream.GetAngularVelocity_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00003FA5 File Offset: 0x000021A5
		public static void SetAngularVelocity_Injected(ref AnimationStream _unity_self, ref Vector3 velocity)
		{
			AnimationStream.SetAngularVelocity_InjectedDelegateField(ref _unity_self, ref velocity);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00003FB3 File Offset: 0x000021B3
		public static void GetRootMotionPosition_Injected(ref AnimationStream _unity_self, out Vector3 ret)
		{
			AnimationStream.GetRootMotionPosition_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00003FC1 File Offset: 0x000021C1
		public static void GetRootMotionRotation_Injected(ref AnimationStream _unity_self, out Quaternion ret)
		{
			AnimationStream.GetRootMotionRotation_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00003FCF File Offset: 0x000021CF
		public static int GetInputStreamCount_Injected(ref AnimationStream _unity_self)
		{
			return AnimationStream.GetInputStreamCount_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00003FDC File Offset: 0x000021DC
		public static void InternalGetInputStream_Injected(ref AnimationStream _unity_self, int index, out AnimationStream ret)
		{
			AnimationStream.InternalGetInputStream_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00003FEB File Offset: 0x000021EB
		public static float InternalGetInputWeight_Injected(ref AnimationStream _unity_self, int index)
		{
			return AnimationStream.InternalGetInputWeight_InjectedDelegateField(ref _unity_self, index);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00003FF9 File Offset: 0x000021F9
		public static void GetHumanStream_Injected(ref AnimationStream _unity_self, out AnimationHumanStream ret)
		{
			AnimationStream.GetHumanStream_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00004007 File Offset: 0x00002207
		public static void InternalReadSceneTransforms_Injected(ref AnimationStream _unity_self)
		{
			AnimationStream.InternalReadSceneTransforms_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00004014 File Offset: 0x00002214
		public static void InternalWriteSceneTransforms_Injected(ref AnimationStream _unity_self)
		{
			AnimationStream.InternalWriteSceneTransforms_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimatorBindingsVersion;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeFieldInfoPtr_constant;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeFieldInfoPtr_input;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr_output;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeFieldInfoPtr_workspace;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeFieldInfoPtr_inputStreamAccessor;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeFieldInfoPtr_animationHandleBinder;

		// Token: 0x040001C3 RID: 451
		[FieldOffset(0)]
		public uint m_AnimatorBindingsVersion;

		// Token: 0x040001C4 RID: 452
		[FieldOffset(8)]
		public IntPtr constant;

		// Token: 0x040001C5 RID: 453
		[FieldOffset(16)]
		public IntPtr input;

		// Token: 0x040001C6 RID: 454
		[FieldOffset(24)]
		public IntPtr output;

		// Token: 0x040001C7 RID: 455
		[FieldOffset(32)]
		public IntPtr workspace;

		// Token: 0x040001C8 RID: 456
		[FieldOffset(40)]
		public IntPtr inputStreamAccessor;

		// Token: 0x040001C9 RID: 457
		[FieldOffset(48)]
		public IntPtr animationHandleBinder;

		// Token: 0x040001CA RID: 458
		public const int InvalidIndex = -1;

		// Token: 0x040001CB RID: 459
		private static readonly AnimationStream.CopyAnimationStreamMotionInternal_InjectedDelegate CopyAnimationStreamMotionInternal_InjectedDelegateField;

		// Token: 0x040001CC RID: 460
		private static readonly AnimationStream.GetDeltaTime_InjectedDelegate GetDeltaTime_InjectedDelegateField;

		// Token: 0x040001CD RID: 461
		private static readonly AnimationStream.GetIsHumanStream_InjectedDelegate GetIsHumanStream_InjectedDelegateField;

		// Token: 0x040001CE RID: 462
		private static readonly AnimationStream.GetVelocity_InjectedDelegate GetVelocity_InjectedDelegateField;

		// Token: 0x040001CF RID: 463
		private static readonly AnimationStream.SetVelocity_InjectedDelegate SetVelocity_InjectedDelegateField;

		// Token: 0x040001D0 RID: 464
		private static readonly AnimationStream.GetAngularVelocity_InjectedDelegate GetAngularVelocity_InjectedDelegateField;

		// Token: 0x040001D1 RID: 465
		private static readonly AnimationStream.SetAngularVelocity_InjectedDelegate SetAngularVelocity_InjectedDelegateField;

		// Token: 0x040001D2 RID: 466
		private static readonly AnimationStream.GetRootMotionPosition_InjectedDelegate GetRootMotionPosition_InjectedDelegateField;

		// Token: 0x040001D3 RID: 467
		private static readonly AnimationStream.GetRootMotionRotation_InjectedDelegate GetRootMotionRotation_InjectedDelegateField;

		// Token: 0x040001D4 RID: 468
		private static readonly AnimationStream.GetInputStreamCount_InjectedDelegate GetInputStreamCount_InjectedDelegateField;

		// Token: 0x040001D5 RID: 469
		private static readonly AnimationStream.InternalGetInputStream_InjectedDelegate InternalGetInputStream_InjectedDelegateField;

		// Token: 0x040001D6 RID: 470
		private static readonly AnimationStream.InternalGetInputWeight_InjectedDelegate InternalGetInputWeight_InjectedDelegateField;

		// Token: 0x040001D7 RID: 471
		private static readonly AnimationStream.GetHumanStream_InjectedDelegate GetHumanStream_InjectedDelegateField;

		// Token: 0x040001D8 RID: 472
		private static readonly AnimationStream.InternalReadSceneTransforms_InjectedDelegate InternalReadSceneTransforms_InjectedDelegateField;

		// Token: 0x040001D9 RID: 473
		private static readonly AnimationStream.InternalWriteSceneTransforms_InjectedDelegate InternalWriteSceneTransforms_InjectedDelegateField;

		// Token: 0x02000176 RID: 374
		// (Invoke) Token: 0x06000792 RID: 1938
		private delegate void CopyAnimationStreamMotionInternal_InjectedDelegate(IntPtr _unity_self, IntPtr animationStream);

		// Token: 0x02000177 RID: 375
		// (Invoke) Token: 0x06000794 RID: 1940
		private delegate float GetDeltaTime_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000178 RID: 376
		// (Invoke) Token: 0x06000796 RID: 1942
		private delegate bool GetIsHumanStream_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000179 RID: 377
		// (Invoke) Token: 0x06000798 RID: 1944
		private delegate void GetVelocity_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x0200017A RID: 378
		// (Invoke) Token: 0x0600079A RID: 1946
		private delegate void SetVelocity_InjectedDelegate(IntPtr _unity_self, IntPtr velocity);

		// Token: 0x0200017B RID: 379
		// (Invoke) Token: 0x0600079C RID: 1948
		private delegate void GetAngularVelocity_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x0200017C RID: 380
		// (Invoke) Token: 0x0600079E RID: 1950
		private delegate void SetAngularVelocity_InjectedDelegate(IntPtr _unity_self, IntPtr velocity);

		// Token: 0x0200017D RID: 381
		// (Invoke) Token: 0x060007A0 RID: 1952
		private delegate void GetRootMotionPosition_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x0200017E RID: 382
		// (Invoke) Token: 0x060007A2 RID: 1954
		private delegate void GetRootMotionRotation_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x0200017F RID: 383
		// (Invoke) Token: 0x060007A4 RID: 1956
		private delegate int GetInputStreamCount_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000180 RID: 384
		// (Invoke) Token: 0x060007A6 RID: 1958
		private delegate void InternalGetInputStream_InjectedDelegate(IntPtr _unity_self, int index, [Out] IntPtr ret);

		// Token: 0x02000181 RID: 385
		// (Invoke) Token: 0x060007A8 RID: 1960
		private delegate float InternalGetInputWeight_InjectedDelegate(IntPtr _unity_self, int index);

		// Token: 0x02000182 RID: 386
		// (Invoke) Token: 0x060007AA RID: 1962
		private delegate void GetHumanStream_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x02000183 RID: 387
		// (Invoke) Token: 0x060007AC RID: 1964
		private delegate void InternalReadSceneTransforms_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000184 RID: 388
		// (Invoke) Token: 0x060007AE RID: 1966
		private delegate void InternalWriteSceneTransforms_InjectedDelegate(IntPtr _unity_self);
	}
}
