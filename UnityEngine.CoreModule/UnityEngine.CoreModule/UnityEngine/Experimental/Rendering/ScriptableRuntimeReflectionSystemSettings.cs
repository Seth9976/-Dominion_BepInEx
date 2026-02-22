using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x0200016B RID: 363
	public static class ScriptableRuntimeReflectionSystemSettings : Object
	{
		// Token: 0x06001AF7 RID: 6903 RVA: 0x000600EC File Offset: 0x0005E2EC
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptableRuntimeReflectionSystemSettings()
		{
			Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Rendering", "ScriptableRuntimeReflectionSystemSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr);
			ScriptableRuntimeReflectionSystemSettings.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr, "s_Instance");
			ScriptableRuntimeReflectionSystemSettings.NativeMethodInfoPtr_set_Internal_ScriptableRuntimeReflectionSystemSettings_system_Private_Static_set_Void_IScriptableRuntimeReflectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr, 100665279);
			ScriptableRuntimeReflectionSystemSettings.NativeMethodInfoPtr_get_Internal_ScriptableRuntimeReflectionSystemSettings_instance_Private_Static_get_ScriptableRuntimeReflectionSystemWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr, 100665280);
			ScriptableRuntimeReflectionSystemSettings.NativeMethodInfoPtr_ScriptingDirtyReflectionSystemInstance_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr, 100665281);
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001B00 RID: 6912 RVA: 0x00060240 File Offset: 0x0005E440
		// (set) Token: 0x06001AF8 RID: 6904 RVA: 0x0006016C File Offset: 0x0005E36C
		public unsafe static IScriptableRuntimeReflectionSystem Internal_ScriptableRuntimeReflectionSystemSettings_system
		{
			get
			{
				return ScriptableRuntimeReflectionSystemSettings.s_Instance.implementation;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83153, XrefRangeEnd = 83167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemSettings.NativeMethodInfoPtr_set_Internal_ScriptableRuntimeReflectionSystemSettings_system_Private_Static_set_Void_IScriptableRuntimeReflectionSystem_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001AF9 RID: 6905 RVA: 0x000601A4 File Offset: 0x0005E3A4
		public unsafe static ScriptableRuntimeReflectionSystemWrapper Internal_ScriptableRuntimeReflectionSystemSettings_instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83167, XrefRangeEnd = 83171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemSettings.NativeMethodInfoPtr_get_Internal_ScriptableRuntimeReflectionSystemSettings_instance_Private_Static_get_ScriptableRuntimeReflectionSystemWrapper_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableRuntimeReflectionSystemWrapper>(intPtr3) : null;
			}
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x000601D8 File Offset: 0x0005E3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83171, XrefRangeEnd = 83179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScriptingDirtyReflectionSystemInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemSettings.NativeMethodInfoPtr_ScriptingDirtyReflectionSystemInstance_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x0000ED82 File Offset: 0x0000CF82
		public ScriptableRuntimeReflectionSystemSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001AFC RID: 6908 RVA: 0x00060200 File Offset: 0x0005E400
		// (set) Token: 0x06001AFD RID: 6909 RVA: 0x0000ED8B File Offset: 0x0000CF8B
		public unsafe static ScriptableRuntimeReflectionSystemWrapper s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScriptableRuntimeReflectionSystemSettings.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableRuntimeReflectionSystemWrapper>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableRuntimeReflectionSystemSettings.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001AFE RID: 6910 RVA: 0x00060228 File Offset: 0x0005E428
		// (set) Token: 0x06001AFF RID: 6911 RVA: 0x0000ED9D File Offset: 0x0000CF9D
		public static IScriptableRuntimeReflectionSystem system
		{
			get
			{
				return ScriptableRuntimeReflectionSystemSettings.Internal_ScriptableRuntimeReflectionSystemSettings_system;
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0400143F RID: 5183
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04001440 RID: 5184
		private static readonly IntPtr NativeMethodInfoPtr_set_Internal_ScriptableRuntimeReflectionSystemSettings_system_Private_Static_set_Void_IScriptableRuntimeReflectionSystem_0;

		// Token: 0x04001441 RID: 5185
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_ScriptableRuntimeReflectionSystemSettings_instance_Private_Static_get_ScriptableRuntimeReflectionSystemWrapper_0;

		// Token: 0x04001442 RID: 5186
		private static readonly IntPtr NativeMethodInfoPtr_ScriptingDirtyReflectionSystemInstance_Private_Static_Void_0;
	}
}
