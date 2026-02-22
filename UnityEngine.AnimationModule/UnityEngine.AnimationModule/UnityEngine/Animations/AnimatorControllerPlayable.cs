using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x02000020 RID: 32
	[StructLayout(2)]
	public struct AnimatorControllerPlayable
	{
		// Token: 0x06000364 RID: 868 RVA: 0x0000B388 File Offset: 0x00009588
		// Note: this type is marked as 'beforefieldinit'.
		static AnimatorControllerPlayable()
		{
			Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimatorControllerPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr);
			AnimatorControllerPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr, "m_Handle");
			AnimatorControllerPlayable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr, "m_NullPlayable");
			AnimatorControllerPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr, 100663366);
			AnimatorControllerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr, 100663367);
			AnimatorControllerPlayable.NativeMethodInfoPtr_SetHandle_Public_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr, 100663368);
			AnimatorControllerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimatorControllerPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr, 100663369);
			AnimatorControllerPlayable.GetAnimatorClipInfoInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetAnimatorClipInfoInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorClipInfoInternal");
			AnimatorControllerPlayable.GetAnimatorControllerInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetAnimatorControllerInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorControllerInternal");
			AnimatorControllerPlayable.GetLayerCountInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetLayerCountInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetLayerCountInternal");
			AnimatorControllerPlayable.GetLayerNameInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetLayerNameInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetLayerNameInternal");
			AnimatorControllerPlayable.GetLayerIndexInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetLayerIndexInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetLayerIndexInternal");
			AnimatorControllerPlayable.GetLayerWeightInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetLayerWeightInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetLayerWeightInternal");
			AnimatorControllerPlayable.SetLayerWeightInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetLayerWeightInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetLayerWeightInternal");
			AnimatorControllerPlayable.GetCurrentAnimatorClipInfoInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetCurrentAnimatorClipInfoInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetCurrentAnimatorClipInfoInternal");
			AnimatorControllerPlayable.GetAnimatorClipInfoCountInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetAnimatorClipInfoCountInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorClipInfoCountInternal");
			AnimatorControllerPlayable.GetNextAnimatorClipInfoInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetNextAnimatorClipInfoInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetNextAnimatorClipInfoInternal");
			AnimatorControllerPlayable.ResolveHashInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.ResolveHashInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::ResolveHashInternal");
			AnimatorControllerPlayable.IsInTransitionInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.IsInTransitionInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::IsInTransitionInternal");
			AnimatorControllerPlayable.GetParametersArrayInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetParametersArrayInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetParametersArrayInternal");
			AnimatorControllerPlayable.GetParameterCountInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetParameterCountInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetParameterCountInternal");
			AnimatorControllerPlayable.StringToHashDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.StringToHashDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::StringToHash");
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.CrossFadeInFixedTimeInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::CrossFadeInFixedTimeInternal");
			AnimatorControllerPlayable.CrossFadeInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.CrossFadeInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::CrossFadeInternal");
			AnimatorControllerPlayable.PlayInFixedTimeInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.PlayInFixedTimeInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::PlayInFixedTimeInternal");
			AnimatorControllerPlayable.PlayInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.PlayInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::PlayInternal");
			AnimatorControllerPlayable.HasStateInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.HasStateInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::HasStateInternal");
			AnimatorControllerPlayable.SetFloatStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetFloatStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetFloatString");
			AnimatorControllerPlayable.SetFloatIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetFloatIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetFloatID");
			AnimatorControllerPlayable.GetFloatStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetFloatStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetFloatString");
			AnimatorControllerPlayable.GetFloatIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetFloatIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetFloatID");
			AnimatorControllerPlayable.SetBoolStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetBoolStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetBoolString");
			AnimatorControllerPlayable.SetBoolIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetBoolIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetBoolID");
			AnimatorControllerPlayable.GetBoolStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetBoolStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetBoolString");
			AnimatorControllerPlayable.GetBoolIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetBoolIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetBoolID");
			AnimatorControllerPlayable.SetIntegerStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetIntegerStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetIntegerString");
			AnimatorControllerPlayable.SetIntegerIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetIntegerIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetIntegerID");
			AnimatorControllerPlayable.GetIntegerStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetIntegerStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetIntegerString");
			AnimatorControllerPlayable.GetIntegerIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetIntegerIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetIntegerID");
			AnimatorControllerPlayable.SetTriggerStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetTriggerStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetTriggerString");
			AnimatorControllerPlayable.SetTriggerIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetTriggerIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetTriggerID");
			AnimatorControllerPlayable.ResetTriggerStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.ResetTriggerStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::ResetTriggerString");
			AnimatorControllerPlayable.ResetTriggerIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.ResetTriggerIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::ResetTriggerID");
			AnimatorControllerPlayable.IsParameterControlledByCurveStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.IsParameterControlledByCurveStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::IsParameterControlledByCurveString");
			AnimatorControllerPlayable.IsParameterControlledByCurveIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.IsParameterControlledByCurveIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::IsParameterControlledByCurveID");
			AnimatorControllerPlayable.CreateHandleInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.CreateHandleInternal_InjectedDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::CreateHandleInternal_Injected");
			AnimatorControllerPlayable.GetCurrentAnimatorStateInfoInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetCurrentAnimatorStateInfoInternal_InjectedDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetCurrentAnimatorStateInfoInternal_Injected");
			AnimatorControllerPlayable.GetNextAnimatorStateInfoInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetNextAnimatorStateInfoInternal_InjectedDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetNextAnimatorStateInfoInternal_Injected");
			AnimatorControllerPlayable.GetAnimatorTransitionInfoInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetAnimatorTransitionInfoInternal_InjectedDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorTransitionInfoInternal_Injected");
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000B6A8 File Offset: 0x000098A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90058, XrefRangeEnd = 90063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimatorControllerPlayable(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorControllerPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000B6DC File Offset: 0x000098DC
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorControllerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000B70C File Offset: 0x0000990C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90068, RefRangeEnd = 90069, XrefRangeStart = 90063, XrefRangeEnd = 90068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHandle(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorControllerPlayable.NativeMethodInfoPtr_SetHandle_Public_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000B740 File Offset: 0x00009940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90069, XrefRangeEnd = 90073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AnimatorControllerPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorControllerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimatorControllerPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00004021 File Offset: 0x00002221
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600036A RID: 874 RVA: 0x0000B780 File Offset: 0x00009980
		// (set) Token: 0x0600036B RID: 875 RVA: 0x00004033 File Offset: 0x00002233
		public unsafe static AnimatorControllerPlayable m_NullPlayable
		{
			get
			{
				AnimatorControllerPlayable animatorControllerPlayable;
				IL2CPP.il2cpp_field_static_get_value(AnimatorControllerPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&animatorControllerPlayable));
				return animatorControllerPlayable;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimatorControllerPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600036C RID: 876 RVA: 0x0000B79C File Offset: 0x0000999C
		public static AnimatorControllerPlayable Null
		{
			get
			{
				return AnimatorControllerPlayable.m_NullPlayable;
			}
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000B7B4 File Offset: 0x000099B4
		public static AnimatorControllerPlayable Create(PlayableGraph graph, RuntimeAnimatorController controller)
		{
			PlayableHandle playableHandle = AnimatorControllerPlayable.CreateHandle(graph, controller);
			return new AnimatorControllerPlayable(playableHandle);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000B7D4 File Offset: 0x000099D4
		public static PlayableHandle CreateHandle(PlayableGraph graph, RuntimeAnimatorController controller)
		{
			PlayableHandle @null = PlayableHandle.Null;
			bool flag = !AnimatorControllerPlayable.CreateHandleInternal(graph, controller, ref @null);
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

		// Token: 0x0600036F RID: 879 RVA: 0x0000B808 File Offset: 0x00009A08
		public static implicit operator Playable(AnimatorControllerPlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000B828 File Offset: 0x00009A28
		public static explicit operator AnimatorControllerPlayable(Playable playable)
		{
			return new AnimatorControllerPlayable(playable.GetHandle());
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000B848 File Offset: 0x00009A48
		public float GetFloat(string name)
		{
			return AnimatorControllerPlayable.GetFloatString(ref this.m_Handle, name);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000B868 File Offset: 0x00009A68
		public float GetFloat(int id)
		{
			return AnimatorControllerPlayable.GetFloatID(ref this.m_Handle, id);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00004041 File Offset: 0x00002241
		public void SetFloat(string name, float value)
		{
			AnimatorControllerPlayable.SetFloatString(ref this.m_Handle, name, value);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00004052 File Offset: 0x00002252
		public void SetFloat(int id, float value)
		{
			AnimatorControllerPlayable.SetFloatID(ref this.m_Handle, id, value);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000B888 File Offset: 0x00009A88
		public bool GetBool(string name)
		{
			return AnimatorControllerPlayable.GetBoolString(ref this.m_Handle, name);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000B8A8 File Offset: 0x00009AA8
		public bool GetBool(int id)
		{
			return AnimatorControllerPlayable.GetBoolID(ref this.m_Handle, id);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00004063 File Offset: 0x00002263
		public void SetBool(string name, bool value)
		{
			AnimatorControllerPlayable.SetBoolString(ref this.m_Handle, name, value);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00004074 File Offset: 0x00002274
		public void SetBool(int id, bool value)
		{
			AnimatorControllerPlayable.SetBoolID(ref this.m_Handle, id, value);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000B8C8 File Offset: 0x00009AC8
		public int GetInteger(string name)
		{
			return AnimatorControllerPlayable.GetIntegerString(ref this.m_Handle, name);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000B8E8 File Offset: 0x00009AE8
		public int GetInteger(int id)
		{
			return AnimatorControllerPlayable.GetIntegerID(ref this.m_Handle, id);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00004085 File Offset: 0x00002285
		public void SetInteger(string name, int value)
		{
			AnimatorControllerPlayable.SetIntegerString(ref this.m_Handle, name, value);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00004096 File Offset: 0x00002296
		public void SetInteger(int id, int value)
		{
			AnimatorControllerPlayable.SetIntegerID(ref this.m_Handle, id, value);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x000040A7 File Offset: 0x000022A7
		public void SetTrigger(string name)
		{
			AnimatorControllerPlayable.SetTriggerString(ref this.m_Handle, name);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x000040B7 File Offset: 0x000022B7
		public void SetTrigger(int id)
		{
			AnimatorControllerPlayable.SetTriggerID(ref this.m_Handle, id);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x000040C7 File Offset: 0x000022C7
		public void ResetTrigger(string name)
		{
			AnimatorControllerPlayable.ResetTriggerString(ref this.m_Handle, name);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x000040D7 File Offset: 0x000022D7
		public void ResetTrigger(int id)
		{
			AnimatorControllerPlayable.ResetTriggerID(ref this.m_Handle, id);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000B908 File Offset: 0x00009B08
		public bool IsParameterControlledByCurve(string name)
		{
			return AnimatorControllerPlayable.IsParameterControlledByCurveString(ref this.m_Handle, name);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0000B928 File Offset: 0x00009B28
		public bool IsParameterControlledByCurve(int id)
		{
			return AnimatorControllerPlayable.IsParameterControlledByCurveID(ref this.m_Handle, id);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000B948 File Offset: 0x00009B48
		public int GetLayerCount()
		{
			return AnimatorControllerPlayable.GetLayerCountInternal(ref this.m_Handle);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000B968 File Offset: 0x00009B68
		public string GetLayerName(int layerIndex)
		{
			return AnimatorControllerPlayable.GetLayerNameInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000B988 File Offset: 0x00009B88
		public int GetLayerIndex(string layerName)
		{
			return AnimatorControllerPlayable.GetLayerIndexInternal(ref this.m_Handle, layerName);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000B9A8 File Offset: 0x00009BA8
		public float GetLayerWeight(int layerIndex)
		{
			return AnimatorControllerPlayable.GetLayerWeightInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x000040E7 File Offset: 0x000022E7
		public void SetLayerWeight(int layerIndex, float weight)
		{
			AnimatorControllerPlayable.SetLayerWeightInternal(ref this.m_Handle, layerIndex, weight);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000B9C8 File Offset: 0x00009BC8
		public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex)
		{
			return AnimatorControllerPlayable.GetCurrentAnimatorStateInfoInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex)
		{
			return AnimatorControllerPlayable.GetNextAnimatorStateInfoInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000BA08 File Offset: 0x00009C08
		public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex)
		{
			return AnimatorControllerPlayable.GetAnimatorTransitionInfoInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000BA28 File Offset: 0x00009C28
		public Il2CppStructArray<AnimatorClipInfo> GetCurrentAnimatorClipInfo(int layerIndex)
		{
			return AnimatorControllerPlayable.GetCurrentAnimatorClipInfoInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000BA48 File Offset: 0x00009C48
		public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips)
		{
			bool flag = clips == null;
			if (flag)
			{
				throw new ArgumentNullException("clips");
			}
			AnimatorControllerPlayable.GetAnimatorClipInfoInternal(ref this.m_Handle, layerIndex, true, clips);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000BA78 File Offset: 0x00009C78
		public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips)
		{
			bool flag = clips == null;
			if (flag)
			{
				throw new ArgumentNullException("clips");
			}
			AnimatorControllerPlayable.GetAnimatorClipInfoInternal(ref this.m_Handle, layerIndex, false, clips);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x000040F8 File Offset: 0x000022F8
		public static void GetAnimatorClipInfoInternal(ref PlayableHandle handle, int layerIndex, bool isCurrent, Object clips)
		{
			AnimatorControllerPlayable.GetAnimatorClipInfoInternalDelegateField(ref handle, layerIndex, isCurrent, IL2CPP.Il2CppObjectBaseToPtr(clips));
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000BAA8 File Offset: 0x00009CA8
		public int GetCurrentAnimatorClipInfoCount(int layerIndex)
		{
			return AnimatorControllerPlayable.GetAnimatorClipInfoCountInternal(ref this.m_Handle, layerIndex, true);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000BAC8 File Offset: 0x00009CC8
		public int GetNextAnimatorClipInfoCount(int layerIndex)
		{
			return AnimatorControllerPlayable.GetAnimatorClipInfoCountInternal(ref this.m_Handle, layerIndex, false);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000BAE8 File Offset: 0x00009CE8
		public Il2CppStructArray<AnimatorClipInfo> GetNextAnimatorClipInfo(int layerIndex)
		{
			return AnimatorControllerPlayable.GetNextAnimatorClipInfoInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000BB08 File Offset: 0x00009D08
		public bool IsInTransition(int layerIndex)
		{
			return AnimatorControllerPlayable.IsInTransitionInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000BB28 File Offset: 0x00009D28
		public int GetParameterCount()
		{
			return AnimatorControllerPlayable.GetParameterCountInternal(ref this.m_Handle);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000410D File Offset: 0x0000230D
		public AnimatorControllerParameter GetParameter(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000411A File Offset: 0x0000231A
		public void CrossFadeInFixedTime(string stateName, float transitionDuration)
		{
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), transitionDuration, -1, 0f);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00004136 File Offset: 0x00002336
		public void CrossFadeInFixedTime(string stateName, float transitionDuration, int layer)
		{
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), transitionDuration, layer, 0f);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00004152 File Offset: 0x00002352
		public void CrossFadeInFixedTime(string stateName, float transitionDuration, int layer, float fixedTime)
		{
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), transitionDuration, layer, fixedTime);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000416B File Offset: 0x0000236B
		public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration)
		{
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternal(ref this.m_Handle, stateNameHash, transitionDuration, -1, 0f);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00004182 File Offset: 0x00002382
		public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, int layer)
		{
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternal(ref this.m_Handle, stateNameHash, transitionDuration, layer, 0f);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00004199 File Offset: 0x00002399
		public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, int layer, float fixedTime)
		{
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternal(ref this.m_Handle, stateNameHash, transitionDuration, layer, fixedTime);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x000041AD File Offset: 0x000023AD
		public void CrossFade(string stateName, float transitionDuration)
		{
			AnimatorControllerPlayable.CrossFadeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), transitionDuration, -1, float.NegativeInfinity);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x000041C9 File Offset: 0x000023C9
		public void CrossFade(string stateName, float transitionDuration, int layer)
		{
			AnimatorControllerPlayable.CrossFadeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), transitionDuration, layer, float.NegativeInfinity);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x000041E5 File Offset: 0x000023E5
		public void CrossFade(string stateName, float transitionDuration, int layer, float normalizedTime)
		{
			AnimatorControllerPlayable.CrossFadeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), transitionDuration, layer, normalizedTime);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x000041FE File Offset: 0x000023FE
		public void CrossFade(int stateNameHash, float transitionDuration)
		{
			AnimatorControllerPlayable.CrossFadeInternal(ref this.m_Handle, stateNameHash, transitionDuration, -1, float.NegativeInfinity);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00004215 File Offset: 0x00002415
		public void CrossFade(int stateNameHash, float transitionDuration, int layer)
		{
			AnimatorControllerPlayable.CrossFadeInternal(ref this.m_Handle, stateNameHash, transitionDuration, layer, float.NegativeInfinity);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000422C File Offset: 0x0000242C
		public void CrossFade(int stateNameHash, float transitionDuration, int layer, float normalizedTime)
		{
			AnimatorControllerPlayable.CrossFadeInternal(ref this.m_Handle, stateNameHash, transitionDuration, layer, normalizedTime);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00004240 File Offset: 0x00002440
		public void PlayInFixedTime(string stateName)
		{
			AnimatorControllerPlayable.PlayInFixedTimeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), -1, float.NegativeInfinity);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000425B File Offset: 0x0000245B
		public void PlayInFixedTime(string stateName, int layer)
		{
			AnimatorControllerPlayable.PlayInFixedTimeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), layer, float.NegativeInfinity);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00004276 File Offset: 0x00002476
		public void PlayInFixedTime(string stateName, int layer, float fixedTime)
		{
			AnimatorControllerPlayable.PlayInFixedTimeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), layer, fixedTime);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000428D File Offset: 0x0000248D
		public void PlayInFixedTime(int stateNameHash)
		{
			AnimatorControllerPlayable.PlayInFixedTimeInternal(ref this.m_Handle, stateNameHash, -1, float.NegativeInfinity);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x000042A3 File Offset: 0x000024A3
		public void PlayInFixedTime(int stateNameHash, int layer)
		{
			AnimatorControllerPlayable.PlayInFixedTimeInternal(ref this.m_Handle, stateNameHash, layer, float.NegativeInfinity);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x000042B9 File Offset: 0x000024B9
		public void PlayInFixedTime(int stateNameHash, int layer, float fixedTime)
		{
			AnimatorControllerPlayable.PlayInFixedTimeInternal(ref this.m_Handle, stateNameHash, layer, fixedTime);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x000042CB File Offset: 0x000024CB
		public void Play(string stateName)
		{
			AnimatorControllerPlayable.PlayInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), -1, float.NegativeInfinity);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x000042E6 File Offset: 0x000024E6
		public void Play(string stateName, int layer)
		{
			AnimatorControllerPlayable.PlayInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), layer, float.NegativeInfinity);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00004301 File Offset: 0x00002501
		public void Play(string stateName, int layer, float normalizedTime)
		{
			AnimatorControllerPlayable.PlayInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), layer, normalizedTime);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00004318 File Offset: 0x00002518
		public void Play(int stateNameHash)
		{
			AnimatorControllerPlayable.PlayInternal(ref this.m_Handle, stateNameHash, -1, float.NegativeInfinity);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000432E File Offset: 0x0000252E
		public void Play(int stateNameHash, int layer)
		{
			AnimatorControllerPlayable.PlayInternal(ref this.m_Handle, stateNameHash, layer, float.NegativeInfinity);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00004344 File Offset: 0x00002544
		public void Play(int stateNameHash, int layer, float normalizedTime)
		{
			AnimatorControllerPlayable.PlayInternal(ref this.m_Handle, stateNameHash, layer, normalizedTime);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000BB48 File Offset: 0x00009D48
		public bool HasState(int layerIndex, int stateID)
		{
			return AnimatorControllerPlayable.HasStateInternal(ref this.m_Handle, layerIndex, stateID);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000BB68 File Offset: 0x00009D68
		public string ResolveHash(int hash)
		{
			return AnimatorControllerPlayable.ResolveHashInternal(ref this.m_Handle, hash);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00004356 File Offset: 0x00002556
		public static bool CreateHandleInternal(PlayableGraph graph, RuntimeAnimatorController controller, ref PlayableHandle handle)
		{
			return AnimatorControllerPlayable.CreateHandleInternal_Injected(ref graph, controller, ref handle);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000BB88 File Offset: 0x00009D88
		public static RuntimeAnimatorController GetAnimatorControllerInternal(ref PlayableHandle handle)
		{
			IntPtr intPtr = AnimatorControllerPlayable.GetAnimatorControllerInternalDelegateField(ref handle);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeAnimatorController>(intPtr2) : null;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00004361 File Offset: 0x00002561
		public static int GetLayerCountInternal(ref PlayableHandle handle)
		{
			return AnimatorControllerPlayable.GetLayerCountInternalDelegateField(ref handle);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000BBB0 File Offset: 0x00009DB0
		public static string GetLayerNameInternal(ref PlayableHandle handle, int layerIndex)
		{
			IntPtr intPtr = AnimatorControllerPlayable.GetLayerNameInternalDelegateField(ref handle, layerIndex);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000436E File Offset: 0x0000256E
		public static int GetLayerIndexInternal(ref PlayableHandle handle, string layerName)
		{
			return AnimatorControllerPlayable.GetLayerIndexInternalDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(layerName));
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00004381 File Offset: 0x00002581
		public static float GetLayerWeightInternal(ref PlayableHandle handle, int layerIndex)
		{
			return AnimatorControllerPlayable.GetLayerWeightInternalDelegateField(ref handle, layerIndex);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000438F File Offset: 0x0000258F
		public static void SetLayerWeightInternal(ref PlayableHandle handle, int layerIndex, float weight)
		{
			AnimatorControllerPlayable.SetLayerWeightInternalDelegateField(ref handle, layerIndex, weight);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000BBD0 File Offset: 0x00009DD0
		public static AnimatorStateInfo GetCurrentAnimatorStateInfoInternal(ref PlayableHandle handle, int layerIndex)
		{
			AnimatorStateInfo animatorStateInfo;
			AnimatorControllerPlayable.GetCurrentAnimatorStateInfoInternal_Injected(ref handle, layerIndex, out animatorStateInfo);
			return animatorStateInfo;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000BBE8 File Offset: 0x00009DE8
		public static AnimatorStateInfo GetNextAnimatorStateInfoInternal(ref PlayableHandle handle, int layerIndex)
		{
			AnimatorStateInfo animatorStateInfo;
			AnimatorControllerPlayable.GetNextAnimatorStateInfoInternal_Injected(ref handle, layerIndex, out animatorStateInfo);
			return animatorStateInfo;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000BC00 File Offset: 0x00009E00
		public static AnimatorTransitionInfo GetAnimatorTransitionInfoInternal(ref PlayableHandle handle, int layerIndex)
		{
			AnimatorTransitionInfo animatorTransitionInfo;
			AnimatorControllerPlayable.GetAnimatorTransitionInfoInternal_Injected(ref handle, layerIndex, out animatorTransitionInfo);
			return animatorTransitionInfo;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000BC18 File Offset: 0x00009E18
		public static Il2CppStructArray<AnimatorClipInfo> GetCurrentAnimatorClipInfoInternal(ref PlayableHandle handle, int layerIndex)
		{
			IntPtr intPtr = AnimatorControllerPlayable.GetCurrentAnimatorClipInfoInternalDelegateField(ref handle, layerIndex);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AnimatorClipInfo>>(intPtr2) : null;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000439E File Offset: 0x0000259E
		public static int GetAnimatorClipInfoCountInternal(ref PlayableHandle handle, int layerIndex, bool current)
		{
			return AnimatorControllerPlayable.GetAnimatorClipInfoCountInternalDelegateField(ref handle, layerIndex, current);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000BC40 File Offset: 0x00009E40
		public static Il2CppStructArray<AnimatorClipInfo> GetNextAnimatorClipInfoInternal(ref PlayableHandle handle, int layerIndex)
		{
			IntPtr intPtr = AnimatorControllerPlayable.GetNextAnimatorClipInfoInternalDelegateField(ref handle, layerIndex);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AnimatorClipInfo>>(intPtr2) : null;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000BC68 File Offset: 0x00009E68
		public static string ResolveHashInternal(ref PlayableHandle handle, int hash)
		{
			IntPtr intPtr = AnimatorControllerPlayable.ResolveHashInternalDelegateField(ref handle, hash);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x000043AD File Offset: 0x000025AD
		public static bool IsInTransitionInternal(ref PlayableHandle handle, int layerIndex)
		{
			return AnimatorControllerPlayable.IsInTransitionInternalDelegateField(ref handle, layerIndex);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000BC88 File Offset: 0x00009E88
		public static Il2CppReferenceArray<AnimatorControllerParameter> GetParametersArrayInternal(ref PlayableHandle handle)
		{
			IntPtr intPtr = AnimatorControllerPlayable.GetParametersArrayInternalDelegateField(ref handle);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AnimatorControllerParameter>>(intPtr2) : null;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x000043BB File Offset: 0x000025BB
		public static int GetParameterCountInternal(ref PlayableHandle handle)
		{
			return AnimatorControllerPlayable.GetParameterCountInternalDelegateField(ref handle);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x000043C8 File Offset: 0x000025C8
		public static int StringToHash(string name)
		{
			return AnimatorControllerPlayable.StringToHashDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x000043DA File Offset: 0x000025DA
		public static void CrossFadeInFixedTimeInternal(ref PlayableHandle handle, int stateNameHash, float transitionDuration, int layer, float fixedTime)
		{
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternalDelegateField(ref handle, stateNameHash, transitionDuration, layer, fixedTime);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x000043EC File Offset: 0x000025EC
		public static void CrossFadeInternal(ref PlayableHandle handle, int stateNameHash, float transitionDuration, int layer, float normalizedTime)
		{
			AnimatorControllerPlayable.CrossFadeInternalDelegateField(ref handle, stateNameHash, transitionDuration, layer, normalizedTime);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x000043FE File Offset: 0x000025FE
		public static void PlayInFixedTimeInternal(ref PlayableHandle handle, int stateNameHash, int layer, float fixedTime)
		{
			AnimatorControllerPlayable.PlayInFixedTimeInternalDelegateField(ref handle, stateNameHash, layer, fixedTime);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000440E File Offset: 0x0000260E
		public static void PlayInternal(ref PlayableHandle handle, int stateNameHash, int layer, float normalizedTime)
		{
			AnimatorControllerPlayable.PlayInternalDelegateField(ref handle, stateNameHash, layer, normalizedTime);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000441E File Offset: 0x0000261E
		public static bool HasStateInternal(ref PlayableHandle handle, int layerIndex, int stateID)
		{
			return AnimatorControllerPlayable.HasStateInternalDelegateField(ref handle, layerIndex, stateID);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000442D File Offset: 0x0000262D
		public static void SetFloatString(ref PlayableHandle handle, string name, float value)
		{
			AnimatorControllerPlayable.SetFloatStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name), value);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00004441 File Offset: 0x00002641
		public static void SetFloatID(ref PlayableHandle handle, int id, float value)
		{
			AnimatorControllerPlayable.SetFloatIDDelegateField(ref handle, id, value);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00004450 File Offset: 0x00002650
		public static float GetFloatString(ref PlayableHandle handle, string name)
		{
			return AnimatorControllerPlayable.GetFloatStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00004463 File Offset: 0x00002663
		public static float GetFloatID(ref PlayableHandle handle, int id)
		{
			return AnimatorControllerPlayable.GetFloatIDDelegateField(ref handle, id);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00004471 File Offset: 0x00002671
		public static void SetBoolString(ref PlayableHandle handle, string name, bool value)
		{
			AnimatorControllerPlayable.SetBoolStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name), value);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00004485 File Offset: 0x00002685
		public static void SetBoolID(ref PlayableHandle handle, int id, bool value)
		{
			AnimatorControllerPlayable.SetBoolIDDelegateField(ref handle, id, value);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00004494 File Offset: 0x00002694
		public static bool GetBoolString(ref PlayableHandle handle, string name)
		{
			return AnimatorControllerPlayable.GetBoolStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060003CD RID: 973 RVA: 0x000044A7 File Offset: 0x000026A7
		public static bool GetBoolID(ref PlayableHandle handle, int id)
		{
			return AnimatorControllerPlayable.GetBoolIDDelegateField(ref handle, id);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x000044B5 File Offset: 0x000026B5
		public static void SetIntegerString(ref PlayableHandle handle, string name, int value)
		{
			AnimatorControllerPlayable.SetIntegerStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name), value);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x000044C9 File Offset: 0x000026C9
		public static void SetIntegerID(ref PlayableHandle handle, int id, int value)
		{
			AnimatorControllerPlayable.SetIntegerIDDelegateField(ref handle, id, value);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x000044D8 File Offset: 0x000026D8
		public static int GetIntegerString(ref PlayableHandle handle, string name)
		{
			return AnimatorControllerPlayable.GetIntegerStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x000044EB File Offset: 0x000026EB
		public static int GetIntegerID(ref PlayableHandle handle, int id)
		{
			return AnimatorControllerPlayable.GetIntegerIDDelegateField(ref handle, id);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x000044F9 File Offset: 0x000026F9
		public static void SetTriggerString(ref PlayableHandle handle, string name)
		{
			AnimatorControllerPlayable.SetTriggerStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000450C File Offset: 0x0000270C
		public static void SetTriggerID(ref PlayableHandle handle, int id)
		{
			AnimatorControllerPlayable.SetTriggerIDDelegateField(ref handle, id);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000451A File Offset: 0x0000271A
		public static void ResetTriggerString(ref PlayableHandle handle, string name)
		{
			AnimatorControllerPlayable.ResetTriggerStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000452D File Offset: 0x0000272D
		public static void ResetTriggerID(ref PlayableHandle handle, int id)
		{
			AnimatorControllerPlayable.ResetTriggerIDDelegateField(ref handle, id);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000453B File Offset: 0x0000273B
		public static bool IsParameterControlledByCurveString(ref PlayableHandle handle, string name)
		{
			return AnimatorControllerPlayable.IsParameterControlledByCurveStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000454E File Offset: 0x0000274E
		public static bool IsParameterControlledByCurveID(ref PlayableHandle handle, int id)
		{
			return AnimatorControllerPlayable.IsParameterControlledByCurveIDDelegateField(ref handle, id);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000455C File Offset: 0x0000275C
		public static bool CreateHandleInternal_Injected(ref PlayableGraph graph, RuntimeAnimatorController controller, ref PlayableHandle handle)
		{
			return AnimatorControllerPlayable.CreateHandleInternal_InjectedDelegateField(ref graph, IL2CPP.Il2CppObjectBaseToPtr(controller), ref handle);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00004570 File Offset: 0x00002770
		public static void GetCurrentAnimatorStateInfoInternal_Injected(ref PlayableHandle handle, int layerIndex, out AnimatorStateInfo ret)
		{
			AnimatorControllerPlayable.GetCurrentAnimatorStateInfoInternal_InjectedDelegateField(ref handle, layerIndex, out ret);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0000457F File Offset: 0x0000277F
		public static void GetNextAnimatorStateInfoInternal_Injected(ref PlayableHandle handle, int layerIndex, out AnimatorStateInfo ret)
		{
			AnimatorControllerPlayable.GetNextAnimatorStateInfoInternal_InjectedDelegateField(ref handle, layerIndex, out ret);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000458E File Offset: 0x0000278E
		public static void GetAnimatorTransitionInfoInternal_Injected(ref PlayableHandle handle, int layerIndex, out AnimatorTransitionInfo ret)
		{
			AnimatorControllerPlayable.GetAnimatorTransitionInfoInternal_InjectedDelegateField(ref handle, layerIndex, out ret);
		}

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_SetHandle_Public_Void_PlayableHandle_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimatorControllerPlayable_0;

		// Token: 0x040001E0 RID: 480
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x040001E1 RID: 481
		private static readonly AnimatorControllerPlayable.GetAnimatorClipInfoInternalDelegate GetAnimatorClipInfoInternalDelegateField;

		// Token: 0x040001E2 RID: 482
		private static readonly AnimatorControllerPlayable.GetAnimatorControllerInternalDelegate GetAnimatorControllerInternalDelegateField;

		// Token: 0x040001E3 RID: 483
		private static readonly AnimatorControllerPlayable.GetLayerCountInternalDelegate GetLayerCountInternalDelegateField;

		// Token: 0x040001E4 RID: 484
		private static readonly AnimatorControllerPlayable.GetLayerNameInternalDelegate GetLayerNameInternalDelegateField;

		// Token: 0x040001E5 RID: 485
		private static readonly AnimatorControllerPlayable.GetLayerIndexInternalDelegate GetLayerIndexInternalDelegateField;

		// Token: 0x040001E6 RID: 486
		private static readonly AnimatorControllerPlayable.GetLayerWeightInternalDelegate GetLayerWeightInternalDelegateField;

		// Token: 0x040001E7 RID: 487
		private static readonly AnimatorControllerPlayable.SetLayerWeightInternalDelegate SetLayerWeightInternalDelegateField;

		// Token: 0x040001E8 RID: 488
		private static readonly AnimatorControllerPlayable.GetCurrentAnimatorClipInfoInternalDelegate GetCurrentAnimatorClipInfoInternalDelegateField;

		// Token: 0x040001E9 RID: 489
		private static readonly AnimatorControllerPlayable.GetAnimatorClipInfoCountInternalDelegate GetAnimatorClipInfoCountInternalDelegateField;

		// Token: 0x040001EA RID: 490
		private static readonly AnimatorControllerPlayable.GetNextAnimatorClipInfoInternalDelegate GetNextAnimatorClipInfoInternalDelegateField;

		// Token: 0x040001EB RID: 491
		private static readonly AnimatorControllerPlayable.ResolveHashInternalDelegate ResolveHashInternalDelegateField;

		// Token: 0x040001EC RID: 492
		private static readonly AnimatorControllerPlayable.IsInTransitionInternalDelegate IsInTransitionInternalDelegateField;

		// Token: 0x040001ED RID: 493
		private static readonly AnimatorControllerPlayable.GetParametersArrayInternalDelegate GetParametersArrayInternalDelegateField;

		// Token: 0x040001EE RID: 494
		private static readonly AnimatorControllerPlayable.GetParameterCountInternalDelegate GetParameterCountInternalDelegateField;

		// Token: 0x040001EF RID: 495
		private static readonly AnimatorControllerPlayable.StringToHashDelegate StringToHashDelegateField;

		// Token: 0x040001F0 RID: 496
		private static readonly AnimatorControllerPlayable.CrossFadeInFixedTimeInternalDelegate CrossFadeInFixedTimeInternalDelegateField;

		// Token: 0x040001F1 RID: 497
		private static readonly AnimatorControllerPlayable.CrossFadeInternalDelegate CrossFadeInternalDelegateField;

		// Token: 0x040001F2 RID: 498
		private static readonly AnimatorControllerPlayable.PlayInFixedTimeInternalDelegate PlayInFixedTimeInternalDelegateField;

		// Token: 0x040001F3 RID: 499
		private static readonly AnimatorControllerPlayable.PlayInternalDelegate PlayInternalDelegateField;

		// Token: 0x040001F4 RID: 500
		private static readonly AnimatorControllerPlayable.HasStateInternalDelegate HasStateInternalDelegateField;

		// Token: 0x040001F5 RID: 501
		private static readonly AnimatorControllerPlayable.SetFloatStringDelegate SetFloatStringDelegateField;

		// Token: 0x040001F6 RID: 502
		private static readonly AnimatorControllerPlayable.SetFloatIDDelegate SetFloatIDDelegateField;

		// Token: 0x040001F7 RID: 503
		private static readonly AnimatorControllerPlayable.GetFloatStringDelegate GetFloatStringDelegateField;

		// Token: 0x040001F8 RID: 504
		private static readonly AnimatorControllerPlayable.GetFloatIDDelegate GetFloatIDDelegateField;

		// Token: 0x040001F9 RID: 505
		private static readonly AnimatorControllerPlayable.SetBoolStringDelegate SetBoolStringDelegateField;

		// Token: 0x040001FA RID: 506
		private static readonly AnimatorControllerPlayable.SetBoolIDDelegate SetBoolIDDelegateField;

		// Token: 0x040001FB RID: 507
		private static readonly AnimatorControllerPlayable.GetBoolStringDelegate GetBoolStringDelegateField;

		// Token: 0x040001FC RID: 508
		private static readonly AnimatorControllerPlayable.GetBoolIDDelegate GetBoolIDDelegateField;

		// Token: 0x040001FD RID: 509
		private static readonly AnimatorControllerPlayable.SetIntegerStringDelegate SetIntegerStringDelegateField;

		// Token: 0x040001FE RID: 510
		private static readonly AnimatorControllerPlayable.SetIntegerIDDelegate SetIntegerIDDelegateField;

		// Token: 0x040001FF RID: 511
		private static readonly AnimatorControllerPlayable.GetIntegerStringDelegate GetIntegerStringDelegateField;

		// Token: 0x04000200 RID: 512
		private static readonly AnimatorControllerPlayable.GetIntegerIDDelegate GetIntegerIDDelegateField;

		// Token: 0x04000201 RID: 513
		private static readonly AnimatorControllerPlayable.SetTriggerStringDelegate SetTriggerStringDelegateField;

		// Token: 0x04000202 RID: 514
		private static readonly AnimatorControllerPlayable.SetTriggerIDDelegate SetTriggerIDDelegateField;

		// Token: 0x04000203 RID: 515
		private static readonly AnimatorControllerPlayable.ResetTriggerStringDelegate ResetTriggerStringDelegateField;

		// Token: 0x04000204 RID: 516
		private static readonly AnimatorControllerPlayable.ResetTriggerIDDelegate ResetTriggerIDDelegateField;

		// Token: 0x04000205 RID: 517
		private static readonly AnimatorControllerPlayable.IsParameterControlledByCurveStringDelegate IsParameterControlledByCurveStringDelegateField;

		// Token: 0x04000206 RID: 518
		private static readonly AnimatorControllerPlayable.IsParameterControlledByCurveIDDelegate IsParameterControlledByCurveIDDelegateField;

		// Token: 0x04000207 RID: 519
		private static readonly AnimatorControllerPlayable.CreateHandleInternal_InjectedDelegate CreateHandleInternal_InjectedDelegateField;

		// Token: 0x04000208 RID: 520
		private static readonly AnimatorControllerPlayable.GetCurrentAnimatorStateInfoInternal_InjectedDelegate GetCurrentAnimatorStateInfoInternal_InjectedDelegateField;

		// Token: 0x04000209 RID: 521
		private static readonly AnimatorControllerPlayable.GetNextAnimatorStateInfoInternal_InjectedDelegate GetNextAnimatorStateInfoInternal_InjectedDelegateField;

		// Token: 0x0400020A RID: 522
		private static readonly AnimatorControllerPlayable.GetAnimatorTransitionInfoInternal_InjectedDelegate GetAnimatorTransitionInfoInternal_InjectedDelegateField;

		// Token: 0x02000185 RID: 389
		// (Invoke) Token: 0x060007B0 RID: 1968
		private delegate void GetAnimatorClipInfoInternalDelegate(IntPtr handle, int layerIndex, bool isCurrent, IntPtr clips);

		// Token: 0x02000186 RID: 390
		// (Invoke) Token: 0x060007B2 RID: 1970
		private delegate IntPtr GetAnimatorControllerInternalDelegate(IntPtr handle);

		// Token: 0x02000187 RID: 391
		// (Invoke) Token: 0x060007B4 RID: 1972
		private delegate int GetLayerCountInternalDelegate(IntPtr handle);

		// Token: 0x02000188 RID: 392
		// (Invoke) Token: 0x060007B6 RID: 1974
		private delegate IntPtr GetLayerNameInternalDelegate(IntPtr handle, int layerIndex);

		// Token: 0x02000189 RID: 393
		// (Invoke) Token: 0x060007B8 RID: 1976
		private delegate int GetLayerIndexInternalDelegate(IntPtr handle, IntPtr layerName);

		// Token: 0x0200018A RID: 394
		// (Invoke) Token: 0x060007BA RID: 1978
		private delegate float GetLayerWeightInternalDelegate(IntPtr handle, int layerIndex);

		// Token: 0x0200018B RID: 395
		// (Invoke) Token: 0x060007BC RID: 1980
		private delegate void SetLayerWeightInternalDelegate(IntPtr handle, int layerIndex, float weight);

		// Token: 0x0200018C RID: 396
		// (Invoke) Token: 0x060007BE RID: 1982
		private delegate IntPtr GetCurrentAnimatorClipInfoInternalDelegate(IntPtr handle, int layerIndex);

		// Token: 0x0200018D RID: 397
		// (Invoke) Token: 0x060007C0 RID: 1984
		private delegate int GetAnimatorClipInfoCountInternalDelegate(IntPtr handle, int layerIndex, bool current);

		// Token: 0x0200018E RID: 398
		// (Invoke) Token: 0x060007C2 RID: 1986
		private delegate IntPtr GetNextAnimatorClipInfoInternalDelegate(IntPtr handle, int layerIndex);

		// Token: 0x0200018F RID: 399
		// (Invoke) Token: 0x060007C4 RID: 1988
		private delegate IntPtr ResolveHashInternalDelegate(IntPtr handle, int hash);

		// Token: 0x02000190 RID: 400
		// (Invoke) Token: 0x060007C6 RID: 1990
		private delegate bool IsInTransitionInternalDelegate(IntPtr handle, int layerIndex);

		// Token: 0x02000191 RID: 401
		// (Invoke) Token: 0x060007C8 RID: 1992
		private delegate IntPtr GetParametersArrayInternalDelegate(IntPtr handle);

		// Token: 0x02000192 RID: 402
		// (Invoke) Token: 0x060007CA RID: 1994
		private delegate int GetParameterCountInternalDelegate(IntPtr handle);

		// Token: 0x02000193 RID: 403
		// (Invoke) Token: 0x060007CC RID: 1996
		private delegate int StringToHashDelegate(IntPtr name);

		// Token: 0x02000194 RID: 404
		// (Invoke) Token: 0x060007CE RID: 1998
		private delegate void CrossFadeInFixedTimeInternalDelegate(IntPtr handle, int stateNameHash, float transitionDuration, int layer, float fixedTime);

		// Token: 0x02000195 RID: 405
		// (Invoke) Token: 0x060007D0 RID: 2000
		private delegate void CrossFadeInternalDelegate(IntPtr handle, int stateNameHash, float transitionDuration, int layer, float normalizedTime);

		// Token: 0x02000196 RID: 406
		// (Invoke) Token: 0x060007D2 RID: 2002
		private delegate void PlayInFixedTimeInternalDelegate(IntPtr handle, int stateNameHash, int layer, float fixedTime);

		// Token: 0x02000197 RID: 407
		// (Invoke) Token: 0x060007D4 RID: 2004
		private delegate void PlayInternalDelegate(IntPtr handle, int stateNameHash, int layer, float normalizedTime);

		// Token: 0x02000198 RID: 408
		// (Invoke) Token: 0x060007D6 RID: 2006
		private delegate bool HasStateInternalDelegate(IntPtr handle, int layerIndex, int stateID);

		// Token: 0x02000199 RID: 409
		// (Invoke) Token: 0x060007D8 RID: 2008
		private delegate void SetFloatStringDelegate(IntPtr handle, IntPtr name, float value);

		// Token: 0x0200019A RID: 410
		// (Invoke) Token: 0x060007DA RID: 2010
		private delegate void SetFloatIDDelegate(IntPtr handle, int id, float value);

		// Token: 0x0200019B RID: 411
		// (Invoke) Token: 0x060007DC RID: 2012
		private delegate float GetFloatStringDelegate(IntPtr handle, IntPtr name);

		// Token: 0x0200019C RID: 412
		// (Invoke) Token: 0x060007DE RID: 2014
		private delegate float GetFloatIDDelegate(IntPtr handle, int id);

		// Token: 0x0200019D RID: 413
		// (Invoke) Token: 0x060007E0 RID: 2016
		private delegate void SetBoolStringDelegate(IntPtr handle, IntPtr name, bool value);

		// Token: 0x0200019E RID: 414
		// (Invoke) Token: 0x060007E2 RID: 2018
		private delegate void SetBoolIDDelegate(IntPtr handle, int id, bool value);

		// Token: 0x0200019F RID: 415
		// (Invoke) Token: 0x060007E4 RID: 2020
		private delegate bool GetBoolStringDelegate(IntPtr handle, IntPtr name);

		// Token: 0x020001A0 RID: 416
		// (Invoke) Token: 0x060007E6 RID: 2022
		private delegate bool GetBoolIDDelegate(IntPtr handle, int id);

		// Token: 0x020001A1 RID: 417
		// (Invoke) Token: 0x060007E8 RID: 2024
		private delegate void SetIntegerStringDelegate(IntPtr handle, IntPtr name, int value);

		// Token: 0x020001A2 RID: 418
		// (Invoke) Token: 0x060007EA RID: 2026
		private delegate void SetIntegerIDDelegate(IntPtr handle, int id, int value);

		// Token: 0x020001A3 RID: 419
		// (Invoke) Token: 0x060007EC RID: 2028
		private delegate int GetIntegerStringDelegate(IntPtr handle, IntPtr name);

		// Token: 0x020001A4 RID: 420
		// (Invoke) Token: 0x060007EE RID: 2030
		private delegate int GetIntegerIDDelegate(IntPtr handle, int id);

		// Token: 0x020001A5 RID: 421
		// (Invoke) Token: 0x060007F0 RID: 2032
		private delegate void SetTriggerStringDelegate(IntPtr handle, IntPtr name);

		// Token: 0x020001A6 RID: 422
		// (Invoke) Token: 0x060007F2 RID: 2034
		private delegate void SetTriggerIDDelegate(IntPtr handle, int id);

		// Token: 0x020001A7 RID: 423
		// (Invoke) Token: 0x060007F4 RID: 2036
		private delegate void ResetTriggerStringDelegate(IntPtr handle, IntPtr name);

		// Token: 0x020001A8 RID: 424
		// (Invoke) Token: 0x060007F6 RID: 2038
		private delegate void ResetTriggerIDDelegate(IntPtr handle, int id);

		// Token: 0x020001A9 RID: 425
		// (Invoke) Token: 0x060007F8 RID: 2040
		private delegate bool IsParameterControlledByCurveStringDelegate(IntPtr handle, IntPtr name);

		// Token: 0x020001AA RID: 426
		// (Invoke) Token: 0x060007FA RID: 2042
		private delegate bool IsParameterControlledByCurveIDDelegate(IntPtr handle, int id);

		// Token: 0x020001AB RID: 427
		// (Invoke) Token: 0x060007FC RID: 2044
		private delegate bool CreateHandleInternal_InjectedDelegate(IntPtr graph, IntPtr controller, IntPtr handle);

		// Token: 0x020001AC RID: 428
		// (Invoke) Token: 0x060007FE RID: 2046
		private delegate void GetCurrentAnimatorStateInfoInternal_InjectedDelegate(IntPtr handle, int layerIndex, [Out] IntPtr ret);

		// Token: 0x020001AD RID: 429
		// (Invoke) Token: 0x06000800 RID: 2048
		private delegate void GetNextAnimatorStateInfoInternal_InjectedDelegate(IntPtr handle, int layerIndex, [Out] IntPtr ret);

		// Token: 0x020001AE RID: 430
		// (Invoke) Token: 0x06000802 RID: 2050
		private delegate void GetAnimatorTransitionInfoInternal_InjectedDelegate(IntPtr handle, int layerIndex, [Out] IntPtr ret);
	}
}
