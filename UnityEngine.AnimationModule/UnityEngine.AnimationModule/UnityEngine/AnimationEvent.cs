using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	[Serializable]
	public sealed class AnimationEvent : Object
	{
		// Token: 0x0600002F RID: 47 RVA: 0x0000632C File Offset: 0x0000452C
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationEvent()
		{
			Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimationEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr);
			AnimationEvent.NativeFieldInfoPtr_m_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, "m_Time");
			AnimationEvent.NativeFieldInfoPtr_m_FunctionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, "m_FunctionName");
			AnimationEvent.NativeFieldInfoPtr_m_StringParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, "m_StringParameter");
			AnimationEvent.NativeFieldInfoPtr_m_ObjectReferenceParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, "m_ObjectReferenceParameter");
			AnimationEvent.NativeFieldInfoPtr_m_FloatParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, "m_FloatParameter");
			AnimationEvent.NativeFieldInfoPtr_m_IntParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, "m_IntParameter");
			AnimationEvent.NativeFieldInfoPtr_m_MessageOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, "m_MessageOptions");
			AnimationEvent.NativeFieldInfoPtr_m_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, "m_Source");
			AnimationEvent.NativeFieldInfoPtr_m_StateSender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, "m_StateSender");
			AnimationEvent.NativeFieldInfoPtr_m_AnimatorStateInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, "m_AnimatorStateInfo");
			AnimationEvent.NativeFieldInfoPtr_m_AnimatorClipInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, "m_AnimatorClipInfo");
			AnimationEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, 100663312);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000644C File Offset: 0x0000464C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89900, XrefRangeEnd = 89904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002244 File Offset: 0x00000444
		public AnimationEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00006488 File Offset: 0x00004688
		// (set) Token: 0x06000033 RID: 51 RVA: 0x0000224D File Offset: 0x0000044D
		public unsafe float m_Time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_Time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_Time)) = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000064B0 File Offset: 0x000046B0
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00002268 File Offset: 0x00000468
		public unsafe string m_FunctionName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_FunctionName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_FunctionName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000064D8 File Offset: 0x000046D8
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00002287 File Offset: 0x00000487
		public unsafe string m_StringParameter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_StringParameter);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_StringParameter), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00006500 File Offset: 0x00004700
		// (set) Token: 0x06000039 RID: 57 RVA: 0x000022A6 File Offset: 0x000004A6
		public unsafe Object m_ObjectReferenceParameter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_ObjectReferenceParameter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_ObjectReferenceParameter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00006530 File Offset: 0x00004730
		// (set) Token: 0x0600003B RID: 59 RVA: 0x000022C5 File Offset: 0x000004C5
		public unsafe float m_FloatParameter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_FloatParameter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_FloatParameter)) = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00006558 File Offset: 0x00004758
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000022E0 File Offset: 0x000004E0
		public unsafe int m_IntParameter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_IntParameter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_IntParameter)) = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00006580 File Offset: 0x00004780
		// (set) Token: 0x0600003F RID: 63 RVA: 0x000022FB File Offset: 0x000004FB
		public unsafe int m_MessageOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_MessageOptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_MessageOptions)) = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000065A8 File Offset: 0x000047A8
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00002316 File Offset: 0x00000516
		public unsafe AnimationEventSource m_Source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_Source);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_Source)) = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000065D0 File Offset: 0x000047D0
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00002331 File Offset: 0x00000531
		public unsafe AnimationState m_StateSender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_StateSender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_StateSender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00006600 File Offset: 0x00004800
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00002350 File Offset: 0x00000550
		public unsafe AnimatorStateInfo m_AnimatorStateInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_AnimatorStateInfo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_AnimatorStateInfo)) = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00006628 File Offset: 0x00004828
		// (set) Token: 0x06000047 RID: 71 RVA: 0x0000236B File Offset: 0x0000056B
		public unsafe AnimatorClipInfo m_AnimatorClipInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_AnimatorClipInfo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_AnimatorClipInfo)) = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00006650 File Offset: 0x00004850
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00002386 File Offset: 0x00000586
		public string data
		{
			get
			{
				return this.m_StringParameter;
			}
			set
			{
				this.m_StringParameter = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00006668 File Offset: 0x00004868
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00002390 File Offset: 0x00000590
		public string stringParameter
		{
			get
			{
				return this.m_StringParameter;
			}
			set
			{
				this.m_StringParameter = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00006680 File Offset: 0x00004880
		// (set) Token: 0x0600004D RID: 77 RVA: 0x0000239A File Offset: 0x0000059A
		public float floatParameter
		{
			get
			{
				return this.m_FloatParameter;
			}
			set
			{
				this.m_FloatParameter = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00006698 File Offset: 0x00004898
		// (set) Token: 0x0600004F RID: 79 RVA: 0x000023A4 File Offset: 0x000005A4
		public int intParameter
		{
			get
			{
				return this.m_IntParameter;
			}
			set
			{
				this.m_IntParameter = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000050 RID: 80 RVA: 0x000066B0 File Offset: 0x000048B0
		// (set) Token: 0x06000051 RID: 81 RVA: 0x000023AE File Offset: 0x000005AE
		public Object objectReferenceParameter
		{
			get
			{
				return this.m_ObjectReferenceParameter;
			}
			set
			{
				this.m_ObjectReferenceParameter = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000052 RID: 82 RVA: 0x000066C8 File Offset: 0x000048C8
		// (set) Token: 0x06000053 RID: 83 RVA: 0x000023B8 File Offset: 0x000005B8
		public string functionName
		{
			get
			{
				return this.m_FunctionName;
			}
			set
			{
				this.m_FunctionName = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000054 RID: 84 RVA: 0x000066E0 File Offset: 0x000048E0
		// (set) Token: 0x06000055 RID: 85 RVA: 0x000023C2 File Offset: 0x000005C2
		public float time
		{
			get
			{
				return this.m_Time;
			}
			set
			{
				this.m_Time = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000066F8 File Offset: 0x000048F8
		// (set) Token: 0x06000057 RID: 87 RVA: 0x000023CC File Offset: 0x000005CC
		public SendMessageOptions messageOptions
		{
			get
			{
				return (SendMessageOptions)this.m_MessageOptions;
			}
			set
			{
				this.m_MessageOptions = (int)value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00006710 File Offset: 0x00004910
		public bool isFiredByLegacy
		{
			get
			{
				return this.m_Source == AnimationEventSource.Legacy;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000059 RID: 89 RVA: 0x0000672C File Offset: 0x0000492C
		public bool isFiredByAnimator
		{
			get
			{
				return this.m_Source == AnimationEventSource.Animator;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00006748 File Offset: 0x00004948
		public AnimationState animationState
		{
			get
			{
				bool flag = !this.isFiredByLegacy;
				if (flag)
				{
					Debug.LogError("AnimationEvent was not fired by Animation component, you shouldn't use AnimationEvent.animationState");
				}
				return this.m_StateSender;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00006778 File Offset: 0x00004978
		public AnimatorStateInfo animatorStateInfo
		{
			get
			{
				bool flag = !this.isFiredByAnimator;
				if (flag)
				{
					Debug.LogError("AnimationEvent was not fired by Animator component, you shouldn't use AnimationEvent.animatorStateInfo");
				}
				return this.m_AnimatorStateInfo;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600005C RID: 92 RVA: 0x000067A8 File Offset: 0x000049A8
		public AnimatorClipInfo animatorClipInfo
		{
			get
			{
				bool flag = !this.isFiredByAnimator;
				if (flag)
				{
					Debug.LogError("AnimationEvent was not fired by Animator component, you shouldn't use AnimationEvent.animatorClipInfo");
				}
				return this.m_AnimatorClipInfo;
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000067D8 File Offset: 0x000049D8
		public int GetHash()
		{
			int hashCode = this.functionName.GetHashCode();
			return 33 * hashCode + this.time.GetHashCode();
		}

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_m_Time;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_m_FunctionName;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr_m_StringParameter;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr_m_ObjectReferenceParameter;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_m_FloatParameter;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_m_IntParameter;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_m_MessageOptions;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_m_Source;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_m_StateSender;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimatorStateInfo;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimatorClipInfo;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
