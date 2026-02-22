using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.SubsystemsImplementation;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	public static class SubsystemManager : Object
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00002D14 File Offset: 0x00000F14
		// Note: this type is marked as 'beforefieldinit'.
		static SubsystemManager()
		{
			Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine", "SubsystemManager");
			SubsystemManager.NativeFieldInfoPtr_beforeReloadSubsystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, "beforeReloadSubsystems");
			SubsystemManager.NativeFieldInfoPtr_afterReloadSubsystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, "afterReloadSubsystems");
			SubsystemManager.NativeFieldInfoPtr_s_IntegratedSubsystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, "s_IntegratedSubsystems");
			SubsystemManager.NativeFieldInfoPtr_s_StandaloneSubsystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, "s_StandaloneSubsystems");
			SubsystemManager.NativeFieldInfoPtr_s_DeprecatedSubsystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, "s_DeprecatedSubsystems");
			SubsystemManager.NativeFieldInfoPtr_reloadSubsytemsStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, "reloadSubsytemsStarted");
			SubsystemManager.NativeFieldInfoPtr_reloadSubsytemsCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, "reloadSubsytemsCompleted");
			SubsystemManager.NativeMethodInfoPtr_ReloadSubsystemsStarted_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, 100663309);
			SubsystemManager.NativeMethodInfoPtr_ReloadSubsystemsCompleted_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, 100663310);
			SubsystemManager.NativeMethodInfoPtr_InitializeIntegratedSubsystem_Private_Static_Void_IntPtr_IntegratedSubsystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, 100663311);
			SubsystemManager.NativeMethodInfoPtr_ClearSubsystems_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, 100663312);
			SubsystemManager.NativeMethodInfoPtr_StaticConstructScriptingClassMap_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, 100663313);
			SubsystemManager.NativeMethodInfoPtr_GetIntegratedSubsystemByPtr_Internal_Static_IntegratedSubsystem_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, 100663315);
			SubsystemManager.ReportSingleSubsystemAnalyticsDelegateField = IL2CPP.ResolveICall<SubsystemManager.ReportSingleSubsystemAnalyticsDelegate>("UnityEngine.SubsystemManager::ReportSingleSubsystemAnalytics");
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002E50 File Offset: 0x00001050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131476, XrefRangeEnd = 131489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReloadSubsystemsStarted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemManager.NativeMethodInfoPtr_ReloadSubsystemsStarted_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002E78 File Offset: 0x00001078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131489, XrefRangeEnd = 131502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReloadSubsystemsCompleted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemManager.NativeMethodInfoPtr_ReloadSubsystemsCompleted_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002EA0 File Offset: 0x000010A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131502, XrefRangeEnd = 131512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeIntegratedSubsystem(IntPtr ptr, IntegratedSubsystem subsystem)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subsystem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemManager.NativeMethodInfoPtr_InitializeIntegratedSubsystem_Private_Static_Void_IntPtr_IntegratedSubsystem_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002EE4 File Offset: 0x000010E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131512, XrefRangeEnd = 131545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearSubsystems()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemManager.NativeMethodInfoPtr_ClearSubsystems_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002F0C File Offset: 0x0000110C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131545, XrefRangeEnd = 131571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StaticConstructScriptingClassMap()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemManager.NativeMethodInfoPtr_StaticConstructScriptingClassMap_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002F34 File Offset: 0x00001134
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131592, RefRangeEnd = 131594, XrefRangeStart = 131571, XrefRangeEnd = 131592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntegratedSubsystem GetIntegratedSubsystemByPtr(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemManager.NativeMethodInfoPtr_GetIntegratedSubsystemByPtr_Internal_Static_IntegratedSubsystem_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntegratedSubsystem>(intPtr3) : null;
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002277 File Offset: 0x00000477
		public SubsystemManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002F74 File Offset: 0x00001174
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00002280 File Offset: 0x00000480
		public unsafe static Action beforeReloadSubsystems
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubsystemManager.NativeFieldInfoPtr_beforeReloadSubsystems, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubsystemManager.NativeFieldInfoPtr_beforeReloadSubsystems, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002F9C File Offset: 0x0000119C
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00002292 File Offset: 0x00000492
		public unsafe static Action afterReloadSubsystems
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubsystemManager.NativeFieldInfoPtr_afterReloadSubsystems, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubsystemManager.NativeFieldInfoPtr_afterReloadSubsystems, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00002FC4 File Offset: 0x000011C4
		// (set) Token: 0x06000047 RID: 71 RVA: 0x000022A4 File Offset: 0x000004A4
		public unsafe static List<IntegratedSubsystem> s_IntegratedSubsystems
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubsystemManager.NativeFieldInfoPtr_s_IntegratedSubsystems, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IntegratedSubsystem>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubsystemManager.NativeFieldInfoPtr_s_IntegratedSubsystems, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00002FEC File Offset: 0x000011EC
		// (set) Token: 0x06000049 RID: 73 RVA: 0x000022B6 File Offset: 0x000004B6
		public unsafe static List<UnityEngine.SubsystemsImplementation.SubsystemWithProvider> s_StandaloneSubsystems
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubsystemManager.NativeFieldInfoPtr_s_StandaloneSubsystems, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnityEngine.SubsystemsImplementation.SubsystemWithProvider>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubsystemManager.NativeFieldInfoPtr_s_StandaloneSubsystems, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00003014 File Offset: 0x00001214
		// (set) Token: 0x0600004B RID: 75 RVA: 0x000022C8 File Offset: 0x000004C8
		public unsafe static List<Subsystem> s_DeprecatedSubsystems
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubsystemManager.NativeFieldInfoPtr_s_DeprecatedSubsystems, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Subsystem>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubsystemManager.NativeFieldInfoPtr_s_DeprecatedSubsystems, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004C RID: 76 RVA: 0x0000303C File Offset: 0x0000123C
		// (set) Token: 0x0600004D RID: 77 RVA: 0x000022DA File Offset: 0x000004DA
		public unsafe static Action reloadSubsytemsStarted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubsystemManager.NativeFieldInfoPtr_reloadSubsytemsStarted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubsystemManager.NativeFieldInfoPtr_reloadSubsytemsStarted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00003064 File Offset: 0x00001264
		// (set) Token: 0x0600004F RID: 79 RVA: 0x000022EC File Offset: 0x000004EC
		public unsafe static Action reloadSubsytemsCompleted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubsystemManager.NativeFieldInfoPtr_reloadSubsytemsCompleted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubsystemManager.NativeFieldInfoPtr_reloadSubsytemsCompleted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000022FE File Offset: 0x000004FE
		public static void ReportSingleSubsystemAnalytics(string id)
		{
			SubsystemManager.ReportSingleSubsystemAnalyticsDelegateField(IL2CPP.ManagedStringToIl2Cpp(id));
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002310 File Offset: 0x00000510
		public static void GetAllSubsystemDescriptors(List<ISubsystemDescriptor> descriptors)
		{
			UnityEngine.SubsystemsImplementation.SubsystemDescriptorStore.GetAllSubsystemDescriptors(descriptors);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000231A File Offset: 0x0000051A
		public static void GetSubsystemDescriptors<T>(List<T> descriptors)
		{
			UnityEngine.SubsystemsImplementation.SubsystemDescriptorStore.GetSubsystemDescriptors<T>(descriptors);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002324 File Offset: 0x00000524
		public static void GetSubsystems<T>(List<T> subsystems)
		{
			subsystems.Clear();
			SubsystemManager.AddSubsystemSubset<IntegratedSubsystem, T>(SubsystemManager.s_IntegratedSubsystems, subsystems);
			SubsystemManager.AddSubsystemSubset<UnityEngine.SubsystemsImplementation.SubsystemWithProvider, T>(SubsystemManager.s_StandaloneSubsystems, subsystems);
			SubsystemManager.AddSubsystemSubset<Subsystem, T>(SubsystemManager.s_DeprecatedSubsystems, subsystems);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000308C File Offset: 0x0000128C
		public static void AddSubsystemSubset<TBaseTypeInList, TQueryType>(List<TBaseTypeInList> copyFrom, List<TQueryType> copyTo)
		{
			List<TBaseTypeInList>.Enumerator enumerator = copyFrom.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TBaseTypeInList tbaseTypeInList = enumerator.Current;
					TQueryType tqueryType;
					bool flag;
					if (tbaseTypeInList.TryCast<TQueryType>() != null)
					{
						tqueryType = tbaseTypeInList.TryCast<TQueryType>().Cast<TQueryType>();
						flag = true;
					}
					else
					{
						flag = false;
					}
					bool flag2 = flag;
					if (flag2)
					{
						copyTo.Add(tqueryType);
					}
				}
			}
			finally
			{
				enumerator.Dispose();
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003108 File Offset: 0x00001308
		public static void RemoveIntegratedSubsystemByPtr(IntPtr ptr)
		{
			for (int i = 0; i < SubsystemManager.s_IntegratedSubsystems.Count; i++)
			{
				bool flag = SubsystemManager.s_IntegratedSubsystems[i].m_Ptr != ptr;
				if (!flag)
				{
					SubsystemManager.s_IntegratedSubsystems[i].m_Ptr = IntPtr.Zero;
					SubsystemManager.s_IntegratedSubsystems.RemoveAt(i);
					break;
				}
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002352 File Offset: 0x00000552
		public static void AddStandaloneSubsystem(UnityEngine.SubsystemsImplementation.SubsystemWithProvider subsystem)
		{
			SubsystemManager.s_StandaloneSubsystems.Add(subsystem);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003170 File Offset: 0x00001370
		public static bool RemoveStandaloneSubsystem(UnityEngine.SubsystemsImplementation.SubsystemWithProvider subsystem)
		{
			return SubsystemManager.s_StandaloneSubsystems.Remove(subsystem);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003190 File Offset: 0x00001390
		public static UnityEngine.SubsystemsImplementation.SubsystemWithProvider FindStandaloneSubsystemByDescriptor(UnityEngine.SubsystemsImplementation.SubsystemDescriptorWithProvider descriptor)
		{
			List<UnityEngine.SubsystemsImplementation.SubsystemWithProvider>.Enumerator enumerator = SubsystemManager.s_StandaloneSubsystems.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					UnityEngine.SubsystemsImplementation.SubsystemWithProvider subsystemWithProvider = enumerator.Current;
					bool flag = subsystemWithProvider.descriptor == descriptor;
					if (flag)
					{
						return subsystemWithProvider;
					}
				}
			}
			finally
			{
				enumerator.Dispose();
			}
			return null;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002361 File Offset: 0x00000561
		public static void GetInstances<T>(List<T> subsystems)
		{
			SubsystemManager.GetSubsystems<T>(subsystems);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000236B File Offset: 0x0000056B
		public static void AddDeprecatedSubsystem(Subsystem subsystem)
		{
			SubsystemManager.s_DeprecatedSubsystems.Add(subsystem);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002379 File Offset: 0x00000579
		public static bool RemoveDeprecatedSubsystem(Subsystem subsystem)
		{
			return SubsystemManager.s_DeprecatedSubsystems.Remove(subsystem);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002386 File Offset: 0x00000586
		public static Subsystem FindDeprecatedSubsystemByDescriptor(SubsystemDescriptor descriptor)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_beforeReloadSubsystems;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_afterReloadSubsystems;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_s_IntegratedSubsystems;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_s_StandaloneSubsystems;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_s_DeprecatedSubsystems;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_reloadSubsytemsStarted;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr_reloadSubsytemsCompleted;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_ReloadSubsystemsStarted_Private_Static_Void_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_ReloadSubsystemsCompleted_Private_Static_Void_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_InitializeIntegratedSubsystem_Private_Static_Void_IntPtr_IntegratedSubsystem_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_ClearSubsystems_Private_Static_Void_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_StaticConstructScriptingClassMap_Private_Static_Void_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_GetIntegratedSubsystemByPtr_Internal_Static_IntegratedSubsystem_IntPtr_0;

		// Token: 0x04000022 RID: 34
		private static readonly SubsystemManager.ReportSingleSubsystemAnalyticsDelegate ReportSingleSubsystemAnalyticsDelegateField;

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x06000099 RID: 153
		private delegate void ReportSingleSubsystemAnalyticsDelegate(IntPtr id);
	}
}
