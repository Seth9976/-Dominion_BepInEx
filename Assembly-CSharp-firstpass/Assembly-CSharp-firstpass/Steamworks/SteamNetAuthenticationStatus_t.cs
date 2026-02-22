using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001E9 RID: 489
	public sealed class SteamNetAuthenticationStatus_t : ValueType
	{
		// Token: 0x0600235D RID: 9053 RVA: 0x000A491C File Offset: 0x000A2B1C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamNetAuthenticationStatus_t()
		{
			Il2CppClassPointerStore<SteamNetAuthenticationStatus_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamNetAuthenticationStatus_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetAuthenticationStatus_t>.NativeClassPtr);
			SteamNetAuthenticationStatus_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetAuthenticationStatus_t>.NativeClassPtr, "k_iCallback");
			SteamNetAuthenticationStatus_t.NativeFieldInfoPtr_m_eAvail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetAuthenticationStatus_t>.NativeClassPtr, "m_eAvail");
			SteamNetAuthenticationStatus_t.NativeFieldInfoPtr_m_debugMsg_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetAuthenticationStatus_t>.NativeClassPtr, "m_debugMsg_");
			SteamNetAuthenticationStatus_t.NativeMethodInfoPtr_get_m_debugMsg_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetAuthenticationStatus_t>.NativeClassPtr, 100668347);
			SteamNetAuthenticationStatus_t.NativeMethodInfoPtr_set_m_debugMsg_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetAuthenticationStatus_t>.NativeClassPtr, 100668348);
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x0600235E RID: 9054 RVA: 0x000A49B0 File Offset: 0x000A2BB0
		// (set) Token: 0x0600235F RID: 9055 RVA: 0x000A49EC File Offset: 0x000A2BEC
		public unsafe string m_debugMsg
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetAuthenticationStatus_t.NativeMethodInfoPtr_get_m_debugMsg_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetAuthenticationStatus_t.NativeMethodInfoPtr_set_m_debugMsg_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002360 RID: 9056 RVA: 0x0000D7C0 File Offset: 0x0000B9C0
		public SteamNetAuthenticationStatus_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002361 RID: 9057 RVA: 0x0000D7C9 File Offset: 0x0000B9C9
		public SteamNetAuthenticationStatus_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamNetAuthenticationStatus_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06002362 RID: 9058 RVA: 0x000A4A34 File Offset: 0x000A2C34
		// (set) Token: 0x06002363 RID: 9059 RVA: 0x0000D7DB File Offset: 0x0000B9DB
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamNetAuthenticationStatus_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamNetAuthenticationStatus_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06002364 RID: 9060 RVA: 0x000A4A50 File Offset: 0x000A2C50
		// (set) Token: 0x06002365 RID: 9061 RVA: 0x0000D7E9 File Offset: 0x0000B9E9
		public unsafe ESteamNetworkingAvailability m_eAvail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetAuthenticationStatus_t.NativeFieldInfoPtr_m_eAvail);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetAuthenticationStatus_t.NativeFieldInfoPtr_m_eAvail)) = value;
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06002366 RID: 9062 RVA: 0x000A4A78 File Offset: 0x000A2C78
		// (set) Token: 0x06002367 RID: 9063 RVA: 0x0000D804 File Offset: 0x0000BA04
		public unsafe Il2CppStructArray<byte> m_debugMsg_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetAuthenticationStatus_t.NativeFieldInfoPtr_m_debugMsg_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetAuthenticationStatus_t.NativeFieldInfoPtr_m_debugMsg_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D0E RID: 7438
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001D0F RID: 7439
		private static readonly IntPtr NativeFieldInfoPtr_m_eAvail;

		// Token: 0x04001D10 RID: 7440
		private static readonly IntPtr NativeFieldInfoPtr_m_debugMsg_;

		// Token: 0x04001D11 RID: 7441
		private static readonly IntPtr NativeMethodInfoPtr_get_m_debugMsg_Public_get_String_0;

		// Token: 0x04001D12 RID: 7442
		private static readonly IntPtr NativeMethodInfoPtr_set_m_debugMsg_Public_set_Void_String_0;
	}
}
