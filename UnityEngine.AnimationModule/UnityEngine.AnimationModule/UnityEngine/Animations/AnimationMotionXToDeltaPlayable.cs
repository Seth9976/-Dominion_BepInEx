using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x02000019 RID: 25
	[StructLayout(2)]
	public struct AnimationMotionXToDeltaPlayable
	{
		// Token: 0x060002BC RID: 700 RVA: 0x0000A100 File Offset: 0x00008300
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationMotionXToDeltaPlayable()
		{
			Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationMotionXToDeltaPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr);
			AnimationMotionXToDeltaPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, "m_Handle");
			AnimationMotionXToDeltaPlayable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, "m_NullPlayable");
			AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr__ctor_Private_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100663346);
			AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100663347);
			AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationMotionXToDeltaPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100663348);
			AnimationMotionXToDeltaPlayable.IsAbsoluteMotionInternalDelegateField = IL2CPP.ResolveICall<AnimationMotionXToDeltaPlayable.IsAbsoluteMotionInternalDelegate>("UnityEngine.Animations.AnimationMotionXToDeltaPlayable::IsAbsoluteMotionInternal");
			AnimationMotionXToDeltaPlayable.SetAbsoluteMotionInternalDelegateField = IL2CPP.ResolveICall<AnimationMotionXToDeltaPlayable.SetAbsoluteMotionInternalDelegate>("UnityEngine.Animations.AnimationMotionXToDeltaPlayable::SetAbsoluteMotionInternal");
			AnimationMotionXToDeltaPlayable.CreateHandleInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationMotionXToDeltaPlayable.CreateHandleInternal_InjectedDelegate>("UnityEngine.Animations.AnimationMotionXToDeltaPlayable::CreateHandleInternal_Injected");
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000A1C4 File Offset: 0x000083C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90009, XrefRangeEnd = 90013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationMotionXToDeltaPlayable(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr__ctor_Private_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000A1F8 File Offset: 0x000083F8
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000A228 File Offset: 0x00008428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90013, XrefRangeEnd = 90017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AnimationMotionXToDeltaPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationMotionXToDeltaPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationMotionXToDeltaPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00003BDA File Offset: 0x00001DDA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x0000A268 File Offset: 0x00008468
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x00003BEC File Offset: 0x00001DEC
		public unsafe static AnimationMotionXToDeltaPlayable m_NullPlayable
		{
			get
			{
				AnimationMotionXToDeltaPlayable animationMotionXToDeltaPlayable;
				IL2CPP.il2cpp_field_static_get_value(AnimationMotionXToDeltaPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&animationMotionXToDeltaPlayable));
				return animationMotionXToDeltaPlayable;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationMotionXToDeltaPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x0000A284 File Offset: 0x00008484
		public static AnimationMotionXToDeltaPlayable Null
		{
			get
			{
				return AnimationMotionXToDeltaPlayable.m_NullPlayable;
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000A29C File Offset: 0x0000849C
		public static AnimationMotionXToDeltaPlayable Create(PlayableGraph graph)
		{
			PlayableHandle playableHandle = AnimationMotionXToDeltaPlayable.CreateHandle(graph);
			return new AnimationMotionXToDeltaPlayable(playableHandle);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000A2BC File Offset: 0x000084BC
		public static PlayableHandle CreateHandle(PlayableGraph graph)
		{
			PlayableHandle @null = PlayableHandle.Null;
			bool flag = !AnimationMotionXToDeltaPlayable.CreateHandleInternal(graph, ref @null);
			PlayableHandle playableHandle;
			if (flag)
			{
				playableHandle = PlayableHandle.Null;
			}
			else
			{
				@null.SetInputCount(1);
				playableHandle = @null;
			}
			return playableHandle;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000A2F8 File Offset: 0x000084F8
		public static implicit operator Playable(AnimationMotionXToDeltaPlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000A318 File Offset: 0x00008518
		public static explicit operator AnimationMotionXToDeltaPlayable(Playable playable)
		{
			return new AnimationMotionXToDeltaPlayable(playable.GetHandle());
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000A338 File Offset: 0x00008538
		public bool IsAbsoluteMotion()
		{
			return AnimationMotionXToDeltaPlayable.IsAbsoluteMotionInternal(ref this.m_Handle);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00003BFA File Offset: 0x00001DFA
		public void SetAbsoluteMotion(bool value)
		{
			AnimationMotionXToDeltaPlayable.SetAbsoluteMotionInternal(ref this.m_Handle, value);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00003C0A File Offset: 0x00001E0A
		public static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle)
		{
			return AnimationMotionXToDeltaPlayable.CreateHandleInternal_Injected(ref graph, ref handle);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00003C14 File Offset: 0x00001E14
		public static bool IsAbsoluteMotionInternal(ref PlayableHandle handle)
		{
			return AnimationMotionXToDeltaPlayable.IsAbsoluteMotionInternalDelegateField(ref handle);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00003C21 File Offset: 0x00001E21
		public static void SetAbsoluteMotionInternal(ref PlayableHandle handle, bool value)
		{
			AnimationMotionXToDeltaPlayable.SetAbsoluteMotionInternalDelegateField(ref handle, value);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00003C2F File Offset: 0x00001E2F
		public static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle)
		{
			return AnimationMotionXToDeltaPlayable.CreateHandleInternal_InjectedDelegateField(ref graph, ref handle);
		}

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_PlayableHandle_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationMotionXToDeltaPlayable_0;

		// Token: 0x0400018C RID: 396
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x0400018D RID: 397
		private static readonly AnimationMotionXToDeltaPlayable.IsAbsoluteMotionInternalDelegate IsAbsoluteMotionInternalDelegateField;

		// Token: 0x0400018E RID: 398
		private static readonly AnimationMotionXToDeltaPlayable.SetAbsoluteMotionInternalDelegate SetAbsoluteMotionInternalDelegateField;

		// Token: 0x0400018F RID: 399
		private static readonly AnimationMotionXToDeltaPlayable.CreateHandleInternal_InjectedDelegate CreateHandleInternal_InjectedDelegateField;

		// Token: 0x02000161 RID: 353
		// (Invoke) Token: 0x06000768 RID: 1896
		private delegate bool IsAbsoluteMotionInternalDelegate(IntPtr handle);

		// Token: 0x02000162 RID: 354
		// (Invoke) Token: 0x0600076A RID: 1898
		private delegate void SetAbsoluteMotionInternalDelegate(IntPtr handle, bool value);

		// Token: 0x02000163 RID: 355
		// (Invoke) Token: 0x0600076C RID: 1900
		private delegate bool CreateHandleInternal_InjectedDelegate(IntPtr graph, IntPtr handle);
	}
}
