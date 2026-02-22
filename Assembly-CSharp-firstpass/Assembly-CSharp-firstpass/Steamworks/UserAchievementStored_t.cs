using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200022D RID: 557
	public sealed class UserAchievementStored_t : ValueType
	{
		// Token: 0x0600253D RID: 9533 RVA: 0x000A8874 File Offset: 0x000A6A74
		// Note: this type is marked as 'beforefieldinit'.
		static UserAchievementStored_t()
		{
			Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "UserAchievementStored_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr);
			UserAchievementStored_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr, "k_iCallback");
			UserAchievementStored_t.NativeFieldInfoPtr_m_nGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr, "m_nGameID");
			UserAchievementStored_t.NativeFieldInfoPtr_m_bGroupAchievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr, "m_bGroupAchievement");
			UserAchievementStored_t.NativeFieldInfoPtr_m_rgchAchievementName_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr, "m_rgchAchievementName_");
			UserAchievementStored_t.NativeFieldInfoPtr_m_nCurProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr, "m_nCurProgress");
			UserAchievementStored_t.NativeFieldInfoPtr_m_nMaxProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr, "m_nMaxProgress");
			UserAchievementStored_t.NativeMethodInfoPtr_get_m_rgchAchievementName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr, 100668373);
			UserAchievementStored_t.NativeMethodInfoPtr_set_m_rgchAchievementName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr, 100668374);
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x0600253E RID: 9534 RVA: 0x000A8944 File Offset: 0x000A6B44
		// (set) Token: 0x0600253F RID: 9535 RVA: 0x000A8980 File Offset: 0x000A6B80
		public unsafe string m_rgchAchievementName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 206854, RefRangeEnd = 206855, XrefRangeStart = 206854, XrefRangeEnd = 206855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserAchievementStored_t.NativeMethodInfoPtr_get_m_rgchAchievementName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserAchievementStored_t.NativeMethodInfoPtr_set_m_rgchAchievementName_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x0000EAE0 File Offset: 0x0000CCE0
		public UserAchievementStored_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x0000EAE9 File Offset: 0x0000CCE9
		public UserAchievementStored_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06002542 RID: 9538 RVA: 0x000A89C8 File Offset: 0x000A6BC8
		// (set) Token: 0x06002543 RID: 9539 RVA: 0x0000EAFB File Offset: 0x0000CCFB
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UserAchievementStored_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserAchievementStored_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06002544 RID: 9540 RVA: 0x000A89E4 File Offset: 0x000A6BE4
		// (set) Token: 0x06002545 RID: 9541 RVA: 0x0000EB09 File Offset: 0x0000CD09
		public unsafe ulong m_nGameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_m_nGameID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_m_nGameID)) = value;
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06002546 RID: 9542 RVA: 0x000A8A0C File Offset: 0x000A6C0C
		// (set) Token: 0x06002547 RID: 9543 RVA: 0x0000EB24 File Offset: 0x0000CD24
		public unsafe bool m_bGroupAchievement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_m_bGroupAchievement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_m_bGroupAchievement)) = value;
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06002548 RID: 9544 RVA: 0x000A8A34 File Offset: 0x000A6C34
		// (set) Token: 0x06002549 RID: 9545 RVA: 0x0000EB3F File Offset: 0x0000CD3F
		public unsafe Il2CppStructArray<byte> m_rgchAchievementName_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_m_rgchAchievementName_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_m_rgchAchievementName_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x0600254A RID: 9546 RVA: 0x000A8A64 File Offset: 0x000A6C64
		// (set) Token: 0x0600254B RID: 9547 RVA: 0x0000EB5E File Offset: 0x0000CD5E
		public unsafe uint m_nCurProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_m_nCurProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_m_nCurProgress)) = value;
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x0600254C RID: 9548 RVA: 0x000A8A8C File Offset: 0x000A6C8C
		// (set) Token: 0x0600254D RID: 9549 RVA: 0x0000EB79 File Offset: 0x0000CD79
		public unsafe uint m_nMaxProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_m_nMaxProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_m_nMaxProgress)) = value;
			}
		}

		// Token: 0x04001EBF RID: 7871
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001EC0 RID: 7872
		private static readonly IntPtr NativeFieldInfoPtr_m_nGameID;

		// Token: 0x04001EC1 RID: 7873
		private static readonly IntPtr NativeFieldInfoPtr_m_bGroupAchievement;

		// Token: 0x04001EC2 RID: 7874
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchAchievementName_;

		// Token: 0x04001EC3 RID: 7875
		private static readonly IntPtr NativeFieldInfoPtr_m_nCurProgress;

		// Token: 0x04001EC4 RID: 7876
		private static readonly IntPtr NativeFieldInfoPtr_m_nMaxProgress;

		// Token: 0x04001EC5 RID: 7877
		private static readonly IntPtr NativeMethodInfoPtr_get_m_rgchAchievementName_Public_get_String_0;

		// Token: 0x04001EC6 RID: 7878
		private static readonly IntPtr NativeMethodInfoPtr_set_m_rgchAchievementName_Public_set_Void_String_0;
	}
}
