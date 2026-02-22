using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002F4 RID: 756
	[Serializable]
	public sealed class SteamNetworkingMessage_t : ValueType
	{
		// Token: 0x06002BA4 RID: 11172 RVA: 0x000BAFC4 File Offset: 0x000B91C4
		// Note: this type is marked as 'beforefieldinit'.
		static SteamNetworkingMessage_t()
		{
			Il2CppClassPointerStore<SteamNetworkingMessage_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamNetworkingMessage_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetworkingMessage_t>.NativeClassPtr);
			SteamNetworkingMessage_t.NativeFieldInfoPtr_m_pData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingMessage_t>.NativeClassPtr, "m_pData");
			SteamNetworkingMessage_t.NativeFieldInfoPtr_m_cbSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingMessage_t>.NativeClassPtr, "m_cbSize");
			SteamNetworkingMessage_t.NativeFieldInfoPtr_m_conn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingMessage_t>.NativeClassPtr, "m_conn");
			SteamNetworkingMessage_t.NativeFieldInfoPtr_m_identityPeer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingMessage_t>.NativeClassPtr, "m_identityPeer");
			SteamNetworkingMessage_t.NativeFieldInfoPtr_m_nConnUserData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingMessage_t>.NativeClassPtr, "m_nConnUserData");
			SteamNetworkingMessage_t.NativeFieldInfoPtr_m_usecTimeReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingMessage_t>.NativeClassPtr, "m_usecTimeReceived");
			SteamNetworkingMessage_t.NativeFieldInfoPtr_m_nMessageNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingMessage_t>.NativeClassPtr, "m_nMessageNumber");
			SteamNetworkingMessage_t.NativeFieldInfoPtr_m_pfnFreeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingMessage_t>.NativeClassPtr, "m_pfnFreeData");
			SteamNetworkingMessage_t.NativeFieldInfoPtr_m_pfnRelease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingMessage_t>.NativeClassPtr, "m_pfnRelease");
			SteamNetworkingMessage_t.NativeFieldInfoPtr_m_nChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingMessage_t>.NativeClassPtr, "m_nChannel");
			SteamNetworkingMessage_t.NativeFieldInfoPtr_m_nFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingMessage_t>.NativeClassPtr, "m_nFlags");
			SteamNetworkingMessage_t.NativeFieldInfoPtr_m_nUserData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingMessage_t>.NativeClassPtr, "m_nUserData");
			SteamNetworkingMessage_t.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingMessage_t>.NativeClassPtr, 100668945);
		}

		// Token: 0x06002BA5 RID: 11173 RVA: 0x000BB0F8 File Offset: 0x000B92F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210996, XrefRangeEnd = 210997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingMessage_t.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x0001133B File Offset: 0x0000F53B
		public SteamNetworkingMessage_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x00011344 File Offset: 0x0000F544
		public SteamNetworkingMessage_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamNetworkingMessage_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06002BA8 RID: 11176 RVA: 0x000BB130 File Offset: 0x000B9330
		// (set) Token: 0x06002BA9 RID: 11177 RVA: 0x00011356 File Offset: 0x0000F556
		public unsafe IntPtr m_pData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessage_t.NativeFieldInfoPtr_m_pData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessage_t.NativeFieldInfoPtr_m_pData)) = value;
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06002BAA RID: 11178 RVA: 0x000BB158 File Offset: 0x000B9358
		// (set) Token: 0x06002BAB RID: 11179 RVA: 0x00011371 File Offset: 0x0000F571
		public unsafe int m_cbSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessage_t.NativeFieldInfoPtr_m_cbSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessage_t.NativeFieldInfoPtr_m_cbSize)) = value;
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06002BAC RID: 11180 RVA: 0x000BB180 File Offset: 0x000B9380
		// (set) Token: 0x06002BAD RID: 11181 RVA: 0x0001138C File Offset: 0x0000F58C
		public unsafe HSteamNetConnection m_conn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessage_t.NativeFieldInfoPtr_m_conn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessage_t.NativeFieldInfoPtr_m_conn)) = value;
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06002BAE RID: 11182 RVA: 0x000BB1A8 File Offset: 0x000B93A8
		// (set) Token: 0x06002BAF RID: 11183 RVA: 0x000113A7 File Offset: 0x0000F5A7
		public SteamNetworkingIdentity m_identityPeer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessage_t.NativeFieldInfoPtr_m_identityPeer);
				return new SteamNetworkingIdentity(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessage_t.NativeFieldInfoPtr_m_identityPeer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06002BB0 RID: 11184 RVA: 0x000BB1D8 File Offset: 0x000B93D8
		// (set) Token: 0x06002BB1 RID: 11185 RVA: 0x000113D5 File Offset: 0x0000F5D5
		public unsafe long m_nConnUserData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessage_t.NativeFieldInfoPtr_m_nConnUserData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessage_t.NativeFieldInfoPtr_m_nConnUserData)) = value;
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06002BB2 RID: 11186 RVA: 0x000BB200 File Offset: 0x000B9400
		// (set) Token: 0x06002BB3 RID: 11187 RVA: 0x000113F0 File Offset: 0x0000F5F0
		public unsafe SteamNetworkingMicroseconds m_usecTimeReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessage_t.NativeFieldInfoPtr_m_usecTimeReceived);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessage_t.NativeFieldInfoPtr_m_usecTimeReceived)) = value;
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06002BB4 RID: 11188 RVA: 0x000BB228 File Offset: 0x000B9428
		// (set) Token: 0x06002BB5 RID: 11189 RVA: 0x0001140B File Offset: 0x0000F60B
		public unsafe long m_nMessageNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessage_t.NativeFieldInfoPtr_m_nMessageNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessage_t.NativeFieldInfoPtr_m_nMessageNumber)) = value;
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06002BB6 RID: 11190 RVA: 0x000BB250 File Offset: 0x000B9450
		// (set) Token: 0x06002BB7 RID: 11191 RVA: 0x00011426 File Offset: 0x0000F626
		public unsafe IntPtr m_pfnFreeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessage_t.NativeFieldInfoPtr_m_pfnFreeData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessage_t.NativeFieldInfoPtr_m_pfnFreeData)) = value;
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06002BB8 RID: 11192 RVA: 0x000BB278 File Offset: 0x000B9478
		// (set) Token: 0x06002BB9 RID: 11193 RVA: 0x00011441 File Offset: 0x0000F641
		public unsafe IntPtr m_pfnRelease
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessage_t.NativeFieldInfoPtr_m_pfnRelease);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessage_t.NativeFieldInfoPtr_m_pfnRelease)) = value;
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06002BBA RID: 11194 RVA: 0x000BB2A0 File Offset: 0x000B94A0
		// (set) Token: 0x06002BBB RID: 11195 RVA: 0x0001145C File Offset: 0x0000F65C
		public unsafe int m_nChannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessage_t.NativeFieldInfoPtr_m_nChannel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessage_t.NativeFieldInfoPtr_m_nChannel)) = value;
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06002BBC RID: 11196 RVA: 0x000BB2C8 File Offset: 0x000B94C8
		// (set) Token: 0x06002BBD RID: 11197 RVA: 0x00011477 File Offset: 0x0000F677
		public unsafe int m_nFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessage_t.NativeFieldInfoPtr_m_nFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessage_t.NativeFieldInfoPtr_m_nFlags)) = value;
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06002BBE RID: 11198 RVA: 0x000BB2F0 File Offset: 0x000B94F0
		// (set) Token: 0x06002BBF RID: 11199 RVA: 0x00011492 File Offset: 0x0000F692
		public unsafe long m_nUserData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessage_t.NativeFieldInfoPtr_m_nUserData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessage_t.NativeFieldInfoPtr_m_nUserData)) = value;
			}
		}

		// Token: 0x040029E4 RID: 10724
		private static readonly IntPtr NativeFieldInfoPtr_m_pData;

		// Token: 0x040029E5 RID: 10725
		private static readonly IntPtr NativeFieldInfoPtr_m_cbSize;

		// Token: 0x040029E6 RID: 10726
		private static readonly IntPtr NativeFieldInfoPtr_m_conn;

		// Token: 0x040029E7 RID: 10727
		private static readonly IntPtr NativeFieldInfoPtr_m_identityPeer;

		// Token: 0x040029E8 RID: 10728
		private static readonly IntPtr NativeFieldInfoPtr_m_nConnUserData;

		// Token: 0x040029E9 RID: 10729
		private static readonly IntPtr NativeFieldInfoPtr_m_usecTimeReceived;

		// Token: 0x040029EA RID: 10730
		private static readonly IntPtr NativeFieldInfoPtr_m_nMessageNumber;

		// Token: 0x040029EB RID: 10731
		private static readonly IntPtr NativeFieldInfoPtr_m_pfnFreeData;

		// Token: 0x040029EC RID: 10732
		private static readonly IntPtr NativeFieldInfoPtr_m_pfnRelease;

		// Token: 0x040029ED RID: 10733
		private static readonly IntPtr NativeFieldInfoPtr_m_nChannel;

		// Token: 0x040029EE RID: 10734
		private static readonly IntPtr NativeFieldInfoPtr_m_nFlags;

		// Token: 0x040029EF RID: 10735
		private static readonly IntPtr NativeFieldInfoPtr_m_nUserData;

		// Token: 0x040029F0 RID: 10736
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
	}
}
