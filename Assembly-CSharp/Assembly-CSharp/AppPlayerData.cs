using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200005C RID: 92
[Serializable]
public sealed class AppPlayerData : ValueType
{
	// Token: 0x06000CE3 RID: 3299 RVA: 0x00040864 File Offset: 0x0003EA64
	// Note: this type is marked as 'beforefieldinit'.
	static AppPlayerData()
	{
		Il2CppClassPointerStore<AppPlayerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AppPlayerData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppPlayerData>.NativeClassPtr);
		AppPlayerData.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppPlayerData>.NativeClassPtr, "id");
		AppPlayerData.NativeFieldInfoPtr_userAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppPlayerData>.NativeClassPtr, "userAvatar");
		AppPlayerData.NativeFieldInfoPtr_userRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppPlayerData>.NativeClassPtr, "userRating");
		AppPlayerData.NativeFieldInfoPtr_playerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppPlayerData>.NativeClassPtr, "playerType");
		AppPlayerData.NativeFieldInfoPtr_aiDifficultyLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppPlayerData>.NativeClassPtr, "aiDifficultyLevel");
		AppPlayerData.NativeFieldInfoPtr_networkPlayerState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppPlayerData>.NativeClassPtr, "networkPlayerState");
		AppPlayerData.NativeFieldInfoPtr_networkPlayerTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppPlayerData>.NativeClassPtr, "networkPlayerTimer");
		AppPlayerData.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppPlayerData>.NativeClassPtr, "name");
	}

	// Token: 0x06000CE4 RID: 3300 RVA: 0x00009A8F File Offset: 0x00007C8F
	public AppPlayerData(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x06000CE5 RID: 3301 RVA: 0x00009A98 File Offset: 0x00007C98
	public AppPlayerData()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppPlayerData>.NativeClassPtr))
	{
	}

	// Token: 0x1700044D RID: 1101
	// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x00040934 File Offset: 0x0003EB34
	// (set) Token: 0x06000CE7 RID: 3303 RVA: 0x00009AAA File Offset: 0x00007CAA
	public unsafe int id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppPlayerData.NativeFieldInfoPtr_id);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppPlayerData.NativeFieldInfoPtr_id)) = value;
		}
	}

	// Token: 0x1700044E RID: 1102
	// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x0004095C File Offset: 0x0003EB5C
	// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x00009AC5 File Offset: 0x00007CC5
	public unsafe ushort userAvatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppPlayerData.NativeFieldInfoPtr_userAvatar);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppPlayerData.NativeFieldInfoPtr_userAvatar)) = value;
		}
	}

	// Token: 0x1700044F RID: 1103
	// (get) Token: 0x06000CEA RID: 3306 RVA: 0x00040984 File Offset: 0x0003EB84
	// (set) Token: 0x06000CEB RID: 3307 RVA: 0x00009AE0 File Offset: 0x00007CE0
	public unsafe ushort userRating
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppPlayerData.NativeFieldInfoPtr_userRating);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppPlayerData.NativeFieldInfoPtr_userRating)) = value;
		}
	}

	// Token: 0x17000450 RID: 1104
	// (get) Token: 0x06000CEC RID: 3308 RVA: 0x000409AC File Offset: 0x0003EBAC
	// (set) Token: 0x06000CED RID: 3309 RVA: 0x00009AFB File Offset: 0x00007CFB
	public unsafe sbyte playerType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppPlayerData.NativeFieldInfoPtr_playerType);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppPlayerData.NativeFieldInfoPtr_playerType)) = value;
		}
	}

	// Token: 0x17000451 RID: 1105
	// (get) Token: 0x06000CEE RID: 3310 RVA: 0x000409D4 File Offset: 0x0003EBD4
	// (set) Token: 0x06000CEF RID: 3311 RVA: 0x00009B16 File Offset: 0x00007D16
	public unsafe sbyte aiDifficultyLevel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppPlayerData.NativeFieldInfoPtr_aiDifficultyLevel);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppPlayerData.NativeFieldInfoPtr_aiDifficultyLevel)) = value;
		}
	}

	// Token: 0x17000452 RID: 1106
	// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x000409FC File Offset: 0x0003EBFC
	// (set) Token: 0x06000CF1 RID: 3313 RVA: 0x00009B31 File Offset: 0x00007D31
	public unsafe ushort networkPlayerState
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppPlayerData.NativeFieldInfoPtr_networkPlayerState);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppPlayerData.NativeFieldInfoPtr_networkPlayerState)) = value;
		}
	}

	// Token: 0x17000453 RID: 1107
	// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x00040A24 File Offset: 0x0003EC24
	// (set) Token: 0x06000CF3 RID: 3315 RVA: 0x00009B4C File Offset: 0x00007D4C
	public unsafe uint networkPlayerTimer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppPlayerData.NativeFieldInfoPtr_networkPlayerTimer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppPlayerData.NativeFieldInfoPtr_networkPlayerTimer)) = value;
		}
	}

	// Token: 0x17000454 RID: 1108
	// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x00040A4C File Offset: 0x0003EC4C
	// (set) Token: 0x06000CF5 RID: 3317 RVA: 0x00009B67 File Offset: 0x00007D67
	public unsafe string name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppPlayerData.NativeFieldInfoPtr_name);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppPlayerData.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x040008B4 RID: 2228
	private static readonly IntPtr NativeFieldInfoPtr_id;

	// Token: 0x040008B5 RID: 2229
	private static readonly IntPtr NativeFieldInfoPtr_userAvatar;

	// Token: 0x040008B6 RID: 2230
	private static readonly IntPtr NativeFieldInfoPtr_userRating;

	// Token: 0x040008B7 RID: 2231
	private static readonly IntPtr NativeFieldInfoPtr_playerType;

	// Token: 0x040008B8 RID: 2232
	private static readonly IntPtr NativeFieldInfoPtr_aiDifficultyLevel;

	// Token: 0x040008B9 RID: 2233
	private static readonly IntPtr NativeFieldInfoPtr_networkPlayerState;

	// Token: 0x040008BA RID: 2234
	private static readonly IntPtr NativeFieldInfoPtr_networkPlayerTimer;

	// Token: 0x040008BB RID: 2235
	private static readonly IntPtr NativeFieldInfoPtr_name;

	// Token: 0x02000184 RID: 388
	public enum PlayerType
	{
		// Token: 0x040018E2 RID: 6370
		PlayerType_Local,
		// Token: 0x040018E3 RID: 6371
		PlayerType_Human,
		// Token: 0x040018E4 RID: 6372
		PlayerType_AI
	}

	// Token: 0x02000185 RID: 389
	public enum AIDifficultyLevel
	{
		// Token: 0x040018E6 RID: 6374
		AIDifficultyLevel_Easy,
		// Token: 0x040018E7 RID: 6375
		AIDifficultyLevel_Medium,
		// Token: 0x040018E8 RID: 6376
		AIDifficultyLevel_Hard,
		// Token: 0x040018E9 RID: 6377
		AIDifficultyLevel_Tutorial
	}
}
