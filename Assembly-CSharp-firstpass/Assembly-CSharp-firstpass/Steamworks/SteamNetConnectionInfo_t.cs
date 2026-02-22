using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002B5 RID: 693
	public sealed class SteamNetConnectionInfo_t : ValueType
	{
		// Token: 0x060027AA RID: 10154 RVA: 0x000ACFB8 File Offset: 0x000AB1B8
		// Note: this type is marked as 'beforefieldinit'.
		static SteamNetConnectionInfo_t()
		{
			Il2CppClassPointerStore<SteamNetConnectionInfo_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamNetConnectionInfo_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetConnectionInfo_t>.NativeClassPtr);
			SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_identityRemote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetConnectionInfo_t>.NativeClassPtr, "m_identityRemote");
			SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_nUserData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetConnectionInfo_t>.NativeClassPtr, "m_nUserData");
			SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_hListenSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetConnectionInfo_t>.NativeClassPtr, "m_hListenSocket");
			SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_addrRemote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetConnectionInfo_t>.NativeClassPtr, "m_addrRemote");
			SteamNetConnectionInfo_t.NativeFieldInfoPtr_m__pad1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetConnectionInfo_t>.NativeClassPtr, "m__pad1");
			SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_idPOPRemote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetConnectionInfo_t>.NativeClassPtr, "m_idPOPRemote");
			SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_idPOPRelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetConnectionInfo_t>.NativeClassPtr, "m_idPOPRelay");
			SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_eState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetConnectionInfo_t>.NativeClassPtr, "m_eState");
			SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_eEndReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetConnectionInfo_t>.NativeClassPtr, "m_eEndReason");
			SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_szEndDebug_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetConnectionInfo_t>.NativeClassPtr, "m_szEndDebug_");
			SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_szConnectionDescription_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetConnectionInfo_t>.NativeClassPtr, "m_szConnectionDescription_");
			SteamNetConnectionInfo_t.NativeFieldInfoPtr_reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetConnectionInfo_t>.NativeClassPtr, "reserved");
			SteamNetConnectionInfo_t.NativeMethodInfoPtr_get_m_szEndDebug_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetConnectionInfo_t>.NativeClassPtr, 100668394);
			SteamNetConnectionInfo_t.NativeMethodInfoPtr_set_m_szEndDebug_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetConnectionInfo_t>.NativeClassPtr, 100668395);
			SteamNetConnectionInfo_t.NativeMethodInfoPtr_get_m_szConnectionDescription_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetConnectionInfo_t>.NativeClassPtr, 100668396);
			SteamNetConnectionInfo_t.NativeMethodInfoPtr_set_m_szConnectionDescription_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetConnectionInfo_t>.NativeClassPtr, 100668397);
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x060027AB RID: 10155 RVA: 0x000AD128 File Offset: 0x000AB328
		// (set) Token: 0x060027AC RID: 10156 RVA: 0x000AD164 File Offset: 0x000AB364
		public unsafe string m_szEndDebug
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetConnectionInfo_t.NativeMethodInfoPtr_get_m_szEndDebug_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206892, XrefRangeEnd = 206893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetConnectionInfo_t.NativeMethodInfoPtr_set_m_szEndDebug_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x060027AD RID: 10157 RVA: 0x000AD1AC File Offset: 0x000AB3AC
		// (set) Token: 0x060027AE RID: 10158 RVA: 0x000AD1E8 File Offset: 0x000AB3E8
		public unsafe string m_szConnectionDescription
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetConnectionInfo_t.NativeMethodInfoPtr_get_m_szConnectionDescription_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206893, XrefRangeEnd = 206894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetConnectionInfo_t.NativeMethodInfoPtr_set_m_szConnectionDescription_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x0000FF65 File Offset: 0x0000E165
		public SteamNetConnectionInfo_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x0000FF6E File Offset: 0x0000E16E
		public SteamNetConnectionInfo_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamNetConnectionInfo_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x060027B1 RID: 10161 RVA: 0x000AD230 File Offset: 0x000AB430
		// (set) Token: 0x060027B2 RID: 10162 RVA: 0x0000FF80 File Offset: 0x0000E180
		public SteamNetworkingIdentity m_identityRemote
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_identityRemote);
				return new SteamNetworkingIdentity(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_identityRemote), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x060027B3 RID: 10163 RVA: 0x000AD260 File Offset: 0x000AB460
		// (set) Token: 0x060027B4 RID: 10164 RVA: 0x0000FFAE File Offset: 0x0000E1AE
		public unsafe long m_nUserData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_nUserData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_nUserData)) = value;
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x060027B5 RID: 10165 RVA: 0x000AD288 File Offset: 0x000AB488
		// (set) Token: 0x060027B6 RID: 10166 RVA: 0x0000FFC9 File Offset: 0x0000E1C9
		public unsafe HSteamListenSocket m_hListenSocket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_hListenSocket);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_hListenSocket)) = value;
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x060027B7 RID: 10167 RVA: 0x000AD2B0 File Offset: 0x000AB4B0
		// (set) Token: 0x060027B8 RID: 10168 RVA: 0x0000FFE4 File Offset: 0x0000E1E4
		public SteamNetworkingIPAddr m_addrRemote
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_addrRemote);
				return new SteamNetworkingIPAddr(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamNetworkingIPAddr>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_addrRemote), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SteamNetworkingIPAddr>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x060027B9 RID: 10169 RVA: 0x000AD2E0 File Offset: 0x000AB4E0
		// (set) Token: 0x060027BA RID: 10170 RVA: 0x00010012 File Offset: 0x0000E212
		public unsafe ushort m__pad1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionInfo_t.NativeFieldInfoPtr_m__pad1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionInfo_t.NativeFieldInfoPtr_m__pad1)) = value;
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x060027BB RID: 10171 RVA: 0x000AD308 File Offset: 0x000AB508
		// (set) Token: 0x060027BC RID: 10172 RVA: 0x0001002D File Offset: 0x0000E22D
		public unsafe SteamNetworkingPOPID m_idPOPRemote
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_idPOPRemote);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_idPOPRemote)) = value;
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x060027BD RID: 10173 RVA: 0x000AD330 File Offset: 0x000AB530
		// (set) Token: 0x060027BE RID: 10174 RVA: 0x00010048 File Offset: 0x0000E248
		public unsafe SteamNetworkingPOPID m_idPOPRelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_idPOPRelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_idPOPRelay)) = value;
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x060027BF RID: 10175 RVA: 0x000AD358 File Offset: 0x000AB558
		// (set) Token: 0x060027C0 RID: 10176 RVA: 0x00010063 File Offset: 0x0000E263
		public unsafe ESteamNetworkingConnectionState m_eState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_eState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_eState)) = value;
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x060027C1 RID: 10177 RVA: 0x000AD380 File Offset: 0x000AB580
		// (set) Token: 0x060027C2 RID: 10178 RVA: 0x0001007E File Offset: 0x0000E27E
		public unsafe int m_eEndReason
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_eEndReason);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_eEndReason)) = value;
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x060027C3 RID: 10179 RVA: 0x000AD3A8 File Offset: 0x000AB5A8
		// (set) Token: 0x060027C4 RID: 10180 RVA: 0x00010099 File Offset: 0x0000E299
		public unsafe Il2CppStructArray<byte> m_szEndDebug_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_szEndDebug_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_szEndDebug_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x060027C5 RID: 10181 RVA: 0x000AD3D8 File Offset: 0x000AB5D8
		// (set) Token: 0x060027C6 RID: 10182 RVA: 0x000100B8 File Offset: 0x0000E2B8
		public unsafe Il2CppStructArray<byte> m_szConnectionDescription_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_szConnectionDescription_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionInfo_t.NativeFieldInfoPtr_m_szConnectionDescription_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x060027C7 RID: 10183 RVA: 0x000AD408 File Offset: 0x000AB608
		// (set) Token: 0x060027C8 RID: 10184 RVA: 0x000100D7 File Offset: 0x0000E2D7
		public unsafe Il2CppStructArray<uint> reserved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionInfo_t.NativeFieldInfoPtr_reserved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionInfo_t.NativeFieldInfoPtr_reserved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040026E3 RID: 9955
		private static readonly IntPtr NativeFieldInfoPtr_m_identityRemote;

		// Token: 0x040026E4 RID: 9956
		private static readonly IntPtr NativeFieldInfoPtr_m_nUserData;

		// Token: 0x040026E5 RID: 9957
		private static readonly IntPtr NativeFieldInfoPtr_m_hListenSocket;

		// Token: 0x040026E6 RID: 9958
		private static readonly IntPtr NativeFieldInfoPtr_m_addrRemote;

		// Token: 0x040026E7 RID: 9959
		private static readonly IntPtr NativeFieldInfoPtr_m__pad1;

		// Token: 0x040026E8 RID: 9960
		private static readonly IntPtr NativeFieldInfoPtr_m_idPOPRemote;

		// Token: 0x040026E9 RID: 9961
		private static readonly IntPtr NativeFieldInfoPtr_m_idPOPRelay;

		// Token: 0x040026EA RID: 9962
		private static readonly IntPtr NativeFieldInfoPtr_m_eState;

		// Token: 0x040026EB RID: 9963
		private static readonly IntPtr NativeFieldInfoPtr_m_eEndReason;

		// Token: 0x040026EC RID: 9964
		private static readonly IntPtr NativeFieldInfoPtr_m_szEndDebug_;

		// Token: 0x040026ED RID: 9965
		private static readonly IntPtr NativeFieldInfoPtr_m_szConnectionDescription_;

		// Token: 0x040026EE RID: 9966
		private static readonly IntPtr NativeFieldInfoPtr_reserved;

		// Token: 0x040026EF RID: 9967
		private static readonly IntPtr NativeMethodInfoPtr_get_m_szEndDebug_Public_get_String_0;

		// Token: 0x040026F0 RID: 9968
		private static readonly IntPtr NativeMethodInfoPtr_set_m_szEndDebug_Public_set_Void_String_0;

		// Token: 0x040026F1 RID: 9969
		private static readonly IntPtr NativeMethodInfoPtr_get_m_szConnectionDescription_Public_get_String_0;

		// Token: 0x040026F2 RID: 9970
		private static readonly IntPtr NativeMethodInfoPtr_set_m_szConnectionDescription_Public_set_Void_String_0;
	}
}
