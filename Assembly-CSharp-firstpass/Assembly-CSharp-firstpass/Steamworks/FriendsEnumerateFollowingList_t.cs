using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000188 RID: 392
	public sealed class FriendsEnumerateFollowingList_t : ValueType
	{
		// Token: 0x06002135 RID: 8501 RVA: 0x000A0748 File Offset: 0x0009E948
		// Note: this type is marked as 'beforefieldinit'.
		static FriendsEnumerateFollowingList_t()
		{
			Il2CppClassPointerStore<FriendsEnumerateFollowingList_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "FriendsEnumerateFollowingList_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsEnumerateFollowingList_t>.NativeClassPtr);
			FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsEnumerateFollowingList_t>.NativeClassPtr, "k_iCallback");
			FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsEnumerateFollowingList_t>.NativeClassPtr, "m_eResult");
			FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_m_rgSteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsEnumerateFollowingList_t>.NativeClassPtr, "m_rgSteamID");
			FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_m_nResultsReturned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsEnumerateFollowingList_t>.NativeClassPtr, "m_nResultsReturned");
			FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_m_nTotalResultCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsEnumerateFollowingList_t>.NativeClassPtr, "m_nTotalResultCount");
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x0000C029 File Offset: 0x0000A229
		public FriendsEnumerateFollowingList_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002137 RID: 8503 RVA: 0x0000C032 File Offset: 0x0000A232
		public FriendsEnumerateFollowingList_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendsEnumerateFollowingList_t>.NativeClassPtr))
		{
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06002138 RID: 8504 RVA: 0x000A07DC File Offset: 0x0009E9DC
		// (set) Token: 0x06002139 RID: 8505 RVA: 0x0000C044 File Offset: 0x0000A244
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x0600213A RID: 8506 RVA: 0x000A07F8 File Offset: 0x0009E9F8
		// (set) Token: 0x0600213B RID: 8507 RVA: 0x0000C052 File Offset: 0x0000A252
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x0600213C RID: 8508 RVA: 0x000A0820 File Offset: 0x0009EA20
		// (set) Token: 0x0600213D RID: 8509 RVA: 0x0000C06D File Offset: 0x0000A26D
		public unsafe Il2CppStructArray<CSteamID> m_rgSteamID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_m_rgSteamID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<CSteamID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_m_rgSteamID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x0600213E RID: 8510 RVA: 0x000A0850 File Offset: 0x0009EA50
		// (set) Token: 0x0600213F RID: 8511 RVA: 0x0000C08C File Offset: 0x0000A28C
		public unsafe int m_nResultsReturned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_m_nResultsReturned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_m_nResultsReturned)) = value;
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06002140 RID: 8512 RVA: 0x000A0878 File Offset: 0x0009EA78
		// (set) Token: 0x06002141 RID: 8513 RVA: 0x0000C0A7 File Offset: 0x0000A2A7
		public unsafe int m_nTotalResultCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_m_nTotalResultCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_m_nTotalResultCount)) = value;
			}
		}

		// Token: 0x04001AF9 RID: 6905
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001AFA RID: 6906
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001AFB RID: 6907
		private static readonly IntPtr NativeFieldInfoPtr_m_rgSteamID;

		// Token: 0x04001AFC RID: 6908
		private static readonly IntPtr NativeFieldInfoPtr_m_nResultsReturned;

		// Token: 0x04001AFD RID: 6909
		private static readonly IntPtr NativeFieldInfoPtr_m_nTotalResultCount;
	}
}
