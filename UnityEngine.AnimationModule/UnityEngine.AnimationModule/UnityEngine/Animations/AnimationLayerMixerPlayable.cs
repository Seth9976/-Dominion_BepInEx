using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x02000017 RID: 23
	[StructLayout(2)]
	public struct AnimationLayerMixerPlayable
	{
		// Token: 0x0600029A RID: 666 RVA: 0x00009B64 File Offset: 0x00007D64
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationLayerMixerPlayable()
		{
			Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationLayerMixerPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr);
			AnimationLayerMixerPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr, "m_Handle");
			AnimationLayerMixerPlayable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr, "m_NullPlayable");
			AnimationLayerMixerPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr, 100663338);
			AnimationLayerMixerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr, 100663339);
			AnimationLayerMixerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationLayerMixerPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr, 100663340);
			AnimationLayerMixerPlayable.IsLayerAdditiveInternalDelegateField = IL2CPP.ResolveICall<AnimationLayerMixerPlayable.IsLayerAdditiveInternalDelegate>("UnityEngine.Animations.AnimationLayerMixerPlayable::IsLayerAdditiveInternal");
			AnimationLayerMixerPlayable.SetLayerAdditiveInternalDelegateField = IL2CPP.ResolveICall<AnimationLayerMixerPlayable.SetLayerAdditiveInternalDelegate>("UnityEngine.Animations.AnimationLayerMixerPlayable::SetLayerAdditiveInternal");
			AnimationLayerMixerPlayable.SetLayerMaskFromAvatarMaskInternalDelegateField = IL2CPP.ResolveICall<AnimationLayerMixerPlayable.SetLayerMaskFromAvatarMaskInternalDelegate>("UnityEngine.Animations.AnimationLayerMixerPlayable::SetLayerMaskFromAvatarMaskInternal");
			AnimationLayerMixerPlayable.CreateHandleInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationLayerMixerPlayable.CreateHandleInternal_InjectedDelegate>("UnityEngine.Animations.AnimationLayerMixerPlayable::CreateHandleInternal_Injected");
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00009C34 File Offset: 0x00007E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89993, XrefRangeEnd = 89997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationLayerMixerPlayable(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLayerMixerPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00009C68 File Offset: 0x00007E68
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLayerMixerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00009C98 File Offset: 0x00007E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89997, XrefRangeEnd = 90001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AnimationLayerMixerPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLayerMixerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationLayerMixerPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00003B37 File Offset: 0x00001D37
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationLayerMixerPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600029F RID: 671 RVA: 0x00009CD8 File Offset: 0x00007ED8
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x00003B49 File Offset: 0x00001D49
		public unsafe static AnimationLayerMixerPlayable m_NullPlayable
		{
			get
			{
				AnimationLayerMixerPlayable animationLayerMixerPlayable;
				IL2CPP.il2cpp_field_static_get_value(AnimationLayerMixerPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&animationLayerMixerPlayable));
				return animationLayerMixerPlayable;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationLayerMixerPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x00009CF4 File Offset: 0x00007EF4
		public static AnimationLayerMixerPlayable Null
		{
			get
			{
				return AnimationLayerMixerPlayable.m_NullPlayable;
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00009D0C File Offset: 0x00007F0C
		public static AnimationLayerMixerPlayable Create(PlayableGraph graph, [Optional] int inputCount)
		{
			PlayableHandle playableHandle = AnimationLayerMixerPlayable.CreateHandle(graph, inputCount);
			return new AnimationLayerMixerPlayable(playableHandle);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00009D2C File Offset: 0x00007F2C
		public static PlayableHandle CreateHandle(PlayableGraph graph, [Optional] int inputCount)
		{
			PlayableHandle @null = PlayableHandle.Null;
			bool flag = !AnimationLayerMixerPlayable.CreateHandleInternal(graph, ref @null);
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

		// Token: 0x060002A4 RID: 676 RVA: 0x00009D68 File Offset: 0x00007F68
		public static implicit operator Playable(AnimationLayerMixerPlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00009D88 File Offset: 0x00007F88
		public static explicit operator AnimationLayerMixerPlayable(Playable playable)
		{
			return new AnimationLayerMixerPlayable(playable.GetHandle());
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00009DA8 File Offset: 0x00007FA8
		public bool IsLayerAdditive(uint layerIndex)
		{
			bool flag = (ulong)layerIndex >= (ulong)((long)this.m_Handle.GetInputCount());
			if (flag)
			{
				throw new ArgumentOutOfRangeException("layerIndex", String.Format("layerIndex {0} must be in the range of 0 to {1}.", layerIndex, this.m_Handle.GetInputCount() - 1));
			}
			return AnimationLayerMixerPlayable.IsLayerAdditiveInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00009E0C File Offset: 0x0000800C
		public void SetLayerAdditive(uint layerIndex, bool value)
		{
			bool flag = (ulong)layerIndex >= (ulong)((long)this.m_Handle.GetInputCount());
			if (flag)
			{
				throw new ArgumentOutOfRangeException("layerIndex", String.Format("layerIndex {0} must be in the range of 0 to {1}.", layerIndex, this.m_Handle.GetInputCount() - 1));
			}
			AnimationLayerMixerPlayable.SetLayerAdditiveInternal(ref this.m_Handle, layerIndex, value);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00009E6C File Offset: 0x0000806C
		public void SetLayerMaskFromAvatarMask(uint layerIndex, AvatarMask mask)
		{
			bool flag = (ulong)layerIndex >= (ulong)((long)this.m_Handle.GetInputCount());
			if (flag)
			{
				throw new ArgumentOutOfRangeException("layerIndex", String.Format("layerIndex {0} must be in the range of 0 to {1}.", layerIndex, this.m_Handle.GetInputCount() - 1));
			}
			bool flag2 = mask == null;
			if (flag2)
			{
				throw new ArgumentNullException("mask");
			}
			AnimationLayerMixerPlayable.SetLayerMaskFromAvatarMaskInternal(ref this.m_Handle, layerIndex, mask);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00003B57 File Offset: 0x00001D57
		public static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle)
		{
			return AnimationLayerMixerPlayable.CreateHandleInternal_Injected(ref graph, ref handle);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00003B61 File Offset: 0x00001D61
		public static bool IsLayerAdditiveInternal(ref PlayableHandle handle, uint layerIndex)
		{
			return AnimationLayerMixerPlayable.IsLayerAdditiveInternalDelegateField(ref handle, layerIndex);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00003B6F File Offset: 0x00001D6F
		public static void SetLayerAdditiveInternal(ref PlayableHandle handle, uint layerIndex, bool value)
		{
			AnimationLayerMixerPlayable.SetLayerAdditiveInternalDelegateField(ref handle, layerIndex, value);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00003B7E File Offset: 0x00001D7E
		public static void SetLayerMaskFromAvatarMaskInternal(ref PlayableHandle handle, uint layerIndex, AvatarMask mask)
		{
			AnimationLayerMixerPlayable.SetLayerMaskFromAvatarMaskInternalDelegateField(ref handle, layerIndex, IL2CPP.Il2CppObjectBaseToPtr(mask));
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00003B92 File Offset: 0x00001D92
		public static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle)
		{
			return AnimationLayerMixerPlayable.CreateHandleInternal_InjectedDelegateField(ref graph, ref handle);
		}

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationLayerMixerPlayable_0;

		// Token: 0x0400017B RID: 379
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x0400017C RID: 380
		private static readonly AnimationLayerMixerPlayable.IsLayerAdditiveInternalDelegate IsLayerAdditiveInternalDelegateField;

		// Token: 0x0400017D RID: 381
		private static readonly AnimationLayerMixerPlayable.SetLayerAdditiveInternalDelegate SetLayerAdditiveInternalDelegateField;

		// Token: 0x0400017E RID: 382
		private static readonly AnimationLayerMixerPlayable.SetLayerMaskFromAvatarMaskInternalDelegate SetLayerMaskFromAvatarMaskInternalDelegateField;

		// Token: 0x0400017F RID: 383
		private static readonly AnimationLayerMixerPlayable.CreateHandleInternal_InjectedDelegate CreateHandleInternal_InjectedDelegateField;

		// Token: 0x0200015C RID: 348
		// (Invoke) Token: 0x0600075E RID: 1886
		private delegate bool IsLayerAdditiveInternalDelegate(IntPtr handle, uint layerIndex);

		// Token: 0x0200015D RID: 349
		// (Invoke) Token: 0x06000760 RID: 1888
		private delegate void SetLayerAdditiveInternalDelegate(IntPtr handle, uint layerIndex, bool value);

		// Token: 0x0200015E RID: 350
		// (Invoke) Token: 0x06000762 RID: 1890
		private delegate void SetLayerMaskFromAvatarMaskInternalDelegate(IntPtr handle, uint layerIndex, IntPtr mask);

		// Token: 0x0200015F RID: 351
		// (Invoke) Token: 0x06000764 RID: 1892
		private delegate bool CreateHandleInternal_InjectedDelegate(IntPtr graph, IntPtr handle);
	}
}
