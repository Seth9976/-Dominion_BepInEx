using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001CD RID: 461
	public sealed class JoinPartyCallback_t : ValueType
	{
		// Token: 0x060022D5 RID: 8917 RVA: 0x000A3D24 File Offset: 0x000A1F24
		// Note: this type is marked as 'beforefieldinit'.
		static JoinPartyCallback_t()
		{
			Il2CppClassPointerStore<JoinPartyCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "JoinPartyCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoinPartyCallback_t>.NativeClassPtr);
			JoinPartyCallback_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinPartyCallback_t>.NativeClassPtr, "k_iCallback");
			JoinPartyCallback_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinPartyCallback_t>.NativeClassPtr, "m_eResult");
			JoinPartyCallback_t.NativeFieldInfoPtr_m_ulBeaconID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinPartyCallback_t>.NativeClassPtr, "m_ulBeaconID");
			JoinPartyCallback_t.NativeFieldInfoPtr_m_SteamIDBeaconOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinPartyCallback_t>.NativeClassPtr, "m_SteamIDBeaconOwner");
			JoinPartyCallback_t.NativeFieldInfoPtr_m_rgchConnectString_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinPartyCallback_t>.NativeClassPtr, "m_rgchConnectString_");
			JoinPartyCallback_t.NativeMethodInfoPtr_get_m_rgchConnectString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinPartyCallback_t>.NativeClassPtr, 100668345);
			JoinPartyCallback_t.NativeMethodInfoPtr_set_m_rgchConnectString_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinPartyCallback_t>.NativeClassPtr, 100668346);
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x060022D6 RID: 8918 RVA: 0x000A3DE0 File Offset: 0x000A1FE0
		// (set) Token: 0x060022D7 RID: 8919 RVA: 0x000A3E1C File Offset: 0x000A201C
		public unsafe string m_rgchConnectString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206865, XrefRangeEnd = 206867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinPartyCallback_t.NativeMethodInfoPtr_get_m_rgchConnectString_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206867, XrefRangeEnd = 206871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinPartyCallback_t.NativeMethodInfoPtr_set_m_rgchConnectString_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x0000D079 File Offset: 0x0000B279
		public JoinPartyCallback_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x0000D082 File Offset: 0x0000B282
		public JoinPartyCallback_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoinPartyCallback_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x060022DA RID: 8922 RVA: 0x000A3E64 File Offset: 0x000A2064
		// (set) Token: 0x060022DB RID: 8923 RVA: 0x0000D094 File Offset: 0x0000B294
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(JoinPartyCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JoinPartyCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x060022DC RID: 8924 RVA: 0x000A3E80 File Offset: 0x000A2080
		// (set) Token: 0x060022DD RID: 8925 RVA: 0x0000D0A2 File Offset: 0x0000B2A2
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinPartyCallback_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinPartyCallback_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x060022DE RID: 8926 RVA: 0x000A3EA8 File Offset: 0x000A20A8
		// (set) Token: 0x060022DF RID: 8927 RVA: 0x0000D0BD File Offset: 0x0000B2BD
		public unsafe PartyBeaconID_t m_ulBeaconID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinPartyCallback_t.NativeFieldInfoPtr_m_ulBeaconID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinPartyCallback_t.NativeFieldInfoPtr_m_ulBeaconID)) = value;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x060022E0 RID: 8928 RVA: 0x000A3ED0 File Offset: 0x000A20D0
		// (set) Token: 0x060022E1 RID: 8929 RVA: 0x0000D0D8 File Offset: 0x0000B2D8
		public unsafe CSteamID m_SteamIDBeaconOwner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinPartyCallback_t.NativeFieldInfoPtr_m_SteamIDBeaconOwner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinPartyCallback_t.NativeFieldInfoPtr_m_SteamIDBeaconOwner)) = value;
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x060022E2 RID: 8930 RVA: 0x000A3EF8 File Offset: 0x000A20F8
		// (set) Token: 0x060022E3 RID: 8931 RVA: 0x0000D0F3 File Offset: 0x0000B2F3
		public unsafe Il2CppStructArray<byte> m_rgchConnectString_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinPartyCallback_t.NativeFieldInfoPtr_m_rgchConnectString_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinPartyCallback_t.NativeFieldInfoPtr_m_rgchConnectString_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001CC1 RID: 7361
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001CC2 RID: 7362
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001CC3 RID: 7363
		private static readonly IntPtr NativeFieldInfoPtr_m_ulBeaconID;

		// Token: 0x04001CC4 RID: 7364
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamIDBeaconOwner;

		// Token: 0x04001CC5 RID: 7365
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchConnectString_;

		// Token: 0x04001CC6 RID: 7366
		private static readonly IntPtr NativeMethodInfoPtr_get_m_rgchConnectString_Public_get_String_0;

		// Token: 0x04001CC7 RID: 7367
		private static readonly IntPtr NativeMethodInfoPtr_set_m_rgchConnectString_Public_set_Void_String_0;
	}
}
