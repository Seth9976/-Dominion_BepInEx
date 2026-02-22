using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	[StructLayout(2)]
	public struct AnimatorClipInfo
	{
		// Token: 0x06000080 RID: 128 RVA: 0x00006A58 File Offset: 0x00004C58
		// Note: this type is marked as 'beforefieldinit'.
		static AnimatorClipInfo()
		{
			Il2CppClassPointerStore<AnimatorClipInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimatorClipInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorClipInfo>.NativeClassPtr);
			AnimatorClipInfo.NativeFieldInfoPtr_m_ClipInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorClipInfo>.NativeClassPtr, "m_ClipInstanceID");
			AnimatorClipInfo.NativeFieldInfoPtr_m_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorClipInfo>.NativeClassPtr, "m_Weight");
			AnimatorClipInfo.InstanceIDToAnimationClipPPtrDelegateField = IL2CPP.ResolveICall<AnimatorClipInfo.InstanceIDToAnimationClipPPtrDelegate>("UnityEngine.AnimatorClipInfo::InstanceIDToAnimationClipPPtr");
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000025FA File Offset: 0x000007FA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimatorClipInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00006AC0 File Offset: 0x00004CC0
		public AnimationClip clip
		{
			get
			{
				return (this.m_ClipInstanceID != 0) ? AnimatorClipInfo.InstanceIDToAnimationClipPPtr(this.m_ClipInstanceID) : null;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00006AE8 File Offset: 0x00004CE8
		public float weight
		{
			get
			{
				return this.m_Weight;
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00006B00 File Offset: 0x00004D00
		public static AnimationClip InstanceIDToAnimationClipPPtr(int instanceID)
		{
			IntPtr intPtr = AnimatorClipInfo.InstanceIDToAnimationClipPPtrDelegateField(instanceID);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
		}

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeFieldInfoPtr_m_ClipInstanceID;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr_m_Weight;

		// Token: 0x04000059 RID: 89
		[FieldOffset(0)]
		public int m_ClipInstanceID;

		// Token: 0x0400005A RID: 90
		[FieldOffset(4)]
		public float m_Weight;

		// Token: 0x0400005B RID: 91
		private static readonly AnimatorClipInfo.InstanceIDToAnimationClipPPtrDelegate InstanceIDToAnimationClipPPtrDelegateField;

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x060005C1 RID: 1473
		private delegate IntPtr InstanceIDToAnimationClipPPtrDelegate(int instanceID);
	}
}
