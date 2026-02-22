using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine.VFX
{
	// Token: 0x0200000A RID: 10
	public class VisualEffect : Behaviour
	{
		// Token: 0x060000BF RID: 191 RVA: 0x00004468 File Offset: 0x00002668
		// Note: this type is marked as 'beforefieldinit'.
		static VisualEffect()
		{
			Il2CppClassPointerStore<VisualEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VisualEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualEffect>.NativeClassPtr);
			VisualEffect.NativeFieldInfoPtr_m_cachedEventAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffect>.NativeClassPtr, "m_cachedEventAttribute");
			VisualEffect.NativeFieldInfoPtr_outputEventReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffect>.NativeClassPtr, "outputEventReceived");
			VisualEffect.NativeMethodInfoPtr_get_visualEffectAsset_Public_get_VisualEffectAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffect>.NativeClassPtr, 100663322);
			VisualEffect.NativeMethodInfoPtr_CreateVFXEventAttribute_Public_VFXEventAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffect>.NativeClassPtr, 100663323);
			VisualEffect.NativeMethodInfoPtr_InvokeGetCachedEventAttributeForOutputEvent_Internal_Private_Static_VFXEventAttribute_VisualEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffect>.NativeClassPtr, 100663324);
			VisualEffect.NativeMethodInfoPtr_InvokeOutputEventReceived_Internal_Private_Static_Void_VisualEffect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffect>.NativeClassPtr, 100663325);
			VisualEffect.get_pauseDelegateField = IL2CPP.ResolveICall<VisualEffect.get_pauseDelegate>("UnityEngine.VFX.VisualEffect::get_pause");
			VisualEffect.set_pauseDelegateField = IL2CPP.ResolveICall<VisualEffect.set_pauseDelegate>("UnityEngine.VFX.VisualEffect::set_pause");
			VisualEffect.get_playRateDelegateField = IL2CPP.ResolveICall<VisualEffect.get_playRateDelegate>("UnityEngine.VFX.VisualEffect::get_playRate");
			VisualEffect.set_playRateDelegateField = IL2CPP.ResolveICall<VisualEffect.set_playRateDelegate>("UnityEngine.VFX.VisualEffect::set_playRate");
			VisualEffect.get_startSeedDelegateField = IL2CPP.ResolveICall<VisualEffect.get_startSeedDelegate>("UnityEngine.VFX.VisualEffect::get_startSeed");
			VisualEffect.set_startSeedDelegateField = IL2CPP.ResolveICall<VisualEffect.set_startSeedDelegate>("UnityEngine.VFX.VisualEffect::set_startSeed");
			VisualEffect.get_resetSeedOnPlayDelegateField = IL2CPP.ResolveICall<VisualEffect.get_resetSeedOnPlayDelegate>("UnityEngine.VFX.VisualEffect::get_resetSeedOnPlay");
			VisualEffect.set_resetSeedOnPlayDelegateField = IL2CPP.ResolveICall<VisualEffect.set_resetSeedOnPlayDelegate>("UnityEngine.VFX.VisualEffect::set_resetSeedOnPlay");
			VisualEffect.get_initialEventIDDelegateField = IL2CPP.ResolveICall<VisualEffect.get_initialEventIDDelegate>("UnityEngine.VFX.VisualEffect::get_initialEventID");
			VisualEffect.set_initialEventIDDelegateField = IL2CPP.ResolveICall<VisualEffect.set_initialEventIDDelegate>("UnityEngine.VFX.VisualEffect::set_initialEventID");
			VisualEffect.get_initialEventNameDelegateField = IL2CPP.ResolveICall<VisualEffect.get_initialEventNameDelegate>("UnityEngine.VFX.VisualEffect::get_initialEventName");
			VisualEffect.set_initialEventNameDelegateField = IL2CPP.ResolveICall<VisualEffect.set_initialEventNameDelegate>("UnityEngine.VFX.VisualEffect::set_initialEventName");
			VisualEffect.get_culledDelegateField = IL2CPP.ResolveICall<VisualEffect.get_culledDelegate>("UnityEngine.VFX.VisualEffect::get_culled");
			VisualEffect.set_visualEffectAssetDelegateField = IL2CPP.ResolveICall<VisualEffect.set_visualEffectAssetDelegate>("UnityEngine.VFX.VisualEffect::set_visualEffectAsset");
			VisualEffect.SendEventFromScriptDelegateField = IL2CPP.ResolveICall<VisualEffect.SendEventFromScriptDelegate>("UnityEngine.VFX.VisualEffect::SendEventFromScript");
			VisualEffect.ReinitDelegateField = IL2CPP.ResolveICall<VisualEffect.ReinitDelegate>("UnityEngine.VFX.VisualEffect::Reinit");
			VisualEffect.AdvanceOneFrameDelegateField = IL2CPP.ResolveICall<VisualEffect.AdvanceOneFrameDelegate>("UnityEngine.VFX.VisualEffect::AdvanceOneFrame");
			VisualEffect.ResetOverrideDelegateField = IL2CPP.ResolveICall<VisualEffect.ResetOverrideDelegate>("UnityEngine.VFX.VisualEffect::ResetOverride");
			VisualEffect.GetTextureDimensionDelegateField = IL2CPP.ResolveICall<VisualEffect.GetTextureDimensionDelegate>("UnityEngine.VFX.VisualEffect::GetTextureDimension");
			VisualEffect.HasBoolDelegateField = IL2CPP.ResolveICall<VisualEffect.HasBoolDelegate>("UnityEngine.VFX.VisualEffect::HasBool");
			VisualEffect.HasIntDelegateField = IL2CPP.ResolveICall<VisualEffect.HasIntDelegate>("UnityEngine.VFX.VisualEffect::HasInt");
			VisualEffect.HasUIntDelegateField = IL2CPP.ResolveICall<VisualEffect.HasUIntDelegate>("UnityEngine.VFX.VisualEffect::HasUInt");
			VisualEffect.HasFloatDelegateField = IL2CPP.ResolveICall<VisualEffect.HasFloatDelegate>("UnityEngine.VFX.VisualEffect::HasFloat");
			VisualEffect.HasVector2DelegateField = IL2CPP.ResolveICall<VisualEffect.HasVector2Delegate>("UnityEngine.VFX.VisualEffect::HasVector2");
			VisualEffect.HasVector3DelegateField = IL2CPP.ResolveICall<VisualEffect.HasVector3Delegate>("UnityEngine.VFX.VisualEffect::HasVector3");
			VisualEffect.HasVector4DelegateField = IL2CPP.ResolveICall<VisualEffect.HasVector4Delegate>("UnityEngine.VFX.VisualEffect::HasVector4");
			VisualEffect.HasMatrix4x4DelegateField = IL2CPP.ResolveICall<VisualEffect.HasMatrix4x4Delegate>("UnityEngine.VFX.VisualEffect::HasMatrix4x4");
			VisualEffect.HasTextureDelegateField = IL2CPP.ResolveICall<VisualEffect.HasTextureDelegate>("UnityEngine.VFX.VisualEffect::HasTexture");
			VisualEffect.HasAnimationCurveDelegateField = IL2CPP.ResolveICall<VisualEffect.HasAnimationCurveDelegate>("UnityEngine.VFX.VisualEffect::HasAnimationCurve");
			VisualEffect.HasGradientDelegateField = IL2CPP.ResolveICall<VisualEffect.HasGradientDelegate>("UnityEngine.VFX.VisualEffect::HasGradient");
			VisualEffect.HasMeshDelegateField = IL2CPP.ResolveICall<VisualEffect.HasMeshDelegate>("UnityEngine.VFX.VisualEffect::HasMesh");
			VisualEffect.HasSkinnedMeshRendererDelegateField = IL2CPP.ResolveICall<VisualEffect.HasSkinnedMeshRendererDelegate>("UnityEngine.VFX.VisualEffect::HasSkinnedMeshRenderer");
			VisualEffect.SetBoolDelegateField = IL2CPP.ResolveICall<VisualEffect.SetBoolDelegate>("UnityEngine.VFX.VisualEffect::SetBool");
			VisualEffect.SetIntDelegateField = IL2CPP.ResolveICall<VisualEffect.SetIntDelegate>("UnityEngine.VFX.VisualEffect::SetInt");
			VisualEffect.SetUIntDelegateField = IL2CPP.ResolveICall<VisualEffect.SetUIntDelegate>("UnityEngine.VFX.VisualEffect::SetUInt");
			VisualEffect.SetFloatDelegateField = IL2CPP.ResolveICall<VisualEffect.SetFloatDelegate>("UnityEngine.VFX.VisualEffect::SetFloat");
			VisualEffect.SetTextureDelegateField = IL2CPP.ResolveICall<VisualEffect.SetTextureDelegate>("UnityEngine.VFX.VisualEffect::SetTexture");
			VisualEffect.SetAnimationCurveDelegateField = IL2CPP.ResolveICall<VisualEffect.SetAnimationCurveDelegate>("UnityEngine.VFX.VisualEffect::SetAnimationCurve");
			VisualEffect.SetGradientDelegateField = IL2CPP.ResolveICall<VisualEffect.SetGradientDelegate>("UnityEngine.VFX.VisualEffect::SetGradient");
			VisualEffect.SetMeshDelegateField = IL2CPP.ResolveICall<VisualEffect.SetMeshDelegate>("UnityEngine.VFX.VisualEffect::SetMesh");
			VisualEffect.SetSkinnedMeshRendererDelegateField = IL2CPP.ResolveICall<VisualEffect.SetSkinnedMeshRendererDelegate>("UnityEngine.VFX.VisualEffect::SetSkinnedMeshRenderer");
			VisualEffect.GetBoolDelegateField = IL2CPP.ResolveICall<VisualEffect.GetBoolDelegate>("UnityEngine.VFX.VisualEffect::GetBool");
			VisualEffect.GetIntDelegateField = IL2CPP.ResolveICall<VisualEffect.GetIntDelegate>("UnityEngine.VFX.VisualEffect::GetInt");
			VisualEffect.GetUIntDelegateField = IL2CPP.ResolveICall<VisualEffect.GetUIntDelegate>("UnityEngine.VFX.VisualEffect::GetUInt");
			VisualEffect.GetFloatDelegateField = IL2CPP.ResolveICall<VisualEffect.GetFloatDelegate>("UnityEngine.VFX.VisualEffect::GetFloat");
			VisualEffect.GetTextureDelegateField = IL2CPP.ResolveICall<VisualEffect.GetTextureDelegate>("UnityEngine.VFX.VisualEffect::GetTexture");
			VisualEffect.GetMeshDelegateField = IL2CPP.ResolveICall<VisualEffect.GetMeshDelegate>("UnityEngine.VFX.VisualEffect::GetMesh");
			VisualEffect.GetSkinnedMeshRendererDelegateField = IL2CPP.ResolveICall<VisualEffect.GetSkinnedMeshRendererDelegate>("UnityEngine.VFX.VisualEffect::GetSkinnedMeshRenderer");
			VisualEffect.Internal_GetGradientDelegateField = IL2CPP.ResolveICall<VisualEffect.Internal_GetGradientDelegate>("UnityEngine.VFX.VisualEffect::Internal_GetGradient");
			VisualEffect.Internal_GetAnimationCurveDelegateField = IL2CPP.ResolveICall<VisualEffect.Internal_GetAnimationCurveDelegate>("UnityEngine.VFX.VisualEffect::Internal_GetAnimationCurve");
			VisualEffect.HasSystemDelegateField = IL2CPP.ResolveICall<VisualEffect.HasSystemDelegate>("UnityEngine.VFX.VisualEffect::HasSystem");
			VisualEffect.GetSpawnSystemInfoDelegateField = IL2CPP.ResolveICall<VisualEffect.GetSpawnSystemInfoDelegate>("UnityEngine.VFX.VisualEffect::GetSpawnSystemInfo");
			VisualEffect.GetSystemNamesDelegateField = IL2CPP.ResolveICall<VisualEffect.GetSystemNamesDelegate>("UnityEngine.VFX.VisualEffect::GetSystemNames");
			VisualEffect.GetParticleSystemNamesDelegateField = IL2CPP.ResolveICall<VisualEffect.GetParticleSystemNamesDelegate>("UnityEngine.VFX.VisualEffect::GetParticleSystemNames");
			VisualEffect.GetOutputEventNamesDelegateField = IL2CPP.ResolveICall<VisualEffect.GetOutputEventNamesDelegate>("UnityEngine.VFX.VisualEffect::GetOutputEventNames");
			VisualEffect.GetSpawnSystemNamesDelegateField = IL2CPP.ResolveICall<VisualEffect.GetSpawnSystemNamesDelegate>("UnityEngine.VFX.VisualEffect::GetSpawnSystemNames");
			VisualEffect.get_aliveParticleCountDelegateField = IL2CPP.ResolveICall<VisualEffect.get_aliveParticleCountDelegate>("UnityEngine.VFX.VisualEffect::get_aliveParticleCount");
			VisualEffect.SimulateDelegateField = IL2CPP.ResolveICall<VisualEffect.SimulateDelegate>("UnityEngine.VFX.VisualEffect::Simulate");
			VisualEffect.SetVector2_InjectedDelegateField = IL2CPP.ResolveICall<VisualEffect.SetVector2_InjectedDelegate>("UnityEngine.VFX.VisualEffect::SetVector2_Injected");
			VisualEffect.SetVector3_InjectedDelegateField = IL2CPP.ResolveICall<VisualEffect.SetVector3_InjectedDelegate>("UnityEngine.VFX.VisualEffect::SetVector3_Injected");
			VisualEffect.SetVector4_InjectedDelegateField = IL2CPP.ResolveICall<VisualEffect.SetVector4_InjectedDelegate>("UnityEngine.VFX.VisualEffect::SetVector4_Injected");
			VisualEffect.SetMatrix4x4_InjectedDelegateField = IL2CPP.ResolveICall<VisualEffect.SetMatrix4x4_InjectedDelegate>("UnityEngine.VFX.VisualEffect::SetMatrix4x4_Injected");
			VisualEffect.GetVector2_InjectedDelegateField = IL2CPP.ResolveICall<VisualEffect.GetVector2_InjectedDelegate>("UnityEngine.VFX.VisualEffect::GetVector2_Injected");
			VisualEffect.GetVector3_InjectedDelegateField = IL2CPP.ResolveICall<VisualEffect.GetVector3_InjectedDelegate>("UnityEngine.VFX.VisualEffect::GetVector3_Injected");
			VisualEffect.GetVector4_InjectedDelegateField = IL2CPP.ResolveICall<VisualEffect.GetVector4_InjectedDelegate>("UnityEngine.VFX.VisualEffect::GetVector4_Injected");
			VisualEffect.GetMatrix4x4_InjectedDelegateField = IL2CPP.ResolveICall<VisualEffect.GetMatrix4x4_InjectedDelegate>("UnityEngine.VFX.VisualEffect::GetMatrix4x4_Injected");
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x000048F0 File Offset: 0x00002AF0
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x000028E6 File Offset: 0x00000AE6
		public unsafe VisualEffectAsset visualEffectAsset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158186, XrefRangeEnd = 158188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualEffect.NativeMethodInfoPtr_get_visualEffectAsset_Public_get_VisualEffectAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualEffectAsset>(intPtr3) : null;
			}
			set
			{
				VisualEffect.set_visualEffectAssetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00004930 File Offset: 0x00002B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158188, XrefRangeEnd = 158204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VFXEventAttribute CreateVFXEventAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualEffect.NativeMethodInfoPtr_CreateVFXEventAttribute_Public_VFXEventAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VFXEventAttribute>(intPtr3) : null;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00004970 File Offset: 0x00002B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158204, XrefRangeEnd = 158220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VFXEventAttribute InvokeGetCachedEventAttributeForOutputEvent_Internal(VisualEffect source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualEffect.NativeMethodInfoPtr_InvokeGetCachedEventAttributeForOutputEvent_Internal_Private_Static_VFXEventAttribute_VisualEffect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VFXEventAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000049B4 File Offset: 0x00002BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158220, XrefRangeEnd = 158223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOutputEventReceived_Internal(VisualEffect source, int eventNameId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventNameId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualEffect.NativeMethodInfoPtr_InvokeOutputEventReceived_Internal_Private_Static_Void_VisualEffect_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000027BC File Offset: 0x000009BC
		public VisualEffect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x000049F8 File Offset: 0x00002BF8
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x000027C5 File Offset: 0x000009C5
		public unsafe VFXEventAttribute m_cachedEventAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualEffect.NativeFieldInfoPtr_m_cachedEventAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VFXEventAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualEffect.NativeFieldInfoPtr_m_cachedEventAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00004A28 File Offset: 0x00002C28
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x000027E4 File Offset: 0x000009E4
		public unsafe Action<VFXOutputEventArgs> outputEventReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualEffect.NativeFieldInfoPtr_outputEventReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<VFXOutputEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualEffect.NativeFieldInfoPtr_outputEventReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00002803 File Offset: 0x00000A03
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00002815 File Offset: 0x00000A15
		public bool pause
		{
			get
			{
				return VisualEffect.get_pauseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VisualEffect.set_pauseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00002828 File Offset: 0x00000A28
		// (set) Token: 0x060000CC RID: 204 RVA: 0x0000283A File Offset: 0x00000A3A
		public float playRate
		{
			get
			{
				return VisualEffect.get_playRateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VisualEffect.set_playRateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000CD RID: 205 RVA: 0x0000284D File Offset: 0x00000A4D
		// (set) Token: 0x060000CE RID: 206 RVA: 0x0000285F File Offset: 0x00000A5F
		public uint startSeed
		{
			get
			{
				return VisualEffect.get_startSeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VisualEffect.set_startSeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00002872 File Offset: 0x00000A72
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00002884 File Offset: 0x00000A84
		public bool resetSeedOnPlay
		{
			get
			{
				return VisualEffect.get_resetSeedOnPlayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VisualEffect.set_resetSeedOnPlayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00002897 File Offset: 0x00000A97
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x000028A9 File Offset: 0x00000AA9
		public int initialEventID
		{
			get
			{
				return VisualEffect.get_initialEventIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VisualEffect.set_initialEventIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00004A58 File Offset: 0x00002C58
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x000028BC File Offset: 0x00000ABC
		public string initialEventName
		{
			get
			{
				IntPtr intPtr = VisualEffect.get_initialEventNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				VisualEffect.set_initialEventNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x000028D4 File Offset: 0x00000AD4
		public bool culled
		{
			get
			{
				return VisualEffect.get_culledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00004A7C File Offset: 0x00002C7C
		public void CheckValidVFXEventAttribute(VFXEventAttribute eventAttribute)
		{
			bool flag = eventAttribute != null && eventAttribute.vfxAsset != this.visualEffectAsset;
			if (flag)
			{
				throw new InvalidOperationException("Invalid VFXEventAttribute provided to VisualEffect. It has been created with another VisualEffectAsset. Use CreateVFXEventAttribute.");
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000028FE File Offset: 0x00000AFE
		public void SendEventFromScript(int eventNameID, VFXEventAttribute eventAttribute)
		{
			VisualEffect.SendEventFromScriptDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), eventNameID, IL2CPP.Il2CppObjectBaseToPtr(eventAttribute));
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002917 File Offset: 0x00000B17
		public void SendEvent(int eventNameID, VFXEventAttribute eventAttribute)
		{
			this.CheckValidVFXEventAttribute(eventAttribute);
			this.SendEventFromScript(eventNameID, eventAttribute);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000292B File Offset: 0x00000B2B
		public void SendEvent(string eventName, VFXEventAttribute eventAttribute)
		{
			this.SendEvent(Shader.PropertyToID(eventName), eventAttribute);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000293C File Offset: 0x00000B3C
		public void SendEvent(int eventNameID)
		{
			this.SendEventFromScript(eventNameID, null);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002948 File Offset: 0x00000B48
		public void SendEvent(string eventName)
		{
			this.SendEvent(Shader.PropertyToID(eventName), null);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002959 File Offset: 0x00000B59
		public void Play(VFXEventAttribute eventAttribute)
		{
			this.SendEvent(VisualEffectAsset.PlayEventID, eventAttribute);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002969 File Offset: 0x00000B69
		public void Play()
		{
			this.SendEvent(VisualEffectAsset.PlayEventID);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002978 File Offset: 0x00000B78
		public void Stop(VFXEventAttribute eventAttribute)
		{
			this.SendEvent(VisualEffectAsset.StopEventID, eventAttribute);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002988 File Offset: 0x00000B88
		public void Stop()
		{
			this.SendEvent(VisualEffectAsset.StopEventID);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002997 File Offset: 0x00000B97
		public void Reinit()
		{
			VisualEffect.ReinitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000029A9 File Offset: 0x00000BA9
		public void AdvanceOneFrame()
		{
			VisualEffect.AdvanceOneFrameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000029BB File Offset: 0x00000BBB
		public void ResetOverride(int nameID)
		{
			VisualEffect.ResetOverrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000029CE File Offset: 0x00000BCE
		public TextureDimension GetTextureDimension(int nameID)
		{
			return VisualEffect.GetTextureDimensionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000029E1 File Offset: 0x00000BE1
		public bool HasBool(int nameID)
		{
			return VisualEffect.HasBoolDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000029F4 File Offset: 0x00000BF4
		public bool HasInt(int nameID)
		{
			return VisualEffect.HasIntDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002A07 File Offset: 0x00000C07
		public bool HasUInt(int nameID)
		{
			return VisualEffect.HasUIntDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002A1A File Offset: 0x00000C1A
		public bool HasFloat(int nameID)
		{
			return VisualEffect.HasFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002A2D File Offset: 0x00000C2D
		public bool HasVector2(int nameID)
		{
			return VisualEffect.HasVector2DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002A40 File Offset: 0x00000C40
		public bool HasVector3(int nameID)
		{
			return VisualEffect.HasVector3DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002A53 File Offset: 0x00000C53
		public bool HasVector4(int nameID)
		{
			return VisualEffect.HasVector4DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002A66 File Offset: 0x00000C66
		public bool HasMatrix4x4(int nameID)
		{
			return VisualEffect.HasMatrix4x4DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002A79 File Offset: 0x00000C79
		public bool HasTexture(int nameID)
		{
			return VisualEffect.HasTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002A8C File Offset: 0x00000C8C
		public bool HasAnimationCurve(int nameID)
		{
			return VisualEffect.HasAnimationCurveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002A9F File Offset: 0x00000C9F
		public bool HasGradient(int nameID)
		{
			return VisualEffect.HasGradientDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002AB2 File Offset: 0x00000CB2
		public bool HasMesh(int nameID)
		{
			return VisualEffect.HasMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002AC5 File Offset: 0x00000CC5
		public bool HasSkinnedMeshRenderer(int nameID)
		{
			return VisualEffect.HasSkinnedMeshRendererDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002AD8 File Offset: 0x00000CD8
		public void SetBool(int nameID, bool b)
		{
			VisualEffect.SetBoolDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, b);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002AEC File Offset: 0x00000CEC
		public void SetInt(int nameID, int i)
		{
			VisualEffect.SetIntDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, i);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002B00 File Offset: 0x00000D00
		public void SetUInt(int nameID, uint i)
		{
			VisualEffect.SetUIntDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, i);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002B14 File Offset: 0x00000D14
		public void SetFloat(int nameID, float f)
		{
			VisualEffect.SetFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, f);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002B28 File Offset: 0x00000D28
		public void SetVector2(int nameID, Vector2 v)
		{
			this.SetVector2_Injected(nameID, ref v);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002B33 File Offset: 0x00000D33
		public void SetVector3(int nameID, Vector3 v)
		{
			this.SetVector3_Injected(nameID, ref v);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002B3E File Offset: 0x00000D3E
		public void SetVector4(int nameID, Vector4 v)
		{
			this.SetVector4_Injected(nameID, ref v);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002B49 File Offset: 0x00000D49
		public void SetMatrix4x4(int nameID, Matrix4x4 v)
		{
			this.SetMatrix4x4_Injected(nameID, ref v);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002B54 File Offset: 0x00000D54
		public void SetTexture(int nameID, Texture t)
		{
			VisualEffect.SetTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(t));
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002B6D File Offset: 0x00000D6D
		public void SetAnimationCurve(int nameID, AnimationCurve c)
		{
			VisualEffect.SetAnimationCurveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(c));
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002B86 File Offset: 0x00000D86
		public void SetGradient(int nameID, Gradient g)
		{
			VisualEffect.SetGradientDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(g));
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002B9F File Offset: 0x00000D9F
		public void SetMesh(int nameID, Mesh m)
		{
			VisualEffect.SetMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(m));
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002BB8 File Offset: 0x00000DB8
		public void SetSkinnedMeshRenderer(int nameID, SkinnedMeshRenderer m)
		{
			VisualEffect.SetSkinnedMeshRendererDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(m));
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002BD1 File Offset: 0x00000DD1
		public bool GetBool(int nameID)
		{
			return VisualEffect.GetBoolDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002BE4 File Offset: 0x00000DE4
		public int GetInt(int nameID)
		{
			return VisualEffect.GetIntDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002BF7 File Offset: 0x00000DF7
		public uint GetUInt(int nameID)
		{
			return VisualEffect.GetUIntDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002C0A File Offset: 0x00000E0A
		public float GetFloat(int nameID)
		{
			return VisualEffect.GetFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00004AB4 File Offset: 0x00002CB4
		public Vector2 GetVector2(int nameID)
		{
			Vector2 vector;
			this.GetVector2_Injected(nameID, out vector);
			return vector;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00004ACC File Offset: 0x00002CCC
		public Vector3 GetVector3(int nameID)
		{
			Vector3 vector;
			this.GetVector3_Injected(nameID, out vector);
			return vector;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00004AE4 File Offset: 0x00002CE4
		public Vector4 GetVector4(int nameID)
		{
			Vector4 vector;
			this.GetVector4_Injected(nameID, out vector);
			return vector;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00004AFC File Offset: 0x00002CFC
		public Matrix4x4 GetMatrix4x4(int nameID)
		{
			Matrix4x4 matrix4x;
			this.GetMatrix4x4_Injected(nameID, out matrix4x);
			return matrix4x;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00004B14 File Offset: 0x00002D14
		public Texture GetTexture(int nameID)
		{
			IntPtr intPtr = VisualEffect.GetTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00004B44 File Offset: 0x00002D44
		public Mesh GetMesh(int nameID)
		{
			IntPtr intPtr = VisualEffect.GetMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00004B74 File Offset: 0x00002D74
		public SkinnedMeshRenderer GetSkinnedMeshRenderer(int nameID)
		{
			IntPtr intPtr = VisualEffect.GetSkinnedMeshRendererDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkinnedMeshRenderer>(intPtr2) : null;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00004BA4 File Offset: 0x00002DA4
		public Gradient GetGradient(int nameID)
		{
			Gradient gradient = new Gradient();
			this.Internal_GetGradient(nameID, gradient);
			return gradient;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002C1D File Offset: 0x00000E1D
		public void Internal_GetGradient(int nameID, Gradient gradient)
		{
			VisualEffect.Internal_GetGradientDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(gradient));
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00004BC8 File Offset: 0x00002DC8
		public AnimationCurve GetAnimationCurve(int nameID)
		{
			AnimationCurve animationCurve = new AnimationCurve();
			this.Internal_GetAnimationCurve(nameID, animationCurve);
			return animationCurve;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002C36 File Offset: 0x00000E36
		public void Internal_GetAnimationCurve(int nameID, AnimationCurve curve)
		{
			VisualEffect.Internal_GetAnimationCurveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(curve));
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002C4F File Offset: 0x00000E4F
		public bool HasSystem(int nameID)
		{
			return VisualEffect.HasSystemDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002C62 File Offset: 0x00000E62
		public void GetSpawnSystemInfo(int nameID, IntPtr spawnerState)
		{
			VisualEffect.GetSpawnSystemInfoDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, spawnerState);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00004BEC File Offset: 0x00002DEC
		public void GetSpawnSystemInfo(int nameID, VFXSpawnerState spawnState)
		{
			bool flag = spawnState == null;
			if (flag)
			{
				throw new NullReferenceException("GetSpawnSystemInfo expects a non null VFXSpawnerState.");
			}
			IntPtr ptr = spawnState.GetPtr();
			bool flag2 = ptr == IntPtr.Zero;
			if (flag2)
			{
				throw new NullReferenceException("GetSpawnSystemInfo use an unexpected not owned VFXSpawnerState.");
			}
			this.GetSpawnSystemInfo(nameID, ptr);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00004C38 File Offset: 0x00002E38
		public VFXSpawnerState GetSpawnSystemInfo(int nameID)
		{
			VFXSpawnerState vfxspawnerState = new VFXSpawnerState();
			this.GetSpawnSystemInfo(nameID, vfxspawnerState);
			return vfxspawnerState;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002C76 File Offset: 0x00000E76
		public void GetSystemNames(List<string> names)
		{
			VisualEffect.GetSystemNamesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(names));
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002C8E File Offset: 0x00000E8E
		public void GetParticleSystemNames(List<string> names)
		{
			VisualEffect.GetParticleSystemNamesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(names));
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002CA6 File Offset: 0x00000EA6
		public void GetOutputEventNames(List<string> names)
		{
			VisualEffect.GetOutputEventNamesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(names));
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002CBE File Offset: 0x00000EBE
		public void GetSpawnSystemNames(List<string> names)
		{
			VisualEffect.GetSpawnSystemNamesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(names));
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002CD6 File Offset: 0x00000ED6
		public void ResetOverride(string name)
		{
			this.ResetOverride(Shader.PropertyToID(name));
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00004C5C File Offset: 0x00002E5C
		public bool HasInt(string name)
		{
			return this.HasInt(Shader.PropertyToID(name));
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00004C7C File Offset: 0x00002E7C
		public bool HasUInt(string name)
		{
			return this.HasUInt(Shader.PropertyToID(name));
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00004C9C File Offset: 0x00002E9C
		public bool HasFloat(string name)
		{
			return this.HasFloat(Shader.PropertyToID(name));
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00004CBC File Offset: 0x00002EBC
		public bool HasVector2(string name)
		{
			return this.HasVector2(Shader.PropertyToID(name));
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00004CDC File Offset: 0x00002EDC
		public bool HasVector3(string name)
		{
			return this.HasVector3(Shader.PropertyToID(name));
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00004CFC File Offset: 0x00002EFC
		public bool HasVector4(string name)
		{
			return this.HasVector4(Shader.PropertyToID(name));
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00004D1C File Offset: 0x00002F1C
		public bool HasMatrix4x4(string name)
		{
			return this.HasMatrix4x4(Shader.PropertyToID(name));
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00004D3C File Offset: 0x00002F3C
		public bool HasTexture(string name)
		{
			return this.HasTexture(Shader.PropertyToID(name));
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00004D5C File Offset: 0x00002F5C
		public TextureDimension GetTextureDimension(string name)
		{
			return this.GetTextureDimension(Shader.PropertyToID(name));
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00004D7C File Offset: 0x00002F7C
		public bool HasAnimationCurve(string name)
		{
			return this.HasAnimationCurve(Shader.PropertyToID(name));
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00004D9C File Offset: 0x00002F9C
		public bool HasGradient(string name)
		{
			return this.HasGradient(Shader.PropertyToID(name));
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00004DBC File Offset: 0x00002FBC
		public bool HasMesh(string name)
		{
			return this.HasMesh(Shader.PropertyToID(name));
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00004DDC File Offset: 0x00002FDC
		public bool HasSkinnedMeshRenderer(string name)
		{
			return this.HasSkinnedMeshRenderer(Shader.PropertyToID(name));
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00004DFC File Offset: 0x00002FFC
		public bool HasBool(string name)
		{
			return this.HasBool(Shader.PropertyToID(name));
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002CE6 File Offset: 0x00000EE6
		public void SetInt(string name, int i)
		{
			this.SetInt(Shader.PropertyToID(name), i);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002CF7 File Offset: 0x00000EF7
		public void SetUInt(string name, uint i)
		{
			this.SetUInt(Shader.PropertyToID(name), i);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002D08 File Offset: 0x00000F08
		public void SetFloat(string name, float f)
		{
			this.SetFloat(Shader.PropertyToID(name), f);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002D19 File Offset: 0x00000F19
		public void SetVector2(string name, Vector2 v)
		{
			this.SetVector2(Shader.PropertyToID(name), v);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002D2A File Offset: 0x00000F2A
		public void SetVector3(string name, Vector3 v)
		{
			this.SetVector3(Shader.PropertyToID(name), v);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002D3B File Offset: 0x00000F3B
		public void SetVector4(string name, Vector4 v)
		{
			this.SetVector4(Shader.PropertyToID(name), v);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002D4C File Offset: 0x00000F4C
		public void SetMatrix4x4(string name, Matrix4x4 v)
		{
			this.SetMatrix4x4(Shader.PropertyToID(name), v);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002D5D File Offset: 0x00000F5D
		public void SetTexture(string name, Texture t)
		{
			this.SetTexture(Shader.PropertyToID(name), t);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002D6E File Offset: 0x00000F6E
		public void SetAnimationCurve(string name, AnimationCurve c)
		{
			this.SetAnimationCurve(Shader.PropertyToID(name), c);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002D7F File Offset: 0x00000F7F
		public void SetGradient(string name, Gradient g)
		{
			this.SetGradient(Shader.PropertyToID(name), g);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002D90 File Offset: 0x00000F90
		public void SetMesh(string name, Mesh m)
		{
			this.SetMesh(Shader.PropertyToID(name), m);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002DA1 File Offset: 0x00000FA1
		public void SetSkinnedMeshRenderer(string name, SkinnedMeshRenderer m)
		{
			this.SetSkinnedMeshRenderer(Shader.PropertyToID(name), m);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002DB2 File Offset: 0x00000FB2
		public void SetBool(string name, bool b)
		{
			this.SetBool(Shader.PropertyToID(name), b);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00004E1C File Offset: 0x0000301C
		public int GetInt(string name)
		{
			return this.GetInt(Shader.PropertyToID(name));
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00004E3C File Offset: 0x0000303C
		public uint GetUInt(string name)
		{
			return this.GetUInt(Shader.PropertyToID(name));
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00004E5C File Offset: 0x0000305C
		public float GetFloat(string name)
		{
			return this.GetFloat(Shader.PropertyToID(name));
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00004E7C File Offset: 0x0000307C
		public Vector2 GetVector2(string name)
		{
			return this.GetVector2(Shader.PropertyToID(name));
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00004E9C File Offset: 0x0000309C
		public Vector3 GetVector3(string name)
		{
			return this.GetVector3(Shader.PropertyToID(name));
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00004EBC File Offset: 0x000030BC
		public Vector4 GetVector4(string name)
		{
			return this.GetVector4(Shader.PropertyToID(name));
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00004EDC File Offset: 0x000030DC
		public Matrix4x4 GetMatrix4x4(string name)
		{
			return this.GetMatrix4x4(Shader.PropertyToID(name));
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00004EFC File Offset: 0x000030FC
		public Texture GetTexture(string name)
		{
			return this.GetTexture(Shader.PropertyToID(name));
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00004F1C File Offset: 0x0000311C
		public Mesh GetMesh(string name)
		{
			return this.GetMesh(Shader.PropertyToID(name));
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00004F3C File Offset: 0x0000313C
		public SkinnedMeshRenderer GetSkinnedMeshRenderer(string name)
		{
			return this.GetSkinnedMeshRenderer(Shader.PropertyToID(name));
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00004F5C File Offset: 0x0000315C
		public bool GetBool(string name)
		{
			return this.GetBool(Shader.PropertyToID(name));
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00004F7C File Offset: 0x0000317C
		public AnimationCurve GetAnimationCurve(string name)
		{
			return this.GetAnimationCurve(Shader.PropertyToID(name));
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00004F9C File Offset: 0x0000319C
		public Gradient GetGradient(string name)
		{
			return this.GetGradient(Shader.PropertyToID(name));
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00004FBC File Offset: 0x000031BC
		public bool HasSystem(string name)
		{
			return this.HasSystem(Shader.PropertyToID(name));
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00004FDC File Offset: 0x000031DC
		public VFXSpawnerState GetSpawnSystemInfo(string name)
		{
			return this.GetSpawnSystemInfo(Shader.PropertyToID(name));
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00002DC3 File Offset: 0x00000FC3
		public int aliveParticleCount
		{
			get
			{
				return VisualEffect.get_aliveParticleCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002DD5 File Offset: 0x00000FD5
		public void Simulate(float stepDeltaTime, [Optional] uint stepCount)
		{
			VisualEffect.SimulateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), stepDeltaTime, stepCount);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002DE9 File Offset: 0x00000FE9
		public void SetVector2_Injected(int nameID, ref Vector2 v)
		{
			VisualEffect.SetVector2_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref v);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002DFD File Offset: 0x00000FFD
		public void SetVector3_Injected(int nameID, ref Vector3 v)
		{
			VisualEffect.SetVector3_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref v);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002E11 File Offset: 0x00001011
		public void SetVector4_Injected(int nameID, ref Vector4 v)
		{
			VisualEffect.SetVector4_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref v);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002E25 File Offset: 0x00001025
		public void SetMatrix4x4_Injected(int nameID, ref Matrix4x4 v)
		{
			VisualEffect.SetMatrix4x4_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref v);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002E39 File Offset: 0x00001039
		public void GetVector2_Injected(int nameID, out Vector2 ret)
		{
			VisualEffect.GetVector2_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, out ret);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002E4D File Offset: 0x0000104D
		public void GetVector3_Injected(int nameID, out Vector3 ret)
		{
			VisualEffect.GetVector3_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, out ret);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002E61 File Offset: 0x00001061
		public void GetVector4_Injected(int nameID, out Vector4 ret)
		{
			VisualEffect.GetVector4_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, out ret);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002E75 File Offset: 0x00001075
		public void GetMatrix4x4_Injected(int nameID, out Matrix4x4 ret)
		{
			VisualEffect.GetMatrix4x4_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, out ret);
		}

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_m_cachedEventAttribute;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_outputEventReceived;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_get_visualEffectAsset_Public_get_VisualEffectAsset_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_CreateVFXEventAttribute_Public_VFXEventAttribute_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_InvokeGetCachedEventAttributeForOutputEvent_Internal_Private_Static_VFXEventAttribute_VisualEffect_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOutputEventReceived_Internal_Private_Static_Void_VisualEffect_Int32_0;

		// Token: 0x04000072 RID: 114
		private static readonly VisualEffect.get_pauseDelegate get_pauseDelegateField;

		// Token: 0x04000073 RID: 115
		private static readonly VisualEffect.set_pauseDelegate set_pauseDelegateField;

		// Token: 0x04000074 RID: 116
		private static readonly VisualEffect.get_playRateDelegate get_playRateDelegateField;

		// Token: 0x04000075 RID: 117
		private static readonly VisualEffect.set_playRateDelegate set_playRateDelegateField;

		// Token: 0x04000076 RID: 118
		private static readonly VisualEffect.get_startSeedDelegate get_startSeedDelegateField;

		// Token: 0x04000077 RID: 119
		private static readonly VisualEffect.set_startSeedDelegate set_startSeedDelegateField;

		// Token: 0x04000078 RID: 120
		private static readonly VisualEffect.get_resetSeedOnPlayDelegate get_resetSeedOnPlayDelegateField;

		// Token: 0x04000079 RID: 121
		private static readonly VisualEffect.set_resetSeedOnPlayDelegate set_resetSeedOnPlayDelegateField;

		// Token: 0x0400007A RID: 122
		private static readonly VisualEffect.get_initialEventIDDelegate get_initialEventIDDelegateField;

		// Token: 0x0400007B RID: 123
		private static readonly VisualEffect.set_initialEventIDDelegate set_initialEventIDDelegateField;

		// Token: 0x0400007C RID: 124
		private static readonly VisualEffect.get_initialEventNameDelegate get_initialEventNameDelegateField;

		// Token: 0x0400007D RID: 125
		private static readonly VisualEffect.set_initialEventNameDelegate set_initialEventNameDelegateField;

		// Token: 0x0400007E RID: 126
		private static readonly VisualEffect.get_culledDelegate get_culledDelegateField;

		// Token: 0x0400007F RID: 127
		private static readonly VisualEffect.set_visualEffectAssetDelegate set_visualEffectAssetDelegateField;

		// Token: 0x04000080 RID: 128
		private static readonly VisualEffect.SendEventFromScriptDelegate SendEventFromScriptDelegateField;

		// Token: 0x04000081 RID: 129
		private static readonly VisualEffect.ReinitDelegate ReinitDelegateField;

		// Token: 0x04000082 RID: 130
		private static readonly VisualEffect.AdvanceOneFrameDelegate AdvanceOneFrameDelegateField;

		// Token: 0x04000083 RID: 131
		private static readonly VisualEffect.ResetOverrideDelegate ResetOverrideDelegateField;

		// Token: 0x04000084 RID: 132
		private static readonly VisualEffect.GetTextureDimensionDelegate GetTextureDimensionDelegateField;

		// Token: 0x04000085 RID: 133
		private static readonly VisualEffect.HasBoolDelegate HasBoolDelegateField;

		// Token: 0x04000086 RID: 134
		private static readonly VisualEffect.HasIntDelegate HasIntDelegateField;

		// Token: 0x04000087 RID: 135
		private static readonly VisualEffect.HasUIntDelegate HasUIntDelegateField;

		// Token: 0x04000088 RID: 136
		private static readonly VisualEffect.HasFloatDelegate HasFloatDelegateField;

		// Token: 0x04000089 RID: 137
		private static readonly VisualEffect.HasVector2Delegate HasVector2DelegateField;

		// Token: 0x0400008A RID: 138
		private static readonly VisualEffect.HasVector3Delegate HasVector3DelegateField;

		// Token: 0x0400008B RID: 139
		private static readonly VisualEffect.HasVector4Delegate HasVector4DelegateField;

		// Token: 0x0400008C RID: 140
		private static readonly VisualEffect.HasMatrix4x4Delegate HasMatrix4x4DelegateField;

		// Token: 0x0400008D RID: 141
		private static readonly VisualEffect.HasTextureDelegate HasTextureDelegateField;

		// Token: 0x0400008E RID: 142
		private static readonly VisualEffect.HasAnimationCurveDelegate HasAnimationCurveDelegateField;

		// Token: 0x0400008F RID: 143
		private static readonly VisualEffect.HasGradientDelegate HasGradientDelegateField;

		// Token: 0x04000090 RID: 144
		private static readonly VisualEffect.HasMeshDelegate HasMeshDelegateField;

		// Token: 0x04000091 RID: 145
		private static readonly VisualEffect.HasSkinnedMeshRendererDelegate HasSkinnedMeshRendererDelegateField;

		// Token: 0x04000092 RID: 146
		private static readonly VisualEffect.SetBoolDelegate SetBoolDelegateField;

		// Token: 0x04000093 RID: 147
		private static readonly VisualEffect.SetIntDelegate SetIntDelegateField;

		// Token: 0x04000094 RID: 148
		private static readonly VisualEffect.SetUIntDelegate SetUIntDelegateField;

		// Token: 0x04000095 RID: 149
		private static readonly VisualEffect.SetFloatDelegate SetFloatDelegateField;

		// Token: 0x04000096 RID: 150
		private static readonly VisualEffect.SetTextureDelegate SetTextureDelegateField;

		// Token: 0x04000097 RID: 151
		private static readonly VisualEffect.SetAnimationCurveDelegate SetAnimationCurveDelegateField;

		// Token: 0x04000098 RID: 152
		private static readonly VisualEffect.SetGradientDelegate SetGradientDelegateField;

		// Token: 0x04000099 RID: 153
		private static readonly VisualEffect.SetMeshDelegate SetMeshDelegateField;

		// Token: 0x0400009A RID: 154
		private static readonly VisualEffect.SetSkinnedMeshRendererDelegate SetSkinnedMeshRendererDelegateField;

		// Token: 0x0400009B RID: 155
		private static readonly VisualEffect.GetBoolDelegate GetBoolDelegateField;

		// Token: 0x0400009C RID: 156
		private static readonly VisualEffect.GetIntDelegate GetIntDelegateField;

		// Token: 0x0400009D RID: 157
		private static readonly VisualEffect.GetUIntDelegate GetUIntDelegateField;

		// Token: 0x0400009E RID: 158
		private static readonly VisualEffect.GetFloatDelegate GetFloatDelegateField;

		// Token: 0x0400009F RID: 159
		private static readonly VisualEffect.GetTextureDelegate GetTextureDelegateField;

		// Token: 0x040000A0 RID: 160
		private static readonly VisualEffect.GetMeshDelegate GetMeshDelegateField;

		// Token: 0x040000A1 RID: 161
		private static readonly VisualEffect.GetSkinnedMeshRendererDelegate GetSkinnedMeshRendererDelegateField;

		// Token: 0x040000A2 RID: 162
		private static readonly VisualEffect.Internal_GetGradientDelegate Internal_GetGradientDelegateField;

		// Token: 0x040000A3 RID: 163
		private static readonly VisualEffect.Internal_GetAnimationCurveDelegate Internal_GetAnimationCurveDelegateField;

		// Token: 0x040000A4 RID: 164
		private static readonly VisualEffect.HasSystemDelegate HasSystemDelegateField;

		// Token: 0x040000A5 RID: 165
		private static readonly VisualEffect.GetSpawnSystemInfoDelegate GetSpawnSystemInfoDelegateField;

		// Token: 0x040000A6 RID: 166
		private static readonly VisualEffect.GetSystemNamesDelegate GetSystemNamesDelegateField;

		// Token: 0x040000A7 RID: 167
		private static readonly VisualEffect.GetParticleSystemNamesDelegate GetParticleSystemNamesDelegateField;

		// Token: 0x040000A8 RID: 168
		private static readonly VisualEffect.GetOutputEventNamesDelegate GetOutputEventNamesDelegateField;

		// Token: 0x040000A9 RID: 169
		private static readonly VisualEffect.GetSpawnSystemNamesDelegate GetSpawnSystemNamesDelegateField;

		// Token: 0x040000AA RID: 170
		private static readonly VisualEffect.get_aliveParticleCountDelegate get_aliveParticleCountDelegateField;

		// Token: 0x040000AB RID: 171
		private static readonly VisualEffect.SimulateDelegate SimulateDelegateField;

		// Token: 0x040000AC RID: 172
		private static readonly VisualEffect.SetVector2_InjectedDelegate SetVector2_InjectedDelegateField;

		// Token: 0x040000AD RID: 173
		private static readonly VisualEffect.SetVector3_InjectedDelegate SetVector3_InjectedDelegateField;

		// Token: 0x040000AE RID: 174
		private static readonly VisualEffect.SetVector4_InjectedDelegate SetVector4_InjectedDelegateField;

		// Token: 0x040000AF RID: 175
		private static readonly VisualEffect.SetMatrix4x4_InjectedDelegate SetMatrix4x4_InjectedDelegateField;

		// Token: 0x040000B0 RID: 176
		private static readonly VisualEffect.GetVector2_InjectedDelegate GetVector2_InjectedDelegateField;

		// Token: 0x040000B1 RID: 177
		private static readonly VisualEffect.GetVector3_InjectedDelegate GetVector3_InjectedDelegateField;

		// Token: 0x040000B2 RID: 178
		private static readonly VisualEffect.GetVector4_InjectedDelegate GetVector4_InjectedDelegateField;

		// Token: 0x040000B3 RID: 179
		private static readonly VisualEffect.GetMatrix4x4_InjectedDelegate GetMatrix4x4_InjectedDelegateField;

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x060001DA RID: 474
		private delegate bool get_pauseDelegate(IntPtr @this);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x060001DC RID: 476
		private delegate void set_pauseDelegate(IntPtr @this, bool value);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x060001DE RID: 478
		private delegate float get_playRateDelegate(IntPtr @this);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x060001E0 RID: 480
		private delegate void set_playRateDelegate(IntPtr @this, float value);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x060001E2 RID: 482
		private delegate uint get_startSeedDelegate(IntPtr @this);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x060001E4 RID: 484
		private delegate void set_startSeedDelegate(IntPtr @this, uint value);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x060001E6 RID: 486
		private delegate bool get_resetSeedOnPlayDelegate(IntPtr @this);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x060001E8 RID: 488
		private delegate void set_resetSeedOnPlayDelegate(IntPtr @this, bool value);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x060001EA RID: 490
		private delegate int get_initialEventIDDelegate(IntPtr @this);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x060001EC RID: 492
		private delegate void set_initialEventIDDelegate(IntPtr @this, int value);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x060001EE RID: 494
		private delegate IntPtr get_initialEventNameDelegate(IntPtr @this);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x060001F0 RID: 496
		private delegate void set_initialEventNameDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x060001F2 RID: 498
		private delegate bool get_culledDelegate(IntPtr @this);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x060001F4 RID: 500
		private delegate void set_visualEffectAssetDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x060001F6 RID: 502
		private delegate void SendEventFromScriptDelegate(IntPtr @this, int eventNameID, IntPtr eventAttribute);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x060001F8 RID: 504
		private delegate void ReinitDelegate(IntPtr @this);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x060001FA RID: 506
		private delegate void AdvanceOneFrameDelegate(IntPtr @this);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x060001FC RID: 508
		private delegate void ResetOverrideDelegate(IntPtr @this, int nameID);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x060001FE RID: 510
		private delegate TextureDimension GetTextureDimensionDelegate(IntPtr @this, int nameID);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x06000200 RID: 512
		private delegate bool HasBoolDelegate(IntPtr @this, int nameID);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x06000202 RID: 514
		private delegate bool HasIntDelegate(IntPtr @this, int nameID);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x06000204 RID: 516
		private delegate bool HasUIntDelegate(IntPtr @this, int nameID);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x06000206 RID: 518
		private delegate bool HasFloatDelegate(IntPtr @this, int nameID);

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x06000208 RID: 520
		private delegate bool HasVector2Delegate(IntPtr @this, int nameID);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x0600020A RID: 522
		private delegate bool HasVector3Delegate(IntPtr @this, int nameID);

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x0600020C RID: 524
		private delegate bool HasVector4Delegate(IntPtr @this, int nameID);

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x0600020E RID: 526
		private delegate bool HasMatrix4x4Delegate(IntPtr @this, int nameID);

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x06000210 RID: 528
		private delegate bool HasTextureDelegate(IntPtr @this, int nameID);

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x06000212 RID: 530
		private delegate bool HasAnimationCurveDelegate(IntPtr @this, int nameID);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x06000214 RID: 532
		private delegate bool HasGradientDelegate(IntPtr @this, int nameID);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x06000216 RID: 534
		private delegate bool HasMeshDelegate(IntPtr @this, int nameID);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x06000218 RID: 536
		private delegate bool HasSkinnedMeshRendererDelegate(IntPtr @this, int nameID);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x0600021A RID: 538
		private delegate void SetBoolDelegate(IntPtr @this, int nameID, bool b);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x0600021C RID: 540
		private delegate void SetIntDelegate(IntPtr @this, int nameID, int i);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x0600021E RID: 542
		private delegate void SetUIntDelegate(IntPtr @this, int nameID, uint i);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x06000220 RID: 544
		private delegate void SetFloatDelegate(IntPtr @this, int nameID, float f);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x06000222 RID: 546
		private delegate void SetTextureDelegate(IntPtr @this, int nameID, IntPtr t);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x06000224 RID: 548
		private delegate void SetAnimationCurveDelegate(IntPtr @this, int nameID, IntPtr c);

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x06000226 RID: 550
		private delegate void SetGradientDelegate(IntPtr @this, int nameID, IntPtr g);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x06000228 RID: 552
		private delegate void SetMeshDelegate(IntPtr @this, int nameID, IntPtr m);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x0600022A RID: 554
		private delegate void SetSkinnedMeshRendererDelegate(IntPtr @this, int nameID, IntPtr m);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x0600022C RID: 556
		private delegate bool GetBoolDelegate(IntPtr @this, int nameID);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x0600022E RID: 558
		private delegate int GetIntDelegate(IntPtr @this, int nameID);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x06000230 RID: 560
		private delegate uint GetUIntDelegate(IntPtr @this, int nameID);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x06000232 RID: 562
		private delegate float GetFloatDelegate(IntPtr @this, int nameID);

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x06000234 RID: 564
		private delegate IntPtr GetTextureDelegate(IntPtr @this, int nameID);

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x06000236 RID: 566
		private delegate IntPtr GetMeshDelegate(IntPtr @this, int nameID);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x06000238 RID: 568
		private delegate IntPtr GetSkinnedMeshRendererDelegate(IntPtr @this, int nameID);

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x0600023A RID: 570
		private delegate void Internal_GetGradientDelegate(IntPtr @this, int nameID, IntPtr gradient);

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x0600023C RID: 572
		private delegate void Internal_GetAnimationCurveDelegate(IntPtr @this, int nameID, IntPtr curve);

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x0600023E RID: 574
		private delegate bool HasSystemDelegate(IntPtr @this, int nameID);

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x06000240 RID: 576
		private delegate void GetSpawnSystemInfoDelegate(IntPtr @this, int nameID, IntPtr spawnerState);

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x06000242 RID: 578
		private delegate void GetSystemNamesDelegate(IntPtr @this, IntPtr names);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x06000244 RID: 580
		private delegate void GetParticleSystemNamesDelegate(IntPtr @this, IntPtr names);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x06000246 RID: 582
		private delegate void GetOutputEventNamesDelegate(IntPtr @this, IntPtr names);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x06000248 RID: 584
		private delegate void GetSpawnSystemNamesDelegate(IntPtr @this, IntPtr names);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x0600024A RID: 586
		private delegate int get_aliveParticleCountDelegate(IntPtr @this);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x0600024C RID: 588
		private delegate void SimulateDelegate(IntPtr @this, float stepDeltaTime, uint stepCount);

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x0600024E RID: 590
		private delegate void SetVector2_InjectedDelegate(IntPtr @this, int nameID, IntPtr v);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x06000250 RID: 592
		private delegate void SetVector3_InjectedDelegate(IntPtr @this, int nameID, IntPtr v);

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x06000252 RID: 594
		private delegate void SetVector4_InjectedDelegate(IntPtr @this, int nameID, IntPtr v);

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x06000254 RID: 596
		private delegate void SetMatrix4x4_InjectedDelegate(IntPtr @this, int nameID, IntPtr v);

		// Token: 0x0200009D RID: 157
		// (Invoke) Token: 0x06000256 RID: 598
		private delegate void GetVector2_InjectedDelegate(IntPtr @this, int nameID, [Out] IntPtr ret);

		// Token: 0x0200009E RID: 158
		// (Invoke) Token: 0x06000258 RID: 600
		private delegate void GetVector3_InjectedDelegate(IntPtr @this, int nameID, [Out] IntPtr ret);

		// Token: 0x0200009F RID: 159
		// (Invoke) Token: 0x0600025A RID: 602
		private delegate void GetVector4_InjectedDelegate(IntPtr @this, int nameID, [Out] IntPtr ret);

		// Token: 0x020000A0 RID: 160
		// (Invoke) Token: 0x0600025C RID: 604
		private delegate void GetMatrix4x4_InjectedDelegate(IntPtr @this, int nameID, [Out] IntPtr ret);
	}
}
