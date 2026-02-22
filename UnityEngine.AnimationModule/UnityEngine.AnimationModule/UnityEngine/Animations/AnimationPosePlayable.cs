using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x0200001C RID: 28
	[StructLayout(2)]
	public struct AnimationPosePlayable
	{
		// Token: 0x060002F3 RID: 755 RVA: 0x0000A780 File Offset: 0x00008980
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationPosePlayable()
		{
			Il2CppClassPointerStore<AnimationPosePlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationPosePlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationPosePlayable>.NativeClassPtr);
			AnimationPosePlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPosePlayable>.NativeClassPtr, "m_Handle");
			AnimationPosePlayable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPosePlayable>.NativeClassPtr, "m_NullPlayable");
			AnimationPosePlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPosePlayable>.NativeClassPtr, 100663354);
			AnimationPosePlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPosePlayable>.NativeClassPtr, 100663355);
			AnimationPosePlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationPosePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPosePlayable>.NativeClassPtr, 100663356);
			AnimationPosePlayable.GetMustReadPreviousPoseInternalDelegateField = IL2CPP.ResolveICall<AnimationPosePlayable.GetMustReadPreviousPoseInternalDelegate>("UnityEngine.Animations.AnimationPosePlayable::GetMustReadPreviousPoseInternal");
			AnimationPosePlayable.SetMustReadPreviousPoseInternalDelegateField = IL2CPP.ResolveICall<AnimationPosePlayable.SetMustReadPreviousPoseInternalDelegate>("UnityEngine.Animations.AnimationPosePlayable::SetMustReadPreviousPoseInternal");
			AnimationPosePlayable.GetReadDefaultPoseInternalDelegateField = IL2CPP.ResolveICall<AnimationPosePlayable.GetReadDefaultPoseInternalDelegate>("UnityEngine.Animations.AnimationPosePlayable::GetReadDefaultPoseInternal");
			AnimationPosePlayable.SetReadDefaultPoseInternalDelegateField = IL2CPP.ResolveICall<AnimationPosePlayable.SetReadDefaultPoseInternalDelegate>("UnityEngine.Animations.AnimationPosePlayable::SetReadDefaultPoseInternal");
			AnimationPosePlayable.GetApplyFootIKInternalDelegateField = IL2CPP.ResolveICall<AnimationPosePlayable.GetApplyFootIKInternalDelegate>("UnityEngine.Animations.AnimationPosePlayable::GetApplyFootIKInternal");
			AnimationPosePlayable.SetApplyFootIKInternalDelegateField = IL2CPP.ResolveICall<AnimationPosePlayable.SetApplyFootIKInternalDelegate>("UnityEngine.Animations.AnimationPosePlayable::SetApplyFootIKInternal");
			AnimationPosePlayable.CreateHandleInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationPosePlayable.CreateHandleInternal_InjectedDelegate>("UnityEngine.Animations.AnimationPosePlayable::CreateHandleInternal_Injected");
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0000A880 File Offset: 0x00008A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90028, XrefRangeEnd = 90032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationPosePlayable(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPosePlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000A8B4 File Offset: 0x00008AB4
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPosePlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000A8E4 File Offset: 0x00008AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90032, XrefRangeEnd = 90039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AnimationPosePlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPosePlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationPosePlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00003D1C File Offset: 0x00001F1C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationPosePlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x0000A924 File Offset: 0x00008B24
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x00003D2E File Offset: 0x00001F2E
		public unsafe static AnimationPosePlayable m_NullPlayable
		{
			get
			{
				AnimationPosePlayable animationPosePlayable;
				IL2CPP.il2cpp_field_static_get_value(AnimationPosePlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&animationPosePlayable));
				return animationPosePlayable;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationPosePlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002FA RID: 762 RVA: 0x0000A940 File Offset: 0x00008B40
		public static AnimationPosePlayable Null
		{
			get
			{
				return AnimationPosePlayable.m_NullPlayable;
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000A958 File Offset: 0x00008B58
		public static AnimationPosePlayable Create(PlayableGraph graph)
		{
			PlayableHandle playableHandle = AnimationPosePlayable.CreateHandle(graph);
			return new AnimationPosePlayable(playableHandle);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000A978 File Offset: 0x00008B78
		public static PlayableHandle CreateHandle(PlayableGraph graph)
		{
			PlayableHandle @null = PlayableHandle.Null;
			bool flag = !AnimationPosePlayable.CreateHandleInternal(graph, ref @null);
			PlayableHandle playableHandle;
			if (flag)
			{
				playableHandle = PlayableHandle.Null;
			}
			else
			{
				playableHandle = @null;
			}
			return playableHandle;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000A9A8 File Offset: 0x00008BA8
		public static implicit operator Playable(AnimationPosePlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000A9C8 File Offset: 0x00008BC8
		public static explicit operator AnimationPosePlayable(Playable playable)
		{
			return new AnimationPosePlayable(playable.GetHandle());
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000A9E8 File Offset: 0x00008BE8
		public bool GetMustReadPreviousPose()
		{
			return AnimationPosePlayable.GetMustReadPreviousPoseInternal(ref this.m_Handle);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00003D3C File Offset: 0x00001F3C
		public void SetMustReadPreviousPose(bool value)
		{
			AnimationPosePlayable.SetMustReadPreviousPoseInternal(ref this.m_Handle, value);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000AA08 File Offset: 0x00008C08
		public bool GetReadDefaultPose()
		{
			return AnimationPosePlayable.GetReadDefaultPoseInternal(ref this.m_Handle);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00003D4C File Offset: 0x00001F4C
		public void SetReadDefaultPose(bool value)
		{
			AnimationPosePlayable.SetReadDefaultPoseInternal(ref this.m_Handle, value);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000AA28 File Offset: 0x00008C28
		public bool GetApplyFootIK()
		{
			return AnimationPosePlayable.GetApplyFootIKInternal(ref this.m_Handle);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00003D5C File Offset: 0x00001F5C
		public void SetApplyFootIK(bool value)
		{
			AnimationPosePlayable.SetApplyFootIKInternal(ref this.m_Handle, value);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00003D6C File Offset: 0x00001F6C
		public static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle)
		{
			return AnimationPosePlayable.CreateHandleInternal_Injected(ref graph, ref handle);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00003D76 File Offset: 0x00001F76
		public static bool GetMustReadPreviousPoseInternal(ref PlayableHandle handle)
		{
			return AnimationPosePlayable.GetMustReadPreviousPoseInternalDelegateField(ref handle);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00003D83 File Offset: 0x00001F83
		public static void SetMustReadPreviousPoseInternal(ref PlayableHandle handle, bool value)
		{
			AnimationPosePlayable.SetMustReadPreviousPoseInternalDelegateField(ref handle, value);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00003D91 File Offset: 0x00001F91
		public static bool GetReadDefaultPoseInternal(ref PlayableHandle handle)
		{
			return AnimationPosePlayable.GetReadDefaultPoseInternalDelegateField(ref handle);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00003D9E File Offset: 0x00001F9E
		public static void SetReadDefaultPoseInternal(ref PlayableHandle handle, bool value)
		{
			AnimationPosePlayable.SetReadDefaultPoseInternalDelegateField(ref handle, value);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00003DAC File Offset: 0x00001FAC
		public static bool GetApplyFootIKInternal(ref PlayableHandle handle)
		{
			return AnimationPosePlayable.GetApplyFootIKInternalDelegateField(ref handle);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00003DB9 File Offset: 0x00001FB9
		public static void SetApplyFootIKInternal(ref PlayableHandle handle, bool value)
		{
			AnimationPosePlayable.SetApplyFootIKInternalDelegateField(ref handle, value);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00003DC7 File Offset: 0x00001FC7
		public static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle)
		{
			return AnimationPosePlayable.CreateHandleInternal_InjectedDelegateField(ref graph, ref handle);
		}

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationPosePlayable_0;

		// Token: 0x040001A4 RID: 420
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x040001A5 RID: 421
		private static readonly AnimationPosePlayable.GetMustReadPreviousPoseInternalDelegate GetMustReadPreviousPoseInternalDelegateField;

		// Token: 0x040001A6 RID: 422
		private static readonly AnimationPosePlayable.SetMustReadPreviousPoseInternalDelegate SetMustReadPreviousPoseInternalDelegateField;

		// Token: 0x040001A7 RID: 423
		private static readonly AnimationPosePlayable.GetReadDefaultPoseInternalDelegate GetReadDefaultPoseInternalDelegateField;

		// Token: 0x040001A8 RID: 424
		private static readonly AnimationPosePlayable.SetReadDefaultPoseInternalDelegate SetReadDefaultPoseInternalDelegateField;

		// Token: 0x040001A9 RID: 425
		private static readonly AnimationPosePlayable.GetApplyFootIKInternalDelegate GetApplyFootIKInternalDelegateField;

		// Token: 0x040001AA RID: 426
		private static readonly AnimationPosePlayable.SetApplyFootIKInternalDelegate SetApplyFootIKInternalDelegateField;

		// Token: 0x040001AB RID: 427
		private static readonly AnimationPosePlayable.CreateHandleInternal_InjectedDelegate CreateHandleInternal_InjectedDelegateField;

		// Token: 0x0200016B RID: 363
		// (Invoke) Token: 0x0600077C RID: 1916
		private delegate bool GetMustReadPreviousPoseInternalDelegate(IntPtr handle);

		// Token: 0x0200016C RID: 364
		// (Invoke) Token: 0x0600077E RID: 1918
		private delegate void SetMustReadPreviousPoseInternalDelegate(IntPtr handle, bool value);

		// Token: 0x0200016D RID: 365
		// (Invoke) Token: 0x06000780 RID: 1920
		private delegate bool GetReadDefaultPoseInternalDelegate(IntPtr handle);

		// Token: 0x0200016E RID: 366
		// (Invoke) Token: 0x06000782 RID: 1922
		private delegate void SetReadDefaultPoseInternalDelegate(IntPtr handle, bool value);

		// Token: 0x0200016F RID: 367
		// (Invoke) Token: 0x06000784 RID: 1924
		private delegate bool GetApplyFootIKInternalDelegate(IntPtr handle);

		// Token: 0x02000170 RID: 368
		// (Invoke) Token: 0x06000786 RID: 1926
		private delegate void SetApplyFootIKInternalDelegate(IntPtr handle, bool value);

		// Token: 0x02000171 RID: 369
		// (Invoke) Token: 0x06000788 RID: 1928
		private delegate bool CreateHandleInternal_InjectedDelegate(IntPtr graph, IntPtr handle);
	}
}
