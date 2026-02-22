using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x0200001D RID: 29
	[StructLayout(2)]
	public struct AnimationRemoveScalePlayable
	{
		// Token: 0x0600030D RID: 781 RVA: 0x0000AA48 File Offset: 0x00008C48
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationRemoveScalePlayable()
		{
			Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationRemoveScalePlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr);
			AnimationRemoveScalePlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr, "m_Handle");
			AnimationRemoveScalePlayable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr, "m_NullPlayable");
			AnimationRemoveScalePlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr, 100663358);
			AnimationRemoveScalePlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr, 100663359);
			AnimationRemoveScalePlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationRemoveScalePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr, 100663360);
			AnimationRemoveScalePlayable.CreateHandleInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationRemoveScalePlayable.CreateHandleInternal_InjectedDelegate>("UnityEngine.Animations.AnimationRemoveScalePlayable::CreateHandleInternal_Injected");
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000AAEC File Offset: 0x00008CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90039, XrefRangeEnd = 90043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationRemoveScalePlayable(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationRemoveScalePlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000AB20 File Offset: 0x00008D20
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationRemoveScalePlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000AB50 File Offset: 0x00008D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90043, XrefRangeEnd = 90050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AnimationRemoveScalePlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationRemoveScalePlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationRemoveScalePlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00003DD5 File Offset: 0x00001FD5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationRemoveScalePlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000312 RID: 786 RVA: 0x0000AB90 File Offset: 0x00008D90
		// (set) Token: 0x06000313 RID: 787 RVA: 0x00003DE7 File Offset: 0x00001FE7
		public unsafe static AnimationRemoveScalePlayable m_NullPlayable
		{
			get
			{
				AnimationRemoveScalePlayable animationRemoveScalePlayable;
				IL2CPP.il2cpp_field_static_get_value(AnimationRemoveScalePlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&animationRemoveScalePlayable));
				return animationRemoveScalePlayable;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationRemoveScalePlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000314 RID: 788 RVA: 0x0000ABAC File Offset: 0x00008DAC
		public static AnimationRemoveScalePlayable Null
		{
			get
			{
				return AnimationRemoveScalePlayable.m_NullPlayable;
			}
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000ABC4 File Offset: 0x00008DC4
		public static AnimationRemoveScalePlayable Create(PlayableGraph graph, int inputCount)
		{
			PlayableHandle playableHandle = AnimationRemoveScalePlayable.CreateHandle(graph, inputCount);
			return new AnimationRemoveScalePlayable(playableHandle);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000ABE4 File Offset: 0x00008DE4
		public static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount)
		{
			PlayableHandle @null = PlayableHandle.Null;
			bool flag = !AnimationRemoveScalePlayable.CreateHandleInternal(graph, ref @null);
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

		// Token: 0x06000317 RID: 791 RVA: 0x0000AC20 File Offset: 0x00008E20
		public static implicit operator Playable(AnimationRemoveScalePlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000AC40 File Offset: 0x00008E40
		public static explicit operator AnimationRemoveScalePlayable(Playable playable)
		{
			return new AnimationRemoveScalePlayable(playable.GetHandle());
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00003DF5 File Offset: 0x00001FF5
		public static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle)
		{
			return AnimationRemoveScalePlayable.CreateHandleInternal_Injected(ref graph, ref handle);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00003DFF File Offset: 0x00001FFF
		public static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle)
		{
			return AnimationRemoveScalePlayable.CreateHandleInternal_InjectedDelegateField(ref graph, ref handle);
		}

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationRemoveScalePlayable_0;

		// Token: 0x040001B1 RID: 433
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x040001B2 RID: 434
		private static readonly AnimationRemoveScalePlayable.CreateHandleInternal_InjectedDelegate CreateHandleInternal_InjectedDelegateField;

		// Token: 0x02000172 RID: 370
		// (Invoke) Token: 0x0600078A RID: 1930
		private delegate bool CreateHandleInternal_InjectedDelegate(IntPtr graph, IntPtr handle);
	}
}
