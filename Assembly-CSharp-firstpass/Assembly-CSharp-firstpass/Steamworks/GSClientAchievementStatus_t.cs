using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000191 RID: 401
	public sealed class GSClientAchievementStatus_t : ValueType
	{
		// Token: 0x06002170 RID: 8560 RVA: 0x000A0E10 File Offset: 0x0009F010
		// Note: this type is marked as 'beforefieldinit'.
		static GSClientAchievementStatus_t()
		{
			Il2CppClassPointerStore<GSClientAchievementStatus_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GSClientAchievementStatus_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSClientAchievementStatus_t>.NativeClassPtr);
			GSClientAchievementStatus_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientAchievementStatus_t>.NativeClassPtr, "k_iCallback");
			GSClientAchievementStatus_t.NativeFieldInfoPtr_m_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientAchievementStatus_t>.NativeClassPtr, "m_SteamID");
			GSClientAchievementStatus_t.NativeFieldInfoPtr_m_pchAchievement_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientAchievementStatus_t>.NativeClassPtr, "m_pchAchievement_");
			GSClientAchievementStatus_t.NativeFieldInfoPtr_m_bUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientAchievementStatus_t>.NativeClassPtr, "m_bUnlocked");
			GSClientAchievementStatus_t.NativeMethodInfoPtr_get_m_pchAchievement_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSClientAchievementStatus_t>.NativeClassPtr, 100668341);
			GSClientAchievementStatus_t.NativeMethodInfoPtr_set_m_pchAchievement_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSClientAchievementStatus_t>.NativeClassPtr, 100668342);
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06002171 RID: 8561 RVA: 0x000A0EB8 File Offset: 0x0009F0B8
		// (set) Token: 0x06002172 RID: 8562 RVA: 0x000A0EF4 File Offset: 0x0009F0F4
		public unsafe string m_pchAchievement
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSClientAchievementStatus_t.NativeMethodInfoPtr_get_m_pchAchievement_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206863, XrefRangeEnd = 206864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSClientAchievementStatus_t.NativeMethodInfoPtr_set_m_pchAchievement_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x0000C2BA File Offset: 0x0000A4BA
		public GSClientAchievementStatus_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x0000C2C3 File Offset: 0x0000A4C3
		public GSClientAchievementStatus_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GSClientAchievementStatus_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06002175 RID: 8565 RVA: 0x000A0F3C File Offset: 0x0009F13C
		// (set) Token: 0x06002176 RID: 8566 RVA: 0x0000C2D5 File Offset: 0x0000A4D5
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSClientAchievementStatus_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSClientAchievementStatus_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06002177 RID: 8567 RVA: 0x000A0F58 File Offset: 0x0009F158
		// (set) Token: 0x06002178 RID: 8568 RVA: 0x0000C2E3 File Offset: 0x0000A4E3
		public unsafe ulong m_SteamID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientAchievementStatus_t.NativeFieldInfoPtr_m_SteamID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientAchievementStatus_t.NativeFieldInfoPtr_m_SteamID)) = value;
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06002179 RID: 8569 RVA: 0x000A0F80 File Offset: 0x0009F180
		// (set) Token: 0x0600217A RID: 8570 RVA: 0x0000C2FE File Offset: 0x0000A4FE
		public unsafe Il2CppStructArray<byte> m_pchAchievement_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientAchievementStatus_t.NativeFieldInfoPtr_m_pchAchievement_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientAchievementStatus_t.NativeFieldInfoPtr_m_pchAchievement_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x0600217B RID: 8571 RVA: 0x000A0FB0 File Offset: 0x0009F1B0
		// (set) Token: 0x0600217C RID: 8572 RVA: 0x0000C31D File Offset: 0x0000A51D
		public unsafe bool m_bUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientAchievementStatus_t.NativeFieldInfoPtr_m_bUnlocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientAchievementStatus_t.NativeFieldInfoPtr_m_bUnlocked)) = value;
			}
		}

		// Token: 0x04001B1E RID: 6942
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001B1F RID: 6943
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamID;

		// Token: 0x04001B20 RID: 6944
		private static readonly IntPtr NativeFieldInfoPtr_m_pchAchievement_;

		// Token: 0x04001B21 RID: 6945
		private static readonly IntPtr NativeFieldInfoPtr_m_bUnlocked;

		// Token: 0x04001B22 RID: 6946
		private static readonly IntPtr NativeMethodInfoPtr_get_m_pchAchievement_Public_get_String_0;

		// Token: 0x04001B23 RID: 6947
		private static readonly IntPtr NativeMethodInfoPtr_set_m_pchAchievement_Public_set_Void_String_0;
	}
}
