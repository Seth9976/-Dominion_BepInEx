using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x0200001A RID: 26
	[StructLayout(2)]
	public struct AnimationOffsetPlayable
	{
		// Token: 0x060002CE RID: 718 RVA: 0x0000A358 File Offset: 0x00008558
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationOffsetPlayable()
		{
			Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationOffsetPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr);
			AnimationOffsetPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, "m_Handle");
			AnimationOffsetPlayable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, "m_NullPlayable");
			AnimationOffsetPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100663350);
			AnimationOffsetPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100663351);
			AnimationOffsetPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationOffsetPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100663352);
			AnimationOffsetPlayable.CreateHandleInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationOffsetPlayable.CreateHandleInternal_InjectedDelegate>("UnityEngine.Animations.AnimationOffsetPlayable::CreateHandleInternal_Injected");
			AnimationOffsetPlayable.GetPositionInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationOffsetPlayable.GetPositionInternal_InjectedDelegate>("UnityEngine.Animations.AnimationOffsetPlayable::GetPositionInternal_Injected");
			AnimationOffsetPlayable.SetPositionInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationOffsetPlayable.SetPositionInternal_InjectedDelegate>("UnityEngine.Animations.AnimationOffsetPlayable::SetPositionInternal_Injected");
			AnimationOffsetPlayable.GetRotationInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationOffsetPlayable.GetRotationInternal_InjectedDelegate>("UnityEngine.Animations.AnimationOffsetPlayable::GetRotationInternal_Injected");
			AnimationOffsetPlayable.SetRotationInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationOffsetPlayable.SetRotationInternal_InjectedDelegate>("UnityEngine.Animations.AnimationOffsetPlayable::SetRotationInternal_Injected");
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000A438 File Offset: 0x00008638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90017, XrefRangeEnd = 90021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationOffsetPlayable(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationOffsetPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000A46C File Offset: 0x0000866C
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationOffsetPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000A49C File Offset: 0x0000869C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90021, XrefRangeEnd = 90028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AnimationOffsetPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationOffsetPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationOffsetPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00003C3D File Offset: 0x00001E3D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x0000A4DC File Offset: 0x000086DC
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x00003C4F File Offset: 0x00001E4F
		public unsafe static AnimationOffsetPlayable m_NullPlayable
		{
			get
			{
				AnimationOffsetPlayable animationOffsetPlayable;
				IL2CPP.il2cpp_field_static_get_value(AnimationOffsetPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&animationOffsetPlayable));
				return animationOffsetPlayable;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationOffsetPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x0000A4F8 File Offset: 0x000086F8
		public static AnimationOffsetPlayable Null
		{
			get
			{
				return AnimationOffsetPlayable.m_NullPlayable;
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000A510 File Offset: 0x00008710
		public static AnimationOffsetPlayable Create(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount)
		{
			PlayableHandle playableHandle = AnimationOffsetPlayable.CreateHandle(graph, position, rotation, inputCount);
			return new AnimationOffsetPlayable(playableHandle);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000A534 File Offset: 0x00008734
		public static PlayableHandle CreateHandle(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount)
		{
			PlayableHandle @null = PlayableHandle.Null;
			bool flag = !AnimationOffsetPlayable.CreateHandleInternal(graph, position, rotation, ref @null);
			PlayableHandle playableHandle;
			if (flag)
			{
				playableHandle = PlayableHandle.Null;
			}
			else
			{
				@null.SetInputCount(inputCount);
				playableHandle = @null;
			}
			return playableHandle;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000A570 File Offset: 0x00008770
		public static implicit operator Playable(AnimationOffsetPlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000A590 File Offset: 0x00008790
		public static explicit operator AnimationOffsetPlayable(Playable playable)
		{
			return new AnimationOffsetPlayable(playable.GetHandle());
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000A5B0 File Offset: 0x000087B0
		public Vector3 GetPosition()
		{
			return AnimationOffsetPlayable.GetPositionInternal(ref this.m_Handle);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00003C5D File Offset: 0x00001E5D
		public void SetPosition(Vector3 value)
		{
			AnimationOffsetPlayable.SetPositionInternal(ref this.m_Handle, value);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000A5D0 File Offset: 0x000087D0
		public Quaternion GetRotation()
		{
			return AnimationOffsetPlayable.GetRotationInternal(ref this.m_Handle);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00003C6D File Offset: 0x00001E6D
		public void SetRotation(Quaternion value)
		{
			AnimationOffsetPlayable.SetRotationInternal(ref this.m_Handle, value);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00003C7D File Offset: 0x00001E7D
		public static bool CreateHandleInternal(PlayableGraph graph, Vector3 position, Quaternion rotation, ref PlayableHandle handle)
		{
			return AnimationOffsetPlayable.CreateHandleInternal_Injected(ref graph, ref position, ref rotation, ref handle);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0000A5F0 File Offset: 0x000087F0
		public static Vector3 GetPositionInternal(ref PlayableHandle handle)
		{
			Vector3 vector;
			AnimationOffsetPlayable.GetPositionInternal_Injected(ref handle, out vector);
			return vector;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00003C8B File Offset: 0x00001E8B
		public static void SetPositionInternal(ref PlayableHandle handle, Vector3 value)
		{
			AnimationOffsetPlayable.SetPositionInternal_Injected(ref handle, ref value);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000A608 File Offset: 0x00008808
		public static Quaternion GetRotationInternal(ref PlayableHandle handle)
		{
			Quaternion quaternion;
			AnimationOffsetPlayable.GetRotationInternal_Injected(ref handle, out quaternion);
			return quaternion;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00003C95 File Offset: 0x00001E95
		public static void SetRotationInternal(ref PlayableHandle handle, Quaternion value)
		{
			AnimationOffsetPlayable.SetRotationInternal_Injected(ref handle, ref value);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00003C9F File Offset: 0x00001E9F
		public static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref Vector3 position, ref Quaternion rotation, ref PlayableHandle handle)
		{
			return AnimationOffsetPlayable.CreateHandleInternal_InjectedDelegateField(ref graph, ref position, ref rotation, ref handle);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00003CAF File Offset: 0x00001EAF
		public static void GetPositionInternal_Injected(ref PlayableHandle handle, out Vector3 ret)
		{
			AnimationOffsetPlayable.GetPositionInternal_InjectedDelegateField(ref handle, out ret);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00003CBD File Offset: 0x00001EBD
		public static void SetPositionInternal_Injected(ref PlayableHandle handle, ref Vector3 value)
		{
			AnimationOffsetPlayable.SetPositionInternal_InjectedDelegateField(ref handle, ref value);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00003CCB File Offset: 0x00001ECB
		public static void GetRotationInternal_Injected(ref PlayableHandle handle, out Quaternion ret)
		{
			AnimationOffsetPlayable.GetRotationInternal_InjectedDelegateField(ref handle, out ret);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00003CD9 File Offset: 0x00001ED9
		public static void SetRotationInternal_Injected(ref PlayableHandle handle, ref Quaternion value)
		{
			AnimationOffsetPlayable.SetRotationInternal_InjectedDelegateField(ref handle, ref value);
		}

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationOffsetPlayable_0;

		// Token: 0x04000195 RID: 405
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x04000196 RID: 406
		private static readonly AnimationOffsetPlayable.CreateHandleInternal_InjectedDelegate CreateHandleInternal_InjectedDelegateField;

		// Token: 0x04000197 RID: 407
		private static readonly AnimationOffsetPlayable.GetPositionInternal_InjectedDelegate GetPositionInternal_InjectedDelegateField;

		// Token: 0x04000198 RID: 408
		private static readonly AnimationOffsetPlayable.SetPositionInternal_InjectedDelegate SetPositionInternal_InjectedDelegateField;

		// Token: 0x04000199 RID: 409
		private static readonly AnimationOffsetPlayable.GetRotationInternal_InjectedDelegate GetRotationInternal_InjectedDelegateField;

		// Token: 0x0400019A RID: 410
		private static readonly AnimationOffsetPlayable.SetRotationInternal_InjectedDelegate SetRotationInternal_InjectedDelegateField;

		// Token: 0x02000164 RID: 356
		// (Invoke) Token: 0x0600076E RID: 1902
		private delegate bool CreateHandleInternal_InjectedDelegate(IntPtr graph, IntPtr position, IntPtr rotation, IntPtr handle);

		// Token: 0x02000165 RID: 357
		// (Invoke) Token: 0x06000770 RID: 1904
		private delegate void GetPositionInternal_InjectedDelegate(IntPtr handle, [Out] IntPtr ret);

		// Token: 0x02000166 RID: 358
		// (Invoke) Token: 0x06000772 RID: 1906
		private delegate void SetPositionInternal_InjectedDelegate(IntPtr handle, IntPtr value);

		// Token: 0x02000167 RID: 359
		// (Invoke) Token: 0x06000774 RID: 1908
		private delegate void GetRotationInternal_InjectedDelegate(IntPtr handle, [Out] IntPtr ret);

		// Token: 0x02000168 RID: 360
		// (Invoke) Token: 0x06000776 RID: 1910
		private delegate void SetRotationInternal_InjectedDelegate(IntPtr handle, IntPtr value);
	}
}
