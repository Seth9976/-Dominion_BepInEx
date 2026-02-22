using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002D9 RID: 729
	[Serializable]
	public sealed class SteamDatagramRelayAuthTicket : ValueType
	{
		// Token: 0x06002A46 RID: 10822 RVA: 0x000B5844 File Offset: 0x000B3A44
		// Note: this type is marked as 'beforefieldinit'.
		static SteamDatagramRelayAuthTicket()
		{
			Il2CppClassPointerStore<SteamDatagramRelayAuthTicket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamDatagramRelayAuthTicket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket>.NativeClassPtr);
			SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_identityGameserver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket>.NativeClassPtr, "m_identityGameserver");
			SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_identityAuthorizedClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket>.NativeClassPtr, "m_identityAuthorizedClient");
			SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_unPublicIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket>.NativeClassPtr, "m_unPublicIP");
			SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_rtimeTicketExpiry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket>.NativeClassPtr, "m_rtimeTicketExpiry");
			SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_routing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket>.NativeClassPtr, "m_routing");
			SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket>.NativeClassPtr, "m_nAppID");
			SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_nRestrictToVirtualPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket>.NativeClassPtr, "m_nRestrictToVirtualPort");
			SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_k_nMaxExtraFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket>.NativeClassPtr, "k_nMaxExtraFields");
			SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_nExtraFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket>.NativeClassPtr, "m_nExtraFields");
			SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_vecExtraFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket>.NativeClassPtr, "m_vecExtraFields");
			SteamDatagramRelayAuthTicket.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket>.NativeClassPtr, 100668707);
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x000B5950 File Offset: 0x000B3B50
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamDatagramRelayAuthTicket.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A48 RID: 10824 RVA: 0x00010E0E File Offset: 0x0000F00E
		public SteamDatagramRelayAuthTicket(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002A49 RID: 10825 RVA: 0x00010E17 File Offset: 0x0000F017
		public SteamDatagramRelayAuthTicket()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket>.NativeClassPtr))
		{
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06002A4A RID: 10826 RVA: 0x000B5988 File Offset: 0x000B3B88
		// (set) Token: 0x06002A4B RID: 10827 RVA: 0x00010E29 File Offset: 0x0000F029
		public SteamNetworkingIdentity m_identityGameserver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_identityGameserver);
				return new SteamNetworkingIdentity(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_identityGameserver), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06002A4C RID: 10828 RVA: 0x000B59B8 File Offset: 0x000B3BB8
		// (set) Token: 0x06002A4D RID: 10829 RVA: 0x00010E57 File Offset: 0x0000F057
		public SteamNetworkingIdentity m_identityAuthorizedClient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_identityAuthorizedClient);
				return new SteamNetworkingIdentity(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_identityAuthorizedClient), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06002A4E RID: 10830 RVA: 0x000B59E8 File Offset: 0x000B3BE8
		// (set) Token: 0x06002A4F RID: 10831 RVA: 0x00010E85 File Offset: 0x0000F085
		public unsafe uint m_unPublicIP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_unPublicIP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_unPublicIP)) = value;
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06002A50 RID: 10832 RVA: 0x000B5A10 File Offset: 0x000B3C10
		// (set) Token: 0x06002A51 RID: 10833 RVA: 0x00010EA0 File Offset: 0x0000F0A0
		public unsafe RTime32 m_rtimeTicketExpiry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_rtimeTicketExpiry);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_rtimeTicketExpiry)) = value;
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06002A52 RID: 10834 RVA: 0x000B5A38 File Offset: 0x000B3C38
		// (set) Token: 0x06002A53 RID: 10835 RVA: 0x00010EBB File Offset: 0x0000F0BB
		public SteamDatagramHostedAddress m_routing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_routing);
				return new SteamDatagramHostedAddress(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamDatagramHostedAddress>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_routing), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SteamDatagramHostedAddress>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06002A54 RID: 10836 RVA: 0x000B5A68 File Offset: 0x000B3C68
		// (set) Token: 0x06002A55 RID: 10837 RVA: 0x00010EE9 File Offset: 0x0000F0E9
		public unsafe uint m_nAppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_nAppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_nAppID)) = value;
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06002A56 RID: 10838 RVA: 0x000B5A90 File Offset: 0x000B3C90
		// (set) Token: 0x06002A57 RID: 10839 RVA: 0x00010F04 File Offset: 0x0000F104
		public unsafe int m_nRestrictToVirtualPort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_nRestrictToVirtualPort);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_nRestrictToVirtualPort)) = value;
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06002A58 RID: 10840 RVA: 0x000B5AB8 File Offset: 0x000B3CB8
		// (set) Token: 0x06002A59 RID: 10841 RVA: 0x00010F1F File Offset: 0x0000F11F
		public unsafe static int k_nMaxExtraFields
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_k_nMaxExtraFields, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_k_nMaxExtraFields, (void*)(&value));
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06002A5A RID: 10842 RVA: 0x000B5AD4 File Offset: 0x000B3CD4
		// (set) Token: 0x06002A5B RID: 10843 RVA: 0x00010F2D File Offset: 0x0000F12D
		public unsafe int m_nExtraFields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_nExtraFields);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_nExtraFields)) = value;
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06002A5C RID: 10844 RVA: 0x000B5AFC File Offset: 0x000B3CFC
		// (set) Token: 0x06002A5D RID: 10845 RVA: 0x00010F48 File Offset: 0x0000F148
		public unsafe Il2CppReferenceArray<SteamDatagramRelayAuthTicket.ExtraField> m_vecExtraFields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_vecExtraFields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SteamDatagramRelayAuthTicket.ExtraField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.NativeFieldInfoPtr_m_vecExtraFields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040028B7 RID: 10423
		private static readonly IntPtr NativeFieldInfoPtr_m_identityGameserver;

		// Token: 0x040028B8 RID: 10424
		private static readonly IntPtr NativeFieldInfoPtr_m_identityAuthorizedClient;

		// Token: 0x040028B9 RID: 10425
		private static readonly IntPtr NativeFieldInfoPtr_m_unPublicIP;

		// Token: 0x040028BA RID: 10426
		private static readonly IntPtr NativeFieldInfoPtr_m_rtimeTicketExpiry;

		// Token: 0x040028BB RID: 10427
		private static readonly IntPtr NativeFieldInfoPtr_m_routing;

		// Token: 0x040028BC RID: 10428
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x040028BD RID: 10429
		private static readonly IntPtr NativeFieldInfoPtr_m_nRestrictToVirtualPort;

		// Token: 0x040028BE RID: 10430
		private static readonly IntPtr NativeFieldInfoPtr_k_nMaxExtraFields;

		// Token: 0x040028BF RID: 10431
		private static readonly IntPtr NativeFieldInfoPtr_m_nExtraFields;

		// Token: 0x040028C0 RID: 10432
		private static readonly IntPtr NativeFieldInfoPtr_m_vecExtraFields;

		// Token: 0x040028C1 RID: 10433
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x020003C7 RID: 967
		public sealed class ExtraField : ValueType
		{
			// Token: 0x0600383D RID: 14397 RVA: 0x000E5198 File Offset: 0x000E3398
			// Note: this type is marked as 'beforefieldinit'.
			static ExtraField()
			{
				Il2CppClassPointerStore<SteamDatagramRelayAuthTicket.ExtraField>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket>.NativeClassPtr, "ExtraField");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket.ExtraField>.NativeClassPtr);
				SteamDatagramRelayAuthTicket.ExtraField.NativeFieldInfoPtr_m_eType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket.ExtraField>.NativeClassPtr, "m_eType");
				SteamDatagramRelayAuthTicket.ExtraField.NativeFieldInfoPtr_m_szName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket.ExtraField>.NativeClassPtr, "m_szName");
				SteamDatagramRelayAuthTicket.ExtraField.NativeFieldInfoPtr_m_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket.ExtraField>.NativeClassPtr, "m_val");
			}

			// Token: 0x0600383E RID: 14398 RVA: 0x00015C71 File Offset: 0x00013E71
			public ExtraField(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600383F RID: 14399 RVA: 0x00015C7A File Offset: 0x00013E7A
			public ExtraField()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket.ExtraField>.NativeClassPtr))
			{
			}

			// Token: 0x17000D47 RID: 3399
			// (get) Token: 0x06003840 RID: 14400 RVA: 0x000E5200 File Offset: 0x000E3400
			// (set) Token: 0x06003841 RID: 14401 RVA: 0x00015C8C File Offset: 0x00013E8C
			public unsafe SteamDatagramRelayAuthTicket.ExtraField.EType m_eType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.ExtraField.NativeFieldInfoPtr_m_eType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.ExtraField.NativeFieldInfoPtr_m_eType)) = value;
				}
			}

			// Token: 0x17000D48 RID: 3400
			// (get) Token: 0x06003842 RID: 14402 RVA: 0x000E5228 File Offset: 0x000E3428
			// (set) Token: 0x06003843 RID: 14403 RVA: 0x00015CA7 File Offset: 0x00013EA7
			public unsafe Il2CppStructArray<byte> m_szName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.ExtraField.NativeFieldInfoPtr_m_szName);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.ExtraField.NativeFieldInfoPtr_m_szName), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D49 RID: 3401
			// (get) Token: 0x06003844 RID: 14404 RVA: 0x000E5258 File Offset: 0x000E3458
			// (set) Token: 0x06003845 RID: 14405 RVA: 0x00015CC6 File Offset: 0x00013EC6
			public SteamDatagramRelayAuthTicket.ExtraField.OptionValue m_val
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.ExtraField.NativeFieldInfoPtr_m_val);
					return new SteamDatagramRelayAuthTicket.ExtraField.OptionValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket.ExtraField.OptionValue>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.ExtraField.NativeFieldInfoPtr_m_val), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket.ExtraField.OptionValue>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040032C6 RID: 12998
			private static readonly IntPtr NativeFieldInfoPtr_m_eType;

			// Token: 0x040032C7 RID: 12999
			private static readonly IntPtr NativeFieldInfoPtr_m_szName;

			// Token: 0x040032C8 RID: 13000
			private static readonly IntPtr NativeFieldInfoPtr_m_val;

			// Token: 0x020003FF RID: 1023
			public enum EType
			{
				// Token: 0x04003433 RID: 13363
				k_EType_String,
				// Token: 0x04003434 RID: 13364
				k_EType_Int,
				// Token: 0x04003435 RID: 13365
				k_EType_Fixed64
			}

			// Token: 0x02000400 RID: 1024
			public sealed class OptionValue : ValueType
			{
				// Token: 0x06003A79 RID: 14969 RVA: 0x000EC17C File Offset: 0x000EA37C
				// Note: this type is marked as 'beforefieldinit'.
				static OptionValue()
				{
					Il2CppClassPointerStore<SteamDatagramRelayAuthTicket.ExtraField.OptionValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket.ExtraField>.NativeClassPtr, "OptionValue");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket.ExtraField.OptionValue>.NativeClassPtr);
					SteamDatagramRelayAuthTicket.ExtraField.OptionValue.NativeFieldInfoPtr_m_szStringValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket.ExtraField.OptionValue>.NativeClassPtr, "m_szStringValue");
					SteamDatagramRelayAuthTicket.ExtraField.OptionValue.NativeFieldInfoPtr_m_nIntValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket.ExtraField.OptionValue>.NativeClassPtr, "m_nIntValue");
					SteamDatagramRelayAuthTicket.ExtraField.OptionValue.NativeFieldInfoPtr_m_nFixed64Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket.ExtraField.OptionValue>.NativeClassPtr, "m_nFixed64Value");
				}

				// Token: 0x06003A7A RID: 14970 RVA: 0x00016A20 File Offset: 0x00014C20
				public OptionValue(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06003A7B RID: 14971 RVA: 0x00016A29 File Offset: 0x00014C29
				public OptionValue()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket.ExtraField.OptionValue>.NativeClassPtr))
				{
				}

				// Token: 0x17000DE8 RID: 3560
				// (get) Token: 0x06003A7C RID: 14972 RVA: 0x000EC1E4 File Offset: 0x000EA3E4
				// (set) Token: 0x06003A7D RID: 14973 RVA: 0x00016A3B File Offset: 0x00014C3B
				public unsafe Il2CppStructArray<byte> m_szStringValue
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.ExtraField.OptionValue.NativeFieldInfoPtr_m_szStringValue);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.ExtraField.OptionValue.NativeFieldInfoPtr_m_szStringValue), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000DE9 RID: 3561
				// (get) Token: 0x06003A7E RID: 14974 RVA: 0x000EC214 File Offset: 0x000EA414
				// (set) Token: 0x06003A7F RID: 14975 RVA: 0x00016A5A File Offset: 0x00014C5A
				public unsafe long m_nIntValue
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.ExtraField.OptionValue.NativeFieldInfoPtr_m_nIntValue);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.ExtraField.OptionValue.NativeFieldInfoPtr_m_nIntValue)) = value;
					}
				}

				// Token: 0x17000DEA RID: 3562
				// (get) Token: 0x06003A80 RID: 14976 RVA: 0x000EC23C File Offset: 0x000EA43C
				// (set) Token: 0x06003A81 RID: 14977 RVA: 0x00016A75 File Offset: 0x00014C75
				public unsafe ulong m_nFixed64Value
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.ExtraField.OptionValue.NativeFieldInfoPtr_m_nFixed64Value);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramRelayAuthTicket.ExtraField.OptionValue.NativeFieldInfoPtr_m_nFixed64Value)) = value;
					}
				}

				// Token: 0x04003436 RID: 13366
				private static readonly IntPtr NativeFieldInfoPtr_m_szStringValue;

				// Token: 0x04003437 RID: 13367
				private static readonly IntPtr NativeFieldInfoPtr_m_nIntValue;

				// Token: 0x04003438 RID: 13368
				private static readonly IntPtr NativeFieldInfoPtr_m_nFixed64Value;
			}
		}
	}
}
