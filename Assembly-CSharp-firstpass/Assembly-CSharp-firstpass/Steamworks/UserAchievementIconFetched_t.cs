using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000233 RID: 563
	public sealed class UserAchievementIconFetched_t : ValueType
	{
		// Token: 0x06002562 RID: 9570 RVA: 0x000A8DAC File Offset: 0x000A6FAC
		// Note: this type is marked as 'beforefieldinit'.
		static UserAchievementIconFetched_t()
		{
			Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "UserAchievementIconFetched_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr);
			UserAchievementIconFetched_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr, "k_iCallback");
			UserAchievementIconFetched_t.NativeFieldInfoPtr_m_nGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr, "m_nGameID");
			UserAchievementIconFetched_t.NativeFieldInfoPtr_m_rgchAchievementName_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr, "m_rgchAchievementName_");
			UserAchievementIconFetched_t.NativeFieldInfoPtr_m_bAchieved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr, "m_bAchieved");
			UserAchievementIconFetched_t.NativeFieldInfoPtr_m_nIconHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr, "m_nIconHandle");
			UserAchievementIconFetched_t.NativeMethodInfoPtr_get_m_rgchAchievementName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr, 100668375);
			UserAchievementIconFetched_t.NativeMethodInfoPtr_set_m_rgchAchievementName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr, 100668376);
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06002563 RID: 9571 RVA: 0x000A8E68 File Offset: 0x000A7068
		// (set) Token: 0x06002564 RID: 9572 RVA: 0x000A8EA4 File Offset: 0x000A70A4
		public unsafe string m_rgchAchievementName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserAchievementIconFetched_t.NativeMethodInfoPtr_get_m_rgchAchievementName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserAchievementIconFetched_t.NativeMethodInfoPtr_set_m_rgchAchievementName_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x0000EC34 File Offset: 0x0000CE34
		public UserAchievementIconFetched_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x0000EC3D File Offset: 0x0000CE3D
		public UserAchievementIconFetched_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06002567 RID: 9575 RVA: 0x000A8EEC File Offset: 0x000A70EC
		// (set) Token: 0x06002568 RID: 9576 RVA: 0x0000EC4F File Offset: 0x0000CE4F
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UserAchievementIconFetched_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserAchievementIconFetched_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06002569 RID: 9577 RVA: 0x000A8F08 File Offset: 0x000A7108
		// (set) Token: 0x0600256A RID: 9578 RVA: 0x0000EC5D File Offset: 0x0000CE5D
		public unsafe CGameID m_nGameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementIconFetched_t.NativeFieldInfoPtr_m_nGameID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementIconFetched_t.NativeFieldInfoPtr_m_nGameID)) = value;
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x0600256B RID: 9579 RVA: 0x000A8F30 File Offset: 0x000A7130
		// (set) Token: 0x0600256C RID: 9580 RVA: 0x0000EC78 File Offset: 0x0000CE78
		public unsafe Il2CppStructArray<byte> m_rgchAchievementName_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementIconFetched_t.NativeFieldInfoPtr_m_rgchAchievementName_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementIconFetched_t.NativeFieldInfoPtr_m_rgchAchievementName_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x0600256D RID: 9581 RVA: 0x000A8F60 File Offset: 0x000A7160
		// (set) Token: 0x0600256E RID: 9582 RVA: 0x0000EC97 File Offset: 0x0000CE97
		public unsafe bool m_bAchieved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementIconFetched_t.NativeFieldInfoPtr_m_bAchieved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementIconFetched_t.NativeFieldInfoPtr_m_bAchieved)) = value;
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x0600256F RID: 9583 RVA: 0x000A8F88 File Offset: 0x000A7188
		// (set) Token: 0x06002570 RID: 9584 RVA: 0x0000ECB2 File Offset: 0x0000CEB2
		public unsafe int m_nIconHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementIconFetched_t.NativeFieldInfoPtr_m_nIconHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementIconFetched_t.NativeFieldInfoPtr_m_nIconHandle)) = value;
			}
		}

		// Token: 0x04001EE8 RID: 7912
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001EE9 RID: 7913
		private static readonly IntPtr NativeFieldInfoPtr_m_nGameID;

		// Token: 0x04001EEA RID: 7914
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchAchievementName_;

		// Token: 0x04001EEB RID: 7915
		private static readonly IntPtr NativeFieldInfoPtr_m_bAchieved;

		// Token: 0x04001EEC RID: 7916
		private static readonly IntPtr NativeFieldInfoPtr_m_nIconHandle;

		// Token: 0x04001EED RID: 7917
		private static readonly IntPtr NativeMethodInfoPtr_get_m_rgchAchievementName_Public_get_String_0;

		// Token: 0x04001EEE RID: 7918
		private static readonly IntPtr NativeMethodInfoPtr_set_m_rgchAchievementName_Public_set_Void_String_0;
	}
}
