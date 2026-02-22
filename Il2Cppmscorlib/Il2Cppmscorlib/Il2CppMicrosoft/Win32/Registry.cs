using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Win32
{
	// Token: 0x0200003F RID: 63
	public static class Registry : Object
	{
		// Token: 0x06000427 RID: 1063 RVA: 0x00032788 File Offset: 0x00030988
		// Note: this type is marked as 'beforefieldinit'.
		static Registry()
		{
			Il2CppClassPointerStore<Registry>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32", "Registry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Registry>.NativeClassPtr);
			Registry.NativeFieldInfoPtr_ClassesRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "ClassesRoot");
			Registry.NativeFieldInfoPtr_CurrentConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "CurrentConfig");
			Registry.NativeFieldInfoPtr_CurrentUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "CurrentUser");
			Registry.NativeFieldInfoPtr_DynData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "DynData");
			Registry.NativeFieldInfoPtr_LocalMachine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "LocalMachine");
			Registry.NativeFieldInfoPtr_PerformanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "PerformanceData");
			Registry.NativeFieldInfoPtr_Users = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "Users");
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00003ADE File Offset: 0x00001CDE
		public Registry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00032844 File Offset: 0x00030A44
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x00003AE7 File Offset: 0x00001CE7
		public unsafe static RegistryKey ClassesRoot
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Registry.NativeFieldInfoPtr_ClassesRoot, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Registry.NativeFieldInfoPtr_ClassesRoot, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x0003286C File Offset: 0x00030A6C
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x00003AF9 File Offset: 0x00001CF9
		public unsafe static RegistryKey CurrentConfig
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Registry.NativeFieldInfoPtr_CurrentConfig, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Registry.NativeFieldInfoPtr_CurrentConfig, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x00032894 File Offset: 0x00030A94
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x00003B0B File Offset: 0x00001D0B
		public unsafe static RegistryKey CurrentUser
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Registry.NativeFieldInfoPtr_CurrentUser, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Registry.NativeFieldInfoPtr_CurrentUser, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x000328BC File Offset: 0x00030ABC
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x00003B1D File Offset: 0x00001D1D
		public unsafe static RegistryKey DynData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Registry.NativeFieldInfoPtr_DynData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Registry.NativeFieldInfoPtr_DynData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x000328E4 File Offset: 0x00030AE4
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x00003B2F File Offset: 0x00001D2F
		public unsafe static RegistryKey LocalMachine
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Registry.NativeFieldInfoPtr_LocalMachine, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Registry.NativeFieldInfoPtr_LocalMachine, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x0003290C File Offset: 0x00030B0C
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x00003B41 File Offset: 0x00001D41
		public unsafe static RegistryKey PerformanceData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Registry.NativeFieldInfoPtr_PerformanceData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Registry.NativeFieldInfoPtr_PerformanceData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x00032934 File Offset: 0x00030B34
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x00003B53 File Offset: 0x00001D53
		public unsafe static RegistryKey Users
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Registry.NativeFieldInfoPtr_Users, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Registry.NativeFieldInfoPtr_Users, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeFieldInfoPtr_ClassesRoot;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeFieldInfoPtr_CurrentConfig;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeFieldInfoPtr_CurrentUser;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeFieldInfoPtr_DynData;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeFieldInfoPtr_LocalMachine;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeFieldInfoPtr_PerformanceData;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeFieldInfoPtr_Users;
	}
}
