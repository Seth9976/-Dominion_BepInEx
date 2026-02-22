using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001EA RID: 490
	public sealed class SteamRelayNetworkStatus_t : ValueType
	{
		// Token: 0x06002368 RID: 9064 RVA: 0x000A4AA8 File Offset: 0x000A2CA8
		// Note: this type is marked as 'beforefieldinit'.
		static SteamRelayNetworkStatus_t()
		{
			Il2CppClassPointerStore<SteamRelayNetworkStatus_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamRelayNetworkStatus_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamRelayNetworkStatus_t>.NativeClassPtr);
			SteamRelayNetworkStatus_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRelayNetworkStatus_t>.NativeClassPtr, "k_iCallback");
			SteamRelayNetworkStatus_t.NativeFieldInfoPtr_m_eAvail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRelayNetworkStatus_t>.NativeClassPtr, "m_eAvail");
			SteamRelayNetworkStatus_t.NativeFieldInfoPtr_m_bPingMeasurementInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRelayNetworkStatus_t>.NativeClassPtr, "m_bPingMeasurementInProgress");
			SteamRelayNetworkStatus_t.NativeFieldInfoPtr_m_eAvailNetworkConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRelayNetworkStatus_t>.NativeClassPtr, "m_eAvailNetworkConfig");
			SteamRelayNetworkStatus_t.NativeFieldInfoPtr_m_eAvailAnyRelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRelayNetworkStatus_t>.NativeClassPtr, "m_eAvailAnyRelay");
			SteamRelayNetworkStatus_t.NativeFieldInfoPtr_m_debugMsg_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRelayNetworkStatus_t>.NativeClassPtr, "m_debugMsg_");
			SteamRelayNetworkStatus_t.NativeMethodInfoPtr_get_m_debugMsg_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRelayNetworkStatus_t>.NativeClassPtr, 100668349);
			SteamRelayNetworkStatus_t.NativeMethodInfoPtr_set_m_debugMsg_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRelayNetworkStatus_t>.NativeClassPtr, 100668350);
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06002369 RID: 9065 RVA: 0x000A4B78 File Offset: 0x000A2D78
		// (set) Token: 0x0600236A RID: 9066 RVA: 0x000A4BB4 File Offset: 0x000A2DB4
		public unsafe string m_debugMsg
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 206854, RefRangeEnd = 206855, XrefRangeStart = 206854, XrefRangeEnd = 206855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRelayNetworkStatus_t.NativeMethodInfoPtr_get_m_debugMsg_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206871, XrefRangeEnd = 206872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRelayNetworkStatus_t.NativeMethodInfoPtr_set_m_debugMsg_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600236B RID: 9067 RVA: 0x0000D823 File Offset: 0x0000BA23
		public SteamRelayNetworkStatus_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x0000D82C File Offset: 0x0000BA2C
		public SteamRelayNetworkStatus_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamRelayNetworkStatus_t>.NativeClassPtr))
		{
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x0600236D RID: 9069 RVA: 0x000A4BFC File Offset: 0x000A2DFC
		// (set) Token: 0x0600236E RID: 9070 RVA: 0x0000D83E File Offset: 0x0000BA3E
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamRelayNetworkStatus_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamRelayNetworkStatus_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x0600236F RID: 9071 RVA: 0x000A4C18 File Offset: 0x000A2E18
		// (set) Token: 0x06002370 RID: 9072 RVA: 0x0000D84C File Offset: 0x0000BA4C
		public unsafe ESteamNetworkingAvailability m_eAvail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRelayNetworkStatus_t.NativeFieldInfoPtr_m_eAvail);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRelayNetworkStatus_t.NativeFieldInfoPtr_m_eAvail)) = value;
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06002371 RID: 9073 RVA: 0x000A4C40 File Offset: 0x000A2E40
		// (set) Token: 0x06002372 RID: 9074 RVA: 0x0000D867 File Offset: 0x0000BA67
		public unsafe int m_bPingMeasurementInProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRelayNetworkStatus_t.NativeFieldInfoPtr_m_bPingMeasurementInProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRelayNetworkStatus_t.NativeFieldInfoPtr_m_bPingMeasurementInProgress)) = value;
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06002373 RID: 9075 RVA: 0x000A4C68 File Offset: 0x000A2E68
		// (set) Token: 0x06002374 RID: 9076 RVA: 0x0000D882 File Offset: 0x0000BA82
		public unsafe ESteamNetworkingAvailability m_eAvailNetworkConfig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRelayNetworkStatus_t.NativeFieldInfoPtr_m_eAvailNetworkConfig);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRelayNetworkStatus_t.NativeFieldInfoPtr_m_eAvailNetworkConfig)) = value;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06002375 RID: 9077 RVA: 0x000A4C90 File Offset: 0x000A2E90
		// (set) Token: 0x06002376 RID: 9078 RVA: 0x0000D89D File Offset: 0x0000BA9D
		public unsafe ESteamNetworkingAvailability m_eAvailAnyRelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRelayNetworkStatus_t.NativeFieldInfoPtr_m_eAvailAnyRelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRelayNetworkStatus_t.NativeFieldInfoPtr_m_eAvailAnyRelay)) = value;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06002377 RID: 9079 RVA: 0x000A4CB8 File Offset: 0x000A2EB8
		// (set) Token: 0x06002378 RID: 9080 RVA: 0x0000D8B8 File Offset: 0x0000BAB8
		public unsafe Il2CppStructArray<byte> m_debugMsg_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRelayNetworkStatus_t.NativeFieldInfoPtr_m_debugMsg_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRelayNetworkStatus_t.NativeFieldInfoPtr_m_debugMsg_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D13 RID: 7443
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001D14 RID: 7444
		private static readonly IntPtr NativeFieldInfoPtr_m_eAvail;

		// Token: 0x04001D15 RID: 7445
		private static readonly IntPtr NativeFieldInfoPtr_m_bPingMeasurementInProgress;

		// Token: 0x04001D16 RID: 7446
		private static readonly IntPtr NativeFieldInfoPtr_m_eAvailNetworkConfig;

		// Token: 0x04001D17 RID: 7447
		private static readonly IntPtr NativeFieldInfoPtr_m_eAvailAnyRelay;

		// Token: 0x04001D18 RID: 7448
		private static readonly IntPtr NativeFieldInfoPtr_m_debugMsg_;

		// Token: 0x04001D19 RID: 7449
		private static readonly IntPtr NativeMethodInfoPtr_get_m_debugMsg_Public_get_String_0;

		// Token: 0x04001D1A RID: 7450
		private static readonly IntPtr NativeMethodInfoPtr_set_m_debugMsg_Public_set_Void_String_0;
	}
}
