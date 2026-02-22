using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public sealed class ParticleSystem : Component
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002B48 File Offset: 0x00000D48
		// Note: this type is marked as 'beforefieldinit'.
		static ParticleSystem()
		{
			Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.ParticleSystemModule.dll", "UnityEngine", "ParticleSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr);
			ParticleSystem.NativeMethodInfoPtr_Emit_Public_Void_Vector3_Vector3_Single_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663297);
			ParticleSystem.NativeMethodInfoPtr_Emit_Public_Void_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663298);
			ParticleSystem.NativeMethodInfoPtr_get_maxParticles_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663299);
			ParticleSystem.NativeMethodInfoPtr_get_simulationSpace_Public_get_ParticleSystemSimulationSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663300);
			ParticleSystem.NativeMethodInfoPtr_get_scalingMode_Public_get_ParticleSystemScalingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663301);
			ParticleSystem.NativeMethodInfoPtr_set_scalingMode_Public_set_Void_ParticleSystemScalingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663302);
			ParticleSystem.NativeMethodInfoPtr_GetParticleCurrentSize_Internal_Single_byref_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663303);
			ParticleSystem.NativeMethodInfoPtr_GetParticleCurrentColor_Internal_Color32_byref_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663304);
			ParticleSystem.NativeMethodInfoPtr_SetParticles_Public_Void_Il2CppStructArray_1_Particle_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663305);
			ParticleSystem.NativeMethodInfoPtr_SetParticles_Public_Void_Il2CppStructArray_1_Particle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663306);
			ParticleSystem.NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663307);
			ParticleSystem.NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663308);
			ParticleSystem.NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663309);
			ParticleSystem.NativeMethodInfoPtr_Simulate_Public_Void_Single_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663310);
			ParticleSystem.NativeMethodInfoPtr_Simulate_Public_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663311);
			ParticleSystem.NativeMethodInfoPtr_Emit_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663312);
			ParticleSystem.NativeMethodInfoPtr_Emit_Internal_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663313);
			ParticleSystem.NativeMethodInfoPtr_Emit_Public_Void_EmitParams_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663314);
			ParticleSystem.NativeMethodInfoPtr_EmitOld_Internal_Private_Void_byref_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663315);
			ParticleSystem.NativeMethodInfoPtr_get_main_Public_get_MainModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663316);
			ParticleSystem.NativeMethodInfoPtr_get_textureSheetAnimation_Public_get_TextureSheetAnimationModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663317);
			ParticleSystem.NativeMethodInfoPtr_GetParticleCurrentColor_Injected_Private_Void_byref_Particle_byref_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663318);
			ParticleSystem.NativeMethodInfoPtr_Emit_Injected_Private_Void_byref_EmitParams_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663319);
			ParticleSystem.get_isPlayingDelegateField = IL2CPP.ResolveICall<ParticleSystem.get_isPlayingDelegate>("UnityEngine.ParticleSystem::get_isPlaying");
			ParticleSystem.get_isEmittingDelegateField = IL2CPP.ResolveICall<ParticleSystem.get_isEmittingDelegate>("UnityEngine.ParticleSystem::get_isEmitting");
			ParticleSystem.get_isStoppedDelegateField = IL2CPP.ResolveICall<ParticleSystem.get_isStoppedDelegate>("UnityEngine.ParticleSystem::get_isStopped");
			ParticleSystem.get_isPausedDelegateField = IL2CPP.ResolveICall<ParticleSystem.get_isPausedDelegate>("UnityEngine.ParticleSystem::get_isPaused");
			ParticleSystem.get_particleCountDelegateField = IL2CPP.ResolveICall<ParticleSystem.get_particleCountDelegate>("UnityEngine.ParticleSystem::get_particleCount");
			ParticleSystem.get_timeDelegateField = IL2CPP.ResolveICall<ParticleSystem.get_timeDelegate>("UnityEngine.ParticleSystem::get_time");
			ParticleSystem.set_timeDelegateField = IL2CPP.ResolveICall<ParticleSystem.set_timeDelegate>("UnityEngine.ParticleSystem::set_time");
			ParticleSystem.get_randomSeedDelegateField = IL2CPP.ResolveICall<ParticleSystem.get_randomSeedDelegate>("UnityEngine.ParticleSystem::get_randomSeed");
			ParticleSystem.set_randomSeedDelegateField = IL2CPP.ResolveICall<ParticleSystem.set_randomSeedDelegate>("UnityEngine.ParticleSystem::set_randomSeed");
			ParticleSystem.get_useAutoRandomSeedDelegateField = IL2CPP.ResolveICall<ParticleSystem.get_useAutoRandomSeedDelegate>("UnityEngine.ParticleSystem::get_useAutoRandomSeed");
			ParticleSystem.set_useAutoRandomSeedDelegateField = IL2CPP.ResolveICall<ParticleSystem.set_useAutoRandomSeedDelegate>("UnityEngine.ParticleSystem::set_useAutoRandomSeed");
			ParticleSystem.get_proceduralSimulationSupportedDelegateField = IL2CPP.ResolveICall<ParticleSystem.get_proceduralSimulationSupportedDelegate>("UnityEngine.ParticleSystem::get_proceduralSimulationSupported");
			ParticleSystem.GetParticleMeshIndexDelegateField = IL2CPP.ResolveICall<ParticleSystem.GetParticleMeshIndexDelegate>("UnityEngine.ParticleSystem::GetParticleMeshIndex");
			ParticleSystem.SetParticlesWithNativeArrayDelegateField = IL2CPP.ResolveICall<ParticleSystem.SetParticlesWithNativeArrayDelegate>("UnityEngine.ParticleSystem::SetParticlesWithNativeArray");
			ParticleSystem.GetParticlesWithNativeArrayDelegateField = IL2CPP.ResolveICall<ParticleSystem.GetParticlesWithNativeArrayDelegate>("UnityEngine.ParticleSystem::GetParticlesWithNativeArray");
			ParticleSystem.SetCustomParticleDataDelegateField = IL2CPP.ResolveICall<ParticleSystem.SetCustomParticleDataDelegate>("UnityEngine.ParticleSystem::SetCustomParticleData");
			ParticleSystem.GetCustomParticleDataDelegateField = IL2CPP.ResolveICall<ParticleSystem.GetCustomParticleDataDelegate>("UnityEngine.ParticleSystem::GetCustomParticleData");
			ParticleSystem.PlayDelegateField = IL2CPP.ResolveICall<ParticleSystem.PlayDelegate>("UnityEngine.ParticleSystem::Play");
			ParticleSystem.PauseDelegateField = IL2CPP.ResolveICall<ParticleSystem.PauseDelegate>("UnityEngine.ParticleSystem::Pause");
			ParticleSystem.StopDelegateField = IL2CPP.ResolveICall<ParticleSystem.StopDelegate>("UnityEngine.ParticleSystem::Stop");
			ParticleSystem.ClearDelegateField = IL2CPP.ResolveICall<ParticleSystem.ClearDelegate>("UnityEngine.ParticleSystem::Clear");
			ParticleSystem.IsAliveDelegateField = IL2CPP.ResolveICall<ParticleSystem.IsAliveDelegate>("UnityEngine.ParticleSystem::IsAlive");
			ParticleSystem.TriggerSubEmitterDelegateField = IL2CPP.ResolveICall<ParticleSystem.TriggerSubEmitterDelegate>("UnityEngine.ParticleSystem::TriggerSubEmitter");
			ParticleSystem.ResetPreMappedBufferMemoryDelegateField = IL2CPP.ResolveICall<ParticleSystem.ResetPreMappedBufferMemoryDelegate>("UnityEngine.ParticleSystem::ResetPreMappedBufferMemory");
			ParticleSystem.SetMaximumPreMappedBufferCountsDelegateField = IL2CPP.ResolveICall<ParticleSystem.SetMaximumPreMappedBufferCountsDelegate>("UnityEngine.ParticleSystem::SetMaximumPreMappedBufferCounts");
			ParticleSystem.AllocateAxisOfRotationAttributeDelegateField = IL2CPP.ResolveICall<ParticleSystem.AllocateAxisOfRotationAttributeDelegate>("UnityEngine.ParticleSystem::AllocateAxisOfRotationAttribute");
			ParticleSystem.AllocateMeshIndexAttributeDelegateField = IL2CPP.ResolveICall<ParticleSystem.AllocateMeshIndexAttributeDelegate>("UnityEngine.ParticleSystem::AllocateMeshIndexAttribute");
			ParticleSystem.AllocateCustomDataAttributeDelegateField = IL2CPP.ResolveICall<ParticleSystem.AllocateCustomDataAttributeDelegate>("UnityEngine.ParticleSystem::AllocateCustomDataAttribute");
			ParticleSystem.GetManagedJobDataDelegateField = IL2CPP.ResolveICall<ParticleSystem.GetManagedJobDataDelegate>("UnityEngine.ParticleSystem::GetManagedJobData");
			ParticleSystem.GetParticleCurrentSize3D_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystem.GetParticleCurrentSize3D_InjectedDelegate>("UnityEngine.ParticleSystem::GetParticleCurrentSize3D_Injected");
			ParticleSystem.TriggerSubEmitterForParticle_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystem.TriggerSubEmitterForParticle_InjectedDelegate>("UnityEngine.ParticleSystem::TriggerSubEmitterForParticle_Injected");
			ParticleSystem.GetManagedJobHandle_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystem.GetManagedJobHandle_InjectedDelegate>("UnityEngine.ParticleSystem::GetManagedJobHandle_Injected");
			ParticleSystem.SetManagedJobHandle_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystem.SetManagedJobHandle_InjectedDelegate>("UnityEngine.ParticleSystem::SetManagedJobHandle_Injected");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002F34 File Offset: 0x00001134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150088, XrefRangeEnd = 150092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lifetime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Emit_Public_Void_Vector3_Vector3_Single_Single_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002FAC File Offset: 0x000011AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150092, XrefRangeEnd = 150094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(ParticleSystem.Particle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref particle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Emit_Public_Void_Particle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002FEC File Offset: 0x000011EC
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00003998 File Offset: 0x00001B98
		public unsafe int maxParticles
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 150096, RefRangeEnd = 150097, XrefRangeStart = 150094, XrefRangeEnd = 150096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_maxParticles_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				ParticleSystem.MainModule main = this.main;
				main.maxParticles = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00003028 File Offset: 0x00001228
		// (set) Token: 0x06000036 RID: 54 RVA: 0x000039B8 File Offset: 0x00001BB8
		public unsafe ParticleSystemSimulationSpace simulationSpace
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 150099, RefRangeEnd = 150100, XrefRangeStart = 150097, XrefRangeEnd = 150099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_simulationSpace_Public_get_ParticleSystemSimulationSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				ParticleSystem.MainModule main = this.main;
				main.simulationSpace = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00003064 File Offset: 0x00001264
		// (set) Token: 0x06000007 RID: 7 RVA: 0x000030A0 File Offset: 0x000012A0
		public unsafe ParticleSystemScalingMode scalingMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 150102, RefRangeEnd = 150103, XrefRangeStart = 150100, XrefRangeEnd = 150102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_scalingMode_Public_get_ParticleSystemScalingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 150105, RefRangeEnd = 150106, XrefRangeStart = 150103, XrefRangeEnd = 150105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_set_scalingMode_Public_set_Void_ParticleSystemScalingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000030E0 File Offset: 0x000012E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150106, XrefRangeEnd = 150108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetParticleCurrentSize(ref ParticleSystem.Particle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &particle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetParticleCurrentSize_Internal_Single_byref_Particle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000312C File Offset: 0x0000132C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150108, XrefRangeEnd = 150110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color32 GetParticleCurrentColor(ref ParticleSystem.Particle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &particle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetParticleCurrentColor_Internal_Color32_byref_Particle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00003178 File Offset: 0x00001378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150110, XrefRangeEnd = 150112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParticles([Out] Il2CppStructArray<ParticleSystem.Particle> particles, int size, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_SetParticles_Public_Void_Il2CppStructArray_1_Particle_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*particles = ((intPtr4 == 0) ? null : new Il2CppStructArray<ParticleSystem.Particle>(intPtr4));
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000031E8 File Offset: 0x000013E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 150114, RefRangeEnd = 150119, XrefRangeStart = 150112, XrefRangeEnd = 150114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParticles([Out] Il2CppStructArray<ParticleSystem.Particle> particles, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_SetParticles_Public_Void_Il2CppStructArray_1_Particle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*particles = ((intPtr4 == 0) ? null : new Il2CppStructArray<ParticleSystem.Particle>(intPtr4));
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00003248 File Offset: 0x00001448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150119, XrefRangeEnd = 150121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetParticles([Out] Il2CppStructArray<ParticleSystem.Particle> particles, int size, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*particles = ((intPtr4 == 0) ? null : new Il2CppStructArray<ParticleSystem.Particle>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000032C4 File Offset: 0x000014C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150121, XrefRangeEnd = 150123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetParticles([Out] Il2CppStructArray<ParticleSystem.Particle> particles, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*particles = ((intPtr4 == 0) ? null : new Il2CppStructArray<ParticleSystem.Particle>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00003330 File Offset: 0x00001530
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 150125, RefRangeEnd = 150131, XrefRangeStart = 150123, XrefRangeEnd = 150125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetParticles([Out] Il2CppStructArray<ParticleSystem.Particle> particles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				*particles = ((intPtr4 == 0) ? null : new Il2CppStructArray<ParticleSystem.Particle>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00003390 File Offset: 0x00001590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150131, XrefRangeEnd = 150133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref withChildren;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref restart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fixedTimeStep;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Simulate_Public_Void_Single_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000033F8 File Offset: 0x000015F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150135, RefRangeEnd = 150136, XrefRangeStart = 150133, XrefRangeEnd = 150135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Simulate(float t, bool withChildren, bool restart)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref withChildren;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref restart;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Simulate_Public_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003454 File Offset: 0x00001654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150136, XrefRangeEnd = 150138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Emit_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003494 File Offset: 0x00001694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit_Internal(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Emit_Internal_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000034D4 File Offset: 0x000016D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150138, XrefRangeEnd = 150140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(ParticleSystem.EmitParams emitParams, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref emitParams;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Emit_Public_Void_EmitParams_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003520 File Offset: 0x00001720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150140, XrefRangeEnd = 150142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitOld_Internal(ref ParticleSystem.Particle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &particle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_EmitOld_Internal_Private_Void_byref_Particle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00003560 File Offset: 0x00001760
		public unsafe ParticleSystem.MainModule main
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 71983, RefRangeEnd = 72005, XrefRangeStart = 71983, XrefRangeEnd = 72005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_main_Public_get_MainModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.MainModule(intPtr);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00003598 File Offset: 0x00001798
		public unsafe ParticleSystem.TextureSheetAnimationModule textureSheetAnimation
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 71983, RefRangeEnd = 72005, XrefRangeStart = 71983, XrefRangeEnd = 72005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_textureSheetAnimation_Public_get_TextureSheetAnimationModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.TextureSheetAnimationModule(intPtr);
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000035D0 File Offset: 0x000017D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150142, XrefRangeEnd = 150144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetParticleCurrentColor_Injected(ref ParticleSystem.Particle particle, out Color32 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &particle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetParticleCurrentColor_Injected_Private_Void_byref_Particle_byref_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000361C File Offset: 0x0000181C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150144, XrefRangeEnd = 150146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit_Injected(ref ParticleSystem.EmitParams emitParams, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &emitParams;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Emit_Injected_Private_Void_byref_EmitParams_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
		public ParticleSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00003668 File Offset: 0x00001868
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00003688 File Offset: 0x00001888
		public float startDelay
		{
			get
			{
				ParticleSystem.MainModule main = this.main;
				return main.startDelayMultiplier;
			}
			set
			{
				ParticleSystem.MainModule main = this.main;
				main.startDelayMultiplier = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000036A8 File Offset: 0x000018A8
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000036C8 File Offset: 0x000018C8
		public bool loop
		{
			get
			{
				ParticleSystem.MainModule main = this.main;
				return main.loop;
			}
			set
			{
				ParticleSystem.MainModule main = this.main;
				main.loop = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000036E8 File Offset: 0x000018E8
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00003708 File Offset: 0x00001908
		public bool playOnAwake
		{
			get
			{
				ParticleSystem.MainModule main = this.main;
				return main.playOnAwake;
			}
			set
			{
				ParticleSystem.MainModule main = this.main;
				main.playOnAwake = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00003728 File Offset: 0x00001928
		public float duration
		{
			get
			{
				ParticleSystem.MainModule main = this.main;
				return main.duration;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00003748 File Offset: 0x00001948
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00003768 File Offset: 0x00001968
		public float playbackSpeed
		{
			get
			{
				ParticleSystem.MainModule main = this.main;
				return main.simulationSpeed;
			}
			set
			{
				ParticleSystem.MainModule main = this.main;
				main.simulationSpeed = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002059 File Offset: 0x00000259
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002066 File Offset: 0x00000266
		public bool enableEmission
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002073 File Offset: 0x00000273
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002080 File Offset: 0x00000280
		public float emissionRate
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00003788 File Offset: 0x00001988
		// (set) Token: 0x06000028 RID: 40 RVA: 0x000037A8 File Offset: 0x000019A8
		public float startSpeed
		{
			get
			{
				ParticleSystem.MainModule main = this.main;
				return main.startSpeedMultiplier;
			}
			set
			{
				ParticleSystem.MainModule main = this.main;
				main.startSpeedMultiplier = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000037C8 File Offset: 0x000019C8
		// (set) Token: 0x0600002A RID: 42 RVA: 0x000037E8 File Offset: 0x000019E8
		public float startSize
		{
			get
			{
				ParticleSystem.MainModule main = this.main;
				return main.startSizeMultiplier;
			}
			set
			{
				ParticleSystem.MainModule main = this.main;
				main.startSizeMultiplier = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00003808 File Offset: 0x00001A08
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00003830 File Offset: 0x00001A30
		public Color startColor
		{
			get
			{
				ParticleSystem.MainModule main = this.main;
				ParticleSystem.MinMaxGradient startColor = main.startColor;
				return startColor.color;
			}
			set
			{
				ParticleSystem.MainModule main = this.main;
				main.startColor = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00003854 File Offset: 0x00001A54
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00003874 File Offset: 0x00001A74
		public float startRotation
		{
			get
			{
				ParticleSystem.MainModule main = this.main;
				return main.startRotationMultiplier;
			}
			set
			{
				ParticleSystem.MainModule main = this.main;
				main.startRotationMultiplier = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00003894 File Offset: 0x00001A94
		// (set) Token: 0x06000030 RID: 48 RVA: 0x000038D8 File Offset: 0x00001AD8
		public Vector3 startRotation3D
		{
			get
			{
				ParticleSystem.MainModule mainModule = this.main;
				float startRotationXMultiplier = mainModule.startRotationXMultiplier;
				mainModule = this.main;
				float startRotationYMultiplier = mainModule.startRotationYMultiplier;
				mainModule = this.main;
				return new Vector3(startRotationXMultiplier, startRotationYMultiplier, mainModule.startRotationZMultiplier);
			}
			set
			{
				ParticleSystem.MainModule main = this.main;
				main.startRotationXMultiplier = value.x;
				main.startRotationYMultiplier = value.y;
				main.startRotationZMultiplier = value.z;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00003918 File Offset: 0x00001B18
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00003938 File Offset: 0x00001B38
		public float startLifetime
		{
			get
			{
				ParticleSystem.MainModule main = this.main;
				return main.startLifetimeMultiplier;
			}
			set
			{
				ParticleSystem.MainModule main = this.main;
				main.startLifetimeMultiplier = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00003958 File Offset: 0x00001B58
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00003978 File Offset: 0x00001B78
		public float gravityModifier
		{
			get
			{
				ParticleSystem.MainModule main = this.main;
				return main.gravityModifierMultiplier;
			}
			set
			{
				ParticleSystem.MainModule main = this.main;
				main.gravityModifierMultiplier = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000039D8 File Offset: 0x00001BD8
		public bool automaticCullingEnabled
		{
			get
			{
				return this.proceduralSimulationSupported;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000208D File Offset: 0x0000028D
		public bool isPlaying
		{
			get
			{
				return ParticleSystem.get_isPlayingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000039 RID: 57 RVA: 0x0000209F File Offset: 0x0000029F
		public bool isEmitting
		{
			get
			{
				return ParticleSystem.get_isEmittingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000020B1 File Offset: 0x000002B1
		public bool isStopped
		{
			get
			{
				return ParticleSystem.get_isStoppedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600003B RID: 59 RVA: 0x000020C3 File Offset: 0x000002C3
		public bool isPaused
		{
			get
			{
				return ParticleSystem.get_isPausedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000020D5 File Offset: 0x000002D5
		public int particleCount
		{
			get
			{
				return ParticleSystem.get_particleCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000020E7 File Offset: 0x000002E7
		// (set) Token: 0x0600003E RID: 62 RVA: 0x000020F9 File Offset: 0x000002F9
		public float time
		{
			get
			{
				return ParticleSystem.get_timeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystem.set_timeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600003F RID: 63 RVA: 0x0000210C File Offset: 0x0000030C
		// (set) Token: 0x06000040 RID: 64 RVA: 0x0000211E File Offset: 0x0000031E
		public uint randomSeed
		{
			get
			{
				return ParticleSystem.get_randomSeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystem.set_randomSeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002143 File Offset: 0x00000343
		public bool useAutoRandomSeed
		{
			get
			{
				return ParticleSystem.get_useAutoRandomSeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystem.set_useAutoRandomSeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002156 File Offset: 0x00000356
		public bool proceduralSimulationSupported
		{
			get
			{
				return ParticleSystem.get_proceduralSimulationSupportedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000039F0 File Offset: 0x00001BF0
		public Vector3 GetParticleCurrentSize3D(ref ParticleSystem.Particle particle)
		{
			Vector3 vector;
			this.GetParticleCurrentSize3D_Injected(ref particle, out vector);
			return vector;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002168 File Offset: 0x00000368
		public int GetParticleMeshIndex(ref ParticleSystem.Particle particle)
		{
			return ParticleSystem.GetParticleMeshIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref particle);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000217B File Offset: 0x0000037B
		public void SetParticles([Out] Il2CppStructArray<ParticleSystem.Particle> particles)
		{
			this.SetParticles(particles, -1);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002187 File Offset: 0x00000387
		public void SetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset)
		{
			ParticleSystem.SetParticlesWithNativeArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), particles, particlesLength, size, offset);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000219E File Offset: 0x0000039E
		public void SetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size, int offset)
		{
			this.SetParticlesWithNativeArray((IntPtr)particles.GetUnsafeReadOnlyPtr<ParticleSystem.Particle>(), particles.Length, size, 0);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000021BE File Offset: 0x000003BE
		public void SetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size)
		{
			this.SetParticles(particles, size, 0);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000021CB File Offset: 0x000003CB
		public void SetParticles([Out] NativeArray<ParticleSystem.Particle> particles)
		{
			this.SetParticles(particles, -1);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000021D7 File Offset: 0x000003D7
		public int GetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset)
		{
			return ParticleSystem.GetParticlesWithNativeArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), particles, particlesLength, size, offset);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003A08 File Offset: 0x00001C08
		public int GetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size, int offset)
		{
			return this.GetParticlesWithNativeArray((IntPtr)NativeArrayUnsafeUtility.GetUnsafePtr<ParticleSystem.Particle>(particles), particles.Length, size, 0);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003A38 File Offset: 0x00001C38
		public int GetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size)
		{
			return this.GetParticles(particles, size, 0);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003A54 File Offset: 0x00001C54
		public int GetParticles([Out] NativeArray<ParticleSystem.Particle> particles)
		{
			return this.GetParticles(particles, -1);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000021EE File Offset: 0x000003EE
		public void SetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex)
		{
			ParticleSystem.SetCustomParticleDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(customData), streamIndex);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002207 File Offset: 0x00000407
		public int GetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex)
		{
			return ParticleSystem.GetCustomParticleDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(customData), streamIndex);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002220 File Offset: 0x00000420
		public void Simulate(float t, bool withChildren)
		{
			this.Simulate(t, withChildren, true);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000222D File Offset: 0x0000042D
		public void Simulate(float t)
		{
			this.Simulate(t, true);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002239 File Offset: 0x00000439
		public void Play(bool withChildren)
		{
			ParticleSystem.PlayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), withChildren);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000224C File Offset: 0x0000044C
		public void Play()
		{
			this.Play(true);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002257 File Offset: 0x00000457
		public void Pause(bool withChildren)
		{
			ParticleSystem.PauseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), withChildren);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000226A File Offset: 0x0000046A
		public void Pause()
		{
			this.Pause(true);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002275 File Offset: 0x00000475
		public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior)
		{
			ParticleSystem.StopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), withChildren, stopBehavior);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002289 File Offset: 0x00000489
		public void Stop(bool withChildren)
		{
			this.Stop(withChildren, ParticleSystemStopBehavior.StopEmitting);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002295 File Offset: 0x00000495
		public void Stop()
		{
			this.Stop(true);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000022A0 File Offset: 0x000004A0
		public void Clear(bool withChildren)
		{
			ParticleSystem.ClearDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), withChildren);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000022B3 File Offset: 0x000004B3
		public void Clear()
		{
			this.Clear(true);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000022BE File Offset: 0x000004BE
		public bool IsAlive(bool withChildren)
		{
			return ParticleSystem.IsAliveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), withChildren);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003A70 File Offset: 0x00001C70
		public bool IsAlive()
		{
			return this.IsAlive(true);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000022D1 File Offset: 0x000004D1
		public void TriggerSubEmitter(int subEmitterIndex)
		{
			this.TriggerSubEmitter(subEmitterIndex, null);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000022DD File Offset: 0x000004DD
		public void TriggerSubEmitter(int subEmitterIndex, ref ParticleSystem.Particle particle)
		{
			this.TriggerSubEmitterForParticle(subEmitterIndex, particle);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000022EE File Offset: 0x000004EE
		public void TriggerSubEmitterForParticle(int subEmitterIndex, ParticleSystem.Particle particle)
		{
			this.TriggerSubEmitterForParticle_Injected(subEmitterIndex, ref particle);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000022F9 File Offset: 0x000004F9
		public void TriggerSubEmitter(int subEmitterIndex, List<ParticleSystem.Particle> particles)
		{
			ParticleSystem.TriggerSubEmitterDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), subEmitterIndex, IL2CPP.Il2CppObjectBaseToPtr(particles));
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002312 File Offset: 0x00000512
		public static void ResetPreMappedBufferMemory()
		{
			ParticleSystem.ResetPreMappedBufferMemoryDelegateField();
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000231E File Offset: 0x0000051E
		public static void SetMaximumPreMappedBufferCounts(int vertexBuffersCount, int indexBuffersCount)
		{
			ParticleSystem.SetMaximumPreMappedBufferCountsDelegateField(vertexBuffersCount, indexBuffersCount);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000232C File Offset: 0x0000052C
		public void AllocateAxisOfRotationAttribute()
		{
			ParticleSystem.AllocateAxisOfRotationAttributeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000233E File Offset: 0x0000053E
		public void AllocateMeshIndexAttribute()
		{
			ParticleSystem.AllocateMeshIndexAttributeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002350 File Offset: 0x00000550
		public void AllocateCustomDataAttribute(ParticleSystemCustomData stream)
		{
			ParticleSystem.AllocateCustomDataAttributeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), stream);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002363 File Offset: 0x00000563
		public unsafe void* GetManagedJobData()
		{
			return ParticleSystem.GetManagedJobDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003A8C File Offset: 0x00001C8C
		public JobHandle GetManagedJobHandle()
		{
			JobHandle jobHandle;
			this.GetManagedJobHandle_Injected(out jobHandle);
			return jobHandle;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002375 File Offset: 0x00000575
		public void SetManagedJobHandle(JobHandle handle)
		{
			this.SetManagedJobHandle_Injected(ref handle);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000237F File Offset: 0x0000057F
		public void GetParticleCurrentSize3D_Injected(ref ParticleSystem.Particle particle, out Vector3 ret)
		{
			ParticleSystem.GetParticleCurrentSize3D_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref particle, out ret);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002393 File Offset: 0x00000593
		public void TriggerSubEmitterForParticle_Injected(int subEmitterIndex, ref ParticleSystem.Particle particle)
		{
			ParticleSystem.TriggerSubEmitterForParticle_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), subEmitterIndex, ref particle);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000023A7 File Offset: 0x000005A7
		public void GetManagedJobHandle_Injected(out JobHandle ret)
		{
			ParticleSystem.GetManagedJobHandle_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000023BA File Offset: 0x000005BA
		public void SetManagedJobHandle_Injected(ref JobHandle handle)
		{
			ParticleSystem.SetManagedJobHandle_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref handle);
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Void_Vector3_Vector3_Single_Single_Color32_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Void_Particle_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_get_maxParticles_Public_get_Int32_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_get_simulationSpace_Public_get_ParticleSystemSimulationSpace_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_get_scalingMode_Public_get_ParticleSystemScalingMode_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_set_scalingMode_Public_set_Void_ParticleSystemScalingMode_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_GetParticleCurrentSize_Internal_Single_byref_Particle_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_GetParticleCurrentColor_Internal_Color32_byref_Particle_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_SetParticles_Public_Void_Il2CppStructArray_1_Particle_Int32_Int32_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_SetParticles_Public_Void_Il2CppStructArray_1_Particle_Int32_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_Int32_Int32_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_Int32_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_Simulate_Public_Void_Single_Boolean_Boolean_Boolean_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_Simulate_Public_Void_Single_Boolean_Boolean_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Void_Int32_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Internal_Private_Void_Int32_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Void_EmitParams_Int32_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_EmitOld_Internal_Private_Void_byref_Particle_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_get_main_Public_get_MainModule_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_get_textureSheetAnimation_Public_get_TextureSheetAnimationModule_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_GetParticleCurrentColor_Injected_Private_Void_byref_Particle_byref_Color32_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Injected_Private_Void_byref_EmitParams_Int32_0;

		// Token: 0x04000018 RID: 24
		private static readonly ParticleSystem.get_isPlayingDelegate get_isPlayingDelegateField;

		// Token: 0x04000019 RID: 25
		private static readonly ParticleSystem.get_isEmittingDelegate get_isEmittingDelegateField;

		// Token: 0x0400001A RID: 26
		private static readonly ParticleSystem.get_isStoppedDelegate get_isStoppedDelegateField;

		// Token: 0x0400001B RID: 27
		private static readonly ParticleSystem.get_isPausedDelegate get_isPausedDelegateField;

		// Token: 0x0400001C RID: 28
		private static readonly ParticleSystem.get_particleCountDelegate get_particleCountDelegateField;

		// Token: 0x0400001D RID: 29
		private static readonly ParticleSystem.get_timeDelegate get_timeDelegateField;

		// Token: 0x0400001E RID: 30
		private static readonly ParticleSystem.set_timeDelegate set_timeDelegateField;

		// Token: 0x0400001F RID: 31
		private static readonly ParticleSystem.get_randomSeedDelegate get_randomSeedDelegateField;

		// Token: 0x04000020 RID: 32
		private static readonly ParticleSystem.set_randomSeedDelegate set_randomSeedDelegateField;

		// Token: 0x04000021 RID: 33
		private static readonly ParticleSystem.get_useAutoRandomSeedDelegate get_useAutoRandomSeedDelegateField;

		// Token: 0x04000022 RID: 34
		private static readonly ParticleSystem.set_useAutoRandomSeedDelegate set_useAutoRandomSeedDelegateField;

		// Token: 0x04000023 RID: 35
		private static readonly ParticleSystem.get_proceduralSimulationSupportedDelegate get_proceduralSimulationSupportedDelegateField;

		// Token: 0x04000024 RID: 36
		private static readonly ParticleSystem.GetParticleMeshIndexDelegate GetParticleMeshIndexDelegateField;

		// Token: 0x04000025 RID: 37
		private static readonly ParticleSystem.SetParticlesWithNativeArrayDelegate SetParticlesWithNativeArrayDelegateField;

		// Token: 0x04000026 RID: 38
		private static readonly ParticleSystem.GetParticlesWithNativeArrayDelegate GetParticlesWithNativeArrayDelegateField;

		// Token: 0x04000027 RID: 39
		private static readonly ParticleSystem.SetCustomParticleDataDelegate SetCustomParticleDataDelegateField;

		// Token: 0x04000028 RID: 40
		private static readonly ParticleSystem.GetCustomParticleDataDelegate GetCustomParticleDataDelegateField;

		// Token: 0x04000029 RID: 41
		private static readonly ParticleSystem.PlayDelegate PlayDelegateField;

		// Token: 0x0400002A RID: 42
		private static readonly ParticleSystem.PauseDelegate PauseDelegateField;

		// Token: 0x0400002B RID: 43
		private static readonly ParticleSystem.StopDelegate StopDelegateField;

		// Token: 0x0400002C RID: 44
		private static readonly ParticleSystem.ClearDelegate ClearDelegateField;

		// Token: 0x0400002D RID: 45
		private static readonly ParticleSystem.IsAliveDelegate IsAliveDelegateField;

		// Token: 0x0400002E RID: 46
		private static readonly ParticleSystem.TriggerSubEmitterDelegate TriggerSubEmitterDelegateField;

		// Token: 0x0400002F RID: 47
		private static readonly ParticleSystem.ResetPreMappedBufferMemoryDelegate ResetPreMappedBufferMemoryDelegateField;

		// Token: 0x04000030 RID: 48
		private static readonly ParticleSystem.SetMaximumPreMappedBufferCountsDelegate SetMaximumPreMappedBufferCountsDelegateField;

		// Token: 0x04000031 RID: 49
		private static readonly ParticleSystem.AllocateAxisOfRotationAttributeDelegate AllocateAxisOfRotationAttributeDelegateField;

		// Token: 0x04000032 RID: 50
		private static readonly ParticleSystem.AllocateMeshIndexAttributeDelegate AllocateMeshIndexAttributeDelegateField;

		// Token: 0x04000033 RID: 51
		private static readonly ParticleSystem.AllocateCustomDataAttributeDelegate AllocateCustomDataAttributeDelegateField;

		// Token: 0x04000034 RID: 52
		private static readonly ParticleSystem.GetManagedJobDataDelegate GetManagedJobDataDelegateField;

		// Token: 0x04000035 RID: 53
		private static readonly ParticleSystem.GetParticleCurrentSize3D_InjectedDelegate GetParticleCurrentSize3D_InjectedDelegateField;

		// Token: 0x04000036 RID: 54
		private static readonly ParticleSystem.TriggerSubEmitterForParticle_InjectedDelegate TriggerSubEmitterForParticle_InjectedDelegateField;

		// Token: 0x04000037 RID: 55
		private static readonly ParticleSystem.GetManagedJobHandle_InjectedDelegate GetManagedJobHandle_InjectedDelegateField;

		// Token: 0x04000038 RID: 56
		private static readonly ParticleSystem.SetManagedJobHandle_InjectedDelegate SetManagedJobHandle_InjectedDelegateField;

		// Token: 0x0200003B RID: 59
		public sealed class MainModule : ValueType
		{
			// Token: 0x060000D3 RID: 211 RVA: 0x00004758 File Offset: 0x00002958
			// Note: this type is marked as 'beforefieldinit'.
			static MainModule()
			{
				Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "MainModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr);
				ParticleSystem.MainModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.MainModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663320);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_startColor_Public_get_MinMaxGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663321);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_startColor_Public_set_Void_MinMaxGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663322);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_simulationSpace_Public_get_ParticleSystemSimulationSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663323);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_scalingMode_Public_get_ParticleSystemScalingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663324);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_scalingMode_Public_set_Void_ParticleSystemScalingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663325);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_maxParticles_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663326);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_startColor_Injected_Private_Static_Void_byref_MainModule_byref_MinMaxGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663327);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_startColor_Injected_Private_Static_Void_byref_MainModule_byref_MinMaxGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663328);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_simulationSpace_Injected_Private_Static_ParticleSystemSimulationSpace_byref_MainModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663329);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_scalingMode_Injected_Private_Static_ParticleSystemScalingMode_byref_MainModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663330);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_scalingMode_Injected_Private_Static_Void_byref_MainModule_ParticleSystemScalingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663331);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_maxParticles_Injected_Private_Static_Int32_byref_MainModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663332);
			}

			// Token: 0x060000D4 RID: 212 RVA: 0x0000489C File Offset: 0x00002A9C
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MainModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x060000D5 RID: 213 RVA: 0x000048EC File Offset: 0x00002AEC
			// (set) Token: 0x060000D6 RID: 214 RVA: 0x00004928 File Offset: 0x00002B28
			public unsafe ParticleSystem.MinMaxGradient startColor
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 150022, RefRangeEnd = 150023, XrefRangeStart = 150020, XrefRangeEnd = 150022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_startColor_Public_get_MinMaxGradient_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ParticleSystem.MinMaxGradient(intPtr);
				}
				[CallerCount(8)]
				[CachedScanResults(RefRangeStart = 150025, RefRangeEnd = 150033, XrefRangeStart = 150023, XrefRangeEnd = 150025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_startColor_Public_set_Void_MinMaxGradient_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x060000D7 RID: 215 RVA: 0x00004974 File Offset: 0x00002B74
			public unsafe ParticleSystemSimulationSpace simulationSpace
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150033, XrefRangeEnd = 150035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_simulationSpace_Public_get_ParticleSystemSimulationSpace_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x060000D8 RID: 216 RVA: 0x000049B8 File Offset: 0x00002BB8
			// (set) Token: 0x060000D9 RID: 217 RVA: 0x000049FC File Offset: 0x00002BFC
			public unsafe ParticleSystemScalingMode scalingMode
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150035, XrefRangeEnd = 150037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_scalingMode_Public_get_ParticleSystemScalingMode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150037, XrefRangeEnd = 150039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_scalingMode_Public_set_Void_ParticleSystemScalingMode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x060000DA RID: 218 RVA: 0x00004A40 File Offset: 0x00002C40
			public unsafe int maxParticles
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 150041, RefRangeEnd = 150044, XrefRangeStart = 150039, XrefRangeEnd = 150041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_maxParticles_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000DB RID: 219 RVA: 0x00004A84 File Offset: 0x00002C84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150044, XrefRangeEnd = 150046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void get_startColor_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxGradient ret)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_startColor_Injected_Private_Static_Void_byref_MainModule_byref_MinMaxGradient_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				ret = ((intPtr4 == 0) ? null : new ParticleSystem.MinMaxGradient(intPtr4));
			}

			// Token: 0x060000DC RID: 220 RVA: 0x00004ADC File Offset: 0x00002CDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150046, XrefRangeEnd = 150048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void set_startColor_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxGradient value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_startColor_Injected_Private_Static_Void_byref_MainModule_byref_MinMaxGradient_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000DD RID: 221 RVA: 0x00004B28 File Offset: 0x00002D28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static ParticleSystemSimulationSpace get_simulationSpace_Injected(ref ParticleSystem.MainModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_simulationSpace_Injected_Private_Static_ParticleSystemSimulationSpace_byref_MainModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000DE RID: 222 RVA: 0x00004B6C File Offset: 0x00002D6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static ParticleSystemScalingMode get_scalingMode_Injected(ref ParticleSystem.MainModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_scalingMode_Injected_Private_Static_ParticleSystemScalingMode_byref_MainModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000DF RID: 223 RVA: 0x00004BB0 File Offset: 0x00002DB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void set_scalingMode_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemScalingMode value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_scalingMode_Injected_Private_Static_Void_byref_MainModule_ParticleSystemScalingMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000E0 RID: 224 RVA: 0x00004BF8 File Offset: 0x00002DF8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 150041, RefRangeEnd = 150044, XrefRangeStart = 150041, XrefRangeEnd = 150044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int get_maxParticles_Injected(ref ParticleSystem.MainModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_maxParticles_Injected_Private_Static_Int32_byref_MainModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000E1 RID: 225 RVA: 0x00002A06 File Offset: 0x00000C06
			public MainModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060000E2 RID: 226 RVA: 0x00002A0F File Offset: 0x00000C0F
			public MainModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr))
			{
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x060000E3 RID: 227 RVA: 0x00004C3C File Offset: 0x00002E3C
			// (set) Token: 0x060000E4 RID: 228 RVA: 0x00002A21 File Offset: 0x00000C21
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MainModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MainModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400017F RID: 383
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x04000180 RID: 384
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;

			// Token: 0x04000181 RID: 385
			private static readonly IntPtr NativeMethodInfoPtr_get_startColor_Public_get_MinMaxGradient_0;

			// Token: 0x04000182 RID: 386
			private static readonly IntPtr NativeMethodInfoPtr_set_startColor_Public_set_Void_MinMaxGradient_0;

			// Token: 0x04000183 RID: 387
			private static readonly IntPtr NativeMethodInfoPtr_get_simulationSpace_Public_get_ParticleSystemSimulationSpace_0;

			// Token: 0x04000184 RID: 388
			private static readonly IntPtr NativeMethodInfoPtr_get_scalingMode_Public_get_ParticleSystemScalingMode_0;

			// Token: 0x04000185 RID: 389
			private static readonly IntPtr NativeMethodInfoPtr_set_scalingMode_Public_set_Void_ParticleSystemScalingMode_0;

			// Token: 0x04000186 RID: 390
			private static readonly IntPtr NativeMethodInfoPtr_get_maxParticles_Public_get_Int32_0;

			// Token: 0x04000187 RID: 391
			private static readonly IntPtr NativeMethodInfoPtr_get_startColor_Injected_Private_Static_Void_byref_MainModule_byref_MinMaxGradient_0;

			// Token: 0x04000188 RID: 392
			private static readonly IntPtr NativeMethodInfoPtr_set_startColor_Injected_Private_Static_Void_byref_MainModule_byref_MinMaxGradient_0;

			// Token: 0x04000189 RID: 393
			private static readonly IntPtr NativeMethodInfoPtr_get_simulationSpace_Injected_Private_Static_ParticleSystemSimulationSpace_byref_MainModule_0;

			// Token: 0x0400018A RID: 394
			private static readonly IntPtr NativeMethodInfoPtr_get_scalingMode_Injected_Private_Static_ParticleSystemScalingMode_byref_MainModule_0;

			// Token: 0x0400018B RID: 395
			private static readonly IntPtr NativeMethodInfoPtr_set_scalingMode_Injected_Private_Static_Void_byref_MainModule_ParticleSystemScalingMode_0;

			// Token: 0x0400018C RID: 396
			private static readonly IntPtr NativeMethodInfoPtr_get_maxParticles_Injected_Private_Static_Int32_byref_MainModule_0;
		}

		// Token: 0x0200003C RID: 60
		public sealed class TextureSheetAnimationModule : ValueType
		{
			// Token: 0x060000E5 RID: 229 RVA: 0x00004C6C File Offset: 0x00002E6C
			// Note: this type is marked as 'beforefieldinit'.
			static TextureSheetAnimationModule()
			{
				Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "TextureSheetAnimationModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr);
				ParticleSystem.TextureSheetAnimationModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr, 100663333);
				ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr, 100663334);
				ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr_get_numTilesX_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr, 100663335);
				ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr_get_numTilesY_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr, 100663336);
				ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr_get_animation_Public_get_ParticleSystemAnimationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr, 100663337);
				ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr_get_cycleCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr, 100663338);
				ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr_get_rowIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr, 100663339);
				ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr_get_enabled_Injected_Private_Static_Boolean_byref_TextureSheetAnimationModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr, 100663340);
				ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr_get_numTilesX_Injected_Private_Static_Int32_byref_TextureSheetAnimationModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr, 100663341);
				ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr_get_numTilesY_Injected_Private_Static_Int32_byref_TextureSheetAnimationModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr, 100663342);
				ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr_get_animation_Injected_Private_Static_ParticleSystemAnimationType_byref_TextureSheetAnimationModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr, 100663343);
				ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr_get_cycleCount_Injected_Private_Static_Int32_byref_TextureSheetAnimationModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr, 100663344);
				ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr_get_rowIndex_Injected_Private_Static_Int32_byref_TextureSheetAnimationModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr, 100663345);
			}

			// Token: 0x060000E6 RID: 230 RVA: 0x00004DB0 File Offset: 0x00002FB0
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TextureSheetAnimationModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x060000E7 RID: 231 RVA: 0x00004E00 File Offset: 0x00003000
			public unsafe bool enabled
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 150050, RefRangeEnd = 150051, XrefRangeStart = 150048, XrefRangeEnd = 150050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x060000E8 RID: 232 RVA: 0x00004E44 File Offset: 0x00003044
			public unsafe int numTilesX
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 150053, RefRangeEnd = 150057, XrefRangeStart = 150051, XrefRangeEnd = 150053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr_get_numTilesX_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x060000E9 RID: 233 RVA: 0x00004E88 File Offset: 0x00003088
			public unsafe int numTilesY
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150057, XrefRangeEnd = 150059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr_get_numTilesY_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x060000EA RID: 234 RVA: 0x00004ECC File Offset: 0x000030CC
			public unsafe ParticleSystemAnimationType animation
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 150061, RefRangeEnd = 150062, XrefRangeStart = 150059, XrefRangeEnd = 150061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr_get_animation_Public_get_ParticleSystemAnimationType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x060000EB RID: 235 RVA: 0x00004F10 File Offset: 0x00003110
			public unsafe int cycleCount
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 150064, RefRangeEnd = 150065, XrefRangeStart = 150062, XrefRangeEnd = 150064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr_get_cycleCount_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x060000EC RID: 236 RVA: 0x00004F54 File Offset: 0x00003154
			public unsafe int rowIndex
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 150067, RefRangeEnd = 150068, XrefRangeStart = 150065, XrefRangeEnd = 150067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr_get_rowIndex_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000ED RID: 237 RVA: 0x00004F98 File Offset: 0x00003198
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 150050, RefRangeEnd = 150051, XrefRangeStart = 150050, XrefRangeEnd = 150051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool get_enabled_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr_get_enabled_Injected_Private_Static_Boolean_byref_TextureSheetAnimationModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000EE RID: 238 RVA: 0x00004FDC File Offset: 0x000031DC
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 150053, RefRangeEnd = 150057, XrefRangeStart = 150053, XrefRangeEnd = 150057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int get_numTilesX_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr_get_numTilesX_Injected_Private_Static_Int32_byref_TextureSheetAnimationModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000EF RID: 239 RVA: 0x00005020 File Offset: 0x00003220
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int get_numTilesY_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr_get_numTilesY_Injected_Private_Static_Int32_byref_TextureSheetAnimationModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000F0 RID: 240 RVA: 0x00005064 File Offset: 0x00003264
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 150061, RefRangeEnd = 150062, XrefRangeStart = 150061, XrefRangeEnd = 150062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static ParticleSystemAnimationType get_animation_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr_get_animation_Injected_Private_Static_ParticleSystemAnimationType_byref_TextureSheetAnimationModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000F1 RID: 241 RVA: 0x000050A8 File Offset: 0x000032A8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 150064, RefRangeEnd = 150065, XrefRangeStart = 150064, XrefRangeEnd = 150065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int get_cycleCount_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr_get_cycleCount_Injected_Private_Static_Int32_byref_TextureSheetAnimationModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000F2 RID: 242 RVA: 0x000050EC File Offset: 0x000032EC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 150067, RefRangeEnd = 150068, XrefRangeStart = 150067, XrefRangeEnd = 150068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int get_rowIndex_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr_get_rowIndex_Injected_Private_Static_Int32_byref_TextureSheetAnimationModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000F3 RID: 243 RVA: 0x00002A40 File Offset: 0x00000C40
			public TextureSheetAnimationModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060000F4 RID: 244 RVA: 0x00002A49 File Offset: 0x00000C49
			public TextureSheetAnimationModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr))
			{
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x060000F5 RID: 245 RVA: 0x00005130 File Offset: 0x00003330
			// (set) Token: 0x060000F6 RID: 246 RVA: 0x00002A5B File Offset: 0x00000C5B
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.TextureSheetAnimationModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.TextureSheetAnimationModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400018D RID: 397
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x0400018E RID: 398
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;

			// Token: 0x0400018F RID: 399
			private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

			// Token: 0x04000190 RID: 400
			private static readonly IntPtr NativeMethodInfoPtr_get_numTilesX_Public_get_Int32_0;

			// Token: 0x04000191 RID: 401
			private static readonly IntPtr NativeMethodInfoPtr_get_numTilesY_Public_get_Int32_0;

			// Token: 0x04000192 RID: 402
			private static readonly IntPtr NativeMethodInfoPtr_get_animation_Public_get_ParticleSystemAnimationType_0;

			// Token: 0x04000193 RID: 403
			private static readonly IntPtr NativeMethodInfoPtr_get_cycleCount_Public_get_Int32_0;

			// Token: 0x04000194 RID: 404
			private static readonly IntPtr NativeMethodInfoPtr_get_rowIndex_Public_get_Int32_0;

			// Token: 0x04000195 RID: 405
			private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Injected_Private_Static_Boolean_byref_TextureSheetAnimationModule_0;

			// Token: 0x04000196 RID: 406
			private static readonly IntPtr NativeMethodInfoPtr_get_numTilesX_Injected_Private_Static_Int32_byref_TextureSheetAnimationModule_0;

			// Token: 0x04000197 RID: 407
			private static readonly IntPtr NativeMethodInfoPtr_get_numTilesY_Injected_Private_Static_Int32_byref_TextureSheetAnimationModule_0;

			// Token: 0x04000198 RID: 408
			private static readonly IntPtr NativeMethodInfoPtr_get_animation_Injected_Private_Static_ParticleSystemAnimationType_byref_TextureSheetAnimationModule_0;

			// Token: 0x04000199 RID: 409
			private static readonly IntPtr NativeMethodInfoPtr_get_cycleCount_Injected_Private_Static_Int32_byref_TextureSheetAnimationModule_0;

			// Token: 0x0400019A RID: 410
			private static readonly IntPtr NativeMethodInfoPtr_get_rowIndex_Injected_Private_Static_Int32_byref_TextureSheetAnimationModule_0;
		}

		// Token: 0x0200003D RID: 61
		[StructLayout(2)]
		public struct Particle
		{
			// Token: 0x060000F7 RID: 247 RVA: 0x00005160 File Offset: 0x00003360
			// Note: this type is marked as 'beforefieldinit'.
			static Particle()
			{
				Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "Particle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr);
				ParticleSystem.Particle.NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_Position");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_Velocity");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_AnimatedVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_AnimatedVelocity");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_InitialVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_InitialVelocity");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_AxisOfRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_AxisOfRotation");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_Rotation");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_AngularVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_AngularVelocity");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_StartSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_StartSize");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_StartColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_StartColor");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_RandomSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_RandomSeed");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_ParentRandomSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_ParentRandomSeed");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_Lifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_Lifetime");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_StartLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_StartLifetime");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_MeshIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_MeshIndex");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_EmitAccumulator0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_EmitAccumulator0");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_EmitAccumulator1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_EmitAccumulator1");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_Flags");
				ParticleSystem.Particle.NativeMethodInfoPtr_set_lifetime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663346);
				ParticleSystem.Particle.NativeMethodInfoPtr_get_position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663347);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663348);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663349);
				ParticleSystem.Particle.NativeMethodInfoPtr_get_remainingLifetime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663350);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_remainingLifetime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663351);
				ParticleSystem.Particle.NativeMethodInfoPtr_get_startLifetime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663352);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_startLifetime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663353);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_startColor_Public_set_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663354);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_randomSeed_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663355);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_startSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663356);
				ParticleSystem.Particle.NativeMethodInfoPtr_get_rotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663357);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_rotation3D_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663358);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_angularVelocity3D_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663359);
				ParticleSystem.Particle.NativeMethodInfoPtr_GetCurrentSize_Public_Single_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663360);
				ParticleSystem.Particle.NativeMethodInfoPtr_GetCurrentColor_Public_Color32_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663361);
			}

			// Token: 0x1700004B RID: 75
			// (set) Token: 0x060000F8 RID: 248 RVA: 0x00005420 File Offset: 0x00003620
			public unsafe float lifetime
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_lifetime_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x060000F9 RID: 249 RVA: 0x00005454 File Offset: 0x00003654
			// (set) Token: 0x060000FA RID: 250 RVA: 0x00005484 File Offset: 0x00003684
			public unsafe Vector3 position
			{
				[CallerCount(36)]
				[CachedScanResults(RefRangeStart = 61063, RefRangeEnd = 61099, XrefRangeStart = 61063, XrefRangeEnd = 61099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_get_position_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 61099, RefRangeEnd = 61100, XrefRangeStart = 61099, XrefRangeEnd = 61100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700004D RID: 77
			// (set) Token: 0x060000FB RID: 251 RVA: 0x000054B8 File Offset: 0x000036B8
			public unsafe Vector3 velocity
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x060000FC RID: 252 RVA: 0x000054EC File Offset: 0x000036EC
			// (set) Token: 0x060000FD RID: 253 RVA: 0x0000551C File Offset: 0x0000371C
			public unsafe float remainingLifetime
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 150068, RefRangeEnd = 150069, XrefRangeStart = 150068, XrefRangeEnd = 150068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_get_remainingLifetime_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_remainingLifetime_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x060000FE RID: 254 RVA: 0x00005550 File Offset: 0x00003750
			// (set) Token: 0x060000FF RID: 255 RVA: 0x00005580 File Offset: 0x00003780
			public unsafe float startLifetime
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 150069, RefRangeEnd = 150070, XrefRangeStart = 150069, XrefRangeEnd = 150069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_get_startLifetime_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_startLifetime_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000050 RID: 80
			// (set) Token: 0x06000100 RID: 256 RVA: 0x000055B4 File Offset: 0x000037B4
			public unsafe Color32 startColor
			{
				[CallerCount(169)]
				[CachedScanResults(RefRangeStart = 90728, RefRangeEnd = 90897, XrefRangeStart = 90728, XrefRangeEnd = 90897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_startColor_Public_set_Void_Color32_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000051 RID: 81
			// (set) Token: 0x06000101 RID: 257 RVA: 0x000055E8 File Offset: 0x000037E8
			public unsafe uint randomSeed
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_randomSeed_Public_set_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000052 RID: 82
			// (set) Token: 0x06000102 RID: 258 RVA: 0x0000561C File Offset: 0x0000381C
			public unsafe float startSize
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_startSize_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x06000103 RID: 259 RVA: 0x00005650 File Offset: 0x00003850
			public unsafe float rotation
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 150070, RefRangeEnd = 150071, XrefRangeStart = 150070, XrefRangeEnd = 150070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_get_rotation_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000054 RID: 84
			// (set) Token: 0x06000104 RID: 260 RVA: 0x00005680 File Offset: 0x00003880
			public unsafe Vector3 rotation3D
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_rotation3D_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000055 RID: 85
			// (set) Token: 0x06000105 RID: 261 RVA: 0x000056B4 File Offset: 0x000038B4
			public unsafe Vector3 angularVelocity3D
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_angularVelocity3D_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000106 RID: 262 RVA: 0x000056E8 File Offset: 0x000038E8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 150074, RefRangeEnd = 150075, XrefRangeStart = 150071, XrefRangeEnd = 150074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float GetCurrentSize(ParticleSystem system)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(system);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_GetCurrentSize_Public_Single_ParticleSystem_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000107 RID: 263 RVA: 0x0000572C File Offset: 0x0000392C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 150077, RefRangeEnd = 150078, XrefRangeStart = 150075, XrefRangeEnd = 150077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Color32 GetCurrentColor(ParticleSystem system)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(system);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_GetCurrentColor_Public_Color32_ParticleSystem_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000108 RID: 264 RVA: 0x00002A7A File Offset: 0x00000C7A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, ref this));
			}

			// Token: 0x0400019B RID: 411
			private static readonly IntPtr NativeFieldInfoPtr_m_Position;

			// Token: 0x0400019C RID: 412
			private static readonly IntPtr NativeFieldInfoPtr_m_Velocity;

			// Token: 0x0400019D RID: 413
			private static readonly IntPtr NativeFieldInfoPtr_m_AnimatedVelocity;

			// Token: 0x0400019E RID: 414
			private static readonly IntPtr NativeFieldInfoPtr_m_InitialVelocity;

			// Token: 0x0400019F RID: 415
			private static readonly IntPtr NativeFieldInfoPtr_m_AxisOfRotation;

			// Token: 0x040001A0 RID: 416
			private static readonly IntPtr NativeFieldInfoPtr_m_Rotation;

			// Token: 0x040001A1 RID: 417
			private static readonly IntPtr NativeFieldInfoPtr_m_AngularVelocity;

			// Token: 0x040001A2 RID: 418
			private static readonly IntPtr NativeFieldInfoPtr_m_StartSize;

			// Token: 0x040001A3 RID: 419
			private static readonly IntPtr NativeFieldInfoPtr_m_StartColor;

			// Token: 0x040001A4 RID: 420
			private static readonly IntPtr NativeFieldInfoPtr_m_RandomSeed;

			// Token: 0x040001A5 RID: 421
			private static readonly IntPtr NativeFieldInfoPtr_m_ParentRandomSeed;

			// Token: 0x040001A6 RID: 422
			private static readonly IntPtr NativeFieldInfoPtr_m_Lifetime;

			// Token: 0x040001A7 RID: 423
			private static readonly IntPtr NativeFieldInfoPtr_m_StartLifetime;

			// Token: 0x040001A8 RID: 424
			private static readonly IntPtr NativeFieldInfoPtr_m_MeshIndex;

			// Token: 0x040001A9 RID: 425
			private static readonly IntPtr NativeFieldInfoPtr_m_EmitAccumulator0;

			// Token: 0x040001AA RID: 426
			private static readonly IntPtr NativeFieldInfoPtr_m_EmitAccumulator1;

			// Token: 0x040001AB RID: 427
			private static readonly IntPtr NativeFieldInfoPtr_m_Flags;

			// Token: 0x040001AC RID: 428
			private static readonly IntPtr NativeMethodInfoPtr_set_lifetime_Public_set_Void_Single_0;

			// Token: 0x040001AD RID: 429
			private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector3_0;

			// Token: 0x040001AE RID: 430
			private static readonly IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0;

			// Token: 0x040001AF RID: 431
			private static readonly IntPtr NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector3_0;

			// Token: 0x040001B0 RID: 432
			private static readonly IntPtr NativeMethodInfoPtr_get_remainingLifetime_Public_get_Single_0;

			// Token: 0x040001B1 RID: 433
			private static readonly IntPtr NativeMethodInfoPtr_set_remainingLifetime_Public_set_Void_Single_0;

			// Token: 0x040001B2 RID: 434
			private static readonly IntPtr NativeMethodInfoPtr_get_startLifetime_Public_get_Single_0;

			// Token: 0x040001B3 RID: 435
			private static readonly IntPtr NativeMethodInfoPtr_set_startLifetime_Public_set_Void_Single_0;

			// Token: 0x040001B4 RID: 436
			private static readonly IntPtr NativeMethodInfoPtr_set_startColor_Public_set_Void_Color32_0;

			// Token: 0x040001B5 RID: 437
			private static readonly IntPtr NativeMethodInfoPtr_set_randomSeed_Public_set_Void_UInt32_0;

			// Token: 0x040001B6 RID: 438
			private static readonly IntPtr NativeMethodInfoPtr_set_startSize_Public_set_Void_Single_0;

			// Token: 0x040001B7 RID: 439
			private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Public_get_Single_0;

			// Token: 0x040001B8 RID: 440
			private static readonly IntPtr NativeMethodInfoPtr_set_rotation3D_Public_set_Void_Vector3_0;

			// Token: 0x040001B9 RID: 441
			private static readonly IntPtr NativeMethodInfoPtr_set_angularVelocity3D_Public_set_Void_Vector3_0;

			// Token: 0x040001BA RID: 442
			private static readonly IntPtr NativeMethodInfoPtr_GetCurrentSize_Public_Single_ParticleSystem_0;

			// Token: 0x040001BB RID: 443
			private static readonly IntPtr NativeMethodInfoPtr_GetCurrentColor_Public_Color32_ParticleSystem_0;

			// Token: 0x040001BC RID: 444
			[FieldOffset(0)]
			public Vector3 m_Position;

			// Token: 0x040001BD RID: 445
			[FieldOffset(12)]
			public Vector3 m_Velocity;

			// Token: 0x040001BE RID: 446
			[FieldOffset(24)]
			public Vector3 m_AnimatedVelocity;

			// Token: 0x040001BF RID: 447
			[FieldOffset(36)]
			public Vector3 m_InitialVelocity;

			// Token: 0x040001C0 RID: 448
			[FieldOffset(48)]
			public Vector3 m_AxisOfRotation;

			// Token: 0x040001C1 RID: 449
			[FieldOffset(60)]
			public Vector3 m_Rotation;

			// Token: 0x040001C2 RID: 450
			[FieldOffset(72)]
			public Vector3 m_AngularVelocity;

			// Token: 0x040001C3 RID: 451
			[FieldOffset(84)]
			public Vector3 m_StartSize;

			// Token: 0x040001C4 RID: 452
			[FieldOffset(96)]
			public Color32 m_StartColor;

			// Token: 0x040001C5 RID: 453
			[FieldOffset(100)]
			public uint m_RandomSeed;

			// Token: 0x040001C6 RID: 454
			[FieldOffset(104)]
			public uint m_ParentRandomSeed;

			// Token: 0x040001C7 RID: 455
			[FieldOffset(108)]
			public float m_Lifetime;

			// Token: 0x040001C8 RID: 456
			[FieldOffset(112)]
			public float m_StartLifetime;

			// Token: 0x040001C9 RID: 457
			[FieldOffset(116)]
			public int m_MeshIndex;

			// Token: 0x040001CA RID: 458
			[FieldOffset(120)]
			public float m_EmitAccumulator0;

			// Token: 0x040001CB RID: 459
			[FieldOffset(124)]
			public float m_EmitAccumulator1;

			// Token: 0x040001CC RID: 460
			[FieldOffset(128)]
			public uint m_Flags;

			// Token: 0x020000A6 RID: 166
			public enum Flags
			{
				// Token: 0x040001EE RID: 494
				Size3D = 1,
				// Token: 0x040001EF RID: 495
				Rotation3D,
				// Token: 0x040001F0 RID: 496
				MeshIndex = 4
			}
		}

		// Token: 0x0200003E RID: 62
		[Serializable]
		public sealed class MinMaxGradient : ValueType
		{
			// Token: 0x06000109 RID: 265 RVA: 0x00005770 File Offset: 0x00003970
			// Note: this type is marked as 'beforefieldinit'.
			static MinMaxGradient()
			{
				Il2CppClassPointerStore<ParticleSystem.MinMaxGradient>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "MinMaxGradient");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.MinMaxGradient>.NativeClassPtr);
				ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.MinMaxGradient>.NativeClassPtr, "m_Mode");
				ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_GradientMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.MinMaxGradient>.NativeClassPtr, "m_GradientMin");
				ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_GradientMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.MinMaxGradient>.NativeClassPtr, "m_GradientMax");
				ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_ColorMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.MinMaxGradient>.NativeClassPtr, "m_ColorMin");
				ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_ColorMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.MinMaxGradient>.NativeClassPtr, "m_ColorMax");
				ParticleSystem.MinMaxGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MinMaxGradient>.NativeClassPtr, 100663362);
				ParticleSystem.MinMaxGradient.NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MinMaxGradient>.NativeClassPtr, 100663363);
				ParticleSystem.MinMaxGradient.NativeMethodInfoPtr_op_Implicit_Public_Static_MinMaxGradient_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MinMaxGradient>.NativeClassPtr, 100663364);
			}

			// Token: 0x0600010A RID: 266 RVA: 0x0000583C File Offset: 0x00003A3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150078, XrefRangeEnd = 150079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MinMaxGradient(Color color)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.MinMaxGradient>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref color;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MinMaxGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x0600010B RID: 267 RVA: 0x00005888 File Offset: 0x00003A88
			public unsafe Color color
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 89026, RefRangeEnd = 89036, XrefRangeStart = 89026, XrefRangeEnd = 89036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MinMaxGradient.NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600010C RID: 268 RVA: 0x000058CC File Offset: 0x00003ACC
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 150080, RefRangeEnd = 150088, XrefRangeStart = 150079, XrefRangeEnd = 150080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static implicit operator ParticleSystem.MinMaxGradient(Color color)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref color;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MinMaxGradient.NativeMethodInfoPtr_op_Implicit_Public_Static_MinMaxGradient_Color_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ParticleSystem.MinMaxGradient(intPtr);
				}
			}

			// Token: 0x0600010D RID: 269 RVA: 0x00002A8C File Offset: 0x00000C8C
			public MinMaxGradient(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600010E RID: 270 RVA: 0x00002A95 File Offset: 0x00000C95
			public MinMaxGradient()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.MinMaxGradient>.NativeClassPtr))
			{
			}

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x0600010F RID: 271 RVA: 0x00005904 File Offset: 0x00003B04
			// (set) Token: 0x06000110 RID: 272 RVA: 0x00002AA7 File Offset: 0x00000CA7
			public unsafe ParticleSystemGradientMode m_Mode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_Mode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_Mode)) = value;
				}
			}

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x06000111 RID: 273 RVA: 0x0000592C File Offset: 0x00003B2C
			// (set) Token: 0x06000112 RID: 274 RVA: 0x00002AC2 File Offset: 0x00000CC2
			public unsafe Gradient m_GradientMin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_GradientMin);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_GradientMin), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x06000113 RID: 275 RVA: 0x0000595C File Offset: 0x00003B5C
			// (set) Token: 0x06000114 RID: 276 RVA: 0x00002AE1 File Offset: 0x00000CE1
			public unsafe Gradient m_GradientMax
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_GradientMax);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_GradientMax), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x06000115 RID: 277 RVA: 0x0000598C File Offset: 0x00003B8C
			// (set) Token: 0x06000116 RID: 278 RVA: 0x00002B00 File Offset: 0x00000D00
			public unsafe Color m_ColorMin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_ColorMin);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_ColorMin)) = value;
				}
			}

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x06000117 RID: 279 RVA: 0x000059B4 File Offset: 0x00003BB4
			// (set) Token: 0x06000118 RID: 280 RVA: 0x00002B1B File Offset: 0x00000D1B
			public unsafe Color m_ColorMax
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_ColorMax);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_ColorMax)) = value;
				}
			}

			// Token: 0x040001CD RID: 461
			private static readonly IntPtr NativeFieldInfoPtr_m_Mode;

			// Token: 0x040001CE RID: 462
			private static readonly IntPtr NativeFieldInfoPtr_m_GradientMin;

			// Token: 0x040001CF RID: 463
			private static readonly IntPtr NativeFieldInfoPtr_m_GradientMax;

			// Token: 0x040001D0 RID: 464
			private static readonly IntPtr NativeFieldInfoPtr_m_ColorMin;

			// Token: 0x040001D1 RID: 465
			private static readonly IntPtr NativeFieldInfoPtr_m_ColorMax;

			// Token: 0x040001D2 RID: 466
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_0;

			// Token: 0x040001D3 RID: 467
			private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;

			// Token: 0x040001D4 RID: 468
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_MinMaxGradient_Color_0;
		}

		// Token: 0x0200003F RID: 63
		[StructLayout(2)]
		public struct EmitParams
		{
			// Token: 0x06000119 RID: 281 RVA: 0x000059DC File Offset: 0x00003BDC
			// Note: this type is marked as 'beforefieldinit'.
			static EmitParams()
			{
				Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "EmitParams");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr);
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_Particle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_Particle");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_PositionSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_PositionSet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_VelocitySet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_VelocitySet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_AxisOfRotationSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_AxisOfRotationSet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_RotationSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_RotationSet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_AngularVelocitySet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_AngularVelocitySet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_StartSizeSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_StartSizeSet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_StartColorSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_StartColorSet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_RandomSeedSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_RandomSeedSet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_StartLifetimeSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_StartLifetimeSet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_MeshIndexSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_MeshIndexSet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_ApplyShapeToPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_ApplyShapeToPosition");
			}

			// Token: 0x0600011A RID: 282 RVA: 0x00002B36 File Offset: 0x00000D36
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, ref this));
			}

			// Token: 0x040001D5 RID: 469
			private static readonly IntPtr NativeFieldInfoPtr_m_Particle;

			// Token: 0x040001D6 RID: 470
			private static readonly IntPtr NativeFieldInfoPtr_m_PositionSet;

			// Token: 0x040001D7 RID: 471
			private static readonly IntPtr NativeFieldInfoPtr_m_VelocitySet;

			// Token: 0x040001D8 RID: 472
			private static readonly IntPtr NativeFieldInfoPtr_m_AxisOfRotationSet;

			// Token: 0x040001D9 RID: 473
			private static readonly IntPtr NativeFieldInfoPtr_m_RotationSet;

			// Token: 0x040001DA RID: 474
			private static readonly IntPtr NativeFieldInfoPtr_m_AngularVelocitySet;

			// Token: 0x040001DB RID: 475
			private static readonly IntPtr NativeFieldInfoPtr_m_StartSizeSet;

			// Token: 0x040001DC RID: 476
			private static readonly IntPtr NativeFieldInfoPtr_m_StartColorSet;

			// Token: 0x040001DD RID: 477
			private static readonly IntPtr NativeFieldInfoPtr_m_RandomSeedSet;

			// Token: 0x040001DE RID: 478
			private static readonly IntPtr NativeFieldInfoPtr_m_StartLifetimeSet;

			// Token: 0x040001DF RID: 479
			private static readonly IntPtr NativeFieldInfoPtr_m_MeshIndexSet;

			// Token: 0x040001E0 RID: 480
			private static readonly IntPtr NativeFieldInfoPtr_m_ApplyShapeToPosition;

			// Token: 0x040001E1 RID: 481
			[FieldOffset(0)]
			public ParticleSystem.Particle m_Particle;

			// Token: 0x040001E2 RID: 482
			[FieldOffset(132)]
			[MarshalAs(4)]
			public bool m_PositionSet;

			// Token: 0x040001E3 RID: 483
			[FieldOffset(133)]
			[MarshalAs(4)]
			public bool m_VelocitySet;

			// Token: 0x040001E4 RID: 484
			[FieldOffset(134)]
			[MarshalAs(4)]
			public bool m_AxisOfRotationSet;

			// Token: 0x040001E5 RID: 485
			[FieldOffset(135)]
			[MarshalAs(4)]
			public bool m_RotationSet;

			// Token: 0x040001E6 RID: 486
			[FieldOffset(136)]
			[MarshalAs(4)]
			public bool m_AngularVelocitySet;

			// Token: 0x040001E7 RID: 487
			[FieldOffset(137)]
			[MarshalAs(4)]
			public bool m_StartSizeSet;

			// Token: 0x040001E8 RID: 488
			[FieldOffset(138)]
			[MarshalAs(4)]
			public bool m_StartColorSet;

			// Token: 0x040001E9 RID: 489
			[FieldOffset(139)]
			[MarshalAs(4)]
			public bool m_RandomSeedSet;

			// Token: 0x040001EA RID: 490
			[FieldOffset(140)]
			[MarshalAs(4)]
			public bool m_StartLifetimeSet;

			// Token: 0x040001EB RID: 491
			[FieldOffset(141)]
			[MarshalAs(4)]
			public bool m_MeshIndexSet;

			// Token: 0x040001EC RID: 492
			[FieldOffset(142)]
			[MarshalAs(4)]
			public bool m_ApplyShapeToPosition;
		}

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x0600011C RID: 284
		private delegate bool get_isPlayingDelegate(IntPtr @this);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x0600011E RID: 286
		private delegate bool get_isEmittingDelegate(IntPtr @this);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x06000120 RID: 288
		private delegate bool get_isStoppedDelegate(IntPtr @this);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x06000122 RID: 290
		private delegate bool get_isPausedDelegate(IntPtr @this);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x06000124 RID: 292
		private delegate int get_particleCountDelegate(IntPtr @this);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x06000126 RID: 294
		private delegate float get_timeDelegate(IntPtr @this);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x06000128 RID: 296
		private delegate void set_timeDelegate(IntPtr @this, float value);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x0600012A RID: 298
		private delegate uint get_randomSeedDelegate(IntPtr @this);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x0600012C RID: 300
		private delegate void set_randomSeedDelegate(IntPtr @this, uint value);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x0600012E RID: 302
		private delegate bool get_useAutoRandomSeedDelegate(IntPtr @this);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x06000130 RID: 304
		private delegate void set_useAutoRandomSeedDelegate(IntPtr @this, bool value);

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x06000132 RID: 306
		private delegate bool get_proceduralSimulationSupportedDelegate(IntPtr @this);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x06000134 RID: 308
		private delegate int GetParticleMeshIndexDelegate(IntPtr @this, IntPtr particle);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x06000136 RID: 310
		private delegate void SetParticlesWithNativeArrayDelegate(IntPtr @this, IntPtr particles, int particlesLength, int size, int offset);

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x06000138 RID: 312
		private delegate int GetParticlesWithNativeArrayDelegate(IntPtr @this, IntPtr particles, int particlesLength, int size, int offset);

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x0600013A RID: 314
		private delegate void SetCustomParticleDataDelegate(IntPtr @this, IntPtr customData, ParticleSystemCustomData streamIndex);

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x0600013C RID: 316
		private delegate int GetCustomParticleDataDelegate(IntPtr @this, IntPtr customData, ParticleSystemCustomData streamIndex);

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x0600013E RID: 318
		private delegate void PlayDelegate(IntPtr @this, bool withChildren);

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x06000140 RID: 320
		private delegate void PauseDelegate(IntPtr @this, bool withChildren);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x06000142 RID: 322
		private delegate void StopDelegate(IntPtr @this, bool withChildren, ParticleSystemStopBehavior stopBehavior);

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x06000144 RID: 324
		private delegate void ClearDelegate(IntPtr @this, bool withChildren);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x06000146 RID: 326
		private delegate bool IsAliveDelegate(IntPtr @this, bool withChildren);

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x06000148 RID: 328
		private delegate void TriggerSubEmitterDelegate(IntPtr @this, int subEmitterIndex, IntPtr particles);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x0600014A RID: 330
		private delegate void ResetPreMappedBufferMemoryDelegate();

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x0600014C RID: 332
		private delegate void SetMaximumPreMappedBufferCountsDelegate(int vertexBuffersCount, int indexBuffersCount);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x0600014E RID: 334
		private delegate void AllocateAxisOfRotationAttributeDelegate(IntPtr @this);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x06000150 RID: 336
		private delegate void AllocateMeshIndexAttributeDelegate(IntPtr @this);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x06000152 RID: 338
		private delegate void AllocateCustomDataAttributeDelegate(IntPtr @this, ParticleSystemCustomData stream);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x06000154 RID: 340
		private delegate IntPtr GetManagedJobDataDelegate(IntPtr @this);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x06000156 RID: 342
		private delegate void GetParticleCurrentSize3D_InjectedDelegate(IntPtr @this, IntPtr particle, [Out] IntPtr ret);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x06000158 RID: 344
		private delegate void TriggerSubEmitterForParticle_InjectedDelegate(IntPtr @this, int subEmitterIndex, IntPtr particle);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x0600015A RID: 346
		private delegate void GetManagedJobHandle_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x0600015C RID: 348
		private delegate void SetManagedJobHandle_InjectedDelegate(IntPtr @this, IntPtr handle);
	}
}
