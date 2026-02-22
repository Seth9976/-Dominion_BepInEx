using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x0200001E RID: 30
	[StructLayout(2)]
	public struct AnimationScriptPlayable
	{
		// Token: 0x0600031B RID: 795 RVA: 0x0000AC60 File Offset: 0x00008E60
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationScriptPlayable()
		{
			Il2CppClassPointerStore<AnimationScriptPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationScriptPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationScriptPlayable>.NativeClassPtr);
			AnimationScriptPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationScriptPlayable>.NativeClassPtr, "m_Handle");
			AnimationScriptPlayable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationScriptPlayable>.NativeClassPtr, "m_NullPlayable");
			AnimationScriptPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationScriptPlayable>.NativeClassPtr, 100663362);
			AnimationScriptPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationScriptPlayable>.NativeClassPtr, 100663363);
			AnimationScriptPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationScriptPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationScriptPlayable>.NativeClassPtr, 100663364);
			AnimationScriptPlayable.CreateHandleInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationScriptPlayable.CreateHandleInternal_InjectedDelegate>("UnityEngine.Animations.AnimationScriptPlayable::CreateHandleInternal_Injected");
			AnimationScriptPlayable.SetProcessInputsInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationScriptPlayable.SetProcessInputsInternal_InjectedDelegate>("UnityEngine.Animations.AnimationScriptPlayable::SetProcessInputsInternal_Injected");
			AnimationScriptPlayable.GetProcessInputsInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationScriptPlayable.GetProcessInputsInternal_InjectedDelegate>("UnityEngine.Animations.AnimationScriptPlayable::GetProcessInputsInternal_Injected");
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000AD24 File Offset: 0x00008F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90050, XrefRangeEnd = 90054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationScriptPlayable(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationScriptPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000AD58 File Offset: 0x00008F58
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationScriptPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000AD88 File Offset: 0x00008F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90054, XrefRangeEnd = 90058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AnimationScriptPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationScriptPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationScriptPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00003E0D File Offset: 0x0000200D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationScriptPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0000ADC8 File Offset: 0x00008FC8
		// (set) Token: 0x06000321 RID: 801 RVA: 0x00003E1F File Offset: 0x0000201F
		public unsafe static AnimationScriptPlayable m_NullPlayable
		{
			get
			{
				AnimationScriptPlayable animationScriptPlayable;
				IL2CPP.il2cpp_field_static_get_value(AnimationScriptPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&animationScriptPlayable));
				return animationScriptPlayable;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationScriptPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0000ADE4 File Offset: 0x00008FE4
		public static AnimationScriptPlayable Null
		{
			get
			{
				return AnimationScriptPlayable.m_NullPlayable;
			}
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000ADFC File Offset: 0x00008FFC
		public static AnimationScriptPlayable Create<T>(PlayableGraph graph, T jobData, [Optional] int inputCount) where T : struct
		{
			PlayableHandle playableHandle = AnimationScriptPlayable.CreateHandle<T>(graph, inputCount);
			AnimationScriptPlayable animationScriptPlayable = new AnimationScriptPlayable(playableHandle);
			animationScriptPlayable.SetJobData<T>(jobData);
			return animationScriptPlayable;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00003E2D File Offset: 0x0000202D
		public static PlayableHandle CreateHandle<T>(PlayableGraph graph, int inputCount) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000AE28 File Offset: 0x00009028
		public void CheckJobTypeValidity<T>()
		{
			Type jobType = this.GetHandle().GetJobType();
			bool flag = jobType != Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
			if (flag)
			{
				throw new ArgumentException(String.Format("Wrong type: the given job type ({0}) is different from the creation job type ({1}).", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()).FullName, jobType.FullName));
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0000AE80 File Offset: 0x00009080
		public unsafe T GetJobData<T>() where T : struct
		{
			this.CheckJobTypeValidity<T>();
			T t;
			UnsafeUtility.CopyPtrToStructure<T>((void*)this.GetHandle().GetJobData(), out t);
			return t;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000AEB8 File Offset: 0x000090B8
		public unsafe void SetJobData<T>(T jobData) where T : struct
		{
			this.CheckJobTypeValidity<T>();
			UnsafeUtility.CopyStructureToPtr<T>(ref jobData, (void*)this.GetHandle().GetJobData());
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000AEE8 File Offset: 0x000090E8
		public static implicit operator Playable(AnimationScriptPlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000AF08 File Offset: 0x00009108
		public static explicit operator AnimationScriptPlayable(Playable playable)
		{
			return new AnimationScriptPlayable(playable.GetHandle());
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00003E3A File Offset: 0x0000203A
		public void SetProcessInputs(bool value)
		{
			AnimationScriptPlayable.SetProcessInputsInternal(this.GetHandle(), value);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000AF28 File Offset: 0x00009128
		public bool GetProcessInputs()
		{
			return AnimationScriptPlayable.GetProcessInputsInternal(this.GetHandle());
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00003E4A File Offset: 0x0000204A
		public static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle, IntPtr jobReflectionData)
		{
			return AnimationScriptPlayable.CreateHandleInternal_Injected(ref graph, ref handle, jobReflectionData);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00003E55 File Offset: 0x00002055
		public static void SetProcessInputsInternal(PlayableHandle handle, bool value)
		{
			AnimationScriptPlayable.SetProcessInputsInternal_Injected(ref handle, value);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00003E5F File Offset: 0x0000205F
		public static bool GetProcessInputsInternal(PlayableHandle handle)
		{
			return AnimationScriptPlayable.GetProcessInputsInternal_Injected(ref handle);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00003E68 File Offset: 0x00002068
		public static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle, IntPtr jobReflectionData)
		{
			return AnimationScriptPlayable.CreateHandleInternal_InjectedDelegateField(ref graph, ref handle, jobReflectionData);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00003E77 File Offset: 0x00002077
		public static void SetProcessInputsInternal_Injected(ref PlayableHandle handle, bool value)
		{
			AnimationScriptPlayable.SetProcessInputsInternal_InjectedDelegateField(ref handle, value);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00003E85 File Offset: 0x00002085
		public static bool GetProcessInputsInternal_Injected(ref PlayableHandle handle)
		{
			return AnimationScriptPlayable.GetProcessInputsInternal_InjectedDelegateField(ref handle);
		}

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationScriptPlayable_0;

		// Token: 0x040001B8 RID: 440
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x040001B9 RID: 441
		private static readonly AnimationScriptPlayable.CreateHandleInternal_InjectedDelegate CreateHandleInternal_InjectedDelegateField;

		// Token: 0x040001BA RID: 442
		private static readonly AnimationScriptPlayable.SetProcessInputsInternal_InjectedDelegate SetProcessInputsInternal_InjectedDelegateField;

		// Token: 0x040001BB RID: 443
		private static readonly AnimationScriptPlayable.GetProcessInputsInternal_InjectedDelegate GetProcessInputsInternal_InjectedDelegateField;

		// Token: 0x02000173 RID: 371
		// (Invoke) Token: 0x0600078C RID: 1932
		private delegate bool CreateHandleInternal_InjectedDelegate(IntPtr graph, IntPtr handle, IntPtr jobReflectionData);

		// Token: 0x02000174 RID: 372
		// (Invoke) Token: 0x0600078E RID: 1934
		private delegate void SetProcessInputsInternal_InjectedDelegate(IntPtr handle, bool value);

		// Token: 0x02000175 RID: 373
		// (Invoke) Token: 0x06000790 RID: 1936
		private delegate bool GetProcessInputsInternal_InjectedDelegate(IntPtr handle);
	}
}
