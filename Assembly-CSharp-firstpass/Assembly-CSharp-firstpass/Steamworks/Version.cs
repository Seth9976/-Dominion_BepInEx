using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002C7 RID: 711
	public static class Version : Object
	{
		// Token: 0x060028B1 RID: 10417 RVA: 0x000B0208 File Offset: 0x000AE408
		// Note: this type is marked as 'beforefieldinit'.
		static Version()
		{
			Il2CppClassPointerStore<Version>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "Version");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Version>.NativeClassPtr);
			Version.NativeFieldInfoPtr_SteamworksNETVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "SteamworksNETVersion");
			Version.NativeFieldInfoPtr_SteamworksSDKVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "SteamworksSDKVersion");
			Version.NativeFieldInfoPtr_SteamAPIDLLVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "SteamAPIDLLVersion");
			Version.NativeFieldInfoPtr_SteamAPIDLLSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "SteamAPIDLLSize");
			Version.NativeFieldInfoPtr_SteamAPI64DLLSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "SteamAPI64DLLSize");
		}

		// Token: 0x060028B2 RID: 10418 RVA: 0x000107BA File Offset: 0x0000E9BA
		public Version(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x060028B3 RID: 10419 RVA: 0x000B029C File Offset: 0x000AE49C
		// (set) Token: 0x060028B4 RID: 10420 RVA: 0x000107C3 File Offset: 0x0000E9C3
		public unsafe static string SteamworksNETVersion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Version.NativeFieldInfoPtr_SteamworksNETVersion, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Version.NativeFieldInfoPtr_SteamworksNETVersion, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x060028B5 RID: 10421 RVA: 0x000B02BC File Offset: 0x000AE4BC
		// (set) Token: 0x060028B6 RID: 10422 RVA: 0x000107D5 File Offset: 0x0000E9D5
		public unsafe static string SteamworksSDKVersion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Version.NativeFieldInfoPtr_SteamworksSDKVersion, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Version.NativeFieldInfoPtr_SteamworksSDKVersion, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x060028B7 RID: 10423 RVA: 0x000B02DC File Offset: 0x000AE4DC
		// (set) Token: 0x060028B8 RID: 10424 RVA: 0x000107E7 File Offset: 0x0000E9E7
		public unsafe static string SteamAPIDLLVersion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Version.NativeFieldInfoPtr_SteamAPIDLLVersion, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Version.NativeFieldInfoPtr_SteamAPIDLLVersion, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x060028B9 RID: 10425 RVA: 0x000B02FC File Offset: 0x000AE4FC
		// (set) Token: 0x060028BA RID: 10426 RVA: 0x000107F9 File Offset: 0x0000E9F9
		public unsafe static int SteamAPIDLLSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Version.NativeFieldInfoPtr_SteamAPIDLLSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Version.NativeFieldInfoPtr_SteamAPIDLLSize, (void*)(&value));
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x060028BB RID: 10427 RVA: 0x000B0318 File Offset: 0x000AE518
		// (set) Token: 0x060028BC RID: 10428 RVA: 0x00010807 File Offset: 0x0000EA07
		public unsafe static int SteamAPI64DLLSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Version.NativeFieldInfoPtr_SteamAPI64DLLSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Version.NativeFieldInfoPtr_SteamAPI64DLLSize, (void*)(&value));
			}
		}

		// Token: 0x04002780 RID: 10112
		private static readonly IntPtr NativeFieldInfoPtr_SteamworksNETVersion;

		// Token: 0x04002781 RID: 10113
		private static readonly IntPtr NativeFieldInfoPtr_SteamworksSDKVersion;

		// Token: 0x04002782 RID: 10114
		private static readonly IntPtr NativeFieldInfoPtr_SteamAPIDLLVersion;

		// Token: 0x04002783 RID: 10115
		private static readonly IntPtr NativeFieldInfoPtr_SteamAPIDLLSize;

		// Token: 0x04002784 RID: 10116
		private static readonly IntPtr NativeFieldInfoPtr_SteamAPI64DLLSize;
	}
}
