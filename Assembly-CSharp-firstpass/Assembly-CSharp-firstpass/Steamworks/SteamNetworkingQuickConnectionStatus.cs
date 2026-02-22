using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002B6 RID: 694
	public sealed class SteamNetworkingQuickConnectionStatus : ValueType
	{
		// Token: 0x060027C9 RID: 10185 RVA: 0x000AD438 File Offset: 0x000AB638
		// Note: this type is marked as 'beforefieldinit'.
		static SteamNetworkingQuickConnectionStatus()
		{
			Il2CppClassPointerStore<SteamNetworkingQuickConnectionStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamNetworkingQuickConnectionStatus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetworkingQuickConnectionStatus>.NativeClassPtr);
			SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_eState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingQuickConnectionStatus>.NativeClassPtr, "m_eState");
			SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_nPing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingQuickConnectionStatus>.NativeClassPtr, "m_nPing");
			SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_flConnectionQualityLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingQuickConnectionStatus>.NativeClassPtr, "m_flConnectionQualityLocal");
			SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_flConnectionQualityRemote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingQuickConnectionStatus>.NativeClassPtr, "m_flConnectionQualityRemote");
			SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_flOutPacketsPerSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingQuickConnectionStatus>.NativeClassPtr, "m_flOutPacketsPerSec");
			SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_flOutBytesPerSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingQuickConnectionStatus>.NativeClassPtr, "m_flOutBytesPerSec");
			SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_flInPacketsPerSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingQuickConnectionStatus>.NativeClassPtr, "m_flInPacketsPerSec");
			SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_flInBytesPerSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingQuickConnectionStatus>.NativeClassPtr, "m_flInBytesPerSec");
			SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_nSendRateBytesPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingQuickConnectionStatus>.NativeClassPtr, "m_nSendRateBytesPerSecond");
			SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_cbPendingUnreliable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingQuickConnectionStatus>.NativeClassPtr, "m_cbPendingUnreliable");
			SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_cbPendingReliable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingQuickConnectionStatus>.NativeClassPtr, "m_cbPendingReliable");
			SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_cbSentUnackedReliable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingQuickConnectionStatus>.NativeClassPtr, "m_cbSentUnackedReliable");
			SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_usecQueueTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingQuickConnectionStatus>.NativeClassPtr, "m_usecQueueTime");
			SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingQuickConnectionStatus>.NativeClassPtr, "reserved");
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x000100F6 File Offset: 0x0000E2F6
		public SteamNetworkingQuickConnectionStatus(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x000100FF File Offset: 0x0000E2FF
		public SteamNetworkingQuickConnectionStatus()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamNetworkingQuickConnectionStatus>.NativeClassPtr))
		{
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x060027CC RID: 10188 RVA: 0x000AD580 File Offset: 0x000AB780
		// (set) Token: 0x060027CD RID: 10189 RVA: 0x00010111 File Offset: 0x0000E311
		public unsafe ESteamNetworkingConnectionState m_eState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_eState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_eState)) = value;
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x060027CE RID: 10190 RVA: 0x000AD5A8 File Offset: 0x000AB7A8
		// (set) Token: 0x060027CF RID: 10191 RVA: 0x0001012C File Offset: 0x0000E32C
		public unsafe int m_nPing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_nPing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_nPing)) = value;
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x060027D0 RID: 10192 RVA: 0x000AD5D0 File Offset: 0x000AB7D0
		// (set) Token: 0x060027D1 RID: 10193 RVA: 0x00010147 File Offset: 0x0000E347
		public unsafe float m_flConnectionQualityLocal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_flConnectionQualityLocal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_flConnectionQualityLocal)) = value;
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x060027D2 RID: 10194 RVA: 0x000AD5F8 File Offset: 0x000AB7F8
		// (set) Token: 0x060027D3 RID: 10195 RVA: 0x00010162 File Offset: 0x0000E362
		public unsafe float m_flConnectionQualityRemote
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_flConnectionQualityRemote);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_flConnectionQualityRemote)) = value;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x060027D4 RID: 10196 RVA: 0x000AD620 File Offset: 0x000AB820
		// (set) Token: 0x060027D5 RID: 10197 RVA: 0x0001017D File Offset: 0x0000E37D
		public unsafe float m_flOutPacketsPerSec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_flOutPacketsPerSec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_flOutPacketsPerSec)) = value;
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x060027D6 RID: 10198 RVA: 0x000AD648 File Offset: 0x000AB848
		// (set) Token: 0x060027D7 RID: 10199 RVA: 0x00010198 File Offset: 0x0000E398
		public unsafe float m_flOutBytesPerSec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_flOutBytesPerSec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_flOutBytesPerSec)) = value;
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x060027D8 RID: 10200 RVA: 0x000AD670 File Offset: 0x000AB870
		// (set) Token: 0x060027D9 RID: 10201 RVA: 0x000101B3 File Offset: 0x0000E3B3
		public unsafe float m_flInPacketsPerSec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_flInPacketsPerSec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_flInPacketsPerSec)) = value;
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x060027DA RID: 10202 RVA: 0x000AD698 File Offset: 0x000AB898
		// (set) Token: 0x060027DB RID: 10203 RVA: 0x000101CE File Offset: 0x0000E3CE
		public unsafe float m_flInBytesPerSec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_flInBytesPerSec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_flInBytesPerSec)) = value;
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x060027DC RID: 10204 RVA: 0x000AD6C0 File Offset: 0x000AB8C0
		// (set) Token: 0x060027DD RID: 10205 RVA: 0x000101E9 File Offset: 0x0000E3E9
		public unsafe int m_nSendRateBytesPerSecond
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_nSendRateBytesPerSecond);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_nSendRateBytesPerSecond)) = value;
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x060027DE RID: 10206 RVA: 0x000AD6E8 File Offset: 0x000AB8E8
		// (set) Token: 0x060027DF RID: 10207 RVA: 0x00010204 File Offset: 0x0000E404
		public unsafe int m_cbPendingUnreliable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_cbPendingUnreliable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_cbPendingUnreliable)) = value;
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x060027E0 RID: 10208 RVA: 0x000AD710 File Offset: 0x000AB910
		// (set) Token: 0x060027E1 RID: 10209 RVA: 0x0001021F File Offset: 0x0000E41F
		public unsafe int m_cbPendingReliable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_cbPendingReliable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_cbPendingReliable)) = value;
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x060027E2 RID: 10210 RVA: 0x000AD738 File Offset: 0x000AB938
		// (set) Token: 0x060027E3 RID: 10211 RVA: 0x0001023A File Offset: 0x0000E43A
		public unsafe int m_cbSentUnackedReliable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_cbSentUnackedReliable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_cbSentUnackedReliable)) = value;
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x060027E4 RID: 10212 RVA: 0x000AD760 File Offset: 0x000AB960
		// (set) Token: 0x060027E5 RID: 10213 RVA: 0x00010255 File Offset: 0x0000E455
		public unsafe SteamNetworkingMicroseconds m_usecQueueTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_usecQueueTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_m_usecQueueTime)) = value;
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x060027E6 RID: 10214 RVA: 0x000AD788 File Offset: 0x000AB988
		// (set) Token: 0x060027E7 RID: 10215 RVA: 0x00010270 File Offset: 0x0000E470
		public unsafe Il2CppStructArray<uint> reserved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_reserved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingQuickConnectionStatus.NativeFieldInfoPtr_reserved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040026F3 RID: 9971
		private static readonly IntPtr NativeFieldInfoPtr_m_eState;

		// Token: 0x040026F4 RID: 9972
		private static readonly IntPtr NativeFieldInfoPtr_m_nPing;

		// Token: 0x040026F5 RID: 9973
		private static readonly IntPtr NativeFieldInfoPtr_m_flConnectionQualityLocal;

		// Token: 0x040026F6 RID: 9974
		private static readonly IntPtr NativeFieldInfoPtr_m_flConnectionQualityRemote;

		// Token: 0x040026F7 RID: 9975
		private static readonly IntPtr NativeFieldInfoPtr_m_flOutPacketsPerSec;

		// Token: 0x040026F8 RID: 9976
		private static readonly IntPtr NativeFieldInfoPtr_m_flOutBytesPerSec;

		// Token: 0x040026F9 RID: 9977
		private static readonly IntPtr NativeFieldInfoPtr_m_flInPacketsPerSec;

		// Token: 0x040026FA RID: 9978
		private static readonly IntPtr NativeFieldInfoPtr_m_flInBytesPerSec;

		// Token: 0x040026FB RID: 9979
		private static readonly IntPtr NativeFieldInfoPtr_m_nSendRateBytesPerSecond;

		// Token: 0x040026FC RID: 9980
		private static readonly IntPtr NativeFieldInfoPtr_m_cbPendingUnreliable;

		// Token: 0x040026FD RID: 9981
		private static readonly IntPtr NativeFieldInfoPtr_m_cbPendingReliable;

		// Token: 0x040026FE RID: 9982
		private static readonly IntPtr NativeFieldInfoPtr_m_cbSentUnackedReliable;

		// Token: 0x040026FF RID: 9983
		private static readonly IntPtr NativeFieldInfoPtr_m_usecQueueTime;

		// Token: 0x04002700 RID: 9984
		private static readonly IntPtr NativeFieldInfoPtr_reserved;
	}
}
