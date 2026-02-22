using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200017F RID: 383
	public sealed class GameRichPresenceJoinRequested_t : ValueType
	{
		// Token: 0x0600210A RID: 8458 RVA: 0x000A012C File Offset: 0x0009E32C
		// Note: this type is marked as 'beforefieldinit'.
		static GameRichPresenceJoinRequested_t()
		{
			Il2CppClassPointerStore<GameRichPresenceJoinRequested_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GameRichPresenceJoinRequested_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameRichPresenceJoinRequested_t>.NativeClassPtr);
			GameRichPresenceJoinRequested_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameRichPresenceJoinRequested_t>.NativeClassPtr, "k_iCallback");
			GameRichPresenceJoinRequested_t.NativeFieldInfoPtr_m_steamIDFriend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameRichPresenceJoinRequested_t>.NativeClassPtr, "m_steamIDFriend");
			GameRichPresenceJoinRequested_t.NativeFieldInfoPtr_m_rgchConnect_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameRichPresenceJoinRequested_t>.NativeClassPtr, "m_rgchConnect_");
			GameRichPresenceJoinRequested_t.NativeMethodInfoPtr_get_m_rgchConnect_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameRichPresenceJoinRequested_t>.NativeClassPtr, 100668335);
			GameRichPresenceJoinRequested_t.NativeMethodInfoPtr_set_m_rgchConnect_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameRichPresenceJoinRequested_t>.NativeClassPtr, 100668336);
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x0600210B RID: 8459 RVA: 0x000A01C0 File Offset: 0x0009E3C0
		// (set) Token: 0x0600210C RID: 8460 RVA: 0x000A01FC File Offset: 0x0009E3FC
		public unsafe string m_rgchConnect
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameRichPresenceJoinRequested_t.NativeMethodInfoPtr_get_m_rgchConnect_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206860, XrefRangeEnd = 206861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameRichPresenceJoinRequested_t.NativeMethodInfoPtr_set_m_rgchConnect_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x0000BEC6 File Offset: 0x0000A0C6
		public GameRichPresenceJoinRequested_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x0000BECF File Offset: 0x0000A0CF
		public GameRichPresenceJoinRequested_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameRichPresenceJoinRequested_t>.NativeClassPtr))
		{
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x0600210F RID: 8463 RVA: 0x000A0244 File Offset: 0x0009E444
		// (set) Token: 0x06002110 RID: 8464 RVA: 0x0000BEE1 File Offset: 0x0000A0E1
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameRichPresenceJoinRequested_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameRichPresenceJoinRequested_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06002111 RID: 8465 RVA: 0x000A0260 File Offset: 0x0009E460
		// (set) Token: 0x06002112 RID: 8466 RVA: 0x0000BEEF File Offset: 0x0000A0EF
		public unsafe CSteamID m_steamIDFriend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameRichPresenceJoinRequested_t.NativeFieldInfoPtr_m_steamIDFriend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameRichPresenceJoinRequested_t.NativeFieldInfoPtr_m_steamIDFriend)) = value;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06002113 RID: 8467 RVA: 0x000A0288 File Offset: 0x0009E488
		// (set) Token: 0x06002114 RID: 8468 RVA: 0x0000BF0A File Offset: 0x0000A10A
		public unsafe Il2CppStructArray<byte> m_rgchConnect_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameRichPresenceJoinRequested_t.NativeFieldInfoPtr_m_rgchConnect_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameRichPresenceJoinRequested_t.NativeFieldInfoPtr_m_rgchConnect_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AC4 RID: 6852
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001AC5 RID: 6853
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDFriend;

		// Token: 0x04001AC6 RID: 6854
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchConnect_;

		// Token: 0x04001AC7 RID: 6855
		private static readonly IntPtr NativeMethodInfoPtr_get_m_rgchConnect_Public_get_String_0;

		// Token: 0x04001AC8 RID: 6856
		private static readonly IntPtr NativeMethodInfoPtr_set_m_rgchConnect_Public_set_Void_String_0;
	}
}
