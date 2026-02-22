using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	[StructLayout(2)]
	public struct AnimatorTransitionInfo
	{
		// Token: 0x06000092 RID: 146 RVA: 0x00006D78 File Offset: 0x00004F78
		// Note: this type is marked as 'beforefieldinit'.
		static AnimatorTransitionInfo()
		{
			Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimatorTransitionInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr);
			AnimatorTransitionInfo.NativeFieldInfoPtr_m_FullPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_FullPath");
			AnimatorTransitionInfo.NativeFieldInfoPtr_m_UserName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_UserName");
			AnimatorTransitionInfo.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_Name");
			AnimatorTransitionInfo.NativeFieldInfoPtr_m_HasFixedDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_HasFixedDuration");
			AnimatorTransitionInfo.NativeFieldInfoPtr_m_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_Duration");
			AnimatorTransitionInfo.NativeFieldInfoPtr_m_NormalizedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_NormalizedTime");
			AnimatorTransitionInfo.NativeFieldInfoPtr_m_AnyState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_AnyState");
			AnimatorTransitionInfo.NativeFieldInfoPtr_m_TransitionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_TransitionType");
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000261E File Offset: 0x0000081E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00006E48 File Offset: 0x00005048
		public bool IsName(string name)
		{
			return Animator.StringToHash(name) == this.m_Name || Animator.StringToHash(name) == this.m_FullPath;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00006E7C File Offset: 0x0000507C
		public bool IsUserName(string name)
		{
			return Animator.StringToHash(name) == this.m_UserName;
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00006E9C File Offset: 0x0000509C
		public int fullPathHash
		{
			get
			{
				return this.m_FullPath;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00006EB4 File Offset: 0x000050B4
		public int nameHash
		{
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00006ECC File Offset: 0x000050CC
		public int userNameHash
		{
			get
			{
				return this.m_UserName;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00006EE4 File Offset: 0x000050E4
		public DurationUnit durationUnit
		{
			get
			{
				return this.m_HasFixedDuration ? DurationUnit.Fixed : DurationUnit.Normalized;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00006F04 File Offset: 0x00005104
		public float duration
		{
			get
			{
				return this.m_Duration;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00006F1C File Offset: 0x0000511C
		public float normalizedTime
		{
			get
			{
				return this.m_NormalizedTime;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00006F34 File Offset: 0x00005134
		public bool anyState
		{
			get
			{
				return this.m_AnyState;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00006F4C File Offset: 0x0000514C
		public bool entry
		{
			get
			{
				return (this.m_TransitionType & 2) != 0;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00006F6C File Offset: 0x0000516C
		public bool exit
		{
			get
			{
				return (this.m_TransitionType & 4) != 0;
			}
		}

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_m_FullPath;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_m_UserName;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_m_HasFixedDuration;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_m_Duration;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalizedTime;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_m_AnyState;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_m_TransitionType;

		// Token: 0x04000077 RID: 119
		[FieldOffset(0)]
		public int m_FullPath;

		// Token: 0x04000078 RID: 120
		[FieldOffset(4)]
		public int m_UserName;

		// Token: 0x04000079 RID: 121
		[FieldOffset(8)]
		public int m_Name;

		// Token: 0x0400007A RID: 122
		[FieldOffset(12)]
		[MarshalAs(4)]
		public bool m_HasFixedDuration;

		// Token: 0x0400007B RID: 123
		[FieldOffset(16)]
		public float m_Duration;

		// Token: 0x0400007C RID: 124
		[FieldOffset(20)]
		public float m_NormalizedTime;

		// Token: 0x0400007D RID: 125
		[FieldOffset(24)]
		[MarshalAs(4)]
		public bool m_AnyState;

		// Token: 0x0400007E RID: 126
		[FieldOffset(28)]
		public int m_TransitionType;
	}
}
