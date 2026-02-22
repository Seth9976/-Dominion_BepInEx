using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002B4 RID: 692
	public sealed class SteamDatagramGameCoordinatorServerLogin : ValueType
	{
		// Token: 0x0600279B RID: 10139 RVA: 0x000ACE08 File Offset: 0x000AB008
		// Note: this type is marked as 'beforefieldinit'.
		static SteamDatagramGameCoordinatorServerLogin()
		{
			Il2CppClassPointerStore<SteamDatagramGameCoordinatorServerLogin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamDatagramGameCoordinatorServerLogin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamDatagramGameCoordinatorServerLogin>.NativeClassPtr);
			SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_m_identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramGameCoordinatorServerLogin>.NativeClassPtr, "m_identity");
			SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_m_routing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramGameCoordinatorServerLogin>.NativeClassPtr, "m_routing");
			SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramGameCoordinatorServerLogin>.NativeClassPtr, "m_nAppID");
			SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_m_rtime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramGameCoordinatorServerLogin>.NativeClassPtr, "m_rtime");
			SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_m_cbAppData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramGameCoordinatorServerLogin>.NativeClassPtr, "m_cbAppData");
			SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_m_appData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramGameCoordinatorServerLogin>.NativeClassPtr, "m_appData");
		}

		// Token: 0x0600279C RID: 10140 RVA: 0x0000FE7E File Offset: 0x0000E07E
		public SteamDatagramGameCoordinatorServerLogin(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x0000FE87 File Offset: 0x0000E087
		public SteamDatagramGameCoordinatorServerLogin()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamDatagramGameCoordinatorServerLogin>.NativeClassPtr))
		{
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x0600279E RID: 10142 RVA: 0x000ACEB0 File Offset: 0x000AB0B0
		// (set) Token: 0x0600279F RID: 10143 RVA: 0x0000FE99 File Offset: 0x0000E099
		public SteamNetworkingIdentity m_identity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_m_identity);
				return new SteamNetworkingIdentity(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_m_identity), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x060027A0 RID: 10144 RVA: 0x000ACEE0 File Offset: 0x000AB0E0
		// (set) Token: 0x060027A1 RID: 10145 RVA: 0x0000FEC7 File Offset: 0x0000E0C7
		public SteamDatagramHostedAddress m_routing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_m_routing);
				return new SteamDatagramHostedAddress(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamDatagramHostedAddress>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_m_routing), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SteamDatagramHostedAddress>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x060027A2 RID: 10146 RVA: 0x000ACF10 File Offset: 0x000AB110
		// (set) Token: 0x060027A3 RID: 10147 RVA: 0x0000FEF5 File Offset: 0x0000E0F5
		public unsafe AppId_t m_nAppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_m_nAppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_m_nAppID)) = value;
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x060027A4 RID: 10148 RVA: 0x000ACF38 File Offset: 0x000AB138
		// (set) Token: 0x060027A5 RID: 10149 RVA: 0x0000FF10 File Offset: 0x0000E110
		public unsafe RTime32 m_rtime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_m_rtime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_m_rtime)) = value;
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x060027A6 RID: 10150 RVA: 0x000ACF60 File Offset: 0x000AB160
		// (set) Token: 0x060027A7 RID: 10151 RVA: 0x0000FF2B File Offset: 0x0000E12B
		public unsafe int m_cbAppData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_m_cbAppData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_m_cbAppData)) = value;
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x060027A8 RID: 10152 RVA: 0x000ACF88 File Offset: 0x000AB188
		// (set) Token: 0x060027A9 RID: 10153 RVA: 0x0000FF46 File Offset: 0x0000E146
		public unsafe Il2CppStructArray<byte> m_appData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_m_appData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramGameCoordinatorServerLogin.NativeFieldInfoPtr_m_appData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040026DD RID: 9949
		private static readonly IntPtr NativeFieldInfoPtr_m_identity;

		// Token: 0x040026DE RID: 9950
		private static readonly IntPtr NativeFieldInfoPtr_m_routing;

		// Token: 0x040026DF RID: 9951
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x040026E0 RID: 9952
		private static readonly IntPtr NativeFieldInfoPtr_m_rtime;

		// Token: 0x040026E1 RID: 9953
		private static readonly IntPtr NativeFieldInfoPtr_m_cbAppData;

		// Token: 0x040026E2 RID: 9954
		private static readonly IntPtr NativeFieldInfoPtr_m_appData;
	}
}
