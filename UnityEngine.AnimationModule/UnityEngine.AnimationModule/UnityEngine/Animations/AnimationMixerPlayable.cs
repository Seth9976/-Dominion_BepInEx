using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x02000018 RID: 24
	[StructLayout(2)]
	public struct AnimationMixerPlayable
	{
		// Token: 0x060002AE RID: 686 RVA: 0x00009EE4 File Offset: 0x000080E4
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationMixerPlayable()
		{
			Il2CppClassPointerStore<AnimationMixerPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationMixerPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationMixerPlayable>.NativeClassPtr);
			AnimationMixerPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationMixerPlayable>.NativeClassPtr, "m_Handle");
			AnimationMixerPlayable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationMixerPlayable>.NativeClassPtr, "m_NullPlayable");
			AnimationMixerPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMixerPlayable>.NativeClassPtr, 100663342);
			AnimationMixerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMixerPlayable>.NativeClassPtr, 100663343);
			AnimationMixerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationMixerPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMixerPlayable>.NativeClassPtr, 100663344);
			AnimationMixerPlayable.CreateHandleInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationMixerPlayable.CreateHandleInternal_InjectedDelegate>("UnityEngine.Animations.AnimationMixerPlayable::CreateHandleInternal_Injected");
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00009F88 File Offset: 0x00008188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90001, XrefRangeEnd = 90005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationMixerPlayable(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationMixerPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00009FBC File Offset: 0x000081BC
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationMixerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00009FEC File Offset: 0x000081EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90005, XrefRangeEnd = 90009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AnimationMixerPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationMixerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationMixerPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00003BA0 File Offset: 0x00001DA0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationMixerPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x0000A02C File Offset: 0x0000822C
		// (set) Token: 0x060002B4 RID: 692 RVA: 0x00003BB2 File Offset: 0x00001DB2
		public unsafe static AnimationMixerPlayable m_NullPlayable
		{
			get
			{
				AnimationMixerPlayable animationMixerPlayable;
				IL2CPP.il2cpp_field_static_get_value(AnimationMixerPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&animationMixerPlayable));
				return animationMixerPlayable;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationMixerPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x0000A048 File Offset: 0x00008248
		public static AnimationMixerPlayable Null
		{
			get
			{
				return AnimationMixerPlayable.m_NullPlayable;
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000A060 File Offset: 0x00008260
		public static AnimationMixerPlayable Create(PlayableGraph graph, [Optional] int inputCount, [Optional] bool normalizeWeights)
		{
			PlayableHandle playableHandle = AnimationMixerPlayable.CreateHandle(graph, inputCount, normalizeWeights);
			return new AnimationMixerPlayable(playableHandle);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000A084 File Offset: 0x00008284
		public static PlayableHandle CreateHandle(PlayableGraph graph, [Optional] int inputCount, [Optional] bool normalizeWeights)
		{
			PlayableHandle @null = PlayableHandle.Null;
			bool flag = !AnimationMixerPlayable.CreateHandleInternal(graph, normalizeWeights, ref @null);
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

		// Token: 0x060002B8 RID: 696 RVA: 0x0000A0C0 File Offset: 0x000082C0
		public static implicit operator Playable(AnimationMixerPlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000A0E0 File Offset: 0x000082E0
		public static explicit operator AnimationMixerPlayable(Playable playable)
		{
			return new AnimationMixerPlayable(playable.GetHandle());
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00003BC0 File Offset: 0x00001DC0
		public static bool CreateHandleInternal(PlayableGraph graph, bool normalizeWeights, ref PlayableHandle handle)
		{
			return AnimationMixerPlayable.CreateHandleInternal_Injected(ref graph, normalizeWeights, ref handle);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00003BCB File Offset: 0x00001DCB
		public static bool CreateHandleInternal_Injected(ref PlayableGraph graph, bool normalizeWeights, ref PlayableHandle handle)
		{
			return AnimationMixerPlayable.CreateHandleInternal_InjectedDelegateField(ref graph, normalizeWeights, ref handle);
		}

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationMixerPlayable_0;

		// Token: 0x04000185 RID: 389
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x04000186 RID: 390
		private static readonly AnimationMixerPlayable.CreateHandleInternal_InjectedDelegate CreateHandleInternal_InjectedDelegateField;

		// Token: 0x02000160 RID: 352
		// (Invoke) Token: 0x06000766 RID: 1894
		private delegate bool CreateHandleInternal_InjectedDelegate(IntPtr graph, bool normalizeWeights, IntPtr handle);
	}
}
